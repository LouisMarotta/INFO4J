using System;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;
using MessagePack;
namespace Marotta.Louis.J.listaSemplice.modules
{
    public class ListaSemplice
    {
        string filePath;

        const int max_lista = 1000;
        Nodo[] nodi = new Nodo[max_lista];

        public ListaSemplice()
        {

        }
        public ListaSemplice(string filepath)
        {
            caricaDaFile(filepath);
        }

        public void InserisciNodoInCoda(char c)
        {
            int pos = getOpenSpot();
            nodi[pos] = new Nodo();
            nodi[pos].valore = c;
            nodi[pos].indice = -1;
            nodi[findLastIndex()].indice = pos;
        }

        //public void InserisciNodoInTesta(char c)
        //{

        //}

        //public void InserisciNodoNellaPosizione(char c, int index)
        //{
        //    int pos = getOpenSpot();
        //    int old_index = nodi[index].indice;
        //    nodi[index].indice = pos;

        //    nodi[pos] = new Nodo();
        //    nodi[pos].valore = c;
        //    nodi[pos].indice = old_index;
        //}

        public void InserisciNodoNellaPosizione(char c, int index)
        {
            int pos = getOpenSpot();
            //Indice del elemento precedente    
            int old_index = findIndexPos(index - 1);

            nodi[pos] = new Nodo();
            nodi[pos].valore = c;
            nodi[pos].indice = old_index;


        }


        public void caricaDaFile(string filePath)
        {
            //Deserializza dal formato JSON
            string file;
            using (var reader = new StreamReader(filePath))
            {
                file = reader.ReadToEnd();
            }
            nodi = JsonConvert.DeserializeObject<Nodo[]>(file);
        }
        public void salvaFile(string filePath)
        {
            //Serializza in formato JSON
            String jsonToWrite = JsonConvert.SerializeObject(nodi, Formatting.Indented);
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write(jsonToWrite);
            }
        }
        public string stampaLista()
        {
            string output = "";
            for (int i = 0; i < getOpenSpot(); i++)
            {
                output = $"{output}\n{i} \t {nodi[i].indice} \t {nodi[i].valore}";
            }
            return output;
        }

        private int getOpenSpot()
        {
            int i;
            for (i = 0; nodi[i] != null && i < nodi.Length; i++)
            {

            }
            return i;
        }

        private int findLastIndex()
        {
            int i;
            for (i = 0; i < nodi.Length; i++)

            {
                if (nodi[i].indice == -1)
                {
                    return i;
                }
            }
            return i;
        }

        private int findIndexPos(int i)
        {
            foreach (Nodo x in nodi)
            {
                if (x.indice == i)
                {
                    return i;
                }
            }
            Exception exception = new Exception("Indice non trovato");
            return 0;
        }
    }
}

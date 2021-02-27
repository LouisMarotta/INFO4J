using System;
using Marotta.Louis.J.listaSemplice.modules;


namespace Marotta.Louis.J.listaSemplice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string filepath = "..//..//listaCaratteri.json";
            ListaSemplice test = new ListaSemplice(filepath);
            //ListaSemplice test = new ListaSemplice(filepath);

            //test.InserisciNodoInTesta('5', 5);

            //test.InserisciNodoInCoda('i');
            test.InserisciNodoNellaPosizione('5', 1);

            Console.WriteLine(test.stampaLista());
            test.salvaFile(filepath);
        }


    }
}

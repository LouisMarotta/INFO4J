using System;
using System.IO;

//Libreria del JSON ufficiale che non ho capito come si usa
//using System.Text.Json;

//Librieria esterna che ho installato con nuget
using Newtonsoft.Json;
using System.Collections.Generic;
using Marotta.Louis.J.studente.modules;


namespace Marotta.Louis.J.studente
{
    class MainClass
    {
        public static class Globals
        {
            public const string filePath = "..//..//studenti4J.json";
        }

        public static void Main(string[] args)
        {
            /*
            Studente[] studenti4J = new Studente[21];
            Non serve perche' tutto contenuto in Classe classe4j
            */

            //Classe risultato = classe4J.Find();
            /*
            //Aggiunta di 2 studenti perche' non so inizializzare il json a mano           
            studenti4J[0] = new Studente("Mattia", "Bernabe", 4);
            studenti4J[1] = new Studente("Elia", "Cesaretti", 4);

            classe4J.addStudente(studenti4J[0]);
            classe4J.addStudente(studenti4J[1]);

            Serializza(classe4J);
            Serializza(studenti4J[0]);
            */

            Classe classe4J = new Classe();
            Deserializza();
            classe4J.generaAssenze();
            classe4J.inserisciAssenza("Marotta");
            classe4J.inserisciVoto("Marotta", 6);
            classe4J.inserisciVoto("Marotta", 8);

            Studente[] studente1 = new Studente[100];
            int[] voti = new int[100];

            Console.WriteLine($"Voti: {classe4J.listVoti("Marotta")}");
            Console.WriteLine($"Media: {classe4J.getMediaStudente("Marotta")}");
            Console.WriteLine($"Media: {classe4J.getMediaStudente("Bernabe")}");
            Console.ReadKey();



            //Gestione file JSON

            //Questa funzione viene usata per salvare
            void Serializza(Classe classe)
            {
                String jsonToWrite = JsonConvert.SerializeObject(classe.getStudenti(), Formatting.Indented);


                using (StreamWriter writer = new StreamWriter(Globals.filePath))
                {
                    writer.Write(jsonToWrite);
                }

            }

            //Questa funzione viene usata per caricare
            void Deserializza()
            {
                string studentsFromFile;
                using (var reader = new StreamReader(Globals.filePath))
                {
                    studentsFromFile = reader.ReadToEnd();
                }

                //Console.WriteLine(studentsFromFile);
                classe4J.studente = JsonConvert.DeserializeObject<List<Studente>>(studentsFromFile);
            }


        }



    }
}
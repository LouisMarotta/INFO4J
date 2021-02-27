using System;
using System.Collections.Generic;
namespace Marotta.Louis.J.studente.modules
{
    public class Classe
    {
        public List<Studente> studente { get; set; } //= new List<Studente>() };

        public Classe() {
            studente = new List<Studente>();
        }


        public void addStudente(Studente studente)
        {
            this.studente.Add(studente);
        }

        public List<Studente> getStudenti()
        {
            return studente;
        }

        public void generaAssenze() {
            studente.ForEach(delegate(Studente std)
            {
                Random rnd = new Random();
                int genRand = rnd.Next(0, 15);
                std.setAssenze(genRand);
            });
           
        }

        private int findStudente(string cerca)
        {
            int indice =  studente.FindIndex(lStudenti => lStudenti.cognome.ToLower() == cerca.ToLower());
            return indice;
            /*
            Studente risultato = studente.Find(lStudenti => lStudenti.cognome.ToLower() == cerca.ToLower());
            risultato.inserisciAssenza();
            */           
        }

        public void inserisciAssenza(string studente)
        {
            int index = findStudente(studente);
            this.studente[index].inserisciAssenza();
        }

        public void inserisciVoto(string studente, int voto)
        {
            int index = findStudente(studente);
            this.studente[index].inserisciVoto(voto);
        }
        public double getMediaStudente(string studente)
        {
            int index = findStudente(studente);
            return this.studente[index].getMedia();
        }
        public string listVoti(string studente)
        {
            int index = findStudente(studente);
            //this.studente.Where
            return this.studente[index].getVoti();
        }

    }
}

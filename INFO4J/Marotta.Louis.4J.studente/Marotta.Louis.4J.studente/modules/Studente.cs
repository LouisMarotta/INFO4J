using System;
using System.Collections.Generic;
using System.Linq;
namespace Marotta.Louis.J.studente.modules
{
    public class Studente
    {
        private string _nome;
        private string _cognome;
        private int _assenze;
        private List<int> _voti;

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string cognome
        {
            get { return _cognome; }
            set { _cognome = value; }
        }
        public int assenze
        {
            get { return _assenze; }
            set { _assenze = value; }
        }
        public List<int> voti 
        {
            get { return _voti; }
            set { _voti = value; }
        }

        public Studente()
        {
        }
        public Studente(string n, string c, int a)
        {
            nome = n;
            cognome = c;
            assenze = a;
        }

        public void inserisciAssenza()
        {
            this.assenze += 1;
        }
        public void inserisciVoto(int voto)
        {
            _voti.Add(voto);
        }
        public override string ToString()
        {
            return $"{this.nome} {this.cognome}, Numero Assenze: {this.assenze}";
        }

        public string getNome()
        {
            return nome;
        }
        public string getCognome()
        {
            return cognome;
        }
        public int getAssenze()
        {
            return assenze;
        }
        public double getMedia()
        {
            double totale = voti.Average();
            return totale;
        }

        public string getVoti()
        {
            string result = "";
            voti.ForEach(delegate (int n)
            {
                result = $"{result} {n.ToString()}";

            });

            return result;
        }


        public void setAssenze(int n) {
            assenze = n;
         }
    }
}

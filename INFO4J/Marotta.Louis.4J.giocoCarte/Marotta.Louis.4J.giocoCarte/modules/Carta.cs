using System;
using System.Collections.Generic;
namespace Marotta.Louis.J.giocoCarte.modules
{
    public class Carta
    {
        public enum Seme
        {
            Cuori,
            Quadri,
            Fiori,
            Picche
        }
        private enum Figure
        {
            Jack = 1,
            Queen = 2,
            King = 3,
            Ace = 4
        }

        private int _valore;
        private Seme _seme;

        public int valore
        {
            get { return _valore; }
            set { if (value < 2)
                {
                    _valore = 2;
                }
                else if (value > 14)
                {
                    _valore = 14;
                }
                else { _valore = value; }
            }
        }
        public Seme seme
        {
            get { return _seme; }
            set { _seme = value; }
        }

        public Carta(int val, Seme seme)
        {
            this.valore = val;
            this.seme = seme;
        }

        public string visualizza() {
            if (this.valore > 10)
            {
                var figura = Enum.GetName(typeof(Figure),(this.valore - 10));
                return $"Valore carta: {figura}\nSeme carta: {this.seme}";
            }

            return $"Valore carta: {this.valore}\nSeme carta: {this.seme}";
            }

        public bool vince(Carta confronto) {
            if (this.valore == confronto.valore)
            {
                if (this.seme > confronto.seme)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            if(this.valore > confronto.valore){return true;}
            else { return false; }

        }
    }
}

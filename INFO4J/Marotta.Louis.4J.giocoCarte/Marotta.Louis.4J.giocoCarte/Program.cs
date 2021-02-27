using System;
using Marotta.Louis.J.giocoCarte.modules;
namespace Marotta.Louis.J.giocoCarte
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Carta carta1 = new Carta(12, Carta.Seme.Quadri);
            Console.WriteLine($"Carta1: \n{carta1.visualizza()}");
            Carta carta2 = new Carta(5, Carta.Seme.Fiori);
            Console.WriteLine($"Carta2: \n{carta2.visualizza()}");


            Console.WriteLine($"Vittoria carta1: {carta1.vince(carta2)}");


        }
    }
}

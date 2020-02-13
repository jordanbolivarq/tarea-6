using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int carta = 0;
            int carta1 = aleatorio.Next(1, 11);
            int carta2 = aleatorio.Next(1, 11);
            int total = carta1 + carta2;
            int contador = 0;
            Console.WriteLine("Llegue exactamente a 21 para ganar");
            

            Console.WriteLine("Primera carta: " + carta1);
            Console.WriteLine("Segunda carta: " + carta2);
            Console.WriteLine("Total: " + total);

            Console.WriteLine("Dijite 's' para obtenter otra carta");
            string continuar = Console.ReadLine();

            while (continuar == "s" && total < 21)
            {
                carta = aleatorio.Next(1, 11);
                contador++;
                Console.WriteLine("Carta " + (2 + contador) + ": " + carta);
                total += carta;
                Console.WriteLine("Total: " + total);

                if (total >= 21)
                    continuar = "f";
                else
                { 
                    Console.WriteLine("Dijite 's' para obtenter otra carta");
                    continuar = Console.ReadLine();
                } 
            }

            if (total == 21)
                Console.WriteLine("BlackJack");
            else
                Console.WriteLine("Perdió");
        }
    }
}

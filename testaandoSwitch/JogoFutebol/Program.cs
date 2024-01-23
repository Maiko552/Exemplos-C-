using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoFutebol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, resul = 0;
            Console.WriteLine("-------------------------");
            Console.WriteLine("  Santos x Conrinthians  ");
            Console.WriteLine("-------------------------");

            Console.WriteLine("Quantos gols o Santos fez?");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos gols o Corithians fez?");
            y = int.Parse(Console.ReadLine());

            resul = x - y;

            switch (resul)
            {
                case 0: Console.WriteLine("\nEmpate");break;
                case 1: Console.WriteLine("\nPartida Normal");break;
                case 2: Console.WriteLine("\nPartida Normal");break;
                case 3: Console.WriteLine("\nPatida Normal");break;
                case 4: Console.WriteLine("\nGoleada");break;
                case 5: Console.WriteLine("\nGoleada");break;
                default: Console.WriteLine("\nDeream um show");break;
                  
             }
            if (resul < 0) 
            {
                Console.WriteLine("Numero Invalido");
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Diferença de {0} gols", resul);
            Console.WriteLine("-------------------------------");

            Console.ReadKey();

        }

    
            


        
    }
}

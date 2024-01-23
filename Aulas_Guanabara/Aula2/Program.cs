using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variaveis
            int x;
            int y;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());


            // declaração IF...ELSE em duas linhas
            if (x > y) Console.WriteLine("x > y");

            else Console.WriteLine("x < y");

            Console.ReadKey();
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplos_Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exemplos de condicionais

            //usando else
            
            //varivael
            float d;

            //processamento
            d = float.Parse(Console.ReadLine());

            //saida
            if (d >= 1000) Console.WriteLine("Partiu Disney");

            else
               Console.WriteLine("chateado");


            Console.ReadKey();
            


            /*
           
            //variavel
            int ano, nasc, idade;

            //processamento
            Console.WriteLine("Em que ano estamos?");
            ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Em que ano você nasceu?");
            nasc = int.Parse(Console.ReadLine());

            //processamento
            idade = (ano - nasc);

            //saida
            Console.WriteLine("Em {0} voce terá {1} anos", ano, idade);
            if (idade >= 30)
                Console.WriteLine("Você está ficando velho(a), vá para o asilo");
            if (idade <= 22)
                Console.WriteLine("Você é muito novo(a) ainda");

            Console.ReadKey();
            

                 /*
            //média ponderada com peso na n2, n3, n4
            //variavel
            double n1, n2, n3, n4, med;


            //entrada
            Console.Write("Informe a primeira nota:" );
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Informe a segunda nota:" );
            n2 = double.Parse(Console.ReadLine());

            Console.Write("Informe a terceira nota:");
            n3 = double.Parse(Console.ReadLine());

            Console.Write("Informe a quarta nota:");
            n4 = double.Parse(Console.ReadLine());

            //processamento
            med = ((1 * n1) + (2 * n2) + (2 * n3) + (2 * n4)) / 7;

            //saida
                if (med >= 5)
            {

                Console.WriteLine("\n A média é {0,1:F1} ", med); //(0,1:F1) para restringir em um decimal
                Console.WriteLine("Você está APROVADO");
            }
                else
            {
                Console.WriteLine("\n A média é {0} ", med);
                Console.WriteLine("Você está REPROVADO");
                 } */

            
             




















        }
    }
}

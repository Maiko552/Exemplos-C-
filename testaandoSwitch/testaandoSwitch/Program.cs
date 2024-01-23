using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testaandoSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N;
            int valor = 0;

            Console.WriteLine("------ CRIANÇA ESPERANÇA ------");
            Console.WriteLine("Muito obrigado por ajudar!");

            Console.WriteLine("{1} Para doar R$5 ");
            Console.WriteLine("{2} Para doar R$10 ");
            Console.WriteLine("{3} Para doar R$15 ");
            Console.WriteLine("{4} Para doar R$20 ");
            Console.WriteLine("{5} Para doar outros valores ");
            Console.WriteLine("{6} Para cancelar");
            Console.WriteLine("-------------------------------");
            N = int.Parse(Console.ReadLine());

            switch (N)
            {
                case 1: valor = 5;break;
                case 2: valor = 10;break;
                case 3: valor = 15;break;
                case 4: valor = 20;break;
                case 5: Console.WriteLine("Qual o valor da doação?");
                    valor = int.Parse(Console.ReadLine());break;
                case 6: valor = 0;break;
                default: Console.WriteLine("Numero Inválido");break;
            }

            Console.WriteLine("VOCÊ DOOU R${0}, MUITO OBRIGADO", valor);

            Console.ReadKey();





        }
    }
}

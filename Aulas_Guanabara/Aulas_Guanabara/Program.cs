using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juros20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variável
            double E, R, T, total1;
            int P;

            /* pagar emprestimo do banco
             * considerando 20% de juros parcelar*/

            //entrada
            Console.WriteLine("Qual o valor do empréstimo?");
            E = double.Parse(Console.ReadLine());

            //Processamento
            R = (E * 20) / 100;
            total1 = R + E;
            Console.WriteLine("Com o juros você terá de pagar futuramente: " + total1);

            Console.WriteLine("\nEm quantas parcelas deseja pagar?");
            P = int.Parse(Console.ReadLine());

            //Saida
            T = (R + E) / P;
            Console.WriteLine("Cada parcela sairá por R$" + T);




            Console.ReadKey();









        }
    }
}

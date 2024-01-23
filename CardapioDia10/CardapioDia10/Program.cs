using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardapioDia10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variavel
            int qp, resul = 0, i;
           

            Console.Clear();

            
                //Layout
                Console.WriteLine("---------- CARDÁPIO RESTAURANTE ----------\n");

                Console.WriteLine("Tecle o número dos respectivos pratos\n");

                Console.WriteLine("0. Salada");
                Console.WriteLine("1. Feijoada");
                Console.WriteLine("2. Virada paulista");
                Console.WriteLine("3. Frango cozido");
                Console.WriteLine("4. Sopa c/ carne");
                Console.WriteLine("5. Macarrão");
                Console.WriteLine("6. Prato vegetariano");
                

                Console.WriteLine("\nQuantos pratos deseja comprar?");
                qp = int.Parse(Console.ReadLine());                 //entrada


            //for
            for (i = 1; i <= qp; i++)
            {
                Console.WriteLine("\nQual prato gostaria: ");
                resul = int.Parse(Console.ReadLine());              //entrada



                //escolha
                switch (resul)
                {
                    case 0: Console.WriteLine("\n 0.Salada\n"); break;
                    case 1: Console.WriteLine("\n 1.Feijoada\n"); break;
                    case 2: Console.WriteLine("\n 2.Virada paulista\n"); break;
                    case 3: Console.WriteLine("\n 3.Frango cozindo\n"); break;
                    case 4: Console.WriteLine("\n 4.Sopa c/ carne\n"); break;
                    case 5: Console.WriteLine("\n 5.Macarrão\n"); break;
                    case 6: Console.WriteLine("\n 6.Prato vegetariano\n"); break;
                    default: Console.WriteLine("\nPedido cancelado\n"); break;
                }

                
            }

            Console.WriteLine("Pedido finalizado!");
            
            



            Console.ReadKey();
        }
    }
}

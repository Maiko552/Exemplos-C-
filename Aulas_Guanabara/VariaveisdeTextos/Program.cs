using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariaveisdeTextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //exemplo: character
            //sempre com as aspas simples
            char nome = 'm';

            Console.WriteLine(nome);

            nome = (char)65;
            Console.WriteLine(nome);

            //ASCII table
            nome = (char)(nome + 1);
            Console.WriteLine(nome);

            //string: texto
            string titulo = "Curso de ADS " + 2022;
            Console.WriteLine(titulo);

            //concatena texto com quebra de linha @
            string programacao = @" - .NET 
                 - JAVA
                 - JavaScript";
            Console.WriteLine(programacao);


            Console.ReadKey();

        }
    }
}

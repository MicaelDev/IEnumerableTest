using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace IEnumerableTest
{
    class Program
    {
        static void Main(string[] args)
        {

            var nomes = new List<string> { "Luis", "João", "Ricardo", "Alexandre" };
            IEnumerable<string> nomesContenhamLetraO = nomes.Where(x => x.Contains("o"));
            nomes[0] = "Marcos";

            foreach (var nome in nomesContenhamLetraO)
            {
                Console.WriteLine(nome);
            }
            Console.ReadLine();
        }
    }
}

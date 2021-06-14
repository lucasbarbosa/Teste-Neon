using System;
using System.Collections.Generic;
using System.Linq;

namespace Neon
{
    public static class NumerosPares
    {
        // Escreva um algoritmo que dada uma lista de números inteiros, retorne a soma dos menores números pares.
        public static void Executar()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Teste 1 - Soma dos menores números pares");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");

            var numeros = new List<int> { 7, 1, 6, 2, 5, 9, 4, 3 };

            Console.Write("Números: ");
            foreach (var numero in numeros)
            {
                if(numeros.IndexOf(numero) > 0)
                    Console.Write(" | ");

                Console.Write(numero);
            }

            var pares = numeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            var par1 = pares[0];
            var par2 = pares[1];
            var soma = par1 + par2;

            Console.WriteLine("");
            Console.WriteLine($"Menores pares: {par1} e {par2}");
            Console.WriteLine($"Soma: {soma}");

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
        }
    }
}
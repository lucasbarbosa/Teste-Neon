using System;
using System.Collections.Generic;
using System.Linq;

namespace Neon
{
    public static class NumerosPares
    {
        public static void Executar()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Teste 1 - Soma dos menores números pares");
            Console.WriteLine("--------------------------------------------------");
            
            // Escreva um algoritmo que dada uma lista de números inteiros, retorne a soma dos menores números pares.
            var numeros = new List<int> { 7, 1, 6, 2, 5, 9, 4, 3 };
            var pares = numeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            var numero1 = pares[0];
            var numero2 = pares[1];
            var soma = numero1 + numero2;

            Console.WriteLine(soma);

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
        }
    }
}
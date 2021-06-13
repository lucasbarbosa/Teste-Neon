using System;

namespace Neon
{
    public static class CaixaEletronico
    {
        public static void Executar()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Teste 2 - Funcionamento de caixa eletrônico");
            Console.WriteLine("--------------------------------------------------");

            // Escreva um algoritmo que simule o funcionamento de um caixa eletrônico.
            // Explicação: Deverá receber o valor desejado de saque e ele retornará à quantidade de cédulas de cada valor. As cédulas consideradas pelo caixa eletrônico são: 100, 50, 20, 10, 5 e 2. Deve ser retornado a menor quantidade de cédulas possível para o valor do saque.

            // var valorSaque = 70;
            // var valorSaque = 48;
            var valorSaque = 91;

            var resto = valorSaque;
            var notas100 = 0;
            var notas50 = 0;
            var notas20 = 0;
            var notas10 = 0;
            var notas5 = 0;
            var notas2 = 0;

            if (resto >= 100)
            {
                notas100 = (int)resto / 100;
                resto -= (notas100 * 100);
            }

            if (resto >= 50)
            {
                notas50 = (int)resto / 50;
                resto -= (notas50 * 50);
            }

            if (resto >= 20)
            {
                notas20 = (int)resto / 20;
                resto -= (notas20 * 20);
            }

            if (resto >= 10)
            {
                notas10 = (int)resto / 10;
                resto -= (notas10 * 10);
            }

            if (resto >= 5)
            {
                notas5 = (int)resto / 5;
                resto -= (notas5 * 5);

                if (resto % 2 != 0)
                {
                    notas5 -= 1;
                    resto += 5;
                }
            }

            if (resto >= 2)
            {
                notas2 = (int)resto / 2;
            }

            Console.WriteLine($"Valor saque: {valorSaque}");

            if (notas100 > 0)
                Console.WriteLine($"Notas 100: {notas100}");

            if (notas50 > 0)
                Console.WriteLine($"Notas 50: {notas50}");

            if (notas20 > 0)
                Console.WriteLine($"Notas 20: {notas20}");

            if (notas10 > 0)
                Console.WriteLine($"Notas 10: {notas10}");

            if (notas5 > 0)
                Console.WriteLine($"Notas 5: {notas5}");

            if (notas2 > 0)
                Console.WriteLine($"Notas 2: {notas2}");

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
        }
    }
}
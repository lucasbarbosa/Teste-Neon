using System;

namespace Neon
{
    public static class CaixaEletronico_old
    {
        // Escreva um algoritmo que simule o funcionamento de um caixa eletrônico.
        // Explicação: Deverá receber o valor desejado de saque e ele retornará à quantidade de cédulas de cada valor. As cédulas consideradas pelo caixa eletrônico são: 100, 50, 20, 10, 5 e 2. Deve ser retornado a menor quantidade de cédulas possível para o valor do saque.

        public static void Executar()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Teste 2 - Funcionamento de caixa eletrônico (1)");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");

            // var valorSaque = 70;
            // var valorSaque = 48;
            ulong valorSaque = 91;

            ulong resto = valorSaque;
            ulong notas100 = 0;
            ulong notas50 = 0;
            ulong notas20 = 0;
            ulong notas10 = 0;
            ulong notas5 = 0;
            ulong notas2 = 0;

            Console.WriteLine($"Valor saque: {valorSaque}");
            Console.WriteLine("--------------------");

            if (valorSaque <= 1 || valorSaque == 3)
                Console.WriteLine("Valor inválido para saque");
            else
            {
                if (resto >= 100)
                {
                    notas100 = resto / 100;
                    resto %= 100;

                    if (resto == 1 || resto == 3)
                    {
                        resto += 100;

                        if (notas100 > 0)
                            notas100--;
                    }
                }

                if (resto >= 50)
                {
                    notas50 = resto / 50;
                    resto %= 50;

                    if (resto == 1 || resto == 3)
                    {
                        resto += 50;

                        if (notas50 > 0)
                            notas50--;
                    }
                }

                if (resto >= 20)
                {
                    notas20 = resto / 20;
                    resto %= 20;

                    if (resto == 1 || resto == 3)
                    {
                        resto += 20;

                        if (notas20 > 0)
                            notas20--;
                    }
                }

                if (resto >= 10)
                {
                    notas10 = resto / 10;
                    resto %= 10;

                    if (resto == 1 || resto == 3)
                    {
                        resto += 10;

                        if (notas10 > 0)
                            notas10--;
                    }
                }

                if (resto >= 5)
                {
                    notas5 = resto / 5;
                    resto %= 5;

                    if (resto == 1 || resto == 3)
                    {
                        resto += 5;

                        if (notas5 > 0)
                            notas5--;
                    }
                }

                if (resto >= 2)
                {
                    notas2 = resto / 2;
                    resto %= 2;

                    if (resto == 1 || resto == 3)
                        if (notas2 > 0)
                            notas2--;
                }

                if (notas100 > 0)
                    Console.WriteLine($"Nota 100: {notas100}");

                if (notas50 > 0)
                    Console.WriteLine($"Nota 50: {notas50}");

                if (notas20 > 0)
                    Console.WriteLine($"Nota 20: {notas20}");

                if (notas10 > 0)
                    Console.WriteLine($"Nota 10: {notas10}");

                if (notas5 > 0)
                    Console.WriteLine($"Nota 5: {notas5}");

                if (notas2 > 0)
                    Console.WriteLine($"Nota 2: {notas2}");
            }

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
        }
    }
}
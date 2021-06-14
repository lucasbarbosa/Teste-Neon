using System;
using System.Collections.Generic;
using System.Linq;

namespace Neon
{
    public static class CaixaEletronico
    {
        private static readonly List<int> NotasDisponiveis = new List<int>() { 2, 5, 10, 20, 50, 100 };

        // Escreva um algoritmo que simule o funcionamento de um caixa eletrônico.
        // Explicação: Deverá receber o valor desejado de saque e ele retornará à quantidade de cédulas de cada valor. As cédulas consideradas pelo caixa eletrônico são: 100, 50, 20, 10, 5 e 2. Deve ser retornado a menor quantidade de cédulas possível para o valor do saque.

        public static void Executar()
        {
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Teste 2 - Funcionamento de caixa eletrônico (2)");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");

            // var valorSaque = 70;
            // var valorSaque = 48;
            // var valorSaque = 91;
            var valorSaque = 11;

            Console.WriteLine($"Valor saque: {valorSaque}");
            Console.WriteLine("--------------------");

            if (valorSaque <= 1 || valorSaque == 3)
            {
                Console.WriteLine("Valor inválido para saque");
            }
            else
            {
                var notas = DistribuirNotas(valorSaque);

                ExibirNotasSaque(notas);
            }

            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("");
        }

        private static List<NotasSaque> DistribuirNotas(int valor)
        {
            var notas = new List<NotasSaque> { };

            foreach (var nota in NotasDisponiveis.OrderByDescending(x => x))
                valor = AdicionarNotas(notas, valor, nota);

            return notas;
        }

        private static int AdicionarNotas(List<NotasSaque> notas, int valor, int nota)
        {
            int qtdNotas = 0;

            if (valor >= nota)
            {
                int qtdNotasDiv = valor / nota;
                valor %= nota;

                if (valor == 1 || valor == 3)
                {
                    valor += nota;

                    if (qtdNotasDiv > 1)
                        qtdNotas = qtdNotasDiv - 1;
                }
                else
                    qtdNotas = qtdNotasDiv;
            }

            if (qtdNotas > 0)
                notas.Add(new NotasSaque(nota, qtdNotas));

            return valor;
        }

        private static void ExibirNotasSaque(List<NotasSaque> notas)
        {
            foreach (var nota in notas)
                if (nota.Quantidade > 0)
                    Console.WriteLine($"R$ {nota.Valor}: {nota.Quantidade}");
        }
    }

    public class NotasSaque
    {
        public int Valor { get; set; }
        public int Quantidade { get; set; }

        public NotasSaque(int valor, int quantidade)
        {
            Valor = valor;
            Quantidade = quantidade;
        }
    }
}
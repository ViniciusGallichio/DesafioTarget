using System;

namespace SequenciaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para saber se ele faz parte da sequência de Fibonacci.");
            int n = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;
            int soma = 0;

            for (int i = 0; i < n; i++)
            {
                a = b;
                b = soma;
                soma = a + b;

                if (soma == n)
                {
                    Console.WriteLine($"Número {n} pertence a sequência.");
                    break;
                }
            }

            if (soma > n)
            {
                Console.WriteLine($"Número {n} não pertence a sequência.");
            }

        }
    }
}

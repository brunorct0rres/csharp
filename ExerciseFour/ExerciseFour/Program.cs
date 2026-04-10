using System;

namespace ExerciseFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números inteiros você vai digitar? ");
            int quantidade = int.Parse(Console.ReadLine());

            double soma = 0.0;

            for (int indice = 1; indice <= quantidade; indice++)
            {
                Console.Write("Valor #" + indice + ": ");
                int numero = int.Parse(Console.ReadLine());
                soma += numero;
            }

            Console.WriteLine("Soma = " + soma);
        }
    }
}
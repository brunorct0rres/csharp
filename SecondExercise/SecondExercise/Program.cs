using System;
using System.Globalization;

namespace SecondExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo:");
            string fullName = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int numberOfRooms = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha separando os valores com espaços)");
            string[] vector = Console.ReadLine().Split(' ');

            string lastName = vector[0];
            int age = int.Parse(vector[1]);
            double height = double.Parse(vector[2], CultureInfo.InvariantCulture);

            Console.WriteLine(fullName);
            Console.WriteLine(numberOfRooms);
            Console.WriteLine(productPrice.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
using System;

namespace ThirdExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int hour = DateTime.Now.Hour;
            string greeting;

            if (hour >= 6 && hour < 12)
                greeting = "Bom dia";
            else if (hour >= 12 && hour < 18)
                greeting = "Boa tarde";
            else
                greeting = "Boa noite";

            Console.WriteLine($"{greeting}! Entre com um número inteiro:");

            int n1 = int.Parse(Console.ReadLine());

            if (n1 % 2 == 0)
                Console.WriteLine("O número digitado é par.");
            else
                Console.WriteLine("O número digitado é ímpar.");
        }
    }
}

using System;
using System.Globalization;

namespace Course
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Variáveis e tipos de dados
            bool completo = false;
            char genero = 'F';
            char letra = '\u0041';
            sbyte n1 = -128;
            byte n2 = 255;
            int n3 = 2147483647;
            long n4 = 2147483648L;
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green";
            object obj1 = "Alex Brown";
            object obj2 = 4.5f;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            // Limites dos tipos numéricos
            int n7 = int.MinValue;
            int n8 = int.MaxValue;
            sbyte n9 = sbyte.MinValue;
            decimal n10 = decimal.MaxValue;

            Console.WriteLine(n7);
            Console.WriteLine(n8);
            Console.WriteLine(n9);
            Console.WriteLine(n10);

            string nome2 = "Bruno";
            int idade = 32;
            double saldo = 10.35784;

            Console.WriteLine(saldo); // Exibe o valor com a formatação padrão do sistema, que pode variar dependendo da cultura (por exemplo, vírgula como separador decimal em algumas culturas)
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture)); // F2: 2 casas decimais, InvariantCulture: ponto como separador decimal (padrão americano)

            // Placeholders
            Console.WriteLine("{0} tem {1} anos e saldo de {2:F2} reais. (com placeholders)", nome2, idade, saldo);

            // Interpolação de strings
            Console.WriteLine($"{nome2} tem {idade} anos e saldo de {saldo:F2} reais. (com interpolação)");

            // Concatenação de strings
            Console.WriteLine(nome2 + " tem " + idade + " anos e saldo de " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais. (com concatenação)");
        }
    }
}

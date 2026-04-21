using System.Globalization;

namespace ExerciseEight
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.Write("Digite um número inteiro: ");
            // int quantidade = int.Parse(Console.ReadLine());

            // Console.WriteLine($"Digite {quantidade} alturas (ex: 1.76):");

            // List<double> alturas = new List<double>();

            // for (int i = 0; i < quantidade; i++)
            // {
            //     double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //     alturas.Add(altura);
            // }

            // Console.WriteLine($"AVERAGE HEIGHT: {alturas.Average().ToString("F2", CultureInfo.InvariantCulture)}");

            // ---

            Console.Write("Digite um número inteiro: ");
            int n = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite o nome do produto {i + 1}: ");
                string nomeProduto = Console.ReadLine();

                Console.Write($"Digite o preço do produto {i + 1}: ");
                double precoProduto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto produto = new Produto(nomeProduto, precoProduto);

                produtos[i] = produto;
            }

            double sum = 0.0;

            for (int i = 0; i < produtos.Length; i++)
            {
                sum += produtos[i].Preco;
            }

            double avg = sum / produtos.Length;

            Console.WriteLine($"AVERAGE PRICE = {avg.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}

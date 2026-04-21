using System.Globalization;

namespace ExerciseSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titularConta = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char temDepositoInicial = char.Parse(Console.ReadLine());


            double valorDeposito;
            if (temDepositoInicial == 's')
            {
                Console.Write("Entre o valor do depósito inicial: ");
                valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new Conta(numeroConta, titularConta, valorDeposito);
            }
            else
            {
                conta = new Conta(numeroConta, titularConta);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para depósito: ");
            valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Depositar(valorDeposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Sacar(valorSaque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(conta);
        }
    }
}

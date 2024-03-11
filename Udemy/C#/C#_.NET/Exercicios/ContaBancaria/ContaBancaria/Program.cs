using System.Globalization;

namespace ContaBancaria {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Conta conta;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char simNao = char.Parse(Console.ReadLine());

            if (simNao == 's' || simNao == 'S') {

                Console.Write("Entre o valor de depósito inicial: ");
                double deposito = double.Parse(Console.ReadLine(), CI);

                conta = new Conta(numeroConta, titular, deposito);
                                
            }
            else {

                conta = new Conta(numeroConta, titular);
                           
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta: ");

            Console.WriteLine(conta);
            
            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine(), CI);
            conta.Deposito(valorDeposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine(), CI);
            conta.Saque(valorSaque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);
        }
    }
}
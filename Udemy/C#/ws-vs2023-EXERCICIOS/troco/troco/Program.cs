using System;
using System.Globalization;

//CAP 03 Exercicio(Troco) 
namespace troco {
    internal class Program {
        private static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double precoUnit, dinheiro, troco;
            int qtdComprada;

            Console.Write("Preço unitário do produto: ");
            precoUnit = double.Parse(Console.ReadLine(), CI);

            Console.Write("Quantidade comprada: ");
            qtdComprada = int.Parse(Console.ReadLine(), CI);

            Console.Write("Dinheiro recebido: ");
            dinheiro = double.Parse(Console.ReadLine(), CI);

            troco = dinheiro - (precoUnit * qtdComprada);

            Console.WriteLine("TROCO = " + troco.ToString("F2", CI));

        }
    }
}
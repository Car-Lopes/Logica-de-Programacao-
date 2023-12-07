using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace EstruturaSequencialExerc05 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            string[] vet1 = Console.ReadLine().Split(' ');
            int codPeca1 = int.Parse(vet1[0]);
            int qtdPeca1 = int.Parse(vet1[1]);
            double precoPeca1 = double.Parse(vet1[2],CI);

            string[] vet2 = Console.ReadLine().Split(' ');
            int codPeca2 = int.Parse(vet2[0]);
            int qtdPeca2 = int.Parse(vet2[1]);
            double precoPeca2 = double.Parse(vet2[2],CI);

            double soma = 0;

            soma = (qtdPeca1 * precoPeca1) + (qtdPeca2 * precoPeca2);

            Console.WriteLine("VALOR A PAGAR: R$ " + soma.ToString("F2",CI));
        }
    }
}
using System;
using System.Globalization;

namespace exercicio_2_1 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int cod, quantidade;
            double total=0;

            string[] texto = Console.ReadLine().Split(" ");
            cod = int.Parse(texto[0]); quantidade = int.Parse(texto[1]);

            if (cod == 1) {
                total = quantidade * 4;
            }
            else if (cod == 2) {
                total = quantidade * 4.50;
            }
            else if (cod == 3) {
                total = quantidade * 5.00;
            }
            else if (cod == 4) {
                total = quantidade * 2.00;
            }
            else {
                total = quantidade * 1.50;
            }

            Console.WriteLine("Total: R$ " + total.ToString("F2",CI));
        }
    }
}
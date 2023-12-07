using System;
using System.Globalization;

namespace EstruturaCondicionalExerc06 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double valor = double.Parse(Console.ReadLine(), CI);

            if (valor < 0) {
                Console.WriteLine("Fora do intervalo");
            }
            else if (valor <= 25) {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if (valor < 50.00) {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if (valor < 75.00) {
                Console.WriteLine("Intervalo [50,75]");
            }
            else if (valor <= 100) {
                Console.WriteLine("Intervalo [75,100]");
            }
            else {
                Console.WriteLine("Fora do intervalo");
            }


        }
    }
}
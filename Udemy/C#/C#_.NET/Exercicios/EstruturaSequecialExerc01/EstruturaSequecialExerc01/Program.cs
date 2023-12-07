using System;
using System.Globalization;

namespace EstruturaSequecialExerc01 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int a, b, soma;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            soma = a + b;

            Console.WriteLine("SOMA = " + soma);
        }
    }
}
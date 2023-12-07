using System;
using System.Globalization;

namespace EstruturaSequencialExerc03 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int a, b, c, d, diferenca;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            diferenca = a * b - c * d;

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}
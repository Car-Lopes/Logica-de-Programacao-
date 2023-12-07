using System;
using System.Globalization;

namespace EstruturaCondicionalExerc01 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int x = int.Parse(Console.ReadLine());

            if (x < 0) {
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("NÂO NEGATIVO");
            }

        }
    }
}
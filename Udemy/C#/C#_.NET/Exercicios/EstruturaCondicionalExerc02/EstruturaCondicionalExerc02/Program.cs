using System;
using System.Globalization;

namespace EstruturaCondicionalExerc02 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("IMPAR");
            }

            
        }
    }
}
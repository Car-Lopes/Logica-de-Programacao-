using System;
using System.Globalization;

namespace EstruturaCondicionalExerc03 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int a, b, troca;

            string[] num = Console.ReadLine().Split(' ');
            a = int.Parse(num[0]);
            b = int.Parse(num[1]);

            if (a < b) {
                troca = a;
                a = b;
                b = troca;
            }

            if (a % b == 0) {
                Console.WriteLine("São Multiplos");
            }
            else {
                Console.WriteLine("Não São Multiplus");
            }

        }
    }
}
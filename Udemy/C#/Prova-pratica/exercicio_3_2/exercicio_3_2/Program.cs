using System;
using System.Globalization;

namespace exercicio_3_2 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, num, dentro=0, fora=0;

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) { 
                num = int.Parse(Console.ReadLine());

                if (num >= 10 && num <= 20) {
                    dentro++;
                }
                else { 
                    fora++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(dentro + " in");
            Console.WriteLine(fora + " out");
        }
    }
}
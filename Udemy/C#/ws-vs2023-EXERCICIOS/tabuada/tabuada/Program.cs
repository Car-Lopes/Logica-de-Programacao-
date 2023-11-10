using System;
using System.Globalization;

//CAP.05
namespace tabuada {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo Ci = CultureInfo.InvariantCulture;

            int n,res;

            Console.Write("Deseja a tabuada para qual valor? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                res = i * n;
                Console.WriteLine(n + " x " + i + " = " + res);
            }

        }
    }
}
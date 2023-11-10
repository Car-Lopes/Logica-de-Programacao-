using System;
using System.Globalization;

//CAP.05
namespace crescente {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int x=0, y=0;

            Console.WriteLine("Digite dois numeros: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            while (x != y) {
                if (x < y) {
                    Console.WriteLine("CRESCENTE!");
                }
                else {
                    Console.WriteLine("DECRESCENTE");
                }

                Console.WriteLine("Digite outros dois numeros: ");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}
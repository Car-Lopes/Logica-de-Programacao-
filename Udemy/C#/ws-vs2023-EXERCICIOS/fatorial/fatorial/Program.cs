using System;
using System.Globalization;

//CAP.05
namespace fatorial {
    internal class Program {
        static void Main(string[] args) {
        
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, fatorial=1;
                        
            Console.Write("Digite o valor de N: ");
            n = int.Parse(Console.ReadLine());

         
            for (int i = n; i > 0; i--) {
                fatorial = fatorial * i;
            }

            Console.WriteLine("FATORIAL = " + fatorial);
        }
    }
}
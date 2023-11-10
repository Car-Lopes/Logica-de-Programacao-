using System;
using System.Globalization;

//CAP.04
namespace multiplos {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, m, r;

            Console.WriteLine("Digite dois numeros inteiros: ");
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());

                      
            if (n < m) {
                if (m % n == 0) {
                    Console.WriteLine("São multiplus");
                }
                else {
                    Console.WriteLine("Nao sao multiplos");
                }
            }
            else if (n > m) {
                if (n % m == 0) {
                    Console.WriteLine("São multiplus");
                }
                else {
                    Console.WriteLine("Nao sao multiplos");
                }
            }
            else { 
                
            }
            
        }
    }
}
using System;
using System.Globalization;

//CAP.05
namespace dentro_fora {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, num, dentro=0, fora=0;

            Console.Write("Quantos numeros vc vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                num = int.Parse(Console.ReadLine());

                if (num >= 10 && num <= 20) {
                    dentro++;
                }
                else {
                    fora++;
                }
            }

            Console.WriteLine(dentro + " DENTRO");
            Console.WriteLine(fora + " FORA");
        }
    }
}
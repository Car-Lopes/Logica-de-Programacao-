using System;
using System.Globalization;

//CAP.06
namespace numeros_pares {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, cont=0;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("NUMEROS PARES: ");
            for (int i = 0; i < n; i++) {
                if (vet[i] % 2 == 0) {
                    cont++;
                    Console.Write(vet[i] + "  ");
                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Quantidade de Pares = " + cont);
        }
    }
}
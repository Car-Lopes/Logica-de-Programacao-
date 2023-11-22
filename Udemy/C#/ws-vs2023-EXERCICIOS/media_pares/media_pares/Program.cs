using System;
using System.Globalization;

//CAP.06
namespace media_pares {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, cont=0;
            double soma = 0, media;

            Console.Write("Quantos elementos vai ter o vetor? ");
            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            for (int i = 0; i < n; i++) {

                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++) {
                if (vet[i] % 2 == 0) {
                    soma = soma + vet[i];
                    cont++;
                }
                else {

                }

            }

            media = soma / cont;

            if (media > 1) {
                Console.WriteLine("MEDIA DOS PARES = " + media.ToString("F1", CI));
            }
            else {
                Console.WriteLine("NENHUM NUMERO PAR"); 
            }

        }
    }
}
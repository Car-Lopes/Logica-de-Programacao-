using System;
using System.Globalization;

//CAP.06
namespace maior_posicao {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, posicao=0;
            double maiorValor;

            Console.Write("Quantos numeros voçê vai digitar? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            maiorValor = vet[0];
            for (int i = 1; i < n; i++) {
                if (maiorValor < vet[i]) {
                    maiorValor = vet[i];
                    posicao = i;
                }
            
            }

            Console.WriteLine();
            Console.WriteLine("MAIOR VALOR = " + maiorValor.ToString("F1", CI));
            Console.WriteLine("POSICAO DO MAIOR VALOR = " + posicao);
        }
    }
}
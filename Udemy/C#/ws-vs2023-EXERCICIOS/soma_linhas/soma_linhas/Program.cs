using System;
using System.Globalization;

//CAP.07
namespace soma_linhas {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, m;

            Console.Write("Qual a quantidade de linhas da matriz? ");
            m = int.Parse(Console.ReadLine());

            Console.Write("Qual a quantidade de colunas da matriz? ");
            n = int.Parse(Console.ReadLine());

            double[,] mat = new double[m, n];
            double[] vet = new double[n];

            for (int i = 0; i < m; i++) {
                Console.WriteLine("Digite os elementos da " + (i + 1) + "a. linha: ");
                for (int j = 0; j < n; j++) {
                    
                    mat[i, j] = double.Parse(Console.ReadLine(),CI);
                }
            }

            
            for (int i = 0; i < m; i++) {
                 for (int j = 0; j < n; j++) {

                    vet[i] = vet[i] + mat[i,j];
                 }
            }

            Console.WriteLine("VETOR GERADO: ");
            for (int i = 0; i < m; i++) {
                Console.WriteLine(vet[i].ToString("F1",CI));
            }

        }
    }
}
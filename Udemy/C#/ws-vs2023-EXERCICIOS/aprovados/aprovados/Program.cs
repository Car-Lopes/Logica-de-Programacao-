using System;
using System.Globalization;

//CAP.06
namespace aprovados {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n;
            double media, soma;

            Console.Write("Quantos alunos serao digitados? ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            double[] n1 = new double[n];
            double[] n2 = new double[n];

            for (int i = 0; i < n; i++) {

                Console.WriteLine("Digite nome, primeira e segunda nota do " + (i+1) +"o aluno:");
                nome[i] = Console.ReadLine();
                n1[i] = double.Parse(Console.ReadLine(), CI);
                n2[i] = double.Parse(Console.ReadLine(), CI);
            }

            soma = 0;
            Console.WriteLine("Alunos aprovados: ");
            for (int i = 0; i < n; i++) { 
                media = (n1[i] + n2[i]) / 2;

                if (media >= 6) {
                    Console.WriteLine(nome[i]);
                }
            }
        }
    }
}
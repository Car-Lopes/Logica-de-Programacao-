using System;
using System.Globalization;

//CAP.06
namespace alturas {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n;
            double mediaAltura, percMenor16 = 0, total = 0, cont = 0;

            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];
            double[] altura = new double[n];

            for (int i = 0; i < n; i++) {

                Console.WriteLine("Dados da " + (i + 1) + "a pessoa: ");

                Console.Write("Nome: ");
                nome[i] = Console.ReadLine();

                Console.Write("Idade: ");
                idade[i] = int.Parse(Console.ReadLine());

                Console.Write("Altura: ");
                altura[i] = double.Parse(Console.ReadLine(), CI);

            }

            for (int i = 0; i < n; i++ ) {
                total = total + altura[i];

                if (idade[i] < 16) {
                    cont++;
                }
                
            }

            mediaAltura = total / n;
            percMenor16 = (cont / n) * 100;

            Console.WriteLine();
            Console.WriteLine("Altura média: " + mediaAltura.ToString("F2", CI));
            Console.WriteLine("Pessoas com menos de 16 anos: " + percMenor16.ToString("F1", CI) + "%");
            
            for (int i = 0; i < n; i++) {
                if (idade[i] < 16) {
                    Console.WriteLine(nome[i]);
                }

            }
        }
    }
}
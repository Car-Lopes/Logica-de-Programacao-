using System;
using System.Globalization;

//CAP.05
namespace par_impar {
    internal class Program {
        static void Main(string[] args) {

            int n, num;

            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                num = int.Parse(Console.ReadLine());

                if (num == 0) {
                    Console.WriteLine("NULO");
                }
                else if (num % 2 == 0) {
                    if (num > 0) {
                        Console.WriteLine("PAR POSITIVO");
                    }
                    else {
                        Console.WriteLine("PAR NEGATIVO");
                    }

                }
                else if (num % 2 != 0) {
                    if (num > 0) {
                        Console.WriteLine("IMPAR POSITIVO");
                    }
                    else {
                        Console.WriteLine("IMPAR NEGATIVO");
                    }

                }
                else {
                   
                }


            }
        }
    }
}
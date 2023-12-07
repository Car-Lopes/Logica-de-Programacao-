using System;

namespace CriandoFuncao {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite tres numeros: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            //chamando a função Maior
            double resultado = maior(n1, n2, n3);

            Console.WriteLine("MAIOR = " + resultado);
        }

        //criando a função Maior
        static int maior(int a, int b, int c) {
            int m;
            if (a > b && a > c) {
                m = a;
            }
            else if (b > c) {
                m = b;
            }
            else {
                m = c;
            }
            return m;
        
        
        }

    }
}
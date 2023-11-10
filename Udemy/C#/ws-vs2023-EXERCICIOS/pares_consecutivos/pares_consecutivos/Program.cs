using System;
using System.Globalization;

//CAP.05
namespace pares_consecutivos {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int x, soma=0, p1,p2,p3,p4,p5;

            Console.Write("Digite um numero inteiro: ");
            x = int.Parse(Console.ReadLine());

            while (x != 0) {
                if (x % 2 == 0) {
                    
                    p1 = x + 2;
                    p2 = p1 + 2;
                    p3 = p2 + 2;
                    p4 = p3 + 2;
                    soma = x + p1 + p2 + p3 + p4;
                }
                else {
                    x = x + 1;
                    p1 = x;
                    p2 = p1 + 2;
                    p3 = p2 + 2;
                    p4 = p3 + 2;
                    p5 = p4 + 2;
                    soma = p1 + p2 + p3 + p4 + p5;
                }

                Console.WriteLine("SOMA = " + soma);
                Console.Write("Digite um numero inteiro: ");
                x = int.Parse(Console.ReadLine());

            }

            
        }
    }
}
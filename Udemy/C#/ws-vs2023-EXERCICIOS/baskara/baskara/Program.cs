using System;
using System.Globalization;

//CAP.04 Exercicio(Baskara)
namespace baskara {
    internal class Program {
        private static void Main(string[] args) {
    
            CultureInfo CI = CultureInfo.InvariantCulture;

            double coeficienteA, coeficienteB, coeficienteC, x1, x2, delta;

            Console.Write("Coeficiente A: ");
            coeficienteA = double.Parse(Console.ReadLine(), CI);
            
            Console.Write("Coeficiente B: ");
            coeficienteB = double.Parse(Console.ReadLine(), CI);

            Console.Write("Coeficiente C: ");
            coeficienteC = double.Parse(Console.ReadLine(), CI);

            delta = Math.Pow(coeficienteB, 2.0) - 4 * coeficienteA * coeficienteC;

            if (coeficienteA == 0 || delta < 0 ) {
                Console.WriteLine("Esta equacao nao possui raizes reais");
            }
            else {
                x1 = (-coeficienteB + Math.Sqrt(delta)) / (2 * coeficienteA);
                x2 = (-coeficienteB - Math.Sqrt(delta)) / (2 * coeficienteA);

                Console.WriteLine("X1 = " + x1.ToString("F4", CI));
                Console.WriteLine("X2 = " + x2.ToString("F4", CI));
               
            }


        }
    }
}
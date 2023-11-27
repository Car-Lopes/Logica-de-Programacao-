using System;
using System.Globalization;

namespace exercicio_2_2 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double coeficienteA, coeficienteB, coeficienteC, x1=0, x2=0, delta;

            string[] texto = Console.ReadLine().Split(" ");
            coeficienteA = double.Parse(texto[0],CI); coeficienteB = double.Parse(texto[1],CI); coeficienteC = double.Parse(texto[2],CI);

            delta= 0;
            delta = Math.Pow(coeficienteB, 2) - 4 * coeficienteA * coeficienteC;

            if (coeficienteA == 0 || delta < 0) {
                Console.WriteLine("Impossivel Calcular");
            }
            else {
                x1 = (-coeficienteB + Math.Sqrt(delta)) / (2 * coeficienteA);
                x2 = (-coeficienteB - Math.Sqrt(delta)) / (2 * coeficienteA);

                Console.WriteLine("X1 = " + x1.ToString("F5", CI));
                Console.WriteLine("X2 = " + x2.ToString("F5", CI));
            }

            
        }
    }
}
using System;
using System.Globalization;

//CAP.04 (Glicose)
namespace glicose {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            double glicose;

            Console.Write("Digite a medida da glicose: ");
            glicose = double.Parse(Console.ReadLine(), CI);

            if (glicose <= 100) {
                Console.WriteLine("Classificacao: Normal");
            }
            else if (glicose <= 140) {
                Console.WriteLine("Classificacao: Elevado");
            }
            else {
                Console.WriteLine("Classificacao: Diabetes");
            }

        }
    }
}
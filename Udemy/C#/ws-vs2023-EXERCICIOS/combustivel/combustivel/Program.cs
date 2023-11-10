using System;
using System.Globalization;

//CAP.05
namespace combustivel {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int codigo, contA=0, contG=0, contD=0;

            Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
            codigo = int.Parse(Console.ReadLine());

            while (codigo != 4) {
                if (codigo == 1) {
                    contA++;
                }
                else if (codigo == 2) {
                    contG++;
                }
                else if (codigo == 3) {
                    contD++;
                }
                else {
                    
                }

                Console.Write("Informe um codigo (1, 2, 3) ou 4 para parar: ");
                codigo = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("MUITO OBRIGADO");

            Console.WriteLine("ALCOOL: " + contA);
            Console.WriteLine("GASOLINA: " + contG);
            Console.WriteLine("DIESEL: " + contD);

        }
    }
}
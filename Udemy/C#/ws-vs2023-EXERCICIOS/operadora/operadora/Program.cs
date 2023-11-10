using System;
using System.Globalization;

//CAP.04 (Operadora)
namespace operadora {
    internal class Program {
        private static void Main(string[] args) {
     
            CultureInfo CI = CultureInfo.InvariantCulture;

            int minutos, minutosExcedentes;
            double ttlPagar=50.00, vlExcedente = 2.00;
                        
            Console.Write("Digite a quantidade de minutos: ");
            minutos = int.Parse(Console.ReadLine());

            if (minutos <= 100) {
                Console.WriteLine("Valor a pagar: R$ " + ttlPagar.ToString("F2", CI));
            }
            else {
                minutosExcedentes = minutos - 100; 
                ttlPagar = ttlPagar + (minutosExcedentes * vlExcedente);
               
                Console.WriteLine("Valor a pagar: " + ttlPagar.ToString("F2", CI));
            }

        }
    }
}
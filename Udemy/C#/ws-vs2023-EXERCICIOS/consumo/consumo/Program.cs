using System;
using System.Globalization;

//CAP. 03 Exercicio(Consumo)
namespace consumo {
    internal class Program {
        private static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int km;
            double combustivelGasto, consumoMedia;

            Console.Write("Distancia percorrida: ");
            km = int.Parse(Console.ReadLine());

            Console.Write("Combustível gasto: ");
            combustivelGasto = double.Parse(Console.ReadLine(), CI);

            consumoMedia = km / combustivelGasto;

            Console.WriteLine("Consumo Medio = " + consumoMedia.ToString("F3", CI));
       
        }
    }
}
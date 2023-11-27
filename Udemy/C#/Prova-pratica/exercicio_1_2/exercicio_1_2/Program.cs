using System;
using System.Globalization;

namespace exercicio_1_2 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double PI = 3.14159, raio, areaCirculo;

            raio = double.Parse(Console.ReadLine(),CI);

            areaCirculo = PI * Math.Pow(raio,2);

            Console.WriteLine("A = " + areaCirculo.ToString("F4",CI));
        }
    }
}
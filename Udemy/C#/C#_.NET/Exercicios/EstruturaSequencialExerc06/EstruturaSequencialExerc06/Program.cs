using System;
using System.Globalization;

namespace EstruturaSequencialExerc06 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double areaTriaguloRetangulo, areaCirculo, areaTrapezio, areaQuadrado, areaRetangulo, PI=3.14159;
            
            string[] vet = Console.ReadLine().Split(' ');
            double a = double.Parse(vet[0],CI);
            double b = double.Parse(vet[1],CI);
            double c = double.Parse(vet[2],CI);

            areaTriaguloRetangulo = a * c / 2;
            areaCirculo = PI * Math.Pow(c, 2);
            areaTrapezio = (a + b) * c / 2;
            areaQuadrado = b * b;
            areaRetangulo = a * b;

            Console.WriteLine("TRIANGULO: " + areaTriaguloRetangulo.ToString("F3",CI));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CI));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CI));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CI));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CI));
        }
    }
}
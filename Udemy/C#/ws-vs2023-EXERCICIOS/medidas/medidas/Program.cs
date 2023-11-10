using System;
using System.Globalization;

//CAP.03 Exercicio(Medidas)
namespace medidas {
    internal class Program {
        private static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double medA, medB, medC, areaQuadrada, areaTriangulo, areaTrapezio;

            Console.Write("Digite a medida A: ");
            medA = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a medida B: ");
            medB = double.Parse(Console.ReadLine(), CI);

            Console.Write("Digite a medida C: ");
            medC = double.Parse(Console.ReadLine(), CI);

            areaQuadrada = medA * medA;
            areaTriangulo = (medA * medB) / 2;
            areaTrapezio = ((medA + medB) * medC) / 2;

            Console.WriteLine("AREA DO QUADRADO = " + areaQuadrada.ToString("F4", CI));
            Console.WriteLine("AREA DO TRIANGULO = " + areaTriangulo.ToString("F4", CI));
            Console.WriteLine("AREA DO TRAPEZIO = " + areaTrapezio.ToString("F4", CI));
            
        }
    }
}
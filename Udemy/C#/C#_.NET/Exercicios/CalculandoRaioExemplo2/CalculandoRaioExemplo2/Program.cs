using System;
using System.Globalization;

namespace CalculandoRaioExemplo2 {
    internal class Program {
        static void Main(string[] args) {

            Calculadora calc = new Calculadora();

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CI);

            double circ = calc.Circunferencia(raio);
            double vol = calc.Volume(raio);

            Console.WriteLine();
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CI));
            Console.WriteLine("Volume: " + vol.ToString("F2", CI));
            Console.WriteLine("Valor de PI: " + calc.pi.ToString("F2", CI));
        }

    }
}
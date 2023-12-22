using System;
using System.Globalization;

namespace CalculandoRaioExemplo3 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CI);

            double circ = Calculadora.Circunferencia(raio);
            double vol = Calculadora.Volume(raio);

            Console.WriteLine();
            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CI));
            Console.WriteLine("Volume: " + vol.ToString("F2", CI));
            Console.WriteLine("Valor de PI: " + Calculadora.pi.ToString("F2", CI));
        }

    }
}
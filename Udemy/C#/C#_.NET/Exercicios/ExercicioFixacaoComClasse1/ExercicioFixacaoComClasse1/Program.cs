using System;
using System.Globalization;

namespace ExercicioFixacaoComClasse1 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Retangulo r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retângulo: ");
            r.Largura = double.Parse(Console.ReadLine(),CI);
            r.Altura = double.Parse(Console.ReadLine(),CI);

            Console.WriteLine();
            Console.WriteLine("AREA = " + r.CalculandoArea().ToString("F2",CI));
            Console.WriteLine("PERÍMETRO = " + r.CalculandoPerimetro().ToString("F2",CI));
            Console.WriteLine("DIAGONAL = " + r.CalculandoDiagona().ToString("F2",CI));

        }
    }
}
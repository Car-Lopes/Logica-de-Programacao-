using System;
using System.Globalization;

// CAP.03 Exercicio(Retangulo)
namespace retangulo {
    internal class Program {
        private static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;


            double bbase, altura, area, perimetro, diagonal;

            Console.Write("Base do retangulo: ");
            bbase = double.Parse(Console.ReadLine(), CI);
            Console.Write("Altura do retangulo: ");
            altura = double.Parse(Console.ReadLine(), CI);

            area = bbase * altura;
            perimetro = 2 * (bbase + altura);
            diagonal = Math.Sqrt(Math.Pow(bbase, 2.0) + Math.Pow(altura, 2.0));
            //Math.Sqrt (Função para raiz quadrada)
            //potenciação(Math.Pow) elevado ao quadrado mesma coisa que (Base * base)

            Console.WriteLine("AREA = " + area.ToString("F4", CI));
            Console.WriteLine("PERIMETRO = " + perimetro.ToString("F4", CI));
            Console.WriteLine("Diagonal = " + diagonal.ToString("F4", CI));

        }
    }
}
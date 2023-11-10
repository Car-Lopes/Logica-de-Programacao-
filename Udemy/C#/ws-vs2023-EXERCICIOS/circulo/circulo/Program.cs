using System;
using System.Globalization;

//CAP. 03 Exercicio(Circulo) 
namespace circulo {
    internal class Program {
        private static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double valorCirculo, area;

            Console.Write("Digite o valor do raio do circulo: ");
            valorCirculo = double.Parse(Console.ReadLine(), CI);

            //calculo da area : 𝑎𝑟𝑒𝑎 = 𝜋 * (𝑟*𝑟)
            area = Math.PI * Math.Pow(valorCirculo, 2.0);

            Console.WriteLine("AREA = " + area.ToString("F3", CI));

        }
    }
}
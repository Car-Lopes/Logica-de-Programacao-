using System;
using System.Globalization;

namespace EstruturaCondicionalExerc08 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double salario, impostoRenda;

            salario = double.Parse(Console.ReadLine(), CI);

            impostoRenda = 0;

            if (salario < 0) {
                Console.WriteLine("Salario Invalido");
            }
            else if (salario <= 2000.00) {
                Console.WriteLine("Isento");
            }
            else if (salario <= 3000.00) {
                impostoRenda = (salario - 2000.0) * 0.08;
                Console.WriteLine("R$ " + impostoRenda.ToString("F2", CI));
            }
            else if (salario <= 4500.00) {
                impostoRenda = (((salario - 3000.0) * 0.18) + 1000.0 * 0.08);
                Console.WriteLine("R$ " + impostoRenda.ToString("F2", CI));
            }
            else {
                impostoRenda = (salario - 4500.0) * 0.28 + 1500.00 * 0.18 + 1000.00 * 0.08;
                Console.WriteLine("R$ " + impostoRenda.ToString("F2", CI));
            }

        }
    }
}
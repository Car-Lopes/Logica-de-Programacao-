using System;
using System.Globalization;

namespace EstruturaSequencialExerc04 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int numero, horas;
            double valorHora, salarioTotal;

            numero = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(),CI);

            salarioTotal = horas * valorHora;            

            Console.WriteLine("NUMBER = " + numero);
            Console.WriteLine("SALARY = U$ " + salarioTotal.ToString("F2",CI));
        }
    }
}
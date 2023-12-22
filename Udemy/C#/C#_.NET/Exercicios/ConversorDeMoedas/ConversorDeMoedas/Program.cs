using System;
using System.Globalization;

namespace ConversorDeMoedas {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Qual é a cotação do dólar? ");
            double cotacaoDollar = double.Parse(Console.ReadLine(),CI);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtdDollar = double.Parse(Console.ReadLine(),CI);

            double converter = ConversorDeMoedas.CalcularDollarReais(cotacaoDollar,qtdDollar);

            Console.WriteLine();
            Console.WriteLine("Valor a ser pago em reais = " + converter.ToString("F2",CI));

        }
    }
}
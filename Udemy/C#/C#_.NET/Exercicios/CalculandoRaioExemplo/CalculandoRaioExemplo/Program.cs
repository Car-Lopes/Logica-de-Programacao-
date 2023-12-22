﻿using System;
using System.Globalization;

namespace CalculandoRaioExemplo {
    internal class Program {

        static double Pi = 3.14;
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Entre com o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CI);

            double circ = Circunferencia(raio);
            double Vol = Volume(raio);

            Console.WriteLine();
            Console.WriteLine("Circunferencia: " + circ.ToString("F2",CI));
            Console.WriteLine("Volume: " + Vol.ToString("F2", CI));
            Console.WriteLine("Valor de PI: " + Pi.ToString("F2",CI));
        }

        static double Circunferencia(double r) {
            return 2.0 * Pi * r;
        }

        static double Volume(double r) {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3);
        }
    }
}
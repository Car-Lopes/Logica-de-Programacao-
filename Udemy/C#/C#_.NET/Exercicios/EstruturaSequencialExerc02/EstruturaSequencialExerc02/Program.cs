using System;
using System.Globalization;

namespace EstruturaSequencialExerc02 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double PI = 3.14159, area = 0, raio;

            raio = double.Parse(Console.ReadLine(),CI);

            area = PI * Math.Pow(raio, 2); 

            Console.WriteLine("A = " + area.ToString("F4",CI));
        }
    }
}
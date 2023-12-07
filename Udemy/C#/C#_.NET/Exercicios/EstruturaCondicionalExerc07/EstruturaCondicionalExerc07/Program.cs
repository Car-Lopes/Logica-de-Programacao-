using System;
using System.Globalization;

namespace EstruturaCondicionalExerc07 {
    internal class Program {
        static void Main(string[] args) {

            string[] planoVet = Console.ReadLine().Split(' ');
            double x = double.Parse(planoVet[0]);
            double y = double.Parse(planoVet[1]);

            if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            }
            else if (x > 0 && y > 0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0) {
                Console.WriteLine("Q3");
            }
            else {
                Console.WriteLine("Q4");
            }

        }
    }
}
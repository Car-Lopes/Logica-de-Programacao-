using System;
using System.Globalization;

namespace EstruturaForExerc03 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

            double media = 0;
            for (int i = 0; i < n; i++) {

                string[] mediaPonderada = Console.ReadLine().Split(' ');
                double a = double.Parse((mediaPonderada[0]),CI);
                double b = double.Parse((mediaPonderada[1]),CI);
                double c = double.Parse((mediaPonderada[2]),CI);

                media = (a * 2.00 + b * 3.00 + c * 5.00) / 10.0;

                Console.WriteLine(media.ToString("F1",CI));

            }

            
        }
    }
}
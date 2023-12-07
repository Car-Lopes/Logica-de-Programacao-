using System;
using System.Globalization;

namespace EstruturaForExerc04 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

            double divisao = 0;
            for (int i = 0; i < n; i++) {

                string[] num = Console.ReadLine().Split(' ');
                int a = int.Parse(num[0]);
                int b = int.Parse(num[1]);

                if (b == 0) {
                    Console.WriteLine("Divisao impossivel");
                }
                else {
                    divisao = (double)a / b;
                    Console.WriteLine(divisao.ToString("F1",CI));
                }

            }

            
        }
    }
}
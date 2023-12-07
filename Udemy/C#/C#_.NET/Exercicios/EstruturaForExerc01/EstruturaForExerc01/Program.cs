using System;
using System.Globalization;

namespace EstruturaForExerc01 {
    internal class Program {
        static void Main(string[] args) {

            int x = int.Parse(Console.ReadLine());

            Console.ReadLine();
            for (int i = 1; i < x; i++) {
                if (i % 2 == 1) {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
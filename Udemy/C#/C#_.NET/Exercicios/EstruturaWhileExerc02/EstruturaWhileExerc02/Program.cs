using System;
using System.Security.Cryptography.X509Certificates;

namespace EstruturaWhileExerc02 {
    internal class Program {
        static void Main(string[] args) {

            string[] planoVet = Console.ReadLine().Split(' ');
            int x = int.Parse(planoVet[0]);
            int y = int.Parse(planoVet[1]);



            while (x != 0 && y != 0) {

                if (x > 0 && y > 0) {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("segundo");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");
                }
                else {
                    Console.WriteLine("quarto");
                }

                planoVet = Console.ReadLine().Split(' ');
                x = int.Parse(planoVet[0]);
                y = int.Parse(planoVet[1]);

            }


        }
    }
}
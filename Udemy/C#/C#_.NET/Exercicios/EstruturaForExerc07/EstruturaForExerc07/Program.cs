using System;

namespace EstruturaForExerc07 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());

            int quadrado, cubo;
            for (int i = 1; i <= n; i++) { 
                
                quadrado = i * i;
                cubo = ((i * i) * i);

               // Console.WriteLine("Concatenação");
                Console.WriteLine(i + " " + quadrado + " " + cubo);
                //Console.WriteLine();
                /*
                Console.WriteLine("Placeholder");
                Console.WriteLine("{0} {1} {2}", i,quadrado,cubo);
                Console.WriteLine();

                Console.WriteLine("Interpolação");
                Console.WriteLine($"{i} {quadrado} {cubo}");
                Console.WriteLine();
                */
            }

            
        }
    }
}
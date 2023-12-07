using System;

namespace EstruturaWhileExerc03 {
    internal class Program {
        static void Main(string[] args) {

            int tipoCombustivel = int.Parse(Console.ReadLine());

            int contAcool = 0, contGasolina =0, contDiesel =0;

            while (tipoCombustivel != 4) {
                if (tipoCombustivel == 1) {
                    contAcool++;
                }
                else if (tipoCombustivel == 2) {
                    contGasolina++;
                }
                else if (tipoCombustivel == 3) {
                    contDiesel++;
                }
                else { 
                    
                }

                tipoCombustivel = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Acool: " + contAcool);
            Console.WriteLine("Gasolina: " + contGasolina);
            Console.WriteLine("Diesel: " + contDiesel);
        }
    }
}
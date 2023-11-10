using System;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

//CAP.04 (Troco Verificado)
namespace troco_verificado {
    internal class Program {
        private static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int qntComprada;
            double pcUnit, dinheiro, troco, vlTotal;

            Console.Write("Preço unitário do produto: ");
            pcUnit = double.Parse(Console.ReadLine(), CI); 
            
            Console.Write("Quantidade comprada: ");
            qntComprada = int.Parse(Console.ReadLine());

            Console.Write("Dinheiro recebido: ");
            dinheiro = double.Parse(Console.ReadLine(), CI);

            vlTotal = pcUnit * qntComprada;
            //troco = dinheiro - vlTotal;

            if (dinheiro < vlTotal) {
                troco = vlTotal - dinheiro;
                Console.WriteLine("DINHEIRO INSUFICIENTE. FALTAM " + troco.ToString("F2", CI) + " REAIS");
            }
            else {
                troco = dinheiro - vlTotal;
                Console.WriteLine("TROCO = " + troco.ToString("F2", CI));
            }
            

        }
    }
}
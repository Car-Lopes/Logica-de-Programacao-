using System;
using System.Globalization;

//CAP.04 
namespace lanchonete {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int codProd, qntComprada;
            double vlrPagar=0;

            Console.Write("Codigo do produto comprado de 1 a 5: ");
            codProd = int.Parse(Console.ReadLine());

            if (codProd <= 0 || codProd >= 6) {
                Console.WriteLine("Não tem esse Codigo cadastrado");
            }
            else {
                Console.Write("Quantidade comprada: ");
                qntComprada = int.Parse(Console.ReadLine());

                if (codProd == 1) {
                    vlrPagar = qntComprada * 5;
                }
                else if (codProd == 2) {
                    vlrPagar = qntComprada * 3.50;
                }
                else if (codProd == 3) {
                    vlrPagar = qntComprada * 4.80;
                }
                else if (codProd == 4) {
                    vlrPagar = qntComprada * 8.90;
                }
                else if (codProd == 5) {
                    vlrPagar = qntComprada * 7.32;
                }
                else {

                }

                Console.WriteLine("Valor a pagar: R$ " + vlrPagar.ToString("F2", CI));

            }
            
        }
    }
}
using System;
using System.Globalization;

namespace EstruturaCondicionalExerc05 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            string[] vet = Console.ReadLine().Split(' ');
            int codProduto = int.Parse(vet[0]);
            int qntdProduto = int.Parse(vet[1]);

            double preçoPagar = 0;

            if (codProduto == 1) {
                preçoPagar = qntdProduto * (double)4.00;
            }
            else if (codProduto == 2) {
                preçoPagar = qntdProduto * (double)4.50;
            }
            else if (codProduto == 3) {
                preçoPagar = qntdProduto * (double)5.00;
            }
            else if (codProduto == 4) {
                preçoPagar = qntdProduto * (double)2.00;
            }
            else {
                preçoPagar = qntdProduto * (double)1.50;
            }


            Console.WriteLine("TOTAL: R$ " + preçoPagar.ToString("F2",CI));


        }

    }
}
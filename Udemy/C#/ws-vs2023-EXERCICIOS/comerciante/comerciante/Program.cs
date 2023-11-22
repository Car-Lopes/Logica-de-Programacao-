using System;
using System.Globalization;

//CAP.06
namespace comerciante {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, lucroDez=0, lucroDezeVinte=0, lucroAcimaVinte=0;
            double totalCompra, totalVenda, lucroTotal, PorcLucro;

            Console.Write("Serao digitados dados de quantos produtos? ");
            n = int.Parse(Console.ReadLine());

            string[] nomeProduto = new string[n];
            double[] precoCompra = new double[n];
            double[] precoVenda = new double[n];

            for (int i = 0; i < n; i++) {

                Console.WriteLine("PRODUTO " + (i+1) + ":");
                Console.Write("Nome: ");
                nomeProduto[i] = Console.ReadLine();

                Console.Write("Preço de compra: ");
                precoCompra[i] = double.Parse(Console.ReadLine(), CI);

                Console.Write("Preço de venda: ");
                precoVenda[i] = double.Parse(Console.ReadLine(), CI);

                Console.WriteLine();

            }

            for (int i = 0; i < n; i++) {

                PorcLucro = (precoVenda[i] - precoCompra[i]) * 100 / precoCompra[i];

                if (PorcLucro < 10) {
                    lucroDez++;
                }
                else if (PorcLucro < 20) {
                    lucroDezeVinte++;
                }
                else {
                    lucroAcimaVinte++;
                }
            }

            totalCompra = 0;
            totalVenda = 0;

            for (int i = 0; i < n; i++) {

                totalCompra = totalCompra + precoCompra[i];
                totalVenda = totalVenda + precoVenda[i];
            }

            lucroTotal = totalVenda - totalCompra;

            Console.WriteLine();
            Console.WriteLine("RELATORIO: ");
            Console.WriteLine("Lucro abaixo de 10%: " + lucroDez);
            Console.WriteLine("Lucro entre de 10% e 20%: " + lucroDezeVinte);
            Console.WriteLine("Lucro entre de 10% e 20%: " + lucroAcimaVinte);
            Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2",CI));
            Console.WriteLine("Valor total de venda: " + totalVenda .ToString("F2",CI));
            Console.WriteLine("Lucro total: " + lucroTotal.ToString("F2", CI));
        }
    }
}
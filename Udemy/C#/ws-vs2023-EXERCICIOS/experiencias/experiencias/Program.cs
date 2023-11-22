using System;
using System.Globalization;

//CAP.05
namespace experiencias {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.CurrentCulture;

            int n, qtdCobaia, qtdRato=0, qtdSapo=0, qtdCoelho=0, qtdTotal=0;
            char tpCobaia;
            double percRato, percSapo, percCoelho;

            Console.Write("Quantos casos de teste serao digitados? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.Write("Quantidade de cobaias: ");
                qtdCobaia = int.Parse(Console.ReadLine());

                Console.Write("Tipo de cobaia: ");
                tpCobaia = char.Parse(Console.ReadLine());

                qtdTotal = qtdTotal + qtdCobaia;

                if (tpCobaia == 'R') {
                    qtdRato = qtdRato + qtdCobaia;
                }
                else if (tpCobaia == 'S') {
                    qtdSapo = qtdSapo + qtdCobaia;
                }
                else {
                    qtdCoelho = qtdCoelho + qtdCobaia;
                }
            }

            percCoelho = (qtdCoelho / (double)qtdTotal)*100;
            percRato = (qtdRato / (double)qtdTotal)*100;
            percSapo = (qtdSapo / (double)qtdTotal)*100;

            Console.WriteLine();
            Console.WriteLine("RELATORIO FINAL: ");
            Console.WriteLine("Total: " + qtdTotal + " cobaias");
            Console.WriteLine("Total de coelhos: " + qtdCoelho);
            Console.WriteLine("Total de ratos: " + qtdRato);
            Console.WriteLine("Total de sapos: " + qtdSapo);
            Console.WriteLine("Percentual de coelhos: " + percCoelho.ToString("F2",CI));
            Console.WriteLine("Percentual de ratos: " + percRato.ToString("F2",CI));
            Console.WriteLine("Percentual de sapos: " + percSapo.ToString("F2",CI));
        }
    }
}
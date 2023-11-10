using System;
using System.Globalization;

//CAP.04
namespace tempo_de_jogo {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int hrInicial, hrFinal, hrTotal; 

            Console.Write("Hora inicial: ");
            hrInicial = int.Parse(Console.ReadLine());

            Console.Write("Hora final: ");
            hrFinal = int.Parse(Console.ReadLine());

            if (hrInicial < hrFinal) {
                hrTotal = hrFinal - hrInicial;
            }
            else {
                hrTotal = (24 - hrInicial) + hrFinal;
            }

            Console.WriteLine("O JOGO DUROU " + hrTotal + " HORAS(S)");
        }
    }
}
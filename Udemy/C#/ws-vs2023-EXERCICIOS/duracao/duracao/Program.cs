using System;
using System.Globalization;

//CAP.03 Exercicio(Duracao)
namespace duracao {
    internal class Program {
        private static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int duracao, hh, mm, ss, resto;

            Console.Write("Digite a duracao em segundos: ");
            duracao = int.Parse(Console.ReadLine());

            hh = duracao / 3600;
            resto = duracao % 3600; //% resta da divisão 

            mm = resto / 60;
            ss = resto % 60; //% resta da divisão 

            Console.WriteLine(hh + ":" + mm + ":" + ss);

        }
    }
}
using System;
using System.Globalization;

namespace EstruturaCondicionalExerc04 {
    internal class Program {
        static void Main(string[] args) {
            CultureInfo CI = CultureInfo.InvariantCulture;

            // int horaInicial, horaFinal, total;

            string[] hora = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(hora[0]);
            int horaFinal = int.Parse(hora[1]);

            int total;

            if (horaInicial < horaFinal) {
                total = horaFinal - horaInicial;
            }
            else {
                total = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + total + " HORA(S)");
        }
    }
}
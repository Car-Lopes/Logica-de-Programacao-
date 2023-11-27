using System;
using System.Globalization;

namespace exercicio_3_1 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int senha;

            senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                
                Console.WriteLine("Senha Invalida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");
        }
    }
}
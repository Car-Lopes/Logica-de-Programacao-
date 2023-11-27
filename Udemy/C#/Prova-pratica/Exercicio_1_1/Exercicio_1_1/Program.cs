using System;
using System.Globalization;

//Prova Curdo de Logica de Programação 
namespace Exercicio_1_1 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int cod1, quantidade1, cod2, quantidade2;
            double preco1, preco2, total , total2, totalGeral;

            string[] texto = Console.ReadLine().Split(" ");
            cod1 = int.Parse(texto[0]); quantidade1 = int.Parse(texto[1]); preco1 = double.Parse(texto[2],CI);
         
            string[] texto1 = Console.ReadLine().Split(" ");
            cod2 = int.Parse(texto1[0]); quantidade2 = int.Parse(texto1[1]); preco2 = double.Parse(texto1[2],CI);
            
            Console.WriteLine();
            total = (quantidade1 * preco1) + (quantidade2 * preco2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CI));
        }
    }
}
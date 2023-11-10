using System;
using System.Globalization;

//CAP.04 Exercicio(Notas)
namespace notas {

    internal class Program {
        private static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double nota1, nota2, soma;

            Console.Write("Digite a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine(), CI);
            
            Console.Write("Digite a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine(), CI);

            soma = nota1 + nota2;
            Console.WriteLine("NOTA FINAL = " + soma.ToString("F1", CI));

            if (soma < 60.00) {
                Console.Write("REPROVADO");
            }
        
        }
    }
}
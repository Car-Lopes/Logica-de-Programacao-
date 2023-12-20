using System;
using System.Globalization;

namespace ExercicioFixacaoComClasse3 {
    internal class Program {

        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();

            Console.WriteLine("Digite as tres notas do aluno:");
            a.N1 = double.Parse(Console.ReadLine(),CI);
            a.N2 = double.Parse(Console.ReadLine(), CI);
            a.N3 = double.Parse(Console.ReadLine(), CI);

            Console.WriteLine();
            Console.Write("NOTA FINAL = " + a.NotaFinal().ToString("F2",CI));

            Console.WriteLine();
            if (a.Aprovado()) {
                Console.WriteLine("APROVADO");
            }
            else {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + a.NotaRestante().ToString("F2",CI)+ " PONTOS");
            }
        }
    }
} 
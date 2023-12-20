using System;
using System.Globalization;

namespace ExercicioFixacaoComClasse2 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Funcionario f = new Funcionario();

            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(),CI);

            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(),CI);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salario: ");
            double porc = double.Parse(Console.ReadLine(), CI);
            f.AumentoSalario(porc);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + f);
            
        }
    }
}
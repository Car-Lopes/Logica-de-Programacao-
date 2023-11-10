using System;
using System.Globalization;

//CAP. 03 Exercicio(pagamento)
namespace pagamento {
    internal class Program {
        private static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            String nome;
            double valorHora, valorTotal;
            int horasTrabalhadas;

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Valor por hora: ");
            valorHora = double.Parse(Console.ReadLine(), CI);

            Console.Write("Horas trabalhadas: ");
            horasTrabalhadas = int.Parse(Console.ReadLine());

            valorTotal = horasTrabalhadas * valorHora; 

            Console.WriteLine("O pagamento para " + nome + " deve ser " + valorTotal.ToString("F2", CI));

        }
    }
}
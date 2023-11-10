using System;
using System.Data.SqlTypes;
using System.Globalization;

//CAP.04
namespace aumento {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double salario, aumento, novoSalario, porc;

            Console.Write("Digite o salario da pessoa: ");
            salario = double.Parse(Console.ReadLine(), CI);

            if (salario <= 1000) {
                porc = 20;
                aumento = salario * 20 / 100;
                novoSalario = salario + aumento;
                
            }
            else if (salario <= 3000) {
                porc = 15;
                aumento = salario * 15 / 100;
                novoSalario = salario + aumento;
                
            }
            else if (salario <= 8000) {
                porc = 10;
                aumento = salario * 10 / 100;
                novoSalario = salario + aumento;
                
            }
            else {
                porc = 5;
                aumento = salario * 5 / 100;
                novoSalario = salario + aumento;
                
            }

            Console.WriteLine("Novo salario = R$ " + novoSalario.ToString("F2", CI));
            Console.WriteLine("Aumento = R$ " + aumento.ToString("F2", CI));
            Console.WriteLine("Porcentagem = " + porc + "%");

        }
    }
}
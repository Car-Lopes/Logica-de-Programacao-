using System;
using System.Globalization;

namespace Primeiro {
    internal class Program {
        private static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Primeiro Programa!");

            int idade;
            double salario, altura;
            char genero;
            String nome;

            idade = 32;
            salario = 4000.9;
            altura = 1.7258;
            genero = 'F';
            nome = "Maria Silva";

            Console.WriteLine(nome + " tem idade = " + idade + " anos e salario de R$ " + salario +
                " com altura de " + altura + " e genero " + genero);

            // Formatando um double
            // Precisam utilizar a biblioteca System.Globalization;
            // e podemos declarar em uma varial o CultureInfo.InvariantCulture;
            // ToString para formatção e o F2(2 casas decimais), F3(2 casas decimais) e assim sucessivamente

            Console.WriteLine();
            Console.WriteLine("Formatando um double com duas casas decimas");
            Console.WriteLine("Altura = " + altura.ToString("F2", CI));

        }
    }
}
using System;
using System.Globalization;

//CAP.05
namespace media_idades {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int idade, cont=0;
            double soma=0, media=0;



            Console.WriteLine("Digite as idades: ");
            idade = int.Parse(Console.ReadLine());

            if (idade < 0) {
                Console.WriteLine("IMPOSSIVEL CALCULAR");
            }
            else {

                while (idade > 0) {
                    soma = soma + idade;
                    cont++;
                    idade = int.Parse(Console.ReadLine());
                }

                media = soma / cont;

                Console.WriteLine("MEDIA = " + media.ToString("F2", CI));
            }
        }
    }
}
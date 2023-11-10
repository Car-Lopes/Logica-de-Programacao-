using System;
using System.Globalization;

//CAP.05
namespace media_ponderada {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n;
            double num1=0, num2=0, num3=0, mediaPonderada=0;

            Console.Write("Quantos casos voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite tres numeros: ");
                num1 = double.Parse(Console.ReadLine(), CI);
                num2 = double.Parse(Console.ReadLine(), CI);
                num3 = double.Parse(Console.ReadLine(), CI);

                num1 = num1 * 2;
                num2 = num2 * 3;
                num3 = num3 * 5;

                mediaPonderada = (num1 + num2 + num3) / 10;

                Console.WriteLine("MEDIA = " + mediaPonderada.ToString("F1", CI));

            }
            
        }
    }
}
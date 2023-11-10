using System;
using System.Globalization;

//CAP.04
namespace temperatura {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            double c, f;
            char x;

            Console.Write("Voce vai digitar a temperatura em qual escala (C/F)? ");
            x = char.Parse(Console.ReadLine());

            if (x == 'F') {
                Console.Write("Digite a temperatura em Fahrenheit: ");
                f = double.Parse(Console.ReadLine(), CI);
                c = (f - 32) * 5/9;
                Console.WriteLine("Temperatura equivalente em Celsius: " + c.ToString("F2", CI));
            }
            else {
                Console.Write("Digite a temperatura em Celsius: ");
                c = double.Parse(Console.ReadLine(), CI);
                f = c * 9 / 5 + 32;
                Console.WriteLine("Temperatura equivalente em Fahrenheit: " + f.ToString("F2", CI));
            }
 
        }
    }
}
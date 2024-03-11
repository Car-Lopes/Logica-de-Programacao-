using System.Globalization;
using System.Numerics;

namespace MyMatrixComClasse {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

            Product[] vet = new Product[n];

            for (int i = 0; i < n; i++) { 
                string name = Console.ReadLine();
                double price = double.Parse(Console.ReadLine(), ci);

                vet[i] = new Product { Name = name, Price = price };
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++) { 
                sum += vet[i].Price;
            }

            double avg = sum / n;
            Console.WriteLine("AVERAGE PRICE = " + avg.ToString("F2", ci));

           //Console.WriteLine("Hello, World!");
        }
    }
}
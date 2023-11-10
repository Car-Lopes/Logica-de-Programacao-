using System;
using System.Globalization;

// CAP.03 Exercicio(Terreno)
namespace terreno {
    internal class Program {
        private static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            double largura, comprimento, metroQudadro, areaTerreno, precoTerreno;

            Console.Write("Digite a largura do terreno: ");
            largura = double.Parse(Console.ReadLine(), CI);
           
            Console.Write("Digite o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine(), CI);
            
            Console.Write("Digite o valor do metro quadrado: ");
            metroQudadro = double.Parse(Console.ReadLine(), CI);

            areaTerreno = largura * comprimento;
            precoTerreno = areaTerreno * metroQudadro;

            Console.WriteLine("Area do terreno = " + areaTerreno.ToString("F2", CI));
            Console.WriteLine("Preco do terreno = " + precoTerreno.ToString("F2", CI));


        }
    }
}


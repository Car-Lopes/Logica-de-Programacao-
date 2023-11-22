using System;
using System.Globalization;

//CAP.06
namespace dados_pessoas {
    internal class Program {
        static void Main(string[] args) {
        
            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, contMulheres, contHomens;
            double menorAltura, maiorAltura, mediaAlturaMulheres, soma, numeroHomens;

            Console.Write("Quantas pessoas serao digitadas? ");
            n = int.Parse(Console.ReadLine());

            char[] genero = new char[n];
            double[] altura = new double[n];

            for (int i = 0; i < n; i++) {

                Console.Write("Altura da " + (i+1) +"a pessoa: ");
                altura[i] = double.Parse(Console.ReadLine(), CI);
                
                Console.Write("Genero da " + (i+1) +"a pessoa: ");
                genero[i] = char.Parse(Console.ReadLine());

            }

            maiorAltura = altura[0];
            menorAltura = altura[0];

            for (int i = 1; i < n; i++) {
                if (maiorAltura < altura[i]) {
                    maiorAltura = altura[i];
                }
                else if (menorAltura > altura[i]) {
                    menorAltura = altura[i];
                }
                else { 
                
                }
            
            }

            Console.WriteLine("Menor altura = " + menorAltura.ToString("F2", CI));
            Console.WriteLine("Maior altura = " + maiorAltura.ToString("F2", CI));

            soma = 0;
            contMulheres = 0;
            contHomens = 0;
            for (int i = 0; i < n; i++) {

                if (genero[i] == 'F') {
                    soma = soma + altura[i];
                    contMulheres++;
                }
                else {
                    contHomens++;
                }
            }
           

            mediaAlturaMulheres = soma / contMulheres;

            Console.WriteLine("Media das alturas das mulheres = " + mediaAlturaMulheres.ToString("F2", CI));
            Console.WriteLine("Numero de homens = " + contHomens);
        }
    }
}
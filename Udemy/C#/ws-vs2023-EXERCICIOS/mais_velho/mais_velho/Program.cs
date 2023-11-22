using System;
using System.Globalization;

//CAP.06
namespace mais_velho {
    internal class Program {
        static void Main(string[] args) {

            int n, maisVelho;
            string nomeMaisVelho;

            Console.Write("Quantas pessoas voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            string[] nome = new string[n];
            int[] idade = new int[n];


            for (int i = 0; i < n; i++) {
               
                Console.WriteLine("Dados da " + (i+1) + "a pessoa: ");
                Console.Write("NOME: ");
                nome[i] = Console.ReadLine();

                Console.Write("IDADE: ");
                idade[i] = int.Parse(Console.ReadLine());
            }

            maisVelho = idade[0];
            nomeMaisVelho = "AA";
            for (int i = 1; i < n; i++) {
                if (maisVelho < idade[i]) {
                    maisVelho = idade[i];
                    nomeMaisVelho = nome[i];
                }
            }
            
            Console.WriteLine("PESSOA MAIS VELHA: " + nomeMaisVelho);
        }
    }
}
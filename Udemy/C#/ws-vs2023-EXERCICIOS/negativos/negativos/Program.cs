﻿using System;
using System.Globalization;

//CAP.06
namespace negativos {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            int n, num;

            
            Console.Write("Quantos numeros voce vai digitar? ");
            n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            for (int i = 0; i < n; i++) {
                Console.Write("Digite um numero: ");
                vet[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("NUMEROS NEGATIVOS:");
            for (int i = 0; i < n; i++) {
                if (vet[i] < 0) {
                    Console.WriteLine(vet[i]);
                }
            }
        }
    }
}
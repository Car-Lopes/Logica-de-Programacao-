using System;
using System.Globalization;

namespace ArrayMyVet {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo ci = CultureInfo.InvariantCulture;

            int n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            
            for (int i = 0; i < n; i++) {
                vet[i] = double.Parse(Console.ReadLine(), ci);    
            }

            double sum = 0;
            for (int i = 0; i < n; i++) {
                sum += vet[i];
            }

            double avg = sum / n;

            //MEDIA DAS ALTURAS
            Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2",ci)); ;
        }
    }
}
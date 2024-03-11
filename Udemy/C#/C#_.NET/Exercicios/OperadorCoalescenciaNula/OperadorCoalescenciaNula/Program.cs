using System;
using System.Globalization;

namespace OperadorCoalescenciaNula {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo ci = CultureInfo.InvariantCulture;

            double? x = null;
            double? y = 10.0;

            double a = x ?? 5.0;
            double b = y ?? 5.0;

            Console.WriteLine(a.ToString("F1",ci));
            Console.WriteLine(b.ToString("F1",ci));

        }
    }
}
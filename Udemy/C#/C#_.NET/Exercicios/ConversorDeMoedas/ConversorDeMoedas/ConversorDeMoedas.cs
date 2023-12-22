using System;
using System.Globalization;


namespace ConversorDeMoedas {
    internal class ConversorDeMoedas {

        CultureInfo CI = CultureInfo.InvariantCulture;

        public static double IOF = 0.06;
       // public static double Dollar;
       // public static double DollarComprar;

        public static double CalcularDollarReais(double Dolar, double qtddDollar) { 
            return (((Dolar * qtddDollar) * IOF) + (Dolar * qtddDollar));
        }

       // public override string ToString() {
        //    return CalcularDollarReais().ToString("F2",CI);
       // }

    }
}

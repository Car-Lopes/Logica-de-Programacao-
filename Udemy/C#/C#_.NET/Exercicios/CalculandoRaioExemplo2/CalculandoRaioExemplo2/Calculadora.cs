using System;

namespace CalculandoRaioExemplo2 {
    internal class Calculadora {

        public  double pi = 3.14;

        public  double Circunferencia(double r) {
            return 2.0 * pi * r;
        }

        public  double Volume(double r) {
            return 4.0 / 3.0 * pi * Math.Pow(r, 3);
        }
    }
}



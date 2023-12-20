using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Criando a Classe
namespace trianguloComFormulaHeronComClasses {
    internal class Triangulo {
        //Atributos
        public double A;
        public double B;
        public double C;


        //Metodos (Função)
        public double CalculandoArea() {
            double p = (A + B + C) / 2.0;
           // double raiz = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
           // return raiz; 
           //ou 

            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

    }
}

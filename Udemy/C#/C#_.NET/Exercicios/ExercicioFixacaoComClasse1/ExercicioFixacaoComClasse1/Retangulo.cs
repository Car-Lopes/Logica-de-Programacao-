using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioFixacaoComClasse1 {
    internal class Retangulo {
        
        CultureInfo CI = CultureInfo.InvariantCulture;

        public double Largura;
        public double Altura;


        public double CalculandoArea() {
            return Largura * Altura;
        }

        public double CalculandoPerimetro() {
            return Largura * 2 + Altura * 2  ;
        }

        public double CalculandoDiagona() { 
            return Math.Sqrt(Math.Pow(Largura,2)+Math.Pow(Altura,2));
        }

       // public override string ToString() {
      //      return "AREA = " + CalculandoArea().ToString("F2", CI) 
      //          + "PERÍMETRO = " + CalculandoPerimetro().ToString("F2",CI);
      //  }

    }
}

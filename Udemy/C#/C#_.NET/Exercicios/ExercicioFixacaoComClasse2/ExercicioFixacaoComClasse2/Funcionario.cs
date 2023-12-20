using System;
using System.Globalization;

namespace ExercicioFixacaoComClasse2 {
    internal class Funcionario {

        CultureInfo CI = CultureInfo.InvariantCulture;

        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido() {
            return SalarioBruto - Imposto;
        }

        public void AumentoSalario(double porcentagem) {
            SalarioBruto = SalarioBruto + (SalarioBruto * (porcentagem/100));
        }
        public override string ToString() {
            return Nome + ", $ "
                + SalarioLiquido().ToString("F2", CI);
                
        }
    }
}

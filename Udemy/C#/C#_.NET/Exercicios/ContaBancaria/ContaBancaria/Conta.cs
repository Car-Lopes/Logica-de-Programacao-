using System.Globalization;

namespace ContaBancaria {
    internal class Conta {

        CultureInfo CI = CultureInfo.InvariantCulture;

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo {get; private set; }


        //Construtores
        public Conta (int numero, string titular) { 
            Numero = numero;
            Titular = titular;
        }

        public Conta( int numero, string titular, double deposito) : this(numero,titular){
            Deposito(deposito);
        }
           
        public double ValorTotaldaConta() {
            return Saldo;
        }
        
        public void Deposito(double valorDeposito) {
            Saldo += valorDeposito;
        }

        public void Saque(double valorSaque) { 
            Saldo -= valorSaque + 5.00;
        }

        public override string ToString() {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + ValorTotaldaConta().ToString("F2", CI);
        }
    }
}

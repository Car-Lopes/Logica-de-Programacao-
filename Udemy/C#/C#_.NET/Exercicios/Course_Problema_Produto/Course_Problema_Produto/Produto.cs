using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course_Problema_Produto {
    internal class Produto {

        CultureInfo CI = CultureInfo.InvariantCulture;

        // public string Nome;
        // public double Preco;
        //public int Quantidade;

        //Ecapsulamento
        private string _nome;
        public double Preco { get; private set; } //Auto Properties 
        public int Quantidade { get; private set; }



           public Produto() { 
           }

           //Gerando o Metodo Construtor 
           public Produto(string nome, double preco, int quantidade) { 
               _nome = nome;
               Preco = preco;
               Quantidade = quantidade;
           }

        //Sobrecarga outro construtor com 2 parametros
        /*  public Produto(string nome, double preco) { 
              Nome = nome;
              Preco = preco;
              Quantidade = 0;
          }
       */


        //Properties 
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }

        }

       // public double Preco {
        //    get { return _preco; }
       // }

       // public int Quantidade {
      //      get { return _quantidade; }
      //  } 
    

        //Metodo Get e Set
        /*
        public string GetNome() {
            return _nome;
        }
        
        public void SetNome(string nome) {
            _nome = nome;
        } */ 

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        } 

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome + ", $ "
                + Preco.ToString("F2", CI)
                + ", "
                + Quantidade
                + " unidade, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CI);
        }
    }
}

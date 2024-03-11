using System.Globalization;

namespace Course_Problema_Produto {
    internal class Program {
        static void Main(string[] args) {
            
            CultureInfo CI = CultureInfo.InvariantCulture;

            // Produto p = new Produto("TV", 500.00, 10);

            //Console.WriteLine(p);

            /*
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CI);
            */
            //  Console.Write("Quantidade no Estoque: ");
            //  int quantidade = int.Parse(Console.ReadLine());

            //Chamado o construtor
            // Produto p = new Produto(nome, preco, quantidade);

            // Produto p = new Produto(nome, preco);
            /*
             Produto p = new Produto { 
                 Nome = "TV",
                 Preco = 500.00,
                 Quantidade = 20
             };*/

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "T";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco.ToString("F2", CI));

            /*
            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p2);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser add no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p2.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p2);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p2.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p2);*/
        }
    }
}
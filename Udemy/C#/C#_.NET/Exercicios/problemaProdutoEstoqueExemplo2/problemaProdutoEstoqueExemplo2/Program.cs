﻿using System;
using System.Globalization;

namespace problemaProdutoEstoqueExemplo2 {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(),CI);

            Console.Write("Quantidade no Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser add no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine();
            Console.Write("Digite o numero de produtos a ser removido no estoque: ");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
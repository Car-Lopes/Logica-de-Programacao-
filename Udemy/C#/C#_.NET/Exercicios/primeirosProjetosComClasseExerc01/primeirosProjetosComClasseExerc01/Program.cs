using System;

namespace primeirosProjetosComClasseExerc01 {
    internal class Program {
        static void Main(string[] args) {

            Pessoa a, b;
            a = new Pessoa(); 
            b = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("NOME: ");
            a.Nome = Console.ReadLine();
            Console.Write("IDADE: ");
            a.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("NOME: ");
            b.Nome = Console.ReadLine();
            Console.Write("IDADE: ");
            b.Idade = int.Parse(Console.ReadLine());

            if (a.Idade > b.Idade) {
                Console.WriteLine("Pessoa mais velha: " + a.Nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha: " + b.Nome);
            }

            
        }
    }
}
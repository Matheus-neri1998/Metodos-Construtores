using System;
using Exercício_2___Produtos.Classes;

namespace Exercício_2___Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto desejado: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string Nome = Console.ReadLine(); // nome do produto 1
            Console.ResetColor();

            Console.WriteLine("---------------------");
            Console.WriteLine("Insira o código do produto: ");
            Console.ForegroundColor = ConsoleColor.Green;
            int Codigo = int.Parse(Console.ReadLine()); // código do produto 1
            Console.ResetColor();

            Console.WriteLine("----------------------");
            Console.WriteLine("Escreva a descrição do produto: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string Descricao = Console.ReadLine(); // descrição do produto 1 
            Console.ResetColor();

            Console.WriteLine("----------------------");
            Console.WriteLine("Insira o estoque do produto: ");
            Console.ForegroundColor = ConsoleColor.Black;
            int Estoque = int.Parse(Console.ReadLine()); // estoque do produto 1
            Console.ResetColor(); 
            // fim de produto 1

            Produto product= new Produto(Nome, Codigo, Descricao, Estoque);
            

            
            Produto product2 = new Produto("Suco de Laranja", 10, "Este suco é natural", 15);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Nome do produto 2 {product2.Nome ??"sem nome"}, Código do produto {product2.Codigo} - " +
            $"Descrição do produto: {product2.Descricao}, Estoque do produto: {product2.Estoque}");
            Console.ResetColor(); 
            // fim de produto 2

            

        }
    }
}

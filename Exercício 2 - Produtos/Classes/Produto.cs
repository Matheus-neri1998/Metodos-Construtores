using System;
namespace Exercício_2___Produtos.Classes
{
    public class Produto
    {
        public string Nome {get; set;}
        public int Codigo {get; set;}
        public string Descricao {get; set;}
        public int Estoque {get; set;}

        public Produto(string nome, int codigo, string descricao, int estoque){
            Nome = nome;
            Codigo = codigo;
            Descricao = descricao;
            Estoque = estoque;
        } // fim de método construtor

        public Produto(int codigo){
            Codigo = codigo;
        }

        public Produto()
        {
        }
    }
}
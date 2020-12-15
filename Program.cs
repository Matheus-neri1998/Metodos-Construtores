using System;
using Metodos_Construtores.Classes;

namespace Metodos_Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu nome: ");
            string primeiroNome = Console.ReadLine();
            
            Console.WriteLine("Digite o seu sobrenome: ");
            string ultimoNome = Console.ReadLine();


            Pessoas people = new Pessoas(primeiroNome, ultimoNome);

            
        }
    }
}

using System;

namespace Metodos_Construtores.Classes
{
    public class Pessoas
    {
        public string primeiroNome;
        public string ultimoNome;

        public Pessoas(){
            
        }

        public Pessoas(string firstname, string lastname){
            
            this.primeiroNome = firstname;
            this.ultimoNome = lastname;

            Console.WriteLine($"Bem vindo {primeiroNome} {ultimoNome}");
        }
    }
}
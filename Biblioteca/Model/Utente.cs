using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class Utente
    {
        internal string nome;
        internal string cognome;
        internal int contatore;

        public Utente(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.contatore = 0;
        }

        public void numeroDiLibri()
        {
            Console.WriteLine($"{nome} ha {contatore} Libri");
        }

      
    }
}

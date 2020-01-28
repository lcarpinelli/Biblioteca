using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class Utente
    {
        internal string Nome { get; set; }
        internal string Cognome { get; set; }
        //Propietà con solo getter che produce nome ecognome
        internal string Descrizione
        {
            get
            {
                return Nome + " " + Cognome;
            }
        }

        internal int contatore;

        public Utente(string nome, string cognome)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.contatore = 0;
        }

        public void numeroDiLibri()
        {
            Console.WriteLine($"{Nome} ha {contatore} Libri");
        }

      
    }
}

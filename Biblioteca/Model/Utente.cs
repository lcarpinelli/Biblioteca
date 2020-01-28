using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class Utente
    {
        internal string nome;
        internal string cognome;

        public Utente(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
        }

        public static void getBook()
        {
            Console.WriteLine("Inserisci il tuo nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Inserisci il tuo cognome: ");
            string cognome = Console.ReadLine();
            Utente ut = new Utente(nome, cognome);
            Console.WriteLine("Quale id vuoi prendere: ");
            string id = Console.ReadLine();


        }


    }
}

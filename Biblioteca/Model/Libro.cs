using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    public class Libro
    {
        private string titolo;
        private int id;
        private Utente utente;


        public Libro(string titolo, int id)
        {
            this.titolo = titolo;
            this.id = id;
            this.utente = null;
            
        }

        public void assegnaLibro(Utente richiedente)
        {
            if (utente == null)
            {
                utente = richiedente;
                Console.WriteLine($"Il libro {titolo} viene assegnato a {richiedente.nome}");
            }
            else
            {
                Console.WriteLine($"Il libro {titolo} è gia assegnato a {utente.nome}");
            }
        }




    }
}

using System;
using System.Collections.Generic;
using Biblioteca.Model;

namespace Biblioteca
{
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Inserisci il titolo del libro: ");
            //string titolo = Console.ReadLine();
            //Console.WriteLine("Inserisci il numero del libro: ");
            //int numero = Convert.ToInt32(Console.ReadLine());
            Libro lib = new Libro("ABCD", 1);
            Utente u = new Utente("Mario", "Rossi");
            lib.assegnaLibro(u);
            Console.WriteLine(lib);

        }

    }
}




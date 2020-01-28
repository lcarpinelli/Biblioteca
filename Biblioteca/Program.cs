using System;
using System.Collections.Generic;
using Biblioteca.Model;

namespace Biblioteca
{
    class Program
    {

        static void Main(string[] args)
        {
            Libro lib = new Libro("ABCD", 1);
            Utente cliente1 = new Utente("Mario", "Rossi");
            Utente cliente2 = new Utente("Marco", "Bianchi");
            lib.assegnaLibro(cliente1);
            lib.assegnaLibro(cliente2);
            cliente1.numeroDiLibri();
            lib.restituzioneLibro(cliente1);
            cliente1.numeroDiLibri();
            lib.assegnaLibro(cliente2);
        }

    }
}




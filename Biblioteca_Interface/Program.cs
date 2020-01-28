using Biblioteca_Interface.Concretizzazione;
using System;

namespace Biblioteca_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Studente s = new Studente("Mario", "Rossi", "AAA");
            Direttore d = new Direttore("Carlo", "Bianchi", "BBB");
            Console.WriteLine(d.Descrizione);
            Console.WriteLine(s.Descrizione);
        }
    }
}

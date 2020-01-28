using Biblioteca_Interface.Concretizzazione;
using System;
using System.Collections.Generic;
using System.Text;


namespace Biblioteca_Interface.Interfacce
{
    public interface IPersona
    {
        string Nome { get; set; }
        string Cognome { get; set; }
        string Descrizione { get; }

    }
}

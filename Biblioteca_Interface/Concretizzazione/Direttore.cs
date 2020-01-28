using Biblioteca_Interface.Interfacce;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_Interface.Concretizzazione
{
    class Direttore : IPersona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string MatricolaDirettore { get; set; }
        public string Descrizione
        {
            get
            {
                return Nome + " " + Cognome;
            }
        }

        public Direttore (string nome, string cognome,string matricoladirettore)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.MatricolaDirettore = matricoladirettore;

        }

    }
}

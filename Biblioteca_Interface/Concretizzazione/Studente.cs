using Biblioteca_Interface.Interfacce;
using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_Interface.Concretizzazione
{
    class Studente : IPersona

    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Matricola { get; set; }
        public string Descrizione
        {
            get
            {
                return Nome + " " + Cognome;
            }
        }

        public Studente (string nome,string cognome,string matricola)
        {
            this.Nome = nome;
            this.Cognome = cognome;
            this.Matricola = matricola;           
        }


    }
}

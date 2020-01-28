using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca.Model
{
    /// <summary>
    /// Rappresenta un libro e gestisce l'assegnazione degli stessi
    /// </summary>
    public class Libro
    {
        private string titolo;
        private int id;
        private Utente utente; // utente che ha in prestito il libro, se NULL è Libero


        public Libro(string titolo, int id)
        {
            this.titolo = titolo;
            this.id = id;
            this.utente = null;
        }

        #region Metodi
        /// <summary>
        /// permette di assegnare il libro se esso è disponibile
        /// </summary>
        /// <param name="richiedente">Accetta in ingresso un oggetto di tipo utente</param>
        public void assegnaLibro(Utente richiedente)
        {
            if (utente == null)
            {
                Console.WriteLine($"Il libro {titolo} viene assegnato a {richiedente.nome}");
                utente = richiedente;
                richiedente.contatore = +1;
            }
            else
            {
                Console.WriteLine($"Mi dispiace {richiedente.nome} Il libro {titolo} è gia assegnato a {utente.nome}");
            }
        }

        /// <summary>
        /// permette di riconsegnare il libro e verifica la disponibilità
        /// </summary>
        /// <param name="restituitore">Accetta in ingresso un oggetto di tipo utente</param>
        public void restituzioneLibro(Utente restituitore)
        {
            if (utente == restituitore)
            {
                Console.WriteLine($"Il libro {titolo} è stato riconsegnato da {restituitore.nome}");
                restituitore.contatore--;
                utente = null;
            }
            else
            {
                Console.WriteLine($"Il libro {titolo} è disponibile");
            }
        }
        #endregion

    }
}

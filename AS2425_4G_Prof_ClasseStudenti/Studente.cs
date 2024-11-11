using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2425_INF_Prof_ClasseStudenti
{
    /// <summary>
    /// Studente della classe
    /// </summary>
    class Studente
    {
        string nome;
        string cognome;

        public Studente(string cognome, string nome)
        {
            this.cognome = cognome;
            this.nome = nome;
        }

        /// <summary>
        /// Visualizzazione dati studente
        /// </summary>
        /// <returns>Dati studente</returns>
        public string Visualizzati()
        {
            return $"{cognome} {nome}";
        }
    }
}

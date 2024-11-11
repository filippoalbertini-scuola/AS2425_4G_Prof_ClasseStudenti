using AS2425_4G_Prof_ClasseStudenti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2425_INF_Prof_ClasseStudenti
{
    /// <summary>
    /// docente della classe
    /// </summary>
    class Docente
    {
        string nome;
        string cognome;

        Materia materia;

        public Docente(string cognome, string nome, Materia materia)
        {
            this.cognome = cognome;
            this.nome = nome;

            this.materia = materia;
        }

        /// <summary>
        /// Visualizzazione dati docente
        /// </summary>
        /// <returns>Dati docente</returns>
        public string Visualizzati()
        {
            return $"{cognome} {nome} {materia.Visualizzati()}";
        }
    }
}

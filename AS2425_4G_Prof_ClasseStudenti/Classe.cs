using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2425_Prof_ClasseStudenti
{
    class Classe
    {
        // dichiara il contenitore per gestire l'associazione agli studenti
        List<Studente> studenti;
        public List<Studente> Studenti { get => studenti; }

        // dichiara il contenitore per gestire l'associazione ai docenti
        List<Docente> docenti;
        public List<Docente> Docenti { get => docenti; }

        // descrizione della classe
        string descrizione;


        public Classe(string descrizione)
        {
            this.descrizione = descrizione;

            // istanzio la lista studenti
            studenti = new List<Studente>();

            // istanzio la lista docenti
            docenti = new List<Docente>();
        }

        /// <summary>
        /// Aggiunta studente alla classe Classe
        /// </summary>
        /// <param name="studente"></param>
        public void AddStudente(Studente studente)
        {
            studenti.Add(studente);
        }

        /// <summary>
        /// Aggiunta docente alla classe Classe
        /// </summary>
        /// <param name="docente"></param>
        public void AddDocente(Docente docente)
        {
            docenti.Add(docente);
        }
    }
}

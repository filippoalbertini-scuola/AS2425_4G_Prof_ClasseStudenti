using AS2425_4G_Prof_ClasseStudenti;
using System;
using System.Collections.Generic;

namespace AS2425_INF_Prof_ClasseStudenti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prof; 4G Lab. T.1; 13/11/2024; Lista classe Persona");

            // dichiaro e istanzio la classe Classe
            Classe classe4G = new Classe("4G");

            Materia informatica = new Materia("Informatica");
            Materia sistemi = new Materia("Sistemi e Reti");

            // aggiungo un docente
            classe4G.AddDocente(new Docente("Fabbri", "Francesco", informatica));
            classe4G.AddDocente(new Docente("Albertini", "Filippo", informatica));
            classe4G.AddDocente(new Docente("Gabellini", "Alessandro", sistemi));

            // aggiungo studenti
            classe4G.AddStudente(new Studente("Randazzo", "Diego"));
            classe4G.AddStudente(new Studente("Dominici", "Matteo"));
            classe4G.AddStudente(new Studente("Agarri", "Francesco"));
            classe4G.AddStudente(new Studente("Marongiu", "Marco"));

            Console.WriteLine("\n");

            Console.WriteLine($"Elenco docenti ({classe4G.Docenti.Count}):\n");
            foreach (Docente d in classe4G.Docenti)
            {
                Console.WriteLine($"{d.Visualizzati()}");
            }

            Console.WriteLine("\n");

            Console.WriteLine($"Elenco studenti ({classe4G.Studenti.Count}):\n");
            foreach (Studente s in classe4G.Studenti)
            {
                Console.WriteLine($"{s.Visualizzati()}");
            }

        }
    }
}

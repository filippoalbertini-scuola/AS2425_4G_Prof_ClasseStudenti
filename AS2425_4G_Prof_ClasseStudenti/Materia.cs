﻿namespace AS2425_4G_Prof_ClasseStudenti
{
    internal class Materia
    {
        private string descrizione;
        public Materia(string descrizione)
        {
            this.descrizione = descrizione;            
        }

        public string Visualizzati()
        {
            return $"{descrizione}";
        }
    }
}
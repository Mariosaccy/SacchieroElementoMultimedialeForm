using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacchieroElementoMultimediale
{
    public abstract class ElementoMultimediale
    {
        public string Titolo { get; set; }
        public ElementoMultimediale(string titolo)
        {
            if (string.IsNullOrWhiteSpace(titolo))
                throw new ArgumentException("Il titolo non può essere vuoto.");
            Titolo = titolo;
        }
        public abstract override string ToString();
    }

    public abstract class Riproducibile : ElementoMultimediale
    {
        public int Durata { get; set; }
        public Riproducibile(string titolo, int durata) : base(titolo)
        {
            if (durata <= 0)
                throw new ArgumentException("La durata deve essere un valore positivo.");
            Durata = durata;
        }
        public abstract void Play();
    }
}

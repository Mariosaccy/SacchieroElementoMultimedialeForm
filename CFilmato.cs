using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SacchieroElementoMultimediale
{
    public class CFilmato : Riproducibile, IVolumeRegolabile, ILuminositaRegolabile, IComparable<CFilmato>
    {
        public int Volume { get; set; }
        public int Luminosita { get; set; }
        public CFilmato(string titolo, int durata, int volume, int luminosita) : base(titolo, durata)
        {
            Volume = volume;
            Luminosita = luminosita;
        }

        public void Weaker()
        {
            // diminuisce il volume di 1 fino a un minimo di 0
            if (Volume > 0)
            {
                Volume--;
            }
            MessageBox.Show("Volume diminuito");
        }
        public void Louder()
        {
            // aumenta il volume di 1 con limite massimo di 20
            if (Volume < 20)
            {
                Volume++;
            }
            MessageBox.Show("Volume aumentato");
        }

        public void Brighter()
        {
            // aumenta la luminosità di 1 unità, fino a un massimo di 10
            if (Luminosita < 10)
            {
                Luminosita++;
            }
            MessageBox.Show("Luminosità aumentata");
        }
        public void Darker()
        {
            // diminuisce la luminosità di 1 fino a un minimo di 0
            if (Luminosita > 0)
            {
                Luminosita--;
            }
            MessageBox.Show("Luminosità diminuita");
        }

        public override string Play()
        {
            string testo = $"{Titolo} - ";
            int j = 0;
            for (int i = 0; i < Durata; i++)
            {
                testo = "";
                for (j = 0; j < Volume; j++)
                {
                    testo += "!";
                }
                testo += " - ";
                for (j = 0; j < Luminosita; j++)
                {
                    testo += "*";
                }
                testo += "\n";
            }

            return testo;
        }
        public override string ToString()
        {
            string testo = $"Filmato - Titolo: {Titolo}, Durata: {Durata}, Volume: {Volume}, Luminosità: {Luminosita}";
            return testo;
        }
        public int CompareTo(CFilmato other)
        {
            if (other == null)
            {
                return 1;
            }
            return this.Durata.CompareTo(other.Durata); // se this.Durata è minore di other.Durata ritorna un valore negativo
        }
    }
}

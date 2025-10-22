using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SacchieroElementoMultimediale
{
    public class CImmagine : ElementoMultimediale, ILuminositaRegolabile
    {
        public int Luminosita { get; set; }
        public CImmagine(string titolo, int luminosita) : base(titolo)
        {
            Luminosita = luminosita;
        }

        public void Brighter()
        {
            // aumenta la luminosità di 1 unità, fino a un massimo di 10
            if (Luminosita < 10)
            {
                Luminosita++;
            }
        }
        public void Darker()
        {
            // diminuisce la luminosità di 1 fino a un minimo di 0
            if (Luminosita > 0)
            {
                Luminosita--;
            }
        }

        public string Show()
        {
            string testo = $"{Titolo} - ";
            for (int i = 0; i < Luminosita; i++)
            {
                testo += "*";
            }
            return testo;
        }
        public override string ToString()
        {
            string testo = $"Immagine - Titolo: {Titolo}, Luminosità: {Luminosita}";
            return testo;
        }
    }
}

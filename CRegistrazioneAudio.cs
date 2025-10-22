using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SacchieroElementoMultimediale
{
    public class CRegistrazioneAudio : Riproducibile, IVolumeRegolabile
    {
        public int Volume { get; set; }
        public CRegistrazioneAudio(string titolo, int durata, int volume) : base(titolo, durata)
        {
            Volume = volume;
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

        public override string Play()
        {
            string testo = $"{Titolo} - ";
            for (int i = 0; i < Durata; i++)
            {
                testo = "";
                for (int j = 0; j < Volume; j++)
                {
                    testo += "!";
                }
                testo += "\n";
            }

            return testo;
        }
        public override string ToString()
        {
            string testo = $"Registrazione Audio - Titolo: {Titolo}, Durata: {Durata}, Volume: {Volume}";
            return testo;
        }
    }
}

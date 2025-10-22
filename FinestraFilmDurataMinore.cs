using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SacchieroElementoMultimediale
{
    public partial class FinestraFilmDurataMinore : Form
    {
        ElementoMultimediale[] elementi = new ElementoMultimediale[5];
        public FinestraFilmDurataMinore(ElementoMultimediale[] elementi)
        {
            InitializeComponent();
            this.elementi = elementi;

            ImpostaValoriBase();
        }

        public void ImpostaValoriBase()
        {
            //imposto i valori di base del form
            foreach (var elemento in elementi)
            {
                cmb_scelta.Items.Add(elemento.GetType().Name);
            }
            // non da la possibilità di scrivere altro nel combobox
            cmb_scelta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_scelta.SelectedIndex = 0;

            // non da la possibilità di scrivere nel xetbox
            txt_esecuzione.ReadOnly = true;
        }

        private void FinestraFilmDurataMinore_Load(object sender, EventArgs e)
        {

        }

        private void btn_visualizza_Click(object sender, EventArgs e)
        {
            // ottengo l'indice selezionato nel combobox
            int index = cmb_scelta.SelectedIndex;
            if (elementi[index] is CFilmato elementoVideo)
            {
                txt_esecuzione.Text = $"I filmati con la durata minore sono:\n";
                int durataVideo = elementoVideo.Durata;
                foreach (var elemento in elementi)
                {
                    if (elemento is CFilmato filmato)
                    {
                        if (filmato.Durata < durataVideo)
                        {
                            txt_esecuzione.Text = $"{filmato.ToString()}\n";
                        }
                    }
                }
            }
            else
            {
                txt_esecuzione.Text = "Errore";
            }
        }
    }
}

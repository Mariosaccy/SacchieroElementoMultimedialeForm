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
    public partial class FinestraEsegui : Form
    {
        ElementoMultimediale[] elementi = new ElementoMultimediale[5];
        public FinestraEsegui(ElementoMultimediale[] elementi)
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

        private void btn_esegui_Click(object sender, EventArgs e)
        {
            // ottengo l'indice selezionato nel combobox
            int index = cmb_scelta.SelectedIndex;
            if (elementi[index] is CImmagine elementoImmagine)
            {
                txt_esecuzione.Text = elementoImmagine.Show();
            }
            else if (elementi[index] is CRegistrazioneAudio elementoAudio)
            {
                txt_esecuzione.Text = elementoAudio.Play();
            }
            else if (elementi[index] is CFilmato elementoVideo)
            {
                txt_esecuzione.Text = elementoVideo.Play();
            }
        }


        private void cmb_scelta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_scelta_Click(object sender, EventArgs e)
        {

        }

        private void txt_esecuzione_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_titoloForm_Click(object sender, EventArgs e)
        {

        }

        private void FinestraEsegui_Load(object sender, EventArgs e)
        {

        }
    }
}

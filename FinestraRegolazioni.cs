using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SacchieroElementoMultimediale
{
    public partial class FinestraRegolazioni : Form
    {
        ElementoMultimediale[] elementi = new ElementoMultimediale[5];
        int index;
        int parametriRegolazione = 0; // 0 = nessuna, 1 = luminosità, 2 = volume, 3 = entrambi
        public FinestraRegolazioni(ElementoMultimediale[] elementi)
        {
            InitializeComponent();
            this.elementi = elementi;

            // aggiungo evento al combobox per cambiare i pannelli visibili in base alla scelta dell'utente
            cmb_scelta.SelectedIndexChanged += (s, e) => PannelliVisibili();
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

            PannelliVisibili();
        }

        public void PannelliVisibili()
        {
            index = cmb_scelta.SelectedIndex;
            //nascondo tutti i pannelli
            pnl_luminosita.Visible = false;
            pnl_volume.Visible = false;

            if (elementi[index] is CImmagine)
            {
                pnl_luminosita.Visible = true;
                trc_luminosita.Value = ((ILuminositaRegolabile)elementi[index]).Luminosita;
                parametriRegolazione = 1;
            }
            else if (elementi[index] is CRegistrazioneAudio)
            {
                pnl_volume.Visible = true;
                trc_volume.Value = ((IVolumeRegolabile)elementi[index]).Volume;
                parametriRegolazione = 2;
            }
            else if (elementi[index] is CFilmato)
            {
                pnl_luminosita.Visible = true;
                pnl_volume.Visible = true;
                trc_luminosita.Value = ((ILuminositaRegolabile)elementi[index]).Luminosita;
                trc_volume.Value = ((IVolumeRegolabile)elementi[index]).Volume;
                parametriRegolazione = 3;
            }

        }

        private void btn_regola_Click(object sender, EventArgs e)
        {
            if (parametriRegolazione == 1)
            {
                // regolazione luminosità
                int luminosita = trc_luminosita.Value;
                if (elementi[index] is ILuminositaRegolabile elementoLuminosita)
                {
                    while (elementoLuminosita.Luminosita < luminosita)
                    {
                        elementoLuminosita.Brighter();
                    }
                    while (elementoLuminosita.Luminosita > luminosita)
                    {
                        elementoLuminosita.Darker();
                    }
                }
            }
            else if (parametriRegolazione == 2)
            {
                // regolazione volume
                int volume = trc_volume.Value;
                if (elementi[index] is IVolumeRegolabile elementoVolume)
                {
                    while (elementoVolume.Volume < volume)
                    {
                        elementoVolume.Louder();
                    }
                    while (elementoVolume.Volume > volume)
                    {
                        elementoVolume.Weaker();
                    }
                }
            }
            else if (parametriRegolazione == 3)
            {
                // regolazione luminosità e volume
                int luminosita = trc_luminosita.Value;
                int volume = trc_volume.Value;
                if (elementi[index] is CFilmato elementoFilmato)
                {
                    while (elementoFilmato.Luminosita < luminosita)
                    {
                        elementoFilmato.Brighter();
                    }
                    while (elementoFilmato.Luminosita > luminosita)
                    {
                        elementoFilmato.Darker();
                    }
                    while (elementoFilmato.Volume < volume)
                    {
                        elementoFilmato.Louder();
                    }
                    while (elementoFilmato.Volume > volume)
                    {
                        elementoFilmato.Weaker();
                    }
                }
            }
            else
            {
                MessageBox.Show("Nessun parametro da regolare per questo elemento.");
            }
        }

        private void FinestraRegolazioni_Load(object sender, EventArgs e)
        {

        }

        private void txt_esecuzione_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_esegui_Click(object sender, EventArgs e)
        {

        }

        private void lbl_scelta_Click(object sender, EventArgs e)
        {

        }

        private void cmb_scelta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_titoloForm_Click(object sender, EventArgs e)
        {

        }

        private void cmb_scelta_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void lbl_scelta_Click_1(object sender, EventArgs e)
        {

        }
    }
}

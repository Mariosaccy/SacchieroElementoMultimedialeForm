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
    public partial class Form1 : Form
    {
        // qui dentro prendo i valori inseriti dall'utente e li salvo in un array di ElementoMultimediale
        // di base chiede solo il nome, poi in base alla scelta dell'utente chiede gli altri valori
        // quindi se sceglie immagine chiede solo luminosità, se sceglie audio chiede durata e volume, se sceglie filmato chiede durata, volume e luminosità

        //crea array da 5 elementi che poi chiederà all'utente
        ElementoMultimediale[] elementi = new ElementoMultimediale[5];
        int index = 0;

        public Form1()
        {
            InitializeComponent();

            //imposto i valori di base del form
            ImpostavaloriBase();

            // aggiungo evento al combobox per cambiare i pannelli visibili in base alla scelta dell'utente
            cmb_scelta.SelectedIndexChanged += PannelliVisibili;

        }

        public void ImpostavaloriBase()
        {
            //nascondo tutti i pannelli
            pnl_durata.Visible = false;
            pnl_volume.Visible = false;
            pnl_luminosita.Visible = false;
            pnl_funzionalita.Visible = false;
            pnl_input.Enabled = true;

            //imposto i valori di base del form
            cmb_scelta.Items.Add("Immagine");
            cmb_scelta.Items.Add("Audio");
            cmb_scelta.Items.Add("Filmato");
            // non da la possibilità di scrivere altro nel combobox
            cmb_scelta.DropDownStyle = ComboBoxStyle.DropDownList;

            cmb_scelta.SelectedIndex = 0;
            pnl_luminosita.Visible = true;

            lbl_numerazioneElemento.Text = $"Elemento {index+1} di 5";
        }

        public void PannelliVisibili(object sender, EventArgs e)
        {
            //nascondo tutti i pannelli
            pnl_durata.Visible = false;
            pnl_volume.Visible = false;
            pnl_luminosita.Visible = false;
            //mostro i pannelli in base alla scelta dell'utente
            switch (cmb_scelta.SelectedItem.ToString())
            {
                case "Immagine":
                    pnl_luminosita.Visible = true;
                    break;
                case "Audio":
                    pnl_durata.Visible = true;
                    pnl_volume.Visible = true;
                    break;
                case "Filmato":
                    pnl_durata.Visible = true;
                    pnl_volume.Visible = true;
                    pnl_luminosita.Visible = true;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_crea_Click(object sender, EventArgs e)
        {
            // crea l'elemento multimediale in base ai valori inseriti dall'utente e lo salva nell'array
            string nome = txt_nome.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Inserisci un nome valido.");
                return;
            }

            try
            {
                switch (cmb_scelta.SelectedItem.ToString())
                {
                    case "Immagine":
                        int luminosita = trc_luminosita.Value;
                        elementi[index] = new CImmagine(nome, luminosita);
                        break;
                    case "Audio":
                        int durata = (int)nmr_durata.Value;
                        if (durata <= 0)
                        {
                            MessageBox.Show("La durata deve essere un valore positivo.");
                            return;
                        }
                        int volume = trc_volume.Value;
                        elementi[index] = new CRegistrazioneAudio(nome, durata, volume);
                        break;
                    case "Filmato":
                        durata = (int)nmr_durata.Value;
                        if (durata <= 0)
                        {
                            MessageBox.Show("La durata deve essere un valore positivo.");
                            return;
                        }
                        volume = trc_volume.Value;
                        luminosita = trc_luminosita.Value;
                        elementi[index] = new CFilmato(nome, durata, volume, luminosita);
                        break;
                }
                index++;
                if (index < elementi.Length)
                {
                    lbl_numerazioneElemento.Text = $"Elemento {index + 1} di 5";
                    // resetto i campi per il prossimo elemento
                    txt_nome.Clear();
                    nmr_durata.Value = nmr_durata.Minimum;
                    trc_volume.Value = trc_volume.Minimum;
                    trc_luminosita.Value = trc_luminosita.Minimum;
                }
                else
                {
                    MessageBox.Show("Hai creato tutti gli elementi multimediali.");
                    btn_crea.Enabled = false;
                    pnl_input.Enabled = false;
                    pnl_durata.Visible = false;
                    pnl_volume.Visible = false;
                    pnl_luminosita.Visible = false;
                    pnl_funzionalita.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Errore: {ex.Message}");
            }
        }

        private void btn_esegui_Click(object sender, EventArgs e)
        {

        }

        private void btn_regola_Click(object sender, EventArgs e)
        {

        }

        private void btn_inferiori_Click(object sender, EventArgs e)
        {

        }

        private void btn_ordina_Click(object sender, EventArgs e)
        {

        }

        private void btn_VerificaUgualianza_Click(object sender, EventArgs e)
        {

        }

        private void btn_esci_Click(object sender, EventArgs e)
        {

        }

        private void trc_volume_Scroll(object sender, EventArgs e)
        {

        }

        private void trc_luminosita_Scroll(object sender, EventArgs e)
        {

        }

        private void lbl_numerazioneElemento_Click(object sender, EventArgs e)
        {

        }

        private void cmb_scelta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pnl_durata_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_durata_Click(object sender, EventArgs e)
        {

        }

        private void nmr_durata_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbl_volume_Click(object sender, EventArgs e)
        {

        }

        private void lbl_luminosita_Click(object sender, EventArgs e)
        {

        }

        private void pnl_volume_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_luminosita_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_scelta_Click(object sender, EventArgs e)
        {

        }

        private void lbl_nome_Click(object sender, EventArgs e)
        {

        }

        private void pnl_input_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_funzionalita_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class FinestraVerificaUgualianza : Form
    {
        ElementoMultimediale[] elementi = new ElementoMultimediale[5];
        public FinestraVerificaUgualianza(ElementoMultimediale[] elementi)
        {
            InitializeComponent();
            this.elementi = elementi;
        }

        public void ImpostaValoriBase()
        {
            //imposto i valori di base del form
            foreach (var elemento in elementi)
            {
                cmb_scelta1.Items.Add(elemento.GetType().Name);
                cmb_scelta2.Items.Add(elemento.GetType().Name);
            }
            // non da la possibilità di scrivere altro nel combobox
            cmb_scelta1.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_scelta1.SelectedIndex = 0;
            cmb_scelta2.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_scelta2.SelectedIndex = 0;
        }

        private void btn_controlla_Click(object sender, EventArgs e)
        {
            // ottengo gli indici selezionati nei combobox
            int index1 = cmb_scelta1.SelectedIndex;
            int index2 = cmb_scelta2.SelectedIndex;
            if (index1 == index2)
            {
                MessageBox.Show("Seleziona due elementi multimediali diversi");
                lbl_risposta.Text = "Seleziona due elementi multimediali diversi";
                return;
            }

            if (elementi[index1].Equals(elementi[index2]))
            {
                MessageBox.Show("I due elementi multimediali sono uguali");
                lbl_risposta.Text = "I due elementi multimediali sono uguali";
            }
            else
            {
                MessageBox.Show("I due elementi multimediali sono diversi");
                lbl_risposta.Text = "I due elementi multimediali sono diversi";
            }
        }
    }
}

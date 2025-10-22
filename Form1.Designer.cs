namespace SacchieroElementoMultimediale
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titoloForm = new System.Windows.Forms.Label();
            this.pnl_funzionalita = new System.Windows.Forms.Panel();
            this.cmb_scelta = new System.Windows.Forms.ComboBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_scelta = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_titoloForm
            // 
            this.lbl_titoloForm.AutoSize = true;
            this.lbl_titoloForm.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titoloForm.Location = new System.Drawing.Point(264, 32);
            this.lbl_titoloForm.Name = "lbl_titoloForm";
            this.lbl_titoloForm.Size = new System.Drawing.Size(273, 19);
            this.lbl_titoloForm.TabIndex = 0;
            this.lbl_titoloForm.Text = "Benvenuto al programma multimediale";
            // 
            // pnl_funzionalita
            // 
            this.pnl_funzionalita.Location = new System.Drawing.Point(23, 32);
            this.pnl_funzionalita.Name = "pnl_funzionalita";
            this.pnl_funzionalita.Size = new System.Drawing.Size(200, 100);
            this.pnl_funzionalita.TabIndex = 1;
            // 
            // cmb_scelta
            // 
            this.cmb_scelta.FormattingEnabled = true;
            this.cmb_scelta.Location = new System.Drawing.Point(252, 176);
            this.cmb_scelta.Name = "cmb_scelta";
            this.cmb_scelta.Size = new System.Drawing.Size(121, 21);
            this.cmb_scelta.TabIndex = 2;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(437, 177);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // lbl_scelta
            // 
            this.lbl_scelta.AutoSize = true;
            this.lbl_scelta.Location = new System.Drawing.Point(249, 160);
            this.lbl_scelta.Name = "lbl_scelta";
            this.lbl_scelta.Size = new System.Drawing.Size(51, 13);
            this.lbl_scelta.TabIndex = 4;
            this.lbl_scelta.Text = "tipo di file";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(434, 160);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(66, 13);
            this.lbl_nome.TabIndex = 5;
            this.lbl_nome.Text = "nome del file";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_scelta);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.cmb_scelta);
            this.Controls.Add(this.pnl_funzionalita);
            this.Controls.Add(this.lbl_titoloForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titoloForm;
        private System.Windows.Forms.Panel pnl_funzionalita;
        private System.Windows.Forms.ComboBox cmb_scelta;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_scelta;
        private System.Windows.Forms.Label lbl_nome;
    }
}


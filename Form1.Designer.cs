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
            this.pnl_input = new System.Windows.Forms.Panel();
            this.cmb_scelta = new System.Windows.Forms.ComboBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_scelta = new System.Windows.Forms.Label();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.btn_crea = new System.Windows.Forms.Button();
            this.trc_volume = new System.Windows.Forms.TrackBar();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.pnl_volume = new System.Windows.Forms.Panel();
            this.pnl_luminosita = new System.Windows.Forms.Panel();
            this.lbl_luminosita = new System.Windows.Forms.Label();
            this.trc_luminosita = new System.Windows.Forms.TrackBar();
            this.lbl_numerazioneElemento = new System.Windows.Forms.Label();
            this.lbl_durata = new System.Windows.Forms.Label();
            this.nmr_durata = new System.Windows.Forms.NumericUpDown();
            this.pnl_durata = new System.Windows.Forms.Panel();
            this.pnl_funzionalita = new System.Windows.Forms.Panel();
            this.btn_esegui = new System.Windows.Forms.Button();
            this.btn_regola = new System.Windows.Forms.Button();
            this.btn_inferiori = new System.Windows.Forms.Button();
            this.btn_ordina = new System.Windows.Forms.Button();
            this.btn_VerificaUgualianza = new System.Windows.Forms.Button();
            this.btn_esci = new System.Windows.Forms.Button();
            this.lbl_ordinato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trc_volume)).BeginInit();
            this.pnl_volume.SuspendLayout();
            this.pnl_luminosita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trc_luminosita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_durata)).BeginInit();
            this.pnl_durata.SuspendLayout();
            this.pnl_funzionalita.SuspendLayout();
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
            // pnl_input
            // 
            this.pnl_input.Location = new System.Drawing.Point(139, 64);
            this.pnl_input.Name = "pnl_input";
            this.pnl_input.Size = new System.Drawing.Size(522, 352);
            this.pnl_input.TabIndex = 1;
            this.pnl_input.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_input_Paint);
            // 
            // cmb_scelta
            // 
            this.cmb_scelta.FormattingEnabled = true;
            this.cmb_scelta.Location = new System.Drawing.Point(259, 122);
            this.cmb_scelta.Name = "cmb_scelta";
            this.cmb_scelta.Size = new System.Drawing.Size(121, 21);
            this.cmb_scelta.TabIndex = 2;
            this.cmb_scelta.SelectedIndexChanged += new System.EventHandler(this.cmb_scelta_SelectedIndexChanged);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(444, 123);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 3;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // lbl_scelta
            // 
            this.lbl_scelta.AutoSize = true;
            this.lbl_scelta.Location = new System.Drawing.Point(256, 106);
            this.lbl_scelta.Name = "lbl_scelta";
            this.lbl_scelta.Size = new System.Drawing.Size(51, 13);
            this.lbl_scelta.TabIndex = 4;
            this.lbl_scelta.Text = "tipo di file";
            this.lbl_scelta.Click += new System.EventHandler(this.lbl_scelta_Click);
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(441, 106);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(66, 13);
            this.lbl_nome.TabIndex = 5;
            this.lbl_nome.Text = "nome del file";
            this.lbl_nome.Click += new System.EventHandler(this.lbl_nome_Click);
            // 
            // btn_crea
            // 
            this.btn_crea.Location = new System.Drawing.Point(364, 368);
            this.btn_crea.Name = "btn_crea";
            this.btn_crea.Size = new System.Drawing.Size(75, 23);
            this.btn_crea.TabIndex = 6;
            this.btn_crea.Text = "crea";
            this.btn_crea.UseVisualStyleBackColor = true;
            this.btn_crea.Click += new System.EventHandler(this.btn_crea_Click);
            // 
            // trc_volume
            // 
            this.trc_volume.Location = new System.Drawing.Point(92, 16);
            this.trc_volume.Maximum = 20;
            this.trc_volume.Name = "trc_volume";
            this.trc_volume.Size = new System.Drawing.Size(206, 45);
            this.trc_volume.TabIndex = 7;
            this.trc_volume.Scroll += new System.EventHandler(this.trc_volume_Scroll);
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Location = new System.Drawing.Point(6, 16);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(41, 13);
            this.lbl_volume.TabIndex = 8;
            this.lbl_volume.Text = "volume";
            this.lbl_volume.Click += new System.EventHandler(this.lbl_volume_Click);
            // 
            // pnl_volume
            // 
            this.pnl_volume.Controls.Add(this.lbl_volume);
            this.pnl_volume.Controls.Add(this.trc_volume);
            this.pnl_volume.Location = new System.Drawing.Point(248, 212);
            this.pnl_volume.Name = "pnl_volume";
            this.pnl_volume.Size = new System.Drawing.Size(305, 66);
            this.pnl_volume.TabIndex = 9;
            this.pnl_volume.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_volume_Paint);
            // 
            // pnl_luminosita
            // 
            this.pnl_luminosita.Controls.Add(this.lbl_luminosita);
            this.pnl_luminosita.Controls.Add(this.trc_luminosita);
            this.pnl_luminosita.Location = new System.Drawing.Point(248, 293);
            this.pnl_luminosita.Name = "pnl_luminosita";
            this.pnl_luminosita.Size = new System.Drawing.Size(305, 66);
            this.pnl_luminosita.TabIndex = 10;
            this.pnl_luminosita.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_luminosita_Paint);
            // 
            // lbl_luminosita
            // 
            this.lbl_luminosita.AutoSize = true;
            this.lbl_luminosita.Location = new System.Drawing.Point(6, 16);
            this.lbl_luminosita.Name = "lbl_luminosita";
            this.lbl_luminosita.Size = new System.Drawing.Size(53, 13);
            this.lbl_luminosita.TabIndex = 8;
            this.lbl_luminosita.Text = "luminosità";
            this.lbl_luminosita.Click += new System.EventHandler(this.lbl_luminosita_Click);
            // 
            // trc_luminosita
            // 
            this.trc_luminosita.Location = new System.Drawing.Point(92, 16);
            this.trc_luminosita.Name = "trc_luminosita";
            this.trc_luminosita.Size = new System.Drawing.Size(206, 45);
            this.trc_luminosita.TabIndex = 7;
            this.trc_luminosita.Scroll += new System.EventHandler(this.trc_luminosita_Scroll);
            // 
            // lbl_numerazioneElemento
            // 
            this.lbl_numerazioneElemento.AutoSize = true;
            this.lbl_numerazioneElemento.Location = new System.Drawing.Point(361, 81);
            this.lbl_numerazioneElemento.Name = "lbl_numerazioneElemento";
            this.lbl_numerazioneElemento.Size = new System.Drawing.Size(66, 13);
            this.lbl_numerazioneElemento.TabIndex = 11;
            this.lbl_numerazioneElemento.Text = "nome del file";
            this.lbl_numerazioneElemento.Click += new System.EventHandler(this.lbl_numerazioneElemento_Click);
            // 
            // lbl_durata
            // 
            this.lbl_durata.AutoSize = true;
            this.lbl_durata.Location = new System.Drawing.Point(90, 9);
            this.lbl_durata.Name = "lbl_durata";
            this.lbl_durata.Size = new System.Drawing.Size(37, 13);
            this.lbl_durata.TabIndex = 13;
            this.lbl_durata.Text = "durata";
            this.lbl_durata.Click += new System.EventHandler(this.lbl_durata_Click);
            // 
            // nmr_durata
            // 
            this.nmr_durata.Location = new System.Drawing.Point(48, 25);
            this.nmr_durata.Name = "nmr_durata";
            this.nmr_durata.Size = new System.Drawing.Size(120, 20);
            this.nmr_durata.TabIndex = 14;
            this.nmr_durata.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmr_durata.ValueChanged += new System.EventHandler(this.nmr_durata_ValueChanged);
            // 
            // pnl_durata
            // 
            this.pnl_durata.Controls.Add(this.lbl_durata);
            this.pnl_durata.Controls.Add(this.nmr_durata);
            this.pnl_durata.Location = new System.Drawing.Point(291, 149);
            this.pnl_durata.Name = "pnl_durata";
            this.pnl_durata.Size = new System.Drawing.Size(219, 57);
            this.pnl_durata.TabIndex = 2;
            this.pnl_durata.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_durata_Paint);
            // 
            // pnl_funzionalita
            // 
            this.pnl_funzionalita.Controls.Add(this.lbl_ordinato);
            this.pnl_funzionalita.Controls.Add(this.btn_esci);
            this.pnl_funzionalita.Controls.Add(this.btn_VerificaUgualianza);
            this.pnl_funzionalita.Controls.Add(this.btn_ordina);
            this.pnl_funzionalita.Controls.Add(this.btn_inferiori);
            this.pnl_funzionalita.Controls.Add(this.btn_regola);
            this.pnl_funzionalita.Controls.Add(this.btn_esegui);
            this.pnl_funzionalita.Location = new System.Drawing.Point(89, 97);
            this.pnl_funzionalita.Name = "pnl_funzionalita";
            this.pnl_funzionalita.Size = new System.Drawing.Size(623, 347);
            this.pnl_funzionalita.TabIndex = 12;
            this.pnl_funzionalita.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_funzionalita_Paint);
            // 
            // btn_esegui
            // 
            this.btn_esegui.Location = new System.Drawing.Point(45, 61);
            this.btn_esegui.Name = "btn_esegui";
            this.btn_esegui.Size = new System.Drawing.Size(156, 67);
            this.btn_esegui.TabIndex = 0;
            this.btn_esegui.Text = "esegui";
            this.btn_esegui.UseVisualStyleBackColor = true;
            this.btn_esegui.Click += new System.EventHandler(this.btn_esegui_Click);
            // 
            // btn_regola
            // 
            this.btn_regola.Location = new System.Drawing.Point(45, 219);
            this.btn_regola.Name = "btn_regola";
            this.btn_regola.Size = new System.Drawing.Size(156, 67);
            this.btn_regola.TabIndex = 1;
            this.btn_regola.Text = "regola parametri";
            this.btn_regola.UseVisualStyleBackColor = true;
            this.btn_regola.Click += new System.EventHandler(this.btn_regola_Click);
            // 
            // btn_inferiori
            // 
            this.btn_inferiori.Location = new System.Drawing.Point(233, 61);
            this.btn_inferiori.Name = "btn_inferiori";
            this.btn_inferiori.Size = new System.Drawing.Size(156, 67);
            this.btn_inferiori.TabIndex = 2;
            this.btn_inferiori.Text = "film con durata inferiore";
            this.btn_inferiori.UseVisualStyleBackColor = true;
            this.btn_inferiori.Click += new System.EventHandler(this.btn_inferiori_Click);
            // 
            // btn_ordina
            // 
            this.btn_ordina.Location = new System.Drawing.Point(233, 219);
            this.btn_ordina.Name = "btn_ordina";
            this.btn_ordina.Size = new System.Drawing.Size(156, 67);
            this.btn_ordina.TabIndex = 3;
            this.btn_ordina.Text = "ordina per titolo";
            this.btn_ordina.UseVisualStyleBackColor = true;
            this.btn_ordina.Click += new System.EventHandler(this.btn_ordina_Click);
            // 
            // btn_VerificaUgualianza
            // 
            this.btn_VerificaUgualianza.Location = new System.Drawing.Point(422, 61);
            this.btn_VerificaUgualianza.Name = "btn_VerificaUgualianza";
            this.btn_VerificaUgualianza.Size = new System.Drawing.Size(156, 67);
            this.btn_VerificaUgualianza.TabIndex = 4;
            this.btn_VerificaUgualianza.Text = "verifica ugualianza";
            this.btn_VerificaUgualianza.UseVisualStyleBackColor = true;
            this.btn_VerificaUgualianza.Click += new System.EventHandler(this.btn_VerificaUgualianza_Click);
            // 
            // btn_esci
            // 
            this.btn_esci.Location = new System.Drawing.Point(422, 219);
            this.btn_esci.Name = "btn_esci";
            this.btn_esci.Size = new System.Drawing.Size(156, 67);
            this.btn_esci.TabIndex = 5;
            this.btn_esci.Text = "esci";
            this.btn_esci.UseVisualStyleBackColor = true;
            this.btn_esci.Click += new System.EventHandler(this.btn_esci_Click);
            // 
            // lbl_ordinato
            // 
            this.lbl_ordinato.AutoSize = true;
            this.lbl_ordinato.Location = new System.Drawing.Point(294, 297);
            this.lbl_ordinato.Name = "lbl_ordinato";
            this.lbl_ordinato.Size = new System.Drawing.Size(0, 13);
            this.lbl_ordinato.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_funzionalita);
            this.Controls.Add(this.pnl_durata);
            this.Controls.Add(this.lbl_numerazioneElemento);
            this.Controls.Add(this.pnl_luminosita);
            this.Controls.Add(this.pnl_volume);
            this.Controls.Add(this.btn_crea);
            this.Controls.Add(this.lbl_nome);
            this.Controls.Add(this.lbl_scelta);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.cmb_scelta);
            this.Controls.Add(this.pnl_input);
            this.Controls.Add(this.lbl_titoloForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trc_volume)).EndInit();
            this.pnl_volume.ResumeLayout(false);
            this.pnl_volume.PerformLayout();
            this.pnl_luminosita.ResumeLayout(false);
            this.pnl_luminosita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trc_luminosita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmr_durata)).EndInit();
            this.pnl_durata.ResumeLayout(false);
            this.pnl_durata.PerformLayout();
            this.pnl_funzionalita.ResumeLayout(false);
            this.pnl_funzionalita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titoloForm;
        private System.Windows.Forms.Panel pnl_input;
        private System.Windows.Forms.ComboBox cmb_scelta;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_scelta;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.Button btn_crea;
        private System.Windows.Forms.TrackBar trc_volume;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.Panel pnl_volume;
        private System.Windows.Forms.Panel pnl_luminosita;
        private System.Windows.Forms.Label lbl_luminosita;
        private System.Windows.Forms.TrackBar trc_luminosita;
        private System.Windows.Forms.Label lbl_numerazioneElemento;
        private System.Windows.Forms.Label lbl_durata;
        private System.Windows.Forms.NumericUpDown nmr_durata;
        private System.Windows.Forms.Panel pnl_durata;
        private System.Windows.Forms.Panel pnl_funzionalita;
        private System.Windows.Forms.Button btn_esci;
        private System.Windows.Forms.Button btn_VerificaUgualianza;
        private System.Windows.Forms.Button btn_ordina;
        private System.Windows.Forms.Button btn_inferiori;
        private System.Windows.Forms.Button btn_regola;
        private System.Windows.Forms.Button btn_esegui;
        private System.Windows.Forms.Label lbl_ordinato;
    }
}


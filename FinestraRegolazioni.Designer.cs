namespace SacchieroElementoMultimediale
{
    partial class FinestraRegolazioni
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_regola = new System.Windows.Forms.Button();
            this.lbl_scelta = new System.Windows.Forms.Label();
            this.cmb_scelta = new System.Windows.Forms.ComboBox();
            this.lbl_titoloForm = new System.Windows.Forms.Label();
            this.pnl_luminosita = new System.Windows.Forms.Panel();
            this.lbl_luminosita = new System.Windows.Forms.Label();
            this.trc_luminosita = new System.Windows.Forms.TrackBar();
            this.pnl_volume = new System.Windows.Forms.Panel();
            this.lbl_volume = new System.Windows.Forms.Label();
            this.trc_volume = new System.Windows.Forms.TrackBar();
            this.pnl_luminosita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trc_luminosita)).BeginInit();
            this.pnl_volume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trc_volume)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_regola
            // 
            this.btn_regola.Location = new System.Drawing.Point(363, 334);
            this.btn_regola.Name = "btn_regola";
            this.btn_regola.Size = new System.Drawing.Size(75, 23);
            this.btn_regola.TabIndex = 9;
            this.btn_regola.Text = "regola";
            this.btn_regola.UseVisualStyleBackColor = true;
            this.btn_regola.Click += new System.EventHandler(this.btn_regola_Click);
            // 
            // lbl_scelta
            // 
            this.lbl_scelta.AutoSize = true;
            this.lbl_scelta.Location = new System.Drawing.Point(357, 74);
            this.lbl_scelta.Name = "lbl_scelta";
            this.lbl_scelta.Size = new System.Drawing.Size(95, 13);
            this.lbl_scelta.TabIndex = 8;
            this.lbl_scelta.Text = "scegliere elemento";
            this.lbl_scelta.Click += new System.EventHandler(this.lbl_scelta_Click_1);
            // 
            // cmb_scelta
            // 
            this.cmb_scelta.FormattingEnabled = true;
            this.cmb_scelta.Location = new System.Drawing.Point(340, 97);
            this.cmb_scelta.Name = "cmb_scelta";
            this.cmb_scelta.Size = new System.Drawing.Size(121, 21);
            this.cmb_scelta.TabIndex = 7;
            this.cmb_scelta.SelectedIndexChanged += new System.EventHandler(this.cmb_scelta_SelectedIndexChanged_1);
            // 
            // lbl_titoloForm
            // 
            this.lbl_titoloForm.AutoSize = true;
            this.lbl_titoloForm.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titoloForm.Location = new System.Drawing.Point(338, 29);
            this.lbl_titoloForm.Name = "lbl_titoloForm";
            this.lbl_titoloForm.Size = new System.Drawing.Size(148, 19);
            this.lbl_titoloForm.TabIndex = 6;
            this.lbl_titoloForm.Text = "Finestra Regolazione";
            // 
            // pnl_luminosita
            // 
            this.pnl_luminosita.Controls.Add(this.lbl_luminosita);
            this.pnl_luminosita.Controls.Add(this.trc_luminosita);
            this.pnl_luminosita.Location = new System.Drawing.Point(248, 233);
            this.pnl_luminosita.Name = "pnl_luminosita";
            this.pnl_luminosita.Size = new System.Drawing.Size(305, 66);
            this.pnl_luminosita.TabIndex = 12;
            // 
            // lbl_luminosita
            // 
            this.lbl_luminosita.AutoSize = true;
            this.lbl_luminosita.Location = new System.Drawing.Point(6, 16);
            this.lbl_luminosita.Name = "lbl_luminosita";
            this.lbl_luminosita.Size = new System.Drawing.Size(53, 13);
            this.lbl_luminosita.TabIndex = 8;
            this.lbl_luminosita.Text = "luminosità";
            // 
            // trc_luminosita
            // 
            this.trc_luminosita.Location = new System.Drawing.Point(92, 16);
            this.trc_luminosita.Name = "trc_luminosita";
            this.trc_luminosita.Size = new System.Drawing.Size(206, 45);
            this.trc_luminosita.TabIndex = 7;
            // 
            // pnl_volume
            // 
            this.pnl_volume.Controls.Add(this.lbl_volume);
            this.pnl_volume.Controls.Add(this.trc_volume);
            this.pnl_volume.Location = new System.Drawing.Point(248, 152);
            this.pnl_volume.Name = "pnl_volume";
            this.pnl_volume.Size = new System.Drawing.Size(305, 66);
            this.pnl_volume.TabIndex = 11;
            // 
            // lbl_volume
            // 
            this.lbl_volume.AutoSize = true;
            this.lbl_volume.Location = new System.Drawing.Point(6, 16);
            this.lbl_volume.Name = "lbl_volume";
            this.lbl_volume.Size = new System.Drawing.Size(41, 13);
            this.lbl_volume.TabIndex = 8;
            this.lbl_volume.Text = "volume";
            // 
            // trc_volume
            // 
            this.trc_volume.Location = new System.Drawing.Point(92, 16);
            this.trc_volume.Maximum = 20;
            this.trc_volume.Name = "trc_volume";
            this.trc_volume.Size = new System.Drawing.Size(206, 45);
            this.trc_volume.TabIndex = 7;
            // 
            // FinestraRegolazioni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_luminosita);
            this.Controls.Add(this.pnl_volume);
            this.Controls.Add(this.btn_regola);
            this.Controls.Add(this.lbl_scelta);
            this.Controls.Add(this.cmb_scelta);
            this.Controls.Add(this.lbl_titoloForm);
            this.Name = "FinestraRegolazioni";
            this.Text = "FinestraRegolazioni";
            this.Load += new System.EventHandler(this.FinestraRegolazioni_Load);
            this.pnl_luminosita.ResumeLayout(false);
            this.pnl_luminosita.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trc_luminosita)).EndInit();
            this.pnl_volume.ResumeLayout(false);
            this.pnl_volume.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trc_volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_regola;
        private System.Windows.Forms.Label lbl_scelta;
        private System.Windows.Forms.ComboBox cmb_scelta;
        private System.Windows.Forms.Label lbl_titoloForm;
        private System.Windows.Forms.Panel pnl_luminosita;
        private System.Windows.Forms.Label lbl_luminosita;
        private System.Windows.Forms.TrackBar trc_luminosita;
        private System.Windows.Forms.Panel pnl_volume;
        private System.Windows.Forms.Label lbl_volume;
        private System.Windows.Forms.TrackBar trc_volume;
    }
}
namespace SacchieroElementoMultimediale
{
    partial class FinestraVerificaUgualianza
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
            this.btn_controlla = new System.Windows.Forms.Button();
            this.lbl_scelta1 = new System.Windows.Forms.Label();
            this.cmb_scelta1 = new System.Windows.Forms.ComboBox();
            this.lbl_titoloForm = new System.Windows.Forms.Label();
            this.lbl_scelta2 = new System.Windows.Forms.Label();
            this.cmb_scelta2 = new System.Windows.Forms.ComboBox();
            this.lbl_risposta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_controlla
            // 
            this.btn_controlla.Location = new System.Drawing.Point(363, 178);
            this.btn_controlla.Name = "btn_controlla";
            this.btn_controlla.Size = new System.Drawing.Size(75, 23);
            this.btn_controlla.TabIndex = 14;
            this.btn_controlla.Text = "esegui";
            this.btn_controlla.UseVisualStyleBackColor = true;
            this.btn_controlla.Click += new System.EventHandler(this.btn_controlla_Click);
            // 
            // lbl_scelta1
            // 
            this.lbl_scelta1.AutoSize = true;
            this.lbl_scelta1.Location = new System.Drawing.Point(234, 104);
            this.lbl_scelta1.Name = "lbl_scelta1";
            this.lbl_scelta1.Size = new System.Drawing.Size(104, 13);
            this.lbl_scelta1.TabIndex = 13;
            this.lbl_scelta1.Text = "scegliere elemento 1";
            // 
            // cmb_scelta1
            // 
            this.cmb_scelta1.FormattingEnabled = true;
            this.cmb_scelta1.Location = new System.Drawing.Point(226, 127);
            this.cmb_scelta1.Name = "cmb_scelta1";
            this.cmb_scelta1.Size = new System.Drawing.Size(121, 21);
            this.cmb_scelta1.TabIndex = 12;
            // 
            // lbl_titoloForm
            // 
            this.lbl_titoloForm.AutoSize = true;
            this.lbl_titoloForm.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titoloForm.Location = new System.Drawing.Point(303, 29);
            this.lbl_titoloForm.Name = "lbl_titoloForm";
            this.lbl_titoloForm.Size = new System.Drawing.Size(194, 19);
            this.lbl_titoloForm.TabIndex = 11;
            this.lbl_titoloForm.Text = "Finestra Verifica Ugualianza";
            // 
            // lbl_scelta2
            // 
            this.lbl_scelta2.AutoSize = true;
            this.lbl_scelta2.Location = new System.Drawing.Point(461, 104);
            this.lbl_scelta2.Name = "lbl_scelta2";
            this.lbl_scelta2.Size = new System.Drawing.Size(104, 13);
            this.lbl_scelta2.TabIndex = 16;
            this.lbl_scelta2.Text = "scegliere elemento 2";
            // 
            // cmb_scelta2
            // 
            this.cmb_scelta2.FormattingEnabled = true;
            this.cmb_scelta2.Location = new System.Drawing.Point(453, 127);
            this.cmb_scelta2.Name = "cmb_scelta2";
            this.cmb_scelta2.Size = new System.Drawing.Size(121, 21);
            this.cmb_scelta2.TabIndex = 15;
            // 
            // lbl_risposta
            // 
            this.lbl_risposta.AutoSize = true;
            this.lbl_risposta.Location = new System.Drawing.Point(383, 246);
            this.lbl_risposta.Name = "lbl_risposta";
            this.lbl_risposta.Size = new System.Drawing.Size(0, 13);
            this.lbl_risposta.TabIndex = 17;
            // 
            // FinestraVerificaUgualianza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_risposta);
            this.Controls.Add(this.lbl_scelta2);
            this.Controls.Add(this.cmb_scelta2);
            this.Controls.Add(this.btn_controlla);
            this.Controls.Add(this.lbl_scelta1);
            this.Controls.Add(this.cmb_scelta1);
            this.Controls.Add(this.lbl_titoloForm);
            this.Name = "FinestraVerificaUgualianza";
            this.Text = "FinestraVerificaUgualianza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_controlla;
        private System.Windows.Forms.Label lbl_scelta1;
        private System.Windows.Forms.ComboBox cmb_scelta1;
        private System.Windows.Forms.Label lbl_titoloForm;
        private System.Windows.Forms.Label lbl_scelta2;
        private System.Windows.Forms.ComboBox cmb_scelta2;
        private System.Windows.Forms.Label lbl_risposta;
    }
}
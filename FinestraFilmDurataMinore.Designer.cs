namespace SacchieroElementoMultimediale
{
    partial class FinestraFilmDurataMinore
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
            this.txt_esecuzione = new System.Windows.Forms.TextBox();
            this.btn_visualizza = new System.Windows.Forms.Button();
            this.lbl_scelta = new System.Windows.Forms.Label();
            this.cmb_scelta = new System.Windows.Forms.ComboBox();
            this.lbl_titoloForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_esecuzione
            // 
            this.txt_esecuzione.Location = new System.Drawing.Point(218, 71);
            this.txt_esecuzione.Multiline = true;
            this.txt_esecuzione.Name = "txt_esecuzione";
            this.txt_esecuzione.Size = new System.Drawing.Size(532, 350);
            this.txt_esecuzione.TabIndex = 10;
            // 
            // btn_visualizza
            // 
            this.btn_visualizza.Location = new System.Drawing.Point(77, 124);
            this.btn_visualizza.Name = "btn_visualizza";
            this.btn_visualizza.Size = new System.Drawing.Size(75, 23);
            this.btn_visualizza.TabIndex = 9;
            this.btn_visualizza.Text = "esegui";
            this.btn_visualizza.UseVisualStyleBackColor = true;
            this.btn_visualizza.Click += new System.EventHandler(this.btn_visualizza_Click);
            // 
            // lbl_scelta
            // 
            this.lbl_scelta.AutoSize = true;
            this.lbl_scelta.Location = new System.Drawing.Point(67, 74);
            this.lbl_scelta.Name = "lbl_scelta";
            this.lbl_scelta.Size = new System.Drawing.Size(95, 13);
            this.lbl_scelta.TabIndex = 8;
            this.lbl_scelta.Text = "scegliere elemento";
            // 
            // cmb_scelta
            // 
            this.cmb_scelta.FormattingEnabled = true;
            this.cmb_scelta.Location = new System.Drawing.Point(50, 97);
            this.cmb_scelta.Name = "cmb_scelta";
            this.cmb_scelta.Size = new System.Drawing.Size(121, 21);
            this.cmb_scelta.TabIndex = 7;
            // 
            // lbl_titoloForm
            // 
            this.lbl_titoloForm.AutoSize = true;
            this.lbl_titoloForm.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titoloForm.Location = new System.Drawing.Point(338, 29);
            this.lbl_titoloForm.Name = "lbl_titoloForm";
            this.lbl_titoloForm.Size = new System.Drawing.Size(194, 19);
            this.lbl_titoloForm.TabIndex = 6;
            this.lbl_titoloForm.Text = "Finestra Film Durata Minore";
            // 
            // FinestraFilmDurataMinore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_esecuzione);
            this.Controls.Add(this.btn_visualizza);
            this.Controls.Add(this.lbl_scelta);
            this.Controls.Add(this.cmb_scelta);
            this.Controls.Add(this.lbl_titoloForm);
            this.Name = "FinestraFilmDurataMinore";
            this.Text = "FinestraFilmDurataMinore";
            this.Load += new System.EventHandler(this.FinestraFilmDurataMinore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_esecuzione;
        private System.Windows.Forms.Button btn_visualizza;
        private System.Windows.Forms.Label lbl_scelta;
        private System.Windows.Forms.ComboBox cmb_scelta;
        private System.Windows.Forms.Label lbl_titoloForm;
    }
}
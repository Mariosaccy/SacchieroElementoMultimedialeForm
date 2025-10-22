namespace SacchieroElementoMultimediale
{
    partial class FinestraEsegui
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
            this.cmb_scelta = new System.Windows.Forms.ComboBox();
            this.lbl_scelta = new System.Windows.Forms.Label();
            this.btn_esegui = new System.Windows.Forms.Button();
            this.lbl_titoloForm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_esecuzione
            // 
            this.txt_esecuzione.Location = new System.Drawing.Point(212, 85);
            this.txt_esecuzione.Multiline = true;
            this.txt_esecuzione.Name = "txt_esecuzione";
            this.txt_esecuzione.Size = new System.Drawing.Size(532, 350);
            this.txt_esecuzione.TabIndex = 5;
            this.txt_esecuzione.TextChanged += new System.EventHandler(this.txt_esecuzione_TextChanged);
            // 
            // cmb_scelta
            // 
            this.cmb_scelta.FormattingEnabled = true;
            this.cmb_scelta.Location = new System.Drawing.Point(44, 111);
            this.cmb_scelta.Name = "cmb_scelta";
            this.cmb_scelta.Size = new System.Drawing.Size(121, 21);
            this.cmb_scelta.TabIndex = 2;
            this.cmb_scelta.SelectedIndexChanged += new System.EventHandler(this.cmb_scelta_SelectedIndexChanged);
            // 
            // lbl_scelta
            // 
            this.lbl_scelta.AutoSize = true;
            this.lbl_scelta.Location = new System.Drawing.Point(61, 88);
            this.lbl_scelta.Name = "lbl_scelta";
            this.lbl_scelta.Size = new System.Drawing.Size(95, 13);
            this.lbl_scelta.TabIndex = 3;
            this.lbl_scelta.Text = "scegliere elemento";
            this.lbl_scelta.Click += new System.EventHandler(this.lbl_scelta_Click);
            // 
            // btn_esegui
            // 
            this.btn_esegui.Location = new System.Drawing.Point(71, 138);
            this.btn_esegui.Name = "btn_esegui";
            this.btn_esegui.Size = new System.Drawing.Size(75, 23);
            this.btn_esegui.TabIndex = 4;
            this.btn_esegui.Text = "esegui";
            this.btn_esegui.UseVisualStyleBackColor = true;
            this.btn_esegui.Click += new System.EventHandler(this.btn_esegui_Click);
            // 
            // lbl_titoloForm
            // 
            this.lbl_titoloForm.AutoSize = true;
            this.lbl_titoloForm.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titoloForm.Location = new System.Drawing.Point(332, 43);
            this.lbl_titoloForm.Name = "lbl_titoloForm";
            this.lbl_titoloForm.Size = new System.Drawing.Size(137, 19);
            this.lbl_titoloForm.TabIndex = 1;
            this.lbl_titoloForm.Text = "Finestra Esecuzione";
            this.lbl_titoloForm.Click += new System.EventHandler(this.lbl_titoloForm_Click);
            // 
            // FinestraEsegui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_esecuzione);
            this.Controls.Add(this.btn_esegui);
            this.Controls.Add(this.lbl_scelta);
            this.Controls.Add(this.cmb_scelta);
            this.Controls.Add(this.lbl_titoloForm);
            this.Name = "FinestraEsegui";
            this.Text = "FinestraEsegui";
            this.Load += new System.EventHandler(this.FinestraEsegui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_esecuzione;
        private System.Windows.Forms.ComboBox cmb_scelta;
        private System.Windows.Forms.Label lbl_scelta;
        private System.Windows.Forms.Button btn_esegui;
        private System.Windows.Forms.Label lbl_titoloForm;
    }
}
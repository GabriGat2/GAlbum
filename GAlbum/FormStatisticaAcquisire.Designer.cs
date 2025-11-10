namespace GAlbum
{
    partial class FormStatisticaAcquisire
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumeroFileValore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumeroFileAssegnati = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero file: ";
            // 
            // labelNumeroFileValore
            // 
            this.labelNumeroFileValore.AutoSize = true;
            this.labelNumeroFileValore.Location = new System.Drawing.Point(109, 34);
            this.labelNumeroFileValore.Name = "labelNumeroFileValore";
            this.labelNumeroFileValore.Size = new System.Drawing.Size(35, 13);
            this.labelNumeroFileValore.TabIndex = 2;
            this.labelNumeroFileValore.Text = "XXXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero file assegnati: ";
            // 
            // NumeroFileAssegnati
            // 
            this.NumeroFileAssegnati.AutoSize = true;
            this.NumeroFileAssegnati.Location = new System.Drawing.Point(156, 61);
            this.NumeroFileAssegnati.Name = "NumeroFileAssegnati";
            this.NumeroFileAssegnati.Size = new System.Drawing.Size(35, 13);
            this.NumeroFileAssegnati.TabIndex = 4;
            this.NumeroFileAssegnati.Text = "XXXX";
            // 
            // FormStatisticaAcquisire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumeroFileAssegnati);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelNumeroFileValore);
            this.Controls.Add(this.label1);
            this.Name = "FormStatisticaAcquisire";
            this.Text = "Esito operazione assegna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumeroFileValore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NumeroFileAssegnati;
    }
} // fine namespace GAlbum
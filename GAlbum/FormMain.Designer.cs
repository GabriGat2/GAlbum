namespace GAlbum
{
    partial class FormMain
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
            this.butSelezione = new System.Windows.Forms.Button();
            this.ButSelezioneFoto = new System.Windows.Forms.Button();
            this.butAreaArchivio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butSelezione
            // 
            this.butSelezione.Location = new System.Drawing.Point(691, 139);
            this.butSelezione.Name = "butSelezione";
            this.butSelezione.Size = new System.Drawing.Size(75, 23);
            this.butSelezione.TabIndex = 0;
            this.butSelezione.Text = "Selezione";
            this.butSelezione.UseVisualStyleBackColor = true;
            this.butSelezione.Click += new System.EventHandler(this.butSelezione_Click);
            // 
            // ButSelezioneFoto
            // 
            this.ButSelezioneFoto.Location = new System.Drawing.Point(31, 104);
            this.ButSelezioneFoto.Name = "ButSelezioneFoto";
            this.ButSelezioneFoto.Size = new System.Drawing.Size(103, 23);
            this.ButSelezioneFoto.TabIndex = 1;
            this.ButSelezioneFoto.Text = "Selezione Foto";
            this.ButSelezioneFoto.UseVisualStyleBackColor = true;
            this.ButSelezioneFoto.Click += new System.EventHandler(this.ButSelezioneFoto_Click);
            // 
            // butAreaArchivio
            // 
            this.butAreaArchivio.Location = new System.Drawing.Point(31, 61);
            this.butAreaArchivio.Name = "butAreaArchivio";
            this.butAreaArchivio.Size = new System.Drawing.Size(103, 23);
            this.butAreaArchivio.TabIndex = 2;
            this.butAreaArchivio.Text = "AreaArchivio";
            this.butAreaArchivio.UseVisualStyleBackColor = true;
            this.butAreaArchivio.Click += new System.EventHandler(this.butAreaArchivio_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butAreaArchivio);
            this.Controls.Add(this.ButSelezioneFoto);
            this.Controls.Add(this.butSelezione);
            this.Name = "FormMain";
            this.Text = "GAlbum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butSelezione;
        private System.Windows.Forms.Button ButSelezioneFoto;
        private System.Windows.Forms.Button butAreaArchivio;
    }
}


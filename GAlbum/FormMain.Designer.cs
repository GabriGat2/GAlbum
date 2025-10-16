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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxAreaArchivio = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAreaArchivioBase = new System.Windows.Forms.TextBox();
            this.textBoxPathAreaArchivioBase = new System.Windows.Forms.TextBox();
            this.splitContainer1A2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxArchivioBase = new System.Windows.Forms.GroupBox();
            this.groupBoxArchivioAttivo = new System.Windows.Forms.GroupBox();
            this.textBoxPathArchivioAttivo = new System.Windows.Forms.TextBox();
            this.textBoxArchivioAttivo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxOperazioni = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxAreaArchivio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1A2)).BeginInit();
            this.splitContainer1A2.Panel1.SuspendLayout();
            this.splitContainer1A2.Panel2.SuspendLayout();
            this.splitContainer1A2.SuspendLayout();
            this.groupBoxArchivioBase.SuspendLayout();
            this.groupBoxArchivioAttivo.SuspendLayout();
            this.groupBoxOperazioni.SuspendLayout();
            this.SuspendLayout();
            // 
            // butSelezione
            // 
            this.butSelezione.Location = new System.Drawing.Point(10, 32);
            this.butSelezione.Name = "butSelezione";
            this.butSelezione.Size = new System.Drawing.Size(75, 23);
            this.butSelezione.TabIndex = 0;
            this.butSelezione.Text = "Selezione";
            this.butSelezione.UseVisualStyleBackColor = true;
            this.butSelezione.Click += new System.EventHandler(this.butSelezione_Click);
            // 
            // ButSelezioneFoto
            // 
            this.ButSelezioneFoto.Location = new System.Drawing.Point(12, 61);
            this.ButSelezioneFoto.Name = "ButSelezioneFoto";
            this.ButSelezioneFoto.Size = new System.Drawing.Size(103, 23);
            this.ButSelezioneFoto.TabIndex = 1;
            this.ButSelezioneFoto.Text = "Selezione Foto";
            this.ButSelezioneFoto.UseVisualStyleBackColor = true;
            this.ButSelezioneFoto.Click += new System.EventHandler(this.ButSelezioneFoto_Click);
            // 
            // butAreaArchivio
            // 
            this.butAreaArchivio.Location = new System.Drawing.Point(6, 98);
            this.butAreaArchivio.Name = "butAreaArchivio";
            this.butAreaArchivio.Size = new System.Drawing.Size(103, 23);
            this.butAreaArchivio.TabIndex = 2;
            this.butAreaArchivio.Text = "Modifica Archivio";
            this.butAreaArchivio.UseVisualStyleBackColor = true;
            this.butAreaArchivio.Click += new System.EventHandler(this.butAreaArchivio_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxAreaArchivio);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxOperazioni);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 3;
            // 
            // groupBoxAreaArchivio
            // 
            this.groupBoxAreaArchivio.Controls.Add(this.splitContainer1A2);
            this.groupBoxAreaArchivio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAreaArchivio.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAreaArchivio.Name = "groupBoxAreaArchivio";
            this.groupBoxAreaArchivio.Size = new System.Drawing.Size(800, 250);
            this.groupBoxAreaArchivio.TabIndex = 0;
            this.groupBoxAreaArchivio.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Path Archivio Base";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Archivio Base";
            // 
            // textBoxAreaArchivioBase
            // 
            this.textBoxAreaArchivioBase.Location = new System.Drawing.Point(121, 19);
            this.textBoxAreaArchivioBase.Name = "textBoxAreaArchivioBase";
            this.textBoxAreaArchivioBase.ReadOnly = true;
            this.textBoxAreaArchivioBase.Size = new System.Drawing.Size(664, 20);
            this.textBoxAreaArchivioBase.TabIndex = 11;
            // 
            // textBoxPathAreaArchivioBase
            // 
            this.textBoxPathAreaArchivioBase.Location = new System.Drawing.Point(121, 54);
            this.textBoxPathAreaArchivioBase.Name = "textBoxPathAreaArchivioBase";
            this.textBoxPathAreaArchivioBase.ReadOnly = true;
            this.textBoxPathAreaArchivioBase.Size = new System.Drawing.Size(664, 20);
            this.textBoxPathAreaArchivioBase.TabIndex = 14;
            // 
            // splitContainer1A2
            // 
            this.splitContainer1A2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1A2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer1A2.Name = "splitContainer1A2";
            this.splitContainer1A2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1A2.Panel1
            // 
            this.splitContainer1A2.Panel1.Controls.Add(this.groupBoxArchivioBase);
            // 
            // splitContainer1A2.Panel2
            // 
            this.splitContainer1A2.Panel2.Controls.Add(this.groupBoxArchivioAttivo);
            this.splitContainer1A2.Size = new System.Drawing.Size(794, 231);
            this.splitContainer1A2.SplitterDistance = 100;
            this.splitContainer1A2.TabIndex = 0;
            // 
            // groupBoxArchivioBase
            // 
            this.groupBoxArchivioBase.Controls.Add(this.textBoxPathAreaArchivioBase);
            this.groupBoxArchivioBase.Controls.Add(this.textBoxAreaArchivioBase);
            this.groupBoxArchivioBase.Controls.Add(this.label1);
            this.groupBoxArchivioBase.Controls.Add(this.label2);
            this.groupBoxArchivioBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxArchivioBase.Location = new System.Drawing.Point(0, 0);
            this.groupBoxArchivioBase.Name = "groupBoxArchivioBase";
            this.groupBoxArchivioBase.Size = new System.Drawing.Size(794, 100);
            this.groupBoxArchivioBase.TabIndex = 0;
            this.groupBoxArchivioBase.TabStop = false;
            this.groupBoxArchivioBase.Text = "Archivio base";
            // 
            // groupBoxArchivioAttivo
            // 
            this.groupBoxArchivioAttivo.Controls.Add(this.butAreaArchivio);
            this.groupBoxArchivioAttivo.Controls.Add(this.textBoxPathArchivioAttivo);
            this.groupBoxArchivioAttivo.Controls.Add(this.textBoxArchivioAttivo);
            this.groupBoxArchivioAttivo.Controls.Add(this.label3);
            this.groupBoxArchivioAttivo.Controls.Add(this.label4);
            this.groupBoxArchivioAttivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxArchivioAttivo.Location = new System.Drawing.Point(0, 0);
            this.groupBoxArchivioAttivo.Name = "groupBoxArchivioAttivo";
            this.groupBoxArchivioAttivo.Size = new System.Drawing.Size(794, 127);
            this.groupBoxArchivioAttivo.TabIndex = 0;
            this.groupBoxArchivioAttivo.TabStop = false;
            this.groupBoxArchivioAttivo.Text = "ArchivioAttivo";
            // 
            // textBoxPathArchivioAttivo
            // 
            this.textBoxPathArchivioAttivo.Location = new System.Drawing.Point(121, 59);
            this.textBoxPathArchivioAttivo.Name = "textBoxPathArchivioAttivo";
            this.textBoxPathArchivioAttivo.ReadOnly = true;
            this.textBoxPathArchivioAttivo.Size = new System.Drawing.Size(667, 20);
            this.textBoxPathArchivioAttivo.TabIndex = 18;
            // 
            // textBoxArchivioAttivo
            // 
            this.textBoxArchivioAttivo.Location = new System.Drawing.Point(121, 24);
            this.textBoxArchivioAttivo.Name = "textBoxArchivioAttivo";
            this.textBoxArchivioAttivo.ReadOnly = true;
            this.textBoxArchivioAttivo.Size = new System.Drawing.Size(667, 20);
            this.textBoxArchivioAttivo.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Archivio Attivo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Path Archivio Attivo";
            // 
            // groupBoxOperazioni
            // 
            this.groupBoxOperazioni.Controls.Add(this.ButSelezioneFoto);
            this.groupBoxOperazioni.Controls.Add(this.butSelezione);
            this.groupBoxOperazioni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOperazioni.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOperazioni.Name = "groupBoxOperazioni";
            this.groupBoxOperazioni.Size = new System.Drawing.Size(800, 196);
            this.groupBoxOperazioni.TabIndex = 2;
            this.groupBoxOperazioni.TabStop = false;
            this.groupBoxOperazioni.Text = "groupBoxOperazioni";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMain";
            this.Text = "GAlbum";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxAreaArchivio.ResumeLayout(false);
            this.splitContainer1A2.Panel1.ResumeLayout(false);
            this.splitContainer1A2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1A2)).EndInit();
            this.splitContainer1A2.ResumeLayout(false);
            this.groupBoxArchivioBase.ResumeLayout(false);
            this.groupBoxArchivioBase.PerformLayout();
            this.groupBoxArchivioAttivo.ResumeLayout(false);
            this.groupBoxArchivioAttivo.PerformLayout();
            this.groupBoxOperazioni.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butSelezione;
        private System.Windows.Forms.Button ButSelezioneFoto;
        private System.Windows.Forms.Button butAreaArchivio;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxAreaArchivio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAreaArchivioBase;
        private System.Windows.Forms.TextBox textBoxPathAreaArchivioBase;
        private System.Windows.Forms.SplitContainer splitContainer1A2;
        private System.Windows.Forms.GroupBox groupBoxArchivioBase;
        private System.Windows.Forms.GroupBox groupBoxArchivioAttivo;
        private System.Windows.Forms.TextBox textBoxPathArchivioAttivo;
        private System.Windows.Forms.TextBox textBoxArchivioAttivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxOperazioni;
    }
}


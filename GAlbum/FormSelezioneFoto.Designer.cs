namespace GAlbum
{
    partial class FormSelezioneFoto
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxDestinazione = new System.Windows.Forms.TextBox();
            this.butDestinazione = new System.Windows.Forms.Button();
            this.textBoxSorgente = new System.Windows.Forms.TextBox();
            this.butSorgente = new System.Windows.Forms.Button();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.splitContainer1B2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1B2B3 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butPrecedente = new System.Windows.Forms.Button();
            this.butSuccessiva = new System.Windows.Forms.Button();
            this.butApri = new System.Windows.Forms.Button();
            this.textBoxPathFoto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1B2)).BeginInit();
            this.splitContainer1B2.Panel2.SuspendLayout();
            this.splitContainer1B2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1B2B3)).BeginInit();
            this.splitContainer1B2B3.Panel1.SuspendLayout();
            this.splitContainer1B2B3.Panel2.SuspendLayout();
            this.splitContainer1B2B3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxPath);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer1B2);
            this.splitContainer1.Size = new System.Drawing.Size(890, 726);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBoxDestinazione
            // 
            this.textBoxDestinazione.Location = new System.Drawing.Point(106, 59);
            this.textBoxDestinazione.Name = "textBoxDestinazione";
            this.textBoxDestinazione.Size = new System.Drawing.Size(772, 20);
            this.textBoxDestinazione.TabIndex = 12;
            this.textBoxDestinazione.TextChanged += new System.EventHandler(this.textBoxDestinazione_TextChanged);
            // 
            // butDestinazione
            // 
            this.butDestinazione.Location = new System.Drawing.Point(10, 57);
            this.butDestinazione.Name = "butDestinazione";
            this.butDestinazione.Size = new System.Drawing.Size(75, 23);
            this.butDestinazione.TabIndex = 11;
            this.butDestinazione.Text = "Destinazione";
            this.butDestinazione.UseVisualStyleBackColor = true;
            this.butDestinazione.Click += new System.EventHandler(this.butDestinazione_Click);
            // 
            // textBoxSorgente
            // 
            this.textBoxSorgente.Location = new System.Drawing.Point(106, 29);
            this.textBoxSorgente.Name = "textBoxSorgente";
            this.textBoxSorgente.Size = new System.Drawing.Size(772, 20);
            this.textBoxSorgente.TabIndex = 10;
            // 
            // butSorgente
            // 
            this.butSorgente.Location = new System.Drawing.Point(10, 27);
            this.butSorgente.Name = "butSorgente";
            this.butSorgente.Size = new System.Drawing.Size(75, 23);
            this.butSorgente.TabIndex = 9;
            this.butSorgente.Text = "Sorgente";
            this.butSorgente.UseVisualStyleBackColor = true;
            this.butSorgente.Click += new System.EventHandler(this.butSorgente_Click);
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Controls.Add(this.textBoxSorgente);
            this.groupBoxPath.Controls.Add(this.textBoxDestinazione);
            this.groupBoxPath.Controls.Add(this.butSorgente);
            this.groupBoxPath.Controls.Add(this.butDestinazione);
            this.groupBoxPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPath.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(890, 90);
            this.groupBoxPath.TabIndex = 13;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Selezione di sorgente e destinazione";
            // 
            // splitContainer1B2
            // 
            this.splitContainer1B2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1B2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1B2.Name = "splitContainer1B2";
            // 
            // splitContainer1B2.Panel2
            // 
            this.splitContainer1B2.Panel2.Controls.Add(this.splitContainer1B2B3);
            this.splitContainer1B2.Size = new System.Drawing.Size(890, 632);
            this.splitContainer1B2.SplitterDistance = 296;
            this.splitContainer1B2.TabIndex = 0;
            // 
            // splitContainer1B2B3
            // 
            this.splitContainer1B2B3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1B2B3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1B2B3.Name = "splitContainer1B2B3";
            this.splitContainer1B2B3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1B2B3.Panel1
            // 
            this.splitContainer1B2B3.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1B2B3.Panel2
            // 
            this.splitContainer1B2B3.Panel2.Controls.Add(this.textBoxPathFoto);
            this.splitContainer1B2B3.Panel2.Controls.Add(this.butPrecedente);
            this.splitContainer1B2B3.Panel2.Controls.Add(this.butApri);
            this.splitContainer1B2B3.Panel2.Controls.Add(this.butSuccessiva);
            this.splitContainer1B2B3.Size = new System.Drawing.Size(590, 632);
            this.splitContainer1B2B3.SplitterDistance = 560;
            this.splitContainer1B2B3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 560);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // butPrecedente
            // 
            this.butPrecedente.Location = new System.Drawing.Point(239, 33);
            this.butPrecedente.Name = "butPrecedente";
            this.butPrecedente.Size = new System.Drawing.Size(75, 23);
            this.butPrecedente.TabIndex = 7;
            this.butPrecedente.Text = "Precedente";
            this.butPrecedente.UseVisualStyleBackColor = true;
            this.butPrecedente.Click += new System.EventHandler(this.butPrecedente_Click);
            // 
            // butSuccessiva
            // 
            this.butSuccessiva.Location = new System.Drawing.Point(158, 33);
            this.butSuccessiva.Name = "butSuccessiva";
            this.butSuccessiva.Size = new System.Drawing.Size(75, 23);
            this.butSuccessiva.TabIndex = 6;
            this.butSuccessiva.Text = "Successiva";
            this.butSuccessiva.UseVisualStyleBackColor = true;
            this.butSuccessiva.Click += new System.EventHandler(this.butSuccessiva_Click);
            // 
            // butApri
            // 
            this.butApri.Location = new System.Drawing.Point(12, 33);
            this.butApri.Name = "butApri";
            this.butApri.Size = new System.Drawing.Size(75, 23);
            this.butApri.TabIndex = 5;
            this.butApri.Text = "Apri";
            this.butApri.UseVisualStyleBackColor = true;
            this.butApri.Click += new System.EventHandler(this.butApri_Click);
            // 
            // textBoxPathFoto
            // 
            this.textBoxPathFoto.Location = new System.Drawing.Point(12, 7);
            this.textBoxPathFoto.Name = "textBoxPathFoto";
            this.textBoxPathFoto.Size = new System.Drawing.Size(575, 20);
            this.textBoxPathFoto.TabIndex = 8;
            // 
            // FormSelezioneFoto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 726);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormSelezioneFoto";
            this.Text = "FormSelezioneFoto";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.splitContainer1B2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1B2)).EndInit();
            this.splitContainer1B2.ResumeLayout(false);
            this.splitContainer1B2B3.Panel1.ResumeLayout(false);
            this.splitContainer1B2B3.Panel2.ResumeLayout(false);
            this.splitContainer1B2B3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1B2B3)).EndInit();
            this.splitContainer1B2B3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxDestinazione;
        private System.Windows.Forms.Button butDestinazione;
        private System.Windows.Forms.TextBox textBoxSorgente;
        private System.Windows.Forms.Button butSorgente;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.SplitContainer splitContainer1B2;
        private System.Windows.Forms.SplitContainer splitContainer1B2B3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butPrecedente;
        private System.Windows.Forms.Button butApri;
        private System.Windows.Forms.Button butSuccessiva;
        private System.Windows.Forms.TextBox textBoxPathFoto;
    }
}
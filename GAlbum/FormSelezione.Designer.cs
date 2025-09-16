namespace GAlbum
{
    partial class FormSelezione
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butApri = new System.Windows.Forms.Button();
            this.textBoxPathFoto = new System.Windows.Forms.TextBox();
            this.butSuccessiva = new System.Windows.Forms.Button();
            this.butPrecedente = new System.Windows.Forms.Button();
            this.butSorgente = new System.Windows.Forms.Button();
            this.textBoxSorgente = new System.Windows.Forms.TextBox();
            this.butDestinazione = new System.Windows.Forms.Button();
            this.textBoxDestinazione = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(303, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(575, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // butApri
            // 
            this.butApri.Location = new System.Drawing.Point(33, 92);
            this.butApri.Name = "butApri";
            this.butApri.Size = new System.Drawing.Size(75, 23);
            this.butApri.TabIndex = 1;
            this.butApri.Text = "Apri";
            this.butApri.UseVisualStyleBackColor = true;
            this.butApri.Click += new System.EventHandler(this.butApri_Click);
            // 
            // textBoxPathFoto
            // 
            this.textBoxPathFoto.Location = new System.Drawing.Point(303, 479);
            this.textBoxPathFoto.Name = "textBoxPathFoto";
            this.textBoxPathFoto.Size = new System.Drawing.Size(575, 20);
            this.textBoxPathFoto.TabIndex = 2;
            // 
            // butSuccessiva
            // 
            this.butSuccessiva.Location = new System.Drawing.Point(33, 121);
            this.butSuccessiva.Name = "butSuccessiva";
            this.butSuccessiva.Size = new System.Drawing.Size(75, 23);
            this.butSuccessiva.TabIndex = 3;
            this.butSuccessiva.Text = "Successiva";
            this.butSuccessiva.UseVisualStyleBackColor = true;
            this.butSuccessiva.Click += new System.EventHandler(this.butSuccessiva_Click);
            // 
            // butPrecedente
            // 
            this.butPrecedente.Location = new System.Drawing.Point(33, 150);
            this.butPrecedente.Name = "butPrecedente";
            this.butPrecedente.Size = new System.Drawing.Size(75, 23);
            this.butPrecedente.TabIndex = 4;
            this.butPrecedente.Text = "Precedente";
            this.butPrecedente.UseVisualStyleBackColor = true;
            this.butPrecedente.Click += new System.EventHandler(this.butPrecedente_Click);
            // 
            // butSorgente
            // 
            this.butSorgente.Location = new System.Drawing.Point(33, 12);
            this.butSorgente.Name = "butSorgente";
            this.butSorgente.Size = new System.Drawing.Size(75, 23);
            this.butSorgente.TabIndex = 5;
            this.butSorgente.Text = "Sorgente";
            this.butSorgente.UseVisualStyleBackColor = true;
            this.butSorgente.Click += new System.EventHandler(this.butSorgente_Click);
            // 
            // textBoxSorgente
            // 
            this.textBoxSorgente.Location = new System.Drawing.Point(129, 14);
            this.textBoxSorgente.Name = "textBoxSorgente";
            this.textBoxSorgente.Size = new System.Drawing.Size(749, 20);
            this.textBoxSorgente.TabIndex = 6;
            // 
            // butDestinazione
            // 
            this.butDestinazione.Location = new System.Drawing.Point(33, 42);
            this.butDestinazione.Name = "butDestinazione";
            this.butDestinazione.Size = new System.Drawing.Size(75, 23);
            this.butDestinazione.TabIndex = 7;
            this.butDestinazione.Text = "Destinazione";
            this.butDestinazione.UseVisualStyleBackColor = true;
            this.butDestinazione.Click += new System.EventHandler(this.butDestinazione_Click);
            // 
            // textBoxDestinazione
            // 
            this.textBoxDestinazione.Location = new System.Drawing.Point(129, 44);
            this.textBoxDestinazione.Name = "textBoxDestinazione";
            this.textBoxDestinazione.Size = new System.Drawing.Size(749, 20);
            this.textBoxDestinazione.TabIndex = 8;
            this.textBoxDestinazione.TextChanged += new System.EventHandler(this.textBoxDestinazione_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(33, 231);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Cose";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(33, 268);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(64, 17);
            this.checkBox2.TabIndex = 10;
            this.checkBox2.Text = "Famiglia";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(33, 309);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(45, 17);
            this.checkBox3.TabIndex = 11;
            this.checkBox3.Text = "Libri";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(33, 347);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(85, 17);
            this.checkBox4.TabIndex = 12;
            this.checkBox4.Text = "Parcheggiati";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // FormSelezione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 726);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxDestinazione);
            this.Controls.Add(this.butDestinazione);
            this.Controls.Add(this.textBoxSorgente);
            this.Controls.Add(this.butSorgente);
            this.Controls.Add(this.butPrecedente);
            this.Controls.Add(this.butSuccessiva);
            this.Controls.Add(this.textBoxPathFoto);
            this.Controls.Add(this.butApri);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSelezione";
            this.Text = "FormSelezione";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butApri;
        private System.Windows.Forms.TextBox textBoxPathFoto;
        private System.Windows.Forms.Button butSuccessiva;
        private System.Windows.Forms.Button butPrecedente;
        private System.Windows.Forms.Button butSorgente;
        private System.Windows.Forms.TextBox textBoxSorgente;
        private System.Windows.Forms.Button butDestinazione;
        private System.Windows.Forms.TextBox textBoxDestinazione;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
    }
}
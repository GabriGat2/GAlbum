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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GAlbum.Properties.Resources.CTNY4062;
            this.pictureBox1.Location = new System.Drawing.Point(180, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(608, 354);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // butApri
            // 
            this.butApri.Location = new System.Drawing.Point(33, 32);
            this.butApri.Name = "butApri";
            this.butApri.Size = new System.Drawing.Size(75, 23);
            this.butApri.TabIndex = 1;
            this.butApri.Text = "Apri";
            this.butApri.UseVisualStyleBackColor = true;
            this.butApri.Click += new System.EventHandler(this.butApri_Click);
            // 
            // textBoxPathFoto
            // 
            this.textBoxPathFoto.Location = new System.Drawing.Point(12, 418);
            this.textBoxPathFoto.Name = "textBoxPathFoto";
            this.textBoxPathFoto.Size = new System.Drawing.Size(776, 20);
            this.textBoxPathFoto.TabIndex = 2;
            // 
            // butSuccessiva
            // 
            this.butSuccessiva.Location = new System.Drawing.Point(33, 61);
            this.butSuccessiva.Name = "butSuccessiva";
            this.butSuccessiva.Size = new System.Drawing.Size(75, 23);
            this.butSuccessiva.TabIndex = 3;
            this.butSuccessiva.Text = "Successiva";
            this.butSuccessiva.UseVisualStyleBackColor = true;
            this.butSuccessiva.Click += new System.EventHandler(this.butSuccessiva_Click);
            // 
            // FormSelezione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}
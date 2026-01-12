namespace GAlbum
{
    partial class FormConfigTreeView
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
            this.tabVisualizza = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxLivello = new System.Windows.Forms.GroupBox();
            this.numericUpDownLivello = new System.Windows.Forms.NumericUpDown();
            this.groupBoxDirectory = new System.Windows.Forms.GroupBox();
            this.checkBoxRami = new System.Windows.Forms.CheckBox();
            this.checkBoxFoglie = new System.Windows.Forms.CheckBox();
            this.checkBoxRamiRiservati = new System.Windows.Forms.CheckBox();
            this.butDefault = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxArchiviazione = new System.Windows.Forms.GroupBox();
            this.checkBoxCopiaParallela = new System.Windows.Forms.CheckBox();
            this.tabVisualizza.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxLivello.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLivello)).BeginInit();
            this.groupBoxDirectory.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBoxArchiviazione.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabVisualizza
            // 
            this.tabVisualizza.Controls.Add(this.tabPage1);
            this.tabVisualizza.Controls.Add(this.tabPage2);
            this.tabVisualizza.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisualizza.Location = new System.Drawing.Point(0, 0);
            this.tabVisualizza.Name = "tabVisualizza";
            this.tabVisualizza.SelectedIndex = 0;
            this.tabVisualizza.Size = new System.Drawing.Size(800, 450);
            this.tabVisualizza.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxLivello);
            this.tabPage1.Controls.Add(this.groupBoxDirectory);
            this.tabPage1.Controls.Add(this.butDefault);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Visualizza";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxLivello
            // 
            this.groupBoxLivello.Controls.Add(this.numericUpDownLivello);
            this.groupBoxLivello.Location = new System.Drawing.Point(8, 19);
            this.groupBoxLivello.Name = "groupBoxLivello";
            this.groupBoxLivello.Size = new System.Drawing.Size(143, 56);
            this.groupBoxLivello.TabIndex = 6;
            this.groupBoxLivello.TabStop = false;
            this.groupBoxLivello.Text = "Livello";
            // 
            // numericUpDownLivello
            // 
            this.numericUpDownLivello.Location = new System.Drawing.Point(6, 19);
            this.numericUpDownLivello.Name = "numericUpDownLivello";
            this.numericUpDownLivello.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownLivello.TabIndex = 4;
            this.numericUpDownLivello.ValueChanged += new System.EventHandler(this.numericUpDownLivello_ValueChanged);
            // 
            // groupBoxDirectory
            // 
            this.groupBoxDirectory.Controls.Add(this.checkBoxRami);
            this.groupBoxDirectory.Controls.Add(this.checkBoxFoglie);
            this.groupBoxDirectory.Controls.Add(this.checkBoxRamiRiservati);
            this.groupBoxDirectory.Location = new System.Drawing.Point(8, 91);
            this.groupBoxDirectory.Name = "groupBoxDirectory";
            this.groupBoxDirectory.Size = new System.Drawing.Size(143, 147);
            this.groupBoxDirectory.TabIndex = 5;
            this.groupBoxDirectory.TabStop = false;
            this.groupBoxDirectory.Text = "Directory";
            // 
            // checkBoxRami
            // 
            this.checkBoxRami.AutoSize = true;
            this.checkBoxRami.Location = new System.Drawing.Point(6, 28);
            this.checkBoxRami.Name = "checkBoxRami";
            this.checkBoxRami.Size = new System.Drawing.Size(50, 17);
            this.checkBoxRami.TabIndex = 0;
            this.checkBoxRami.Text = "Rami";
            this.checkBoxRami.UseVisualStyleBackColor = true;
            this.checkBoxRami.CheckedChanged += new System.EventHandler(this.checkBoxRami_CheckedChanged);
            // 
            // checkBoxFoglie
            // 
            this.checkBoxFoglie.AutoSize = true;
            this.checkBoxFoglie.Location = new System.Drawing.Point(6, 66);
            this.checkBoxFoglie.Name = "checkBoxFoglie";
            this.checkBoxFoglie.Size = new System.Drawing.Size(54, 17);
            this.checkBoxFoglie.TabIndex = 1;
            this.checkBoxFoglie.Text = "Foglie";
            this.checkBoxFoglie.UseVisualStyleBackColor = true;
            this.checkBoxFoglie.CheckedChanged += new System.EventHandler(this.checkBoxFoglie_CheckedChanged);
            // 
            // checkBoxRamiRiservati
            // 
            this.checkBoxRamiRiservati.AutoSize = true;
            this.checkBoxRamiRiservati.Location = new System.Drawing.Point(6, 109);
            this.checkBoxRamiRiservati.Name = "checkBoxRamiRiservati";
            this.checkBoxRamiRiservati.Size = new System.Drawing.Size(89, 17);
            this.checkBoxRamiRiservati.TabIndex = 2;
            this.checkBoxRamiRiservati.Text = "Rami riservati";
            this.checkBoxRamiRiservati.UseVisualStyleBackColor = true;
            this.checkBoxRamiRiservati.CheckedChanged += new System.EventHandler(this.checkBoxRamiRiservati_CheckedChanged);
            // 
            // butDefault
            // 
            this.butDefault.Location = new System.Drawing.Point(709, 393);
            this.butDefault.Name = "butDefault";
            this.butDefault.Size = new System.Drawing.Size(75, 23);
            this.butDefault.TabIndex = 3;
            this.butDefault.Text = "Default";
            this.butDefault.UseVisualStyleBackColor = true;
            this.butDefault.Click += new System.EventHandler(this.butDefault_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxArchiviazione);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Archivia";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxArchiviazione
            // 
            this.groupBoxArchiviazione.Controls.Add(this.checkBoxCopiaParallela);
            this.groupBoxArchiviazione.Location = new System.Drawing.Point(20, 20);
            this.groupBoxArchiviazione.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxArchiviazione.Name = "groupBoxArchiviazione";
            this.groupBoxArchiviazione.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxArchiviazione.Size = new System.Drawing.Size(164, 119);
            this.groupBoxArchiviazione.TabIndex = 0;
            this.groupBoxArchiviazione.TabStop = false;
            this.groupBoxArchiviazione.Text = "Archiviazione";
            // 
            // checkBoxCopiaParallela
            // 
            this.checkBoxCopiaParallela.AutoSize = true;
            this.checkBoxCopiaParallela.Location = new System.Drawing.Point(16, 36);
            this.checkBoxCopiaParallela.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxCopiaParallela.Name = "checkBoxCopiaParallela";
            this.checkBoxCopiaParallela.Size = new System.Drawing.Size(96, 17);
            this.checkBoxCopiaParallela.TabIndex = 0;
            this.checkBoxCopiaParallela.Text = "Copia Parallela";
            this.checkBoxCopiaParallela.UseVisualStyleBackColor = true;
            this.checkBoxCopiaParallela.CheckedChanged += new System.EventHandler(this.checkBoxCopiaParallela_CheckedChanged);
            // 
            // FormConfigTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabVisualizza);
            this.Name = "FormConfigTreeView";
            this.Text = "FormConfigTreeView";
            this.tabVisualizza.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxLivello.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLivello)).EndInit();
            this.groupBoxDirectory.ResumeLayout(false);
            this.groupBoxDirectory.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxArchiviazione.ResumeLayout(false);
            this.groupBoxArchiviazione.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabVisualizza;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox checkBoxRamiRiservati;
        private System.Windows.Forms.CheckBox checkBoxFoglie;
        private System.Windows.Forms.CheckBox checkBoxRami;
        private System.Windows.Forms.Button butDefault;
        private System.Windows.Forms.NumericUpDown numericUpDownLivello;
        private System.Windows.Forms.GroupBox groupBoxLivello;
        private System.Windows.Forms.GroupBox groupBoxDirectory;
        private System.Windows.Forms.GroupBox groupBoxArchiviazione;
        private System.Windows.Forms.CheckBox checkBoxCopiaParallela;
    }
}
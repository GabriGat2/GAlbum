namespace GAlbum
{
    partial class FormNomeLibro
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
            this.butAssegna = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomeFileSrc = new System.Windows.Forms.TextBox();
            this.textBoxCognome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAltroNome = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotVolumi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxVolumi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxVolume = new System.Windows.Forms.CheckBox();
            this.textBoxDataLettura = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBoxFileSorgente = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.butExplorerAcquisire = new System.Windows.Forms.Button();
            this.textBoxPathSrc = new System.Windows.Forms.TextBox();
            this.groupBoxAutore = new System.Windows.Forms.GroupBox();
            this.groupBoxDataLettura = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDataLettura = new System.Windows.Forms.DateTimePicker();
            this.checkBoxDataLettura = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPathDst = new System.Windows.Forms.TextBox();
            this.textBoxNomeFileDst = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxFileSorgente.SuspendLayout();
            this.groupBoxAutore.SuspendLayout();
            this.groupBoxDataLettura.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // butAssegna
            // 
            this.butAssegna.Location = new System.Drawing.Point(682, 394);
            this.butAssegna.Name = "butAssegna";
            this.butAssegna.Size = new System.Drawing.Size(75, 23);
            this.butAssegna.TabIndex = 0;
            this.butAssegna.Text = "Assegna";
            this.butAssegna.UseVisualStyleBackColor = true;
            this.butAssegna.Click += new System.EventHandler(this.butAssegna_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "NomeFile";
            // 
            // textBoxNomeFileSrc
            // 
            this.textBoxNomeFileSrc.Location = new System.Drawing.Point(120, 45);
            this.textBoxNomeFileSrc.Name = "textBoxNomeFileSrc";
            this.textBoxNomeFileSrc.ReadOnly = true;
            this.textBoxNomeFileSrc.Size = new System.Drawing.Size(628, 20);
            this.textBoxNomeFileSrc.TabIndex = 2;
            // 
            // textBoxCognome
            // 
            this.textBoxCognome.Location = new System.Drawing.Point(120, 21);
            this.textBoxCognome.Name = "textBoxCognome";
            this.textBoxCognome.Size = new System.Drawing.Size(144, 20);
            this.textBoxCognome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cognome";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(351, 21);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(144, 20);
            this.textBoxNome.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome";
            // 
            // textBoxAltroNome
            // 
            this.textBoxAltroNome.Location = new System.Drawing.Point(606, 21);
            this.textBoxAltroNome.Name = "textBoxAltroNome";
            this.textBoxAltroNome.Size = new System.Drawing.Size(144, 20);
            this.textBoxAltroNome.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(541, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Altro Nome";
            // 
            // textBoxTotVolumi
            // 
            this.textBoxTotVolumi.Location = new System.Drawing.Point(351, 19);
            this.textBoxTotVolumi.Name = "textBoxTotVolumi";
            this.textBoxTotVolumi.Size = new System.Drawing.Size(144, 20);
            this.textBoxTotVolumi.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Volumi";
            // 
            // textBoxVolumi
            // 
            this.textBoxVolumi.Location = new System.Drawing.Point(120, 22);
            this.textBoxVolumi.Name = "textBoxVolumi";
            this.textBoxVolumi.Size = new System.Drawing.Size(144, 20);
            this.textBoxVolumi.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(62, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Volume";
            // 
            // checkBoxVolume
            // 
            this.checkBoxVolume.AutoSize = true;
            this.checkBoxVolume.Location = new System.Drawing.Point(10, 29);
            this.checkBoxVolume.Name = "checkBoxVolume";
            this.checkBoxVolume.Size = new System.Drawing.Size(15, 14);
            this.checkBoxVolume.TabIndex = 15;
            this.checkBoxVolume.UseVisualStyleBackColor = true;
            // 
            // textBoxDataLettura
            // 
            this.textBoxDataLettura.Location = new System.Drawing.Point(119, 19);
            this.textBoxDataLettura.Name = "textBoxDataLettura";
            this.textBoxDataLettura.Size = new System.Drawing.Size(144, 20);
            this.textBoxDataLettura.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(61, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Data";
            // 
            // groupBoxFileSorgente
            // 
            this.groupBoxFileSorgente.Controls.Add(this.label9);
            this.groupBoxFileSorgente.Controls.Add(this.butExplorerAcquisire);
            this.groupBoxFileSorgente.Controls.Add(this.textBoxPathSrc);
            this.groupBoxFileSorgente.Controls.Add(this.textBoxNomeFileSrc);
            this.groupBoxFileSorgente.Controls.Add(this.label1);
            this.groupBoxFileSorgente.Location = new System.Drawing.Point(9, 13);
            this.groupBoxFileSorgente.Name = "groupBoxFileSorgente";
            this.groupBoxFileSorgente.Size = new System.Drawing.Size(779, 79);
            this.groupBoxFileSorgente.TabIndex = 19;
            this.groupBoxFileSorgente.TabStop = false;
            this.groupBoxFileSorgente.Text = "File Sorgente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Path";
            // 
            // butExplorerAcquisire
            // 
            this.butExplorerAcquisire.Location = new System.Drawing.Point(756, 17);
            this.butExplorerAcquisire.Name = "butExplorerAcquisire";
            this.butExplorerAcquisire.Size = new System.Drawing.Size(17, 23);
            this.butExplorerAcquisire.TabIndex = 18;
            this.butExplorerAcquisire.Text = "E";
            this.butExplorerAcquisire.UseVisualStyleBackColor = true;
            // 
            // textBoxPathSrc
            // 
            this.textBoxPathSrc.Location = new System.Drawing.Point(120, 19);
            this.textBoxPathSrc.Name = "textBoxPathSrc";
            this.textBoxPathSrc.ReadOnly = true;
            this.textBoxPathSrc.Size = new System.Drawing.Size(628, 20);
            this.textBoxPathSrc.TabIndex = 17;
            // 
            // groupBoxAutore
            // 
            this.groupBoxAutore.Controls.Add(this.textBoxNome);
            this.groupBoxAutore.Controls.Add(this.label2);
            this.groupBoxAutore.Controls.Add(this.textBoxCognome);
            this.groupBoxAutore.Controls.Add(this.label3);
            this.groupBoxAutore.Controls.Add(this.label4);
            this.groupBoxAutore.Controls.Add(this.textBoxAltroNome);
            this.groupBoxAutore.Location = new System.Drawing.Point(9, 98);
            this.groupBoxAutore.Name = "groupBoxAutore";
            this.groupBoxAutore.Size = new System.Drawing.Size(778, 55);
            this.groupBoxAutore.TabIndex = 20;
            this.groupBoxAutore.TabStop = false;
            this.groupBoxAutore.Text = "Autore";
            // 
            // groupBoxDataLettura
            // 
            this.groupBoxDataLettura.Controls.Add(this.dateTimePickerDataLettura);
            this.groupBoxDataLettura.Controls.Add(this.checkBoxDataLettura);
            this.groupBoxDataLettura.Controls.Add(this.textBoxDataLettura);
            this.groupBoxDataLettura.Controls.Add(this.label8);
            this.groupBoxDataLettura.Location = new System.Drawing.Point(10, 159);
            this.groupBoxDataLettura.Name = "groupBoxDataLettura";
            this.groupBoxDataLettura.Size = new System.Drawing.Size(778, 55);
            this.groupBoxDataLettura.TabIndex = 21;
            this.groupBoxDataLettura.TabStop = false;
            this.groupBoxDataLettura.Text = "DataLettura";
            // 
            // dateTimePickerDataLettura
            // 
            this.dateTimePickerDataLettura.Location = new System.Drawing.Point(312, 18);
            this.dateTimePickerDataLettura.Name = "dateTimePickerDataLettura";
            this.dateTimePickerDataLettura.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDataLettura.TabIndex = 20;
            // 
            // checkBoxDataLettura
            // 
            this.checkBoxDataLettura.AutoSize = true;
            this.checkBoxDataLettura.Location = new System.Drawing.Point(9, 27);
            this.checkBoxDataLettura.Name = "checkBoxDataLettura";
            this.checkBoxDataLettura.Size = new System.Drawing.Size(15, 14);
            this.checkBoxDataLettura.TabIndex = 19;
            this.checkBoxDataLettura.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxVolume);
            this.groupBox4.Controls.Add(this.textBoxVolumi);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBoxTotVolumi);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(9, 220);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(778, 55);
            this.groupBox4.TabIndex = 22;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Volumi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.textBoxPathDst);
            this.groupBox1.Controls.Add(this.textBoxNomeFileDst);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(8, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 79);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "File destinazione";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Path";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(17, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "E";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxPathDst
            // 
            this.textBoxPathDst.Location = new System.Drawing.Point(120, 19);
            this.textBoxPathDst.Name = "textBoxPathDst";
            this.textBoxPathDst.ReadOnly = true;
            this.textBoxPathDst.Size = new System.Drawing.Size(628, 20);
            this.textBoxPathDst.TabIndex = 17;
            // 
            // textBoxNomeFileDst
            // 
            this.textBoxNomeFileDst.Location = new System.Drawing.Point(120, 45);
            this.textBoxNomeFileDst.Name = "textBoxNomeFileDst";
            this.textBoxNomeFileDst.ReadOnly = true;
            this.textBoxNomeFileDst.Size = new System.Drawing.Size(628, 20);
            this.textBoxNomeFileDst.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(61, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "NomeFile";
            // 
            // FormNomeLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxDataLettura);
            this.Controls.Add(this.groupBoxAutore);
            this.Controls.Add(this.groupBoxFileSorgente);
            this.Controls.Add(this.butAssegna);
            this.Name = "FormNomeLibro";
            this.Text = "FormNomeLibro";
            this.groupBoxFileSorgente.ResumeLayout(false);
            this.groupBoxFileSorgente.PerformLayout();
            this.groupBoxAutore.ResumeLayout(false);
            this.groupBoxAutore.PerformLayout();
            this.groupBoxDataLettura.ResumeLayout(false);
            this.groupBoxDataLettura.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butAssegna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeFileSrc;
        private System.Windows.Forms.TextBox textBoxCognome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAltroNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTotVolumi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxVolumi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxVolume;
        private System.Windows.Forms.TextBox textBoxDataLettura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxFileSorgente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button butExplorerAcquisire;
        private System.Windows.Forms.TextBox textBoxPathSrc;
        private System.Windows.Forms.GroupBox groupBoxAutore;
        private System.Windows.Forms.GroupBox groupBoxDataLettura;
        private System.Windows.Forms.CheckBox checkBoxDataLettura;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataLettura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPathDst;
        private System.Windows.Forms.TextBox textBoxNomeFileDst;
        private System.Windows.Forms.Label label10;
    }
}
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
            this.textBoxAutore1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAutore2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAutore3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxTotVolumi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxVolumi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxVolumi = new System.Windows.Forms.CheckBox();
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
            this.groupBoxVolumi = new System.Windows.Forms.GroupBox();
            this.groupBoxDestinazione = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxPathDst = new System.Windows.Forms.TextBox();
            this.textBoxNomeFileDst = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBoxSupporto = new System.Windows.Forms.GroupBox();
            this.butDelete = new System.Windows.Forms.Button();
            this.comboBoxSupporto = new System.Windows.Forms.ComboBox();
            this.checkBoxSupporto = new System.Windows.Forms.CheckBox();
            this.textBoxSupporto = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxTitoli = new System.Windows.Forms.GroupBox();
            this.textBoxTitolo2 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxTitolo1 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxTitolo3 = new System.Windows.Forms.TextBox();
            this.groupBoxFileSorgente.SuspendLayout();
            this.groupBoxAutore.SuspendLayout();
            this.groupBoxDataLettura.SuspendLayout();
            this.groupBoxVolumi.SuspendLayout();
            this.groupBoxDestinazione.SuspendLayout();
            this.groupBoxSupporto.SuspendLayout();
            this.groupBoxTitoli.SuspendLayout();
            this.SuspendLayout();
            // 
            // butAssegna
            // 
            this.butAssegna.Location = new System.Drawing.Point(813, 691);
            this.butAssegna.Name = "butAssegna";
            this.butAssegna.Size = new System.Drawing.Size(75, 23);
            this.butAssegna.TabIndex = 0;
            this.butAssegna.Text = "Assegna";
            this.butAssegna.UseVisualStyleBackColor = true;
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
            this.textBoxNomeFileSrc.Size = new System.Drawing.Size(730, 20);
            this.textBoxNomeFileSrc.TabIndex = 2;
            // 
            // textBoxAutore1
            // 
            this.textBoxAutore1.Location = new System.Drawing.Point(120, 21);
            this.textBoxAutore1.Name = "textBoxAutore1";
            this.textBoxAutore1.Size = new System.Drawing.Size(730, 20);
            this.textBoxAutore1.TabIndex = 4;
            this.textBoxAutore1.TextChanged += new System.EventHandler(this.textBoxAutore1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Autore 1";
            // 
            // textBoxAutore2
            // 
            this.textBoxAutore2.Location = new System.Drawing.Point(121, 47);
            this.textBoxAutore2.Name = "textBoxAutore2";
            this.textBoxAutore2.Size = new System.Drawing.Size(730, 20);
            this.textBoxAutore2.TabIndex = 6;
            this.textBoxAutore2.TextChanged += new System.EventHandler(this.textBoxAutore2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autore 2";
            // 
            // textBoxAutore3
            // 
            this.textBoxAutore3.Location = new System.Drawing.Point(120, 73);
            this.textBoxAutore3.Name = "textBoxAutore3";
            this.textBoxAutore3.Size = new System.Drawing.Size(730, 20);
            this.textBoxAutore3.TabIndex = 8;
            this.textBoxAutore3.TextChanged += new System.EventHandler(this.textBoxAutore3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Autore 3";
            // 
            // textBoxTotVolumi
            // 
            this.textBoxTotVolumi.Location = new System.Drawing.Point(351, 19);
            this.textBoxTotVolumi.Name = "textBoxTotVolumi";
            this.textBoxTotVolumi.Size = new System.Drawing.Size(144, 20);
            this.textBoxTotVolumi.TabIndex = 12;
            this.textBoxTotVolumi.TextChanged += new System.EventHandler(this.textBoxTotVolumi_TextChanged);
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
            this.textBoxVolumi.TextChanged += new System.EventHandler(this.textBoxVolumi_TextChanged);
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
            // checkBoxVolumi
            // 
            this.checkBoxVolumi.AutoSize = true;
            this.checkBoxVolumi.Location = new System.Drawing.Point(10, 29);
            this.checkBoxVolumi.Name = "checkBoxVolumi";
            this.checkBoxVolumi.Size = new System.Drawing.Size(15, 14);
            this.checkBoxVolumi.TabIndex = 15;
            this.checkBoxVolumi.UseVisualStyleBackColor = true;
            // 
            // textBoxDataLettura
            // 
            this.textBoxDataLettura.Location = new System.Drawing.Point(596, 19);
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
            this.groupBoxFileSorgente.Size = new System.Drawing.Size(869, 79);
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
            this.butExplorerAcquisire.Location = new System.Drawing.Point(833, 20);
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
            this.textBoxPathSrc.Size = new System.Drawing.Size(707, 20);
            this.textBoxPathSrc.TabIndex = 17;
            // 
            // groupBoxAutore
            // 
            this.groupBoxAutore.Controls.Add(this.textBoxAutore2);
            this.groupBoxAutore.Controls.Add(this.label2);
            this.groupBoxAutore.Controls.Add(this.textBoxAutore1);
            this.groupBoxAutore.Controls.Add(this.label3);
            this.groupBoxAutore.Controls.Add(this.label4);
            this.groupBoxAutore.Controls.Add(this.textBoxAutore3);
            this.groupBoxAutore.Location = new System.Drawing.Point(9, 98);
            this.groupBoxAutore.Name = "groupBoxAutore";
            this.groupBoxAutore.Size = new System.Drawing.Size(869, 118);
            this.groupBoxAutore.TabIndex = 20;
            this.groupBoxAutore.TabStop = false;
            this.groupBoxAutore.Text = "Autori e titoli";
            // 
            // groupBoxDataLettura
            // 
            this.groupBoxDataLettura.Controls.Add(this.dateTimePickerDataLettura);
            this.groupBoxDataLettura.Controls.Add(this.checkBoxDataLettura);
            this.groupBoxDataLettura.Controls.Add(this.textBoxDataLettura);
            this.groupBoxDataLettura.Controls.Add(this.label8);
            this.groupBoxDataLettura.Location = new System.Drawing.Point(10, 407);
            this.groupBoxDataLettura.Name = "groupBoxDataLettura";
            this.groupBoxDataLettura.Size = new System.Drawing.Size(868, 55);
            this.groupBoxDataLettura.TabIndex = 21;
            this.groupBoxDataLettura.TabStop = false;
            this.groupBoxDataLettura.Text = "DataLettura";
            // 
            // dateTimePickerDataLettura
            // 
            this.dateTimePickerDataLettura.Location = new System.Drawing.Point(121, 16);
            this.dateTimePickerDataLettura.Name = "dateTimePickerDataLettura";
            this.dateTimePickerDataLettura.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDataLettura.TabIndex = 20;
            this.dateTimePickerDataLettura.ValueChanged += new System.EventHandler(this.dateTimePickerDataLettura_ValueChanged);
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
            // groupBoxVolumi
            // 
            this.groupBoxVolumi.Controls.Add(this.checkBoxVolumi);
            this.groupBoxVolumi.Controls.Add(this.textBoxVolumi);
            this.groupBoxVolumi.Controls.Add(this.label7);
            this.groupBoxVolumi.Controls.Add(this.textBoxTotVolumi);
            this.groupBoxVolumi.Controls.Add(this.label6);
            this.groupBoxVolumi.Location = new System.Drawing.Point(9, 346);
            this.groupBoxVolumi.Name = "groupBoxVolumi";
            this.groupBoxVolumi.Size = new System.Drawing.Size(869, 55);
            this.groupBoxVolumi.TabIndex = 22;
            this.groupBoxVolumi.TabStop = false;
            this.groupBoxVolumi.Text = "Volumi";
            // 
            // groupBoxDestinazione
            // 
            this.groupBoxDestinazione.Controls.Add(this.label5);
            this.groupBoxDestinazione.Controls.Add(this.button1);
            this.groupBoxDestinazione.Controls.Add(this.textBoxPathDst);
            this.groupBoxDestinazione.Controls.Add(this.textBoxNomeFileDst);
            this.groupBoxDestinazione.Controls.Add(this.label10);
            this.groupBoxDestinazione.Location = new System.Drawing.Point(10, 555);
            this.groupBoxDestinazione.Name = "groupBoxDestinazione";
            this.groupBoxDestinazione.Size = new System.Drawing.Size(868, 79);
            this.groupBoxDestinazione.TabIndex = 20;
            this.groupBoxDestinazione.TabStop = false;
            this.groupBoxDestinazione.Text = "File destinazione";
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
            this.button1.Location = new System.Drawing.Point(834, 19);
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
            this.textBoxPathDst.Size = new System.Drawing.Size(708, 20);
            this.textBoxPathDst.TabIndex = 17;
            // 
            // textBoxNomeFileDst
            // 
            this.textBoxNomeFileDst.Location = new System.Drawing.Point(120, 45);
            this.textBoxNomeFileDst.Name = "textBoxNomeFileDst";
            this.textBoxNomeFileDst.ReadOnly = true;
            this.textBoxNomeFileDst.Size = new System.Drawing.Size(731, 20);
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
            // groupBoxSupporto
            // 
            this.groupBoxSupporto.Controls.Add(this.butDelete);
            this.groupBoxSupporto.Controls.Add(this.comboBoxSupporto);
            this.groupBoxSupporto.Controls.Add(this.checkBoxSupporto);
            this.groupBoxSupporto.Controls.Add(this.textBoxSupporto);
            this.groupBoxSupporto.Controls.Add(this.label11);
            this.groupBoxSupporto.Location = new System.Drawing.Point(8, 468);
            this.groupBoxSupporto.Name = "groupBoxSupporto";
            this.groupBoxSupporto.Size = new System.Drawing.Size(869, 55);
            this.groupBoxSupporto.TabIndex = 23;
            this.groupBoxSupporto.TabStop = false;
            this.groupBoxSupporto.Text = "Supporto";
            // 
            // butDelete
            // 
            this.butDelete.Location = new System.Drawing.Point(748, 22);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(104, 23);
            this.butDelete.TabIndex = 17;
            this.butDelete.Text = "Cancella";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // comboBoxSupporto
            // 
            this.comboBoxSupporto.FormattingEnabled = true;
            this.comboBoxSupporto.Location = new System.Drawing.Point(122, 22);
            this.comboBoxSupporto.Name = "comboBoxSupporto";
            this.comboBoxSupporto.Size = new System.Drawing.Size(142, 21);
            this.comboBoxSupporto.TabIndex = 16;
            this.comboBoxSupporto.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupporto_SelectedIndexChanged);
            this.comboBoxSupporto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBoxSupporto_KeyUp);
            // 
            // checkBoxSupporto
            // 
            this.checkBoxSupporto.AutoSize = true;
            this.checkBoxSupporto.Location = new System.Drawing.Point(10, 29);
            this.checkBoxSupporto.Name = "checkBoxSupporto";
            this.checkBoxSupporto.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSupporto.TabIndex = 15;
            this.checkBoxSupporto.UseVisualStyleBackColor = true;
            // 
            // textBoxSupporto
            // 
            this.textBoxSupporto.Location = new System.Drawing.Point(313, 23);
            this.textBoxSupporto.Name = "textBoxSupporto";
            this.textBoxSupporto.ReadOnly = true;
            this.textBoxSupporto.Size = new System.Drawing.Size(182, 20);
            this.textBoxSupporto.TabIndex = 14;
            this.textBoxSupporto.Text = "gdfg";
            this.textBoxSupporto.TextChanged += new System.EventHandler(this.textBoxSupporto_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Supporto";
            // 
            // groupBoxTitoli
            // 
            this.groupBoxTitoli.Controls.Add(this.textBoxTitolo2);
            this.groupBoxTitoli.Controls.Add(this.label16);
            this.groupBoxTitoli.Controls.Add(this.textBoxTitolo1);
            this.groupBoxTitoli.Controls.Add(this.label17);
            this.groupBoxTitoli.Controls.Add(this.label18);
            this.groupBoxTitoli.Controls.Add(this.textBoxTitolo3);
            this.groupBoxTitoli.Location = new System.Drawing.Point(9, 222);
            this.groupBoxTitoli.Name = "groupBoxTitoli";
            this.groupBoxTitoli.Size = new System.Drawing.Size(869, 118);
            this.groupBoxTitoli.TabIndex = 21;
            this.groupBoxTitoli.TabStop = false;
            this.groupBoxTitoli.Text = "Titoli";
            // 
            // textBoxTitolo2
            // 
            this.textBoxTitolo2.Location = new System.Drawing.Point(121, 47);
            this.textBoxTitolo2.Name = "textBoxTitolo2";
            this.textBoxTitolo2.Size = new System.Drawing.Size(730, 20);
            this.textBoxTitolo2.TabIndex = 6;
            this.textBoxTitolo2.TextChanged += new System.EventHandler(this.textBoxTitolo2_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(62, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Titolo 1";
            // 
            // textBoxTitolo1
            // 
            this.textBoxTitolo1.Location = new System.Drawing.Point(120, 21);
            this.textBoxTitolo1.Name = "textBoxTitolo1";
            this.textBoxTitolo1.Size = new System.Drawing.Size(730, 20);
            this.textBoxTitolo1.TabIndex = 4;
            this.textBoxTitolo1.TextChanged += new System.EventHandler(this.textBoxTitolo1_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(62, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 5;
            this.label17.Text = "Titolo 2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(61, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Titolo 3";
            // 
            // textBoxTitolo3
            // 
            this.textBoxTitolo3.Location = new System.Drawing.Point(120, 73);
            this.textBoxTitolo3.Name = "textBoxTitolo3";
            this.textBoxTitolo3.Size = new System.Drawing.Size(730, 20);
            this.textBoxTitolo3.TabIndex = 8;
            this.textBoxTitolo3.TextChanged += new System.EventHandler(this.textBoxTitolo3_TextChanged);
            // 
            // FormNomeLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 726);
            this.Controls.Add(this.groupBoxTitoli);
            this.Controls.Add(this.groupBoxSupporto);
            this.Controls.Add(this.groupBoxDestinazione);
            this.Controls.Add(this.groupBoxVolumi);
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
            this.groupBoxVolumi.ResumeLayout(false);
            this.groupBoxVolumi.PerformLayout();
            this.groupBoxDestinazione.ResumeLayout(false);
            this.groupBoxDestinazione.PerformLayout();
            this.groupBoxSupporto.ResumeLayout(false);
            this.groupBoxSupporto.PerformLayout();
            this.groupBoxTitoli.ResumeLayout(false);
            this.groupBoxTitoli.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butAssegna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeFileSrc;
        private System.Windows.Forms.TextBox textBoxAutore1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAutore2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAutore3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTotVolumi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxVolumi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxVolumi;
        private System.Windows.Forms.TextBox textBoxDataLettura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBoxFileSorgente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button butExplorerAcquisire;
        private System.Windows.Forms.TextBox textBoxPathSrc;
        private System.Windows.Forms.GroupBox groupBoxAutore;
        private System.Windows.Forms.GroupBox groupBoxDataLettura;
        private System.Windows.Forms.CheckBox checkBoxDataLettura;
        private System.Windows.Forms.GroupBox groupBoxVolumi;
        private System.Windows.Forms.DateTimePicker dateTimePickerDataLettura;
        private System.Windows.Forms.GroupBox groupBoxDestinazione;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxPathDst;
        private System.Windows.Forms.TextBox textBoxNomeFileDst;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBoxSupporto;
        private System.Windows.Forms.CheckBox checkBoxSupporto;
        private System.Windows.Forms.TextBox textBoxSupporto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxTitoli;
        private System.Windows.Forms.TextBox textBoxTitolo2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBoxTitolo1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBoxTitolo3;
        private System.Windows.Forms.ComboBox comboBoxSupporto;
        private System.Windows.Forms.Button butDelete;
    }
}
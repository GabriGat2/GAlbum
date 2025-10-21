namespace GAlbum
{
    partial class FormAcquisire
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
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Nodo1");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Nodo2");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Nodo5");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Nodo4", new System.Windows.Forms.TreeNode[] {
            treeNode15});
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Nodo3", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Nodo0", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14,
            treeNode17});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.textBoxSmistati = new System.Windows.Forms.TextBox();
            this.butSmistati = new System.Windows.Forms.Button();
            this.textBoxAcquisire = new System.Windows.Forms.TextBox();
            this.textBoxSmistare = new System.Windows.Forms.TextBox();
            this.butAcquisire = new System.Windows.Forms.Button();
            this.butSmistare = new System.Windows.Forms.Button();
            this.splitContainer1B2 = new System.Windows.Forms.SplitContainer();
            this.splitContainer1B2A3 = new System.Windows.Forms.SplitContainer();
            this.groupBoxSorgente = new System.Windows.Forms.GroupBox();
            this.treeViewSorgente = new System.Windows.Forms.TreeView();
            this.groupBoxDestinazione = new System.Windows.Forms.GroupBox();
            this.treeViewDestinazione = new System.Windows.Forms.TreeView();
            this.splitContainer1B2B3 = new System.Windows.Forms.SplitContainer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butNonAssegna = new System.Windows.Forms.Button();
            this.butAssegna = new System.Windows.Forms.Button();
            this.textBoxDebug = new System.Windows.Forms.TextBox();
            this.textBoxPathFoto = new System.Windows.Forms.TextBox();
            this.butPrecedente = new System.Windows.Forms.Button();
            this.butSuccessiva = new System.Windows.Forms.Button();
            this.butExplorerAcquisire = new System.Windows.Forms.Button();
            this.butExplorerSmistare = new System.Windows.Forms.Button();
            this.butExplorerSmistati = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1B2)).BeginInit();
            this.splitContainer1B2.Panel1.SuspendLayout();
            this.splitContainer1B2.Panel2.SuspendLayout();
            this.splitContainer1B2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1B2A3)).BeginInit();
            this.splitContainer1B2A3.Panel1.SuspendLayout();
            this.splitContainer1B2A3.Panel2.SuspendLayout();
            this.splitContainer1B2A3.SuspendLayout();
            this.groupBoxSorgente.SuspendLayout();
            this.groupBoxDestinazione.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1B2B3)).BeginInit();
            this.splitContainer1B2B3.Panel1.SuspendLayout();
            this.splitContainer1B2B3.Panel2.SuspendLayout();
            this.splitContainer1B2B3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.Control;
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
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 0;
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Controls.Add(this.butExplorerSmistati);
            this.groupBoxPath.Controls.Add(this.butExplorerSmistare);
            this.groupBoxPath.Controls.Add(this.butExplorerAcquisire);
            this.groupBoxPath.Controls.Add(this.textBoxSmistati);
            this.groupBoxPath.Controls.Add(this.butSmistati);
            this.groupBoxPath.Controls.Add(this.textBoxAcquisire);
            this.groupBoxPath.Controls.Add(this.textBoxSmistare);
            this.groupBoxPath.Controls.Add(this.butAcquisire);
            this.groupBoxPath.Controls.Add(this.butSmistare);
            this.groupBoxPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPath.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(890, 130);
            this.groupBoxPath.TabIndex = 13;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Selezione di sorgente e destinazione";
            // 
            // textBoxSmistati
            // 
            this.textBoxSmistati.Location = new System.Drawing.Point(104, 87);
            this.textBoxSmistati.Name = "textBoxSmistati";
            this.textBoxSmistati.Size = new System.Drawing.Size(706, 20);
            this.textBoxSmistati.TabIndex = 14;
            // 
            // butSmistati
            // 
            this.butSmistati.Location = new System.Drawing.Point(12, 85);
            this.butSmistati.Name = "butSmistati";
            this.butSmistati.Size = new System.Drawing.Size(86, 23);
            this.butSmistati.TabIndex = 13;
            this.butSmistati.Text = "Smistati";
            this.butSmistati.UseVisualStyleBackColor = true;
            this.butSmistati.Click += new System.EventHandler(this.butSmistati_Click);
            // 
            // textBoxAcquisire
            // 
            this.textBoxAcquisire.Location = new System.Drawing.Point(104, 29);
            this.textBoxAcquisire.Name = "textBoxAcquisire";
            this.textBoxAcquisire.ReadOnly = true;
            this.textBoxAcquisire.Size = new System.Drawing.Size(706, 20);
            this.textBoxAcquisire.TabIndex = 10;
            this.textBoxAcquisire.TextChanged += new System.EventHandler(this.textBoxSorgente_TextChanged);
            // 
            // textBoxSmistare
            // 
            this.textBoxSmistare.Location = new System.Drawing.Point(104, 58);
            this.textBoxSmistare.Name = "textBoxSmistare";
            this.textBoxSmistare.Size = new System.Drawing.Size(706, 20);
            this.textBoxSmistare.TabIndex = 12;
            this.textBoxSmistare.TextChanged += new System.EventHandler(this.textBoxDestinazione_TextChanged);
            // 
            // butAcquisire
            // 
            this.butAcquisire.Location = new System.Drawing.Point(12, 27);
            this.butAcquisire.Name = "butAcquisire";
            this.butAcquisire.Size = new System.Drawing.Size(86, 23);
            this.butAcquisire.TabIndex = 9;
            this.butAcquisire.Text = "Acquisire";
            this.butAcquisire.UseVisualStyleBackColor = true;
            this.butAcquisire.Click += new System.EventHandler(this.butAcquisire_Click);
            // 
            // butSmistare
            // 
            this.butSmistare.Location = new System.Drawing.Point(12, 56);
            this.butSmistare.Name = "butSmistare";
            this.butSmistare.Size = new System.Drawing.Size(86, 23);
            this.butSmistare.TabIndex = 11;
            this.butSmistare.Text = "Smistare";
            this.butSmistare.UseVisualStyleBackColor = true;
            this.butSmistare.Click += new System.EventHandler(this.butSmistare_Click);
            // 
            // splitContainer1B2
            // 
            this.splitContainer1B2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1B2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1B2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1B2.Name = "splitContainer1B2";
            // 
            // splitContainer1B2.Panel1
            // 
            this.splitContainer1B2.Panel1.Controls.Add(this.splitContainer1B2A3);
            // 
            // splitContainer1B2.Panel2
            // 
            this.splitContainer1B2.Panel2.Controls.Add(this.splitContainer1B2B3);
            this.splitContainer1B2.Size = new System.Drawing.Size(890, 592);
            this.splitContainer1B2.SplitterDistance = 296;
            this.splitContainer1B2.TabIndex = 0;
            // 
            // splitContainer1B2A3
            // 
            this.splitContainer1B2A3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1B2A3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1B2A3.Name = "splitContainer1B2A3";
            // 
            // splitContainer1B2A3.Panel1
            // 
            this.splitContainer1B2A3.Panel1.Controls.Add(this.groupBoxSorgente);
            // 
            // splitContainer1B2A3.Panel2
            // 
            this.splitContainer1B2A3.Panel2.Controls.Add(this.groupBoxDestinazione);
            this.splitContainer1B2A3.Size = new System.Drawing.Size(296, 592);
            this.splitContainer1B2A3.SplitterDistance = 145;
            this.splitContainer1B2A3.TabIndex = 0;
            // 
            // groupBoxSorgente
            // 
            this.groupBoxSorgente.Controls.Add(this.treeViewSorgente);
            this.groupBoxSorgente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSorgente.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSorgente.Name = "groupBoxSorgente";
            this.groupBoxSorgente.Size = new System.Drawing.Size(145, 592);
            this.groupBoxSorgente.TabIndex = 0;
            this.groupBoxSorgente.TabStop = false;
            this.groupBoxSorgente.Text = "Sorgente";
            // 
            // treeViewSorgente
            // 
            this.treeViewSorgente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewSorgente.Location = new System.Drawing.Point(3, 16);
            this.treeViewSorgente.Name = "treeViewSorgente";
            this.treeViewSorgente.Size = new System.Drawing.Size(139, 573);
            this.treeViewSorgente.TabIndex = 0;
            this.treeViewSorgente.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSorgente_AfterSelect);
            this.treeViewSorgente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeViewSorgente_MouseDoubleClick);
            // 
            // groupBoxDestinazione
            // 
            this.groupBoxDestinazione.Controls.Add(this.treeViewDestinazione);
            this.groupBoxDestinazione.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDestinazione.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDestinazione.Name = "groupBoxDestinazione";
            this.groupBoxDestinazione.Size = new System.Drawing.Size(147, 592);
            this.groupBoxDestinazione.TabIndex = 0;
            this.groupBoxDestinazione.TabStop = false;
            this.groupBoxDestinazione.Text = "Destinazione";
            // 
            // treeViewDestinazione
            // 
            this.treeViewDestinazione.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDestinazione.Location = new System.Drawing.Point(3, 16);
            this.treeViewDestinazione.Name = "treeViewDestinazione";
            treeNode13.Name = "Nodo1";
            treeNode13.Text = "Nodo1";
            treeNode14.Name = "Nodo2";
            treeNode14.Text = "Nodo2";
            treeNode15.Name = "Nodo5";
            treeNode15.Text = "Nodo5";
            treeNode16.Name = "Nodo4";
            treeNode16.Text = "Nodo4";
            treeNode17.Name = "Nodo3";
            treeNode17.Text = "Nodo3";
            treeNode18.Name = "Nodo0";
            treeNode18.Text = "Nodo0";
            this.treeViewDestinazione.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18});
            this.treeViewDestinazione.Size = new System.Drawing.Size(141, 573);
            this.treeViewDestinazione.TabIndex = 0;
            this.treeViewDestinazione.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewDestinazione_AfterSelect);
            this.treeViewDestinazione.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeViewDestinazione_MouseDoubleClick);
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
            this.splitContainer1B2B3.Panel2.Controls.Add(this.butNonAssegna);
            this.splitContainer1B2B3.Panel2.Controls.Add(this.butAssegna);
            this.splitContainer1B2B3.Panel2.Controls.Add(this.textBoxDebug);
            this.splitContainer1B2B3.Panel2.Controls.Add(this.textBoxPathFoto);
            this.splitContainer1B2B3.Panel2.Controls.Add(this.butPrecedente);
            this.splitContainer1B2B3.Panel2.Controls.Add(this.butSuccessiva);
            this.splitContainer1B2B3.Size = new System.Drawing.Size(590, 592);
            this.splitContainer1B2B3.SplitterDistance = 524;
            this.splitContainer1B2B3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(590, 524);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // butNonAssegna
            // 
            this.butNonAssegna.Location = new System.Drawing.Point(275, 35);
            this.butNonAssegna.Name = "butNonAssegna";
            this.butNonAssegna.Size = new System.Drawing.Size(80, 23);
            this.butNonAssegna.TabIndex = 11;
            this.butNonAssegna.Text = "NonAssegna";
            this.butNonAssegna.UseVisualStyleBackColor = true;
            this.butNonAssegna.Click += new System.EventHandler(this.butNonAssegna_Click);
            // 
            // butAssegna
            // 
            this.butAssegna.Location = new System.Drawing.Point(194, 35);
            this.butAssegna.Name = "butAssegna";
            this.butAssegna.Size = new System.Drawing.Size(75, 23);
            this.butAssegna.TabIndex = 10;
            this.butAssegna.Text = "Assegna";
            this.butAssegna.UseVisualStyleBackColor = true;
            this.butAssegna.Click += new System.EventHandler(this.butAssegna_Click);
            // 
            // textBoxDebug
            // 
            this.textBoxDebug.Location = new System.Drawing.Point(532, 37);
            this.textBoxDebug.Name = "textBoxDebug";
            this.textBoxDebug.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDebug.Size = new System.Drawing.Size(46, 20);
            this.textBoxDebug.TabIndex = 9;
            // 
            // textBoxPathFoto
            // 
            this.textBoxPathFoto.Location = new System.Drawing.Point(12, 7);
            this.textBoxPathFoto.Name = "textBoxPathFoto";
            this.textBoxPathFoto.Size = new System.Drawing.Size(575, 20);
            this.textBoxPathFoto.TabIndex = 8;
            // 
            // butPrecedente
            // 
            this.butPrecedente.Location = new System.Drawing.Point(12, 35);
            this.butPrecedente.Name = "butPrecedente";
            this.butPrecedente.Size = new System.Drawing.Size(75, 23);
            this.butPrecedente.TabIndex = 7;
            this.butPrecedente.Text = "Precedente";
            this.butPrecedente.UseVisualStyleBackColor = true;
            this.butPrecedente.Click += new System.EventHandler(this.butPrecedente_Click);
            // 
            // butSuccessiva
            // 
            this.butSuccessiva.Location = new System.Drawing.Point(93, 35);
            this.butSuccessiva.Name = "butSuccessiva";
            this.butSuccessiva.Size = new System.Drawing.Size(75, 23);
            this.butSuccessiva.TabIndex = 6;
            this.butSuccessiva.Text = "Successiva";
            this.butSuccessiva.UseVisualStyleBackColor = true;
            this.butSuccessiva.Click += new System.EventHandler(this.butSuccessiva_Click);
            // 
            // butExplorerAcquisire
            // 
            this.butExplorerAcquisire.Location = new System.Drawing.Point(816, 29);
            this.butExplorerAcquisire.Name = "butExplorerAcquisire";
            this.butExplorerAcquisire.Size = new System.Drawing.Size(17, 23);
            this.butExplorerAcquisire.TabIndex = 16;
            this.butExplorerAcquisire.Text = "E";
            this.butExplorerAcquisire.UseVisualStyleBackColor = true;
            this.butExplorerAcquisire.Click += new System.EventHandler(this.butExplorerAcquisire_Click);
            // 
            // butExplorerSmistare
            // 
            this.butExplorerSmistare.Location = new System.Drawing.Point(816, 58);
            this.butExplorerSmistare.Name = "butExplorerSmistare";
            this.butExplorerSmistare.Size = new System.Drawing.Size(17, 23);
            this.butExplorerSmistare.TabIndex = 17;
            this.butExplorerSmistare.Text = "E";
            this.butExplorerSmistare.UseVisualStyleBackColor = true;
            this.butExplorerSmistare.Click += new System.EventHandler(this.butExplorerSmistare_Click);
            // 
            // butExplorerSmistati
            // 
            this.butExplorerSmistati.Location = new System.Drawing.Point(816, 87);
            this.butExplorerSmistati.Name = "butExplorerSmistati";
            this.butExplorerSmistati.Size = new System.Drawing.Size(17, 23);
            this.butExplorerSmistati.TabIndex = 18;
            this.butExplorerSmistati.Text = "E";
            this.butExplorerSmistati.UseVisualStyleBackColor = true;
            this.butExplorerSmistati.Click += new System.EventHandler(this.butExplorerSmistati_Click);
            // 
            // FormAcquisire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 726);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormAcquisire";
            this.Text = "Acquisizione Archivi Foto";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.splitContainer1B2.Panel1.ResumeLayout(false);
            this.splitContainer1B2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1B2)).EndInit();
            this.splitContainer1B2.ResumeLayout(false);
            this.splitContainer1B2A3.Panel1.ResumeLayout(false);
            this.splitContainer1B2A3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1B2A3)).EndInit();
            this.splitContainer1B2A3.ResumeLayout(false);
            this.groupBoxSorgente.ResumeLayout(false);
            this.groupBoxDestinazione.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox textBoxSmistare;
        private System.Windows.Forms.Button butSmistare;
        private System.Windows.Forms.TextBox textBoxAcquisire;
        private System.Windows.Forms.Button butAcquisire;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.SplitContainer splitContainer1B2;
        private System.Windows.Forms.SplitContainer splitContainer1B2B3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butPrecedente;
        private System.Windows.Forms.Button butSuccessiva;
        private System.Windows.Forms.TextBox textBoxPathFoto;
        private System.Windows.Forms.SplitContainer splitContainer1B2A3;
        private System.Windows.Forms.GroupBox groupBoxDestinazione;
        private System.Windows.Forms.GroupBox groupBoxSorgente;
        private System.Windows.Forms.TreeView treeViewDestinazione;
        private System.Windows.Forms.TextBox textBoxDebug;
        private System.Windows.Forms.TreeView treeViewSorgente;
        private System.Windows.Forms.Button butNonAssegna;
        private System.Windows.Forms.Button butAssegna;
        private System.Windows.Forms.TextBox textBoxSmistati;
        private System.Windows.Forms.Button butSmistati;
        private System.Windows.Forms.Button butExplorerAcquisire;
        private System.Windows.Forms.Button butExplorerSmistare;
        private System.Windows.Forms.Button butExplorerSmistati;
    }
}
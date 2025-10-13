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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Nodo1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Nodo2");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nodo5");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nodo4", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nodo3", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Nodo0", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode5});
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.textBoxDebug2 = new System.Windows.Forms.TextBox();
            this.textBoxSorgente = new System.Windows.Forms.TextBox();
            this.textBoxDestinazione = new System.Windows.Forms.TextBox();
            this.butSorgente = new System.Windows.Forms.Button();
            this.butApri = new System.Windows.Forms.Button();
            this.butDestinazione = new System.Windows.Forms.Button();
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
            // groupBoxPath
            // 
            this.groupBoxPath.Controls.Add(this.textBoxDebug2);
            this.groupBoxPath.Controls.Add(this.textBoxSorgente);
            this.groupBoxPath.Controls.Add(this.textBoxDestinazione);
            this.groupBoxPath.Controls.Add(this.butSorgente);
            this.groupBoxPath.Controls.Add(this.butApri);
            this.groupBoxPath.Controls.Add(this.butDestinazione);
            this.groupBoxPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPath.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(890, 90);
            this.groupBoxPath.TabIndex = 13;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Selezione di sorgente e destinazione";
            // 
            // textBoxDebug2
            // 
            this.textBoxDebug2.Location = new System.Drawing.Point(13, 60);
            this.textBoxDebug2.Name = "textBoxDebug2";
            this.textBoxDebug2.Size = new System.Drawing.Size(59, 20);
            this.textBoxDebug2.TabIndex = 13;
            // 
            // textBoxSorgente
            // 
            this.textBoxSorgente.Location = new System.Drawing.Point(172, 29);
            this.textBoxSorgente.Name = "textBoxSorgente";
            this.textBoxSorgente.Size = new System.Drawing.Size(706, 20);
            this.textBoxSorgente.TabIndex = 10;
            this.textBoxSorgente.TextChanged += new System.EventHandler(this.textBoxSorgente_TextChanged);
            // 
            // textBoxDestinazione
            // 
            this.textBoxDestinazione.Location = new System.Drawing.Point(172, 55);
            this.textBoxDestinazione.Name = "textBoxDestinazione";
            this.textBoxDestinazione.Size = new System.Drawing.Size(706, 20);
            this.textBoxDestinazione.TabIndex = 12;
            this.textBoxDestinazione.TextChanged += new System.EventHandler(this.textBoxDestinazione_TextChanged);
            // 
            // butSorgente
            // 
            this.butSorgente.Location = new System.Drawing.Point(80, 27);
            this.butSorgente.Name = "butSorgente";
            this.butSorgente.Size = new System.Drawing.Size(86, 23);
            this.butSorgente.TabIndex = 9;
            this.butSorgente.Text = "Sorgente";
            this.butSorgente.UseVisualStyleBackColor = true;
            this.butSorgente.Click += new System.EventHandler(this.butSorgente_Click);
            // 
            // butApri
            // 
            this.butApri.Location = new System.Drawing.Point(10, 27);
            this.butApri.Name = "butApri";
            this.butApri.Size = new System.Drawing.Size(63, 23);
            this.butApri.TabIndex = 5;
            this.butApri.Text = "Apri";
            this.butApri.UseVisualStyleBackColor = true;
            this.butApri.Click += new System.EventHandler(this.butApri_Click);
            // 
            // butDestinazione
            // 
            this.butDestinazione.Location = new System.Drawing.Point(80, 56);
            this.butDestinazione.Name = "butDestinazione";
            this.butDestinazione.Size = new System.Drawing.Size(86, 23);
            this.butDestinazione.TabIndex = 11;
            this.butDestinazione.Text = "Destinazione";
            this.butDestinazione.UseVisualStyleBackColor = true;
            this.butDestinazione.Click += new System.EventHandler(this.butDestinazione_Click);
            // 
            // splitContainer1B2
            // 
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
            this.splitContainer1B2.Size = new System.Drawing.Size(890, 632);
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
            this.splitContainer1B2A3.Size = new System.Drawing.Size(296, 632);
            this.splitContainer1B2A3.SplitterDistance = 145;
            this.splitContainer1B2A3.TabIndex = 0;
            // 
            // groupBoxSorgente
            // 
            this.groupBoxSorgente.Controls.Add(this.treeViewSorgente);
            this.groupBoxSorgente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSorgente.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSorgente.Name = "groupBoxSorgente";
            this.groupBoxSorgente.Size = new System.Drawing.Size(145, 632);
            this.groupBoxSorgente.TabIndex = 0;
            this.groupBoxSorgente.TabStop = false;
            this.groupBoxSorgente.Text = "Sorgente";
            // 
            // treeViewSorgente
            // 
            this.treeViewSorgente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewSorgente.Location = new System.Drawing.Point(3, 16);
            this.treeViewSorgente.Name = "treeViewSorgente";
            this.treeViewSorgente.Size = new System.Drawing.Size(139, 613);
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
            this.groupBoxDestinazione.Size = new System.Drawing.Size(147, 632);
            this.groupBoxDestinazione.TabIndex = 0;
            this.groupBoxDestinazione.TabStop = false;
            this.groupBoxDestinazione.Text = "Destinazione";
            // 
            // treeViewDestinazione
            // 
            this.treeViewDestinazione.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewDestinazione.Location = new System.Drawing.Point(3, 16);
            this.treeViewDestinazione.Name = "treeViewDestinazione";
            treeNode1.Name = "Nodo1";
            treeNode1.Text = "Nodo1";
            treeNode2.Name = "Nodo2";
            treeNode2.Text = "Nodo2";
            treeNode3.Name = "Nodo5";
            treeNode3.Text = "Nodo5";
            treeNode4.Name = "Nodo4";
            treeNode4.Text = "Nodo4";
            treeNode5.Name = "Nodo3";
            treeNode5.Text = "Nodo3";
            treeNode6.Name = "Nodo0";
            treeNode6.Text = "Nodo0";
            this.treeViewDestinazione.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeViewDestinazione.Size = new System.Drawing.Size(141, 613);
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
        private System.Windows.Forms.SplitContainer splitContainer1B2A3;
        private System.Windows.Forms.GroupBox groupBoxDestinazione;
        private System.Windows.Forms.GroupBox groupBoxSorgente;
        private System.Windows.Forms.TreeView treeViewDestinazione;
        private System.Windows.Forms.TextBox textBoxDebug;
        private System.Windows.Forms.TreeView treeViewSorgente;
        private System.Windows.Forms.TextBox textBoxDebug2;
        private System.Windows.Forms.Button butNonAssegna;
        private System.Windows.Forms.Button butAssegna;
    }
}
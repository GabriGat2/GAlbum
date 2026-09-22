namespace GAlbum
{
    partial class FormAggiornaArgomenti
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
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Nodo1");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("Nodo2");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("Nodo5");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("Nodo4", new System.Windows.Forms.TreeNode[] {
            treeNode39});
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Nodo3", new System.Windows.Forms.TreeNode[] {
            treeNode40});
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("Nodo0", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38,
            treeNode41});
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("Nodo1");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("Nodo2");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Nodo5");
            System.Windows.Forms.TreeNode treeNode46 = new System.Windows.Forms.TreeNode("Nodo4", new System.Windows.Forms.TreeNode[] {
            treeNode45});
            System.Windows.Forms.TreeNode treeNode47 = new System.Windows.Forms.TreeNode("Nodo3", new System.Windows.Forms.TreeNode[] {
            treeNode46});
            System.Windows.Forms.TreeNode treeNode48 = new System.Windows.Forms.TreeNode("Nodo0", new System.Windows.Forms.TreeNode[] {
            treeNode43,
            treeNode44,
            treeNode47});
            this.splitContainer1B2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxSmistare = new System.Windows.Forms.GroupBox();
            this.treeViewSmistare = new System.Windows.Forms.TreeView();
            this.groupBoxArgomenti = new System.Windows.Forms.GroupBox();
            this.treeViewSmistati = new System.Windows.Forms.TreeView();
            this.textBoxDebug = new System.Windows.Forms.TextBox();
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.butEsegui = new System.Windows.Forms.Button();
            this.butExplorerSmistati = new System.Windows.Forms.Button();
            this.butExplorerSmistare = new System.Windows.Forms.Button();
            this.butExplorerAcquisire = new System.Windows.Forms.Button();
            this.textBoxSmistati = new System.Windows.Forms.TextBox();
            this.butSmistati = new System.Windows.Forms.Button();
            this.textBoxAcquisire = new System.Windows.Forms.TextBox();
            this.textBoxSmistare = new System.Windows.Forms.TextBox();
            this.butAcquisire = new System.Windows.Forms.Button();
            this.butSmistare = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1B2)).BeginInit();
            this.splitContainer1B2.Panel1.SuspendLayout();
            this.splitContainer1B2.Panel2.SuspendLayout();
            this.splitContainer1B2.SuspendLayout();
            this.groupBoxSmistare.SuspendLayout();
            this.groupBoxArgomenti.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1B2.Panel1.Controls.Add(this.groupBoxSmistare);
            // 
            // splitContainer1B2.Panel2
            // 
            this.splitContainer1B2.Panel2.Controls.Add(this.groupBoxArgomenti);
            this.splitContainer1B2.Size = new System.Drawing.Size(890, 592);
            this.splitContainer1B2.SplitterDistance = 450;
            this.splitContainer1B2.TabIndex = 0;
            // 
            // groupBoxSmistare
            // 
            this.groupBoxSmistare.Controls.Add(this.treeViewSmistare);
            this.groupBoxSmistare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSmistare.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSmistare.Name = "groupBoxSmistare";
            this.groupBoxSmistare.Size = new System.Drawing.Size(450, 592);
            this.groupBoxSmistare.TabIndex = 0;
            this.groupBoxSmistare.TabStop = false;
            this.groupBoxSmistare.Text = "Smistare";
            // 
            // treeViewSmistare
            // 
            this.treeViewSmistare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewSmistare.Location = new System.Drawing.Point(3, 16);
            this.treeViewSmistare.Name = "treeViewSmistare";
            treeNode37.Name = "Nodo1";
            treeNode37.Text = "Nodo1";
            treeNode38.Name = "Nodo2";
            treeNode38.Text = "Nodo2";
            treeNode39.Name = "Nodo5";
            treeNode39.Text = "Nodo5";
            treeNode40.Name = "Nodo4";
            treeNode40.Text = "Nodo4";
            treeNode41.Name = "Nodo3";
            treeNode41.Text = "Nodo3";
            treeNode42.Name = "Nodo0";
            treeNode42.Text = "Nodo0";
            this.treeViewSmistare.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode42});
            this.treeViewSmistare.Size = new System.Drawing.Size(444, 573);
            this.treeViewSmistare.TabIndex = 0;
            this.treeViewSmistare.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSmistare_AfterSelect);
            this.treeViewSmistare.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeViewSmistare_MouseDoubleClick);
            // 
            // groupBoxArgomenti
            // 
            this.groupBoxArgomenti.Controls.Add(this.treeViewSmistati);
            this.groupBoxArgomenti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxArgomenti.Location = new System.Drawing.Point(0, 0);
            this.groupBoxArgomenti.Name = "groupBoxArgomenti";
            this.groupBoxArgomenti.Size = new System.Drawing.Size(436, 592);
            this.groupBoxArgomenti.TabIndex = 2;
            this.groupBoxArgomenti.TabStop = false;
            this.groupBoxArgomenti.Text = "Smistare-Argomenti";
            // 
            // treeViewSmistati
            // 
            this.treeViewSmistati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewSmistati.Location = new System.Drawing.Point(3, 16);
            this.treeViewSmistati.Name = "treeViewSmistati";
            treeNode43.Name = "Nodo1";
            treeNode43.Text = "Nodo1";
            treeNode44.Name = "Nodo2";
            treeNode44.Text = "Nodo2";
            treeNode45.Name = "Nodo5";
            treeNode45.Text = "Nodo5";
            treeNode46.Name = "Nodo4";
            treeNode46.Text = "Nodo4";
            treeNode47.Name = "Nodo3";
            treeNode47.Text = "Nodo3";
            treeNode48.Name = "Nodo0";
            treeNode48.Text = "Nodo0";
            this.treeViewSmistati.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode48});
            this.treeViewSmistati.Size = new System.Drawing.Size(430, 573);
            this.treeViewSmistati.TabIndex = 0;
            this.treeViewSmistati.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewSmistati_AfterSelect);
            this.treeViewSmistati.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeViewSmistati_MouseDoubleClick);
            // 
            // textBoxDebug
            // 
            this.textBoxDebug.Location = new System.Drawing.Point(532, 37);
            this.textBoxDebug.Name = "textBoxDebug";
            this.textBoxDebug.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxDebug.Size = new System.Drawing.Size(46, 20);
            this.textBoxDebug.TabIndex = 9;
            // 
            // groupBoxPath
            // 
            this.groupBoxPath.Controls.Add(this.progressBar1);
            this.groupBoxPath.Controls.Add(this.butEsegui);
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
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(10, 105);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(847, 19);
            this.progressBar1.TabIndex = 21;
            this.progressBar1.Visible = false;
            // 
            // butEsegui
            // 
            this.butEsegui.Location = new System.Drawing.Point(6, 21);
            this.butEsegui.Name = "butEsegui";
            this.butEsegui.Size = new System.Drawing.Size(86, 23);
            this.butEsegui.TabIndex = 19;
            this.butEsegui.Text = "Esegui";
            this.butEsegui.UseVisualStyleBackColor = true;
            this.butEsegui.Click += new System.EventHandler(this.butEsegui_Click);
            // 
            // butExplorerSmistati
            // 
            this.butExplorerSmistati.Location = new System.Drawing.Point(863, 77);
            this.butExplorerSmistati.Name = "butExplorerSmistati";
            this.butExplorerSmistati.Size = new System.Drawing.Size(17, 23);
            this.butExplorerSmistati.TabIndex = 18;
            this.butExplorerSmistati.Text = "E";
            this.butExplorerSmistati.UseVisualStyleBackColor = true;
            this.butExplorerSmistati.Click += new System.EventHandler(this.butExplorerSmistati_Click);
            // 
            // butExplorerSmistare
            // 
            this.butExplorerSmistare.Location = new System.Drawing.Point(863, 47);
            this.butExplorerSmistare.Name = "butExplorerSmistare";
            this.butExplorerSmistare.Size = new System.Drawing.Size(17, 23);
            this.butExplorerSmistare.TabIndex = 17;
            this.butExplorerSmistare.Text = "E";
            this.butExplorerSmistare.UseVisualStyleBackColor = true;
            this.butExplorerSmistare.Click += new System.EventHandler(this.butExplorerSmistare_Click);
            // 
            // butExplorerAcquisire
            // 
            this.butExplorerAcquisire.Location = new System.Drawing.Point(863, 21);
            this.butExplorerAcquisire.Name = "butExplorerAcquisire";
            this.butExplorerAcquisire.Size = new System.Drawing.Size(17, 23);
            this.butExplorerAcquisire.TabIndex = 16;
            this.butExplorerAcquisire.Text = "E";
            this.butExplorerAcquisire.UseVisualStyleBackColor = true;
            this.butExplorerAcquisire.Click += new System.EventHandler(this.butExplorerAcquisire_Click);
            // 
            // textBoxSmistati
            // 
            this.textBoxSmistati.Location = new System.Drawing.Point(193, 79);
            this.textBoxSmistati.Name = "textBoxSmistati";
            this.textBoxSmistati.ReadOnly = true;
            this.textBoxSmistati.Size = new System.Drawing.Size(664, 20);
            this.textBoxSmistati.TabIndex = 14;
            // 
            // butSmistati
            // 
            this.butSmistati.Location = new System.Drawing.Point(101, 77);
            this.butSmistati.Name = "butSmistati";
            this.butSmistati.Size = new System.Drawing.Size(86, 23);
            this.butSmistati.TabIndex = 13;
            this.butSmistati.Text = "Smistare 2";
            this.butSmistati.UseVisualStyleBackColor = true;
            this.butSmistati.Click += new System.EventHandler(this.butSmistati_Click);
            // 
            // textBoxAcquisire
            // 
            this.textBoxAcquisire.Location = new System.Drawing.Point(193, 21);
            this.textBoxAcquisire.Name = "textBoxAcquisire";
            this.textBoxAcquisire.ReadOnly = true;
            this.textBoxAcquisire.Size = new System.Drawing.Size(664, 20);
            this.textBoxAcquisire.TabIndex = 10;
            this.textBoxAcquisire.TextChanged += new System.EventHandler(this.textBoxAcquisire_TextChanged);
            // 
            // textBoxSmistare
            // 
            this.textBoxSmistare.Location = new System.Drawing.Point(193, 50);
            this.textBoxSmistare.Name = "textBoxSmistare";
            this.textBoxSmistare.ReadOnly = true;
            this.textBoxSmistare.Size = new System.Drawing.Size(664, 20);
            this.textBoxSmistare.TabIndex = 12;
            this.textBoxSmistare.TextChanged += new System.EventHandler(this.textBoxSmistare_TextChanged);
            // 
            // butAcquisire
            // 
            this.butAcquisire.Location = new System.Drawing.Point(101, 19);
            this.butAcquisire.Name = "butAcquisire";
            this.butAcquisire.Size = new System.Drawing.Size(86, 23);
            this.butAcquisire.TabIndex = 9;
            this.butAcquisire.Text = "Acquisire";
            this.butAcquisire.UseVisualStyleBackColor = true;
            this.butAcquisire.Click += new System.EventHandler(this.butAcquisire_Click);
            // 
            // butSmistare
            // 
            this.butSmistare.Location = new System.Drawing.Point(101, 48);
            this.butSmistare.Name = "butSmistare";
            this.butSmistare.Size = new System.Drawing.Size(86, 23);
            this.butSmistare.TabIndex = 11;
            this.butSmistare.Text = "Smistare";
            this.butSmistare.UseVisualStyleBackColor = true;
            this.butSmistare.Click += new System.EventHandler(this.butSmistare_Click);
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
            // FormAggiornaArgomenti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 726);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormAggiornaArgomenti";
            this.Text = "Aggiorna Argomenti";
            this.splitContainer1B2.Panel1.ResumeLayout(false);
            this.splitContainer1B2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1B2)).EndInit();
            this.splitContainer1B2.ResumeLayout(false);
            this.groupBoxSmistare.ResumeLayout(false);
            this.groupBoxArgomenti.ResumeLayout(false);
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1B2;
        private System.Windows.Forms.SplitContainer splitContainer1B2A3;
        private System.Windows.Forms.SplitContainer splitContainer1B2A3B4;
        private System.Windows.Forms.GroupBox groupBoxSmistare;
        private System.Windows.Forms.TreeView treeViewSmistare;
        private System.Windows.Forms.GroupBox groupBoxArgomenti;
        private System.Windows.Forms.TreeView treeViewSmistati;
        private System.Windows.Forms.SplitContainer splitContainer1B2B3;
        private System.Windows.Forms.TextBox textBoxDebug;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button butEsegui;
        private System.Windows.Forms.Button butExplorerSmistati;
        private System.Windows.Forms.Button butExplorerSmistare;
        private System.Windows.Forms.Button butExplorerAcquisire;
        private System.Windows.Forms.TextBox textBoxSmistati;
        private System.Windows.Forms.Button butSmistati;
        private System.Windows.Forms.TextBox textBoxAcquisire;
        private System.Windows.Forms.TextBox textBoxSmistare;
        private System.Windows.Forms.Button butAcquisire;
        private System.Windows.Forms.Button butSmistare;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}
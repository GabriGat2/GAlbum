namespace GAlbum
{
    partial class FormAreaArchivio
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
            this.groupBoxPath = new System.Windows.Forms.GroupBox();
            this.textAreaArchivioBase = new System.Windows.Forms.TextBox();
            this.butAreaArchivioBase = new System.Windows.Forms.Button();
            this.butNuova = new System.Windows.Forms.Button();
            this.splitContainer1B2 = new System.Windows.Forms.SplitContainer();
            this.groupBoxAreeArchivio = new System.Windows.Forms.GroupBox();
            this.treeViewAreeArchivio = new System.Windows.Forms.TreeView();
            this.textBoxAreaArchivio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1B2)).BeginInit();
            this.splitContainer1B2.Panel1.SuspendLayout();
            this.splitContainer1B2.SuspendLayout();
            this.groupBoxAreeArchivio.SuspendLayout();
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
            this.groupBoxPath.Controls.Add(this.textBoxAreaArchivio);
            this.groupBoxPath.Controls.Add(this.textAreaArchivioBase);
            this.groupBoxPath.Controls.Add(this.butAreaArchivioBase);
            this.groupBoxPath.Controls.Add(this.butNuova);
            this.groupBoxPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPath.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(890, 90);
            this.groupBoxPath.TabIndex = 14;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Selezione di sorgente e destinazione";
            // 
            // textAreaArchivioBase
            // 
            this.textAreaArchivioBase.Location = new System.Drawing.Point(172, 29);
            this.textAreaArchivioBase.Name = "textAreaArchivioBase";
            this.textAreaArchivioBase.Size = new System.Drawing.Size(706, 20);
            this.textAreaArchivioBase.TabIndex = 10;
            // 
            // butAreaArchivioBase
            // 
            this.butAreaArchivioBase.Location = new System.Drawing.Point(6, 27);
            this.butAreaArchivioBase.Name = "butAreaArchivioBase";
            this.butAreaArchivioBase.Size = new System.Drawing.Size(160, 23);
            this.butAreaArchivioBase.TabIndex = 9;
            this.butAreaArchivioBase.Text = "Area Archivio Base";
            this.butAreaArchivioBase.UseVisualStyleBackColor = true;
            this.butAreaArchivioBase.Click += new System.EventHandler(this.butAreaArchivioBase_Click);
            // 
            // butNuova
            // 
            this.butNuova.Location = new System.Drawing.Point(6, 52);
            this.butNuova.Name = "butNuova";
            this.butNuova.Size = new System.Drawing.Size(160, 23);
            this.butNuova.TabIndex = 5;
            this.butNuova.Text = "Nuova";
            this.butNuova.UseVisualStyleBackColor = true;
            this.butNuova.Click += new System.EventHandler(this.butNuova_Click);
            // 
            // splitContainer1B2
            // 
            this.splitContainer1B2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1B2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1B2.Name = "splitContainer1B2";
            // 
            // splitContainer1B2.Panel1
            // 
            this.splitContainer1B2.Panel1.Controls.Add(this.groupBoxAreeArchivio);
            this.splitContainer1B2.Size = new System.Drawing.Size(890, 632);
            this.splitContainer1B2.SplitterDistance = 296;
            this.splitContainer1B2.TabIndex = 0;
            // 
            // groupBoxAreeArchivio
            // 
            this.groupBoxAreeArchivio.Controls.Add(this.treeViewAreeArchivio);
            this.groupBoxAreeArchivio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAreeArchivio.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAreeArchivio.Name = "groupBoxAreeArchivio";
            this.groupBoxAreeArchivio.Size = new System.Drawing.Size(296, 632);
            this.groupBoxAreeArchivio.TabIndex = 1;
            this.groupBoxAreeArchivio.TabStop = false;
            this.groupBoxAreeArchivio.Text = "Aree Archivio";
            // 
            // treeViewAreeArchivio
            // 
            this.treeViewAreeArchivio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewAreeArchivio.Location = new System.Drawing.Point(3, 16);
            this.treeViewAreeArchivio.Name = "treeViewAreeArchivio";
            this.treeViewAreeArchivio.Size = new System.Drawing.Size(290, 613);
            this.treeViewAreeArchivio.TabIndex = 0;
            // 
            // textBoxAreaArchivio
            // 
            this.textBoxAreaArchivio.Location = new System.Drawing.Point(172, 55);
            this.textBoxAreaArchivio.Name = "textBoxAreaArchivio";
            this.textBoxAreaArchivio.Size = new System.Drawing.Size(706, 20);
            this.textBoxAreaArchivio.TabIndex = 11;
            // 
            // FormAreaArchivio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 726);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormAreaArchivio";
            this.Text = "FormAmbiente";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxPath.ResumeLayout(false);
            this.groupBoxPath.PerformLayout();
            this.splitContainer1B2.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1B2)).EndInit();
            this.splitContainer1B2.ResumeLayout(false);
            this.groupBoxAreeArchivio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.TextBox textAreaArchivioBase;
        private System.Windows.Forms.Button butAreaArchivioBase;
        private System.Windows.Forms.Button butNuova;
        private System.Windows.Forms.SplitContainer splitContainer1B2;
        private System.Windows.Forms.GroupBox groupBoxAreeArchivio;
        private System.Windows.Forms.TreeView treeViewAreeArchivio;
        private System.Windows.Forms.TextBox textBoxAreaArchivio;
    }
}
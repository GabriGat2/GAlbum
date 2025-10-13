namespace GAlbum
{
    partial class FormAmbiente
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
            this.textBoxSorgente = new System.Windows.Forms.TextBox();
            this.butSorgente = new System.Windows.Forms.Button();
            this.butApri = new System.Windows.Forms.Button();
            this.splitContainer1B2 = new System.Windows.Forms.SplitContainer();
            this.treeViewSorgente = new System.Windows.Forms.TreeView();
            this.groupBoxAmbienti = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1B2)).BeginInit();
            this.splitContainer1B2.Panel1.SuspendLayout();
            this.splitContainer1B2.SuspendLayout();
            this.groupBoxAmbienti.SuspendLayout();
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
            this.groupBoxPath.Controls.Add(this.textBoxSorgente);
            this.groupBoxPath.Controls.Add(this.butSorgente);
            this.groupBoxPath.Controls.Add(this.butApri);
            this.groupBoxPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPath.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPath.Name = "groupBoxPath";
            this.groupBoxPath.Size = new System.Drawing.Size(890, 90);
            this.groupBoxPath.TabIndex = 14;
            this.groupBoxPath.TabStop = false;
            this.groupBoxPath.Text = "Selezione di sorgente e destinazione";
            // 
            // textBoxSorgente
            // 
            this.textBoxSorgente.Location = new System.Drawing.Point(172, 29);
            this.textBoxSorgente.Name = "textBoxSorgente";
            this.textBoxSorgente.Size = new System.Drawing.Size(706, 20);
            this.textBoxSorgente.TabIndex = 10;
            // 
            // butSorgente
            // 
            this.butSorgente.Location = new System.Drawing.Point(80, 27);
            this.butSorgente.Name = "butSorgente";
            this.butSorgente.Size = new System.Drawing.Size(86, 23);
            this.butSorgente.TabIndex = 9;
            this.butSorgente.Text = "Sorgente";
            this.butSorgente.UseVisualStyleBackColor = true;
            // 
            // butApri
            // 
            this.butApri.Location = new System.Drawing.Point(10, 27);
            this.butApri.Name = "butApri";
            this.butApri.Size = new System.Drawing.Size(63, 23);
            this.butApri.TabIndex = 5;
            this.butApri.Text = "Apri";
            this.butApri.UseVisualStyleBackColor = true;
            // 
            // splitContainer1B2
            // 
            this.splitContainer1B2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1B2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1B2.Name = "splitContainer1B2";
            // 
            // splitContainer1B2.Panel1
            // 
            this.splitContainer1B2.Panel1.Controls.Add(this.groupBoxAmbienti);
            this.splitContainer1B2.Size = new System.Drawing.Size(890, 632);
            this.splitContainer1B2.SplitterDistance = 296;
            this.splitContainer1B2.TabIndex = 0;
            // 
            // treeViewSorgente
            // 
            this.treeViewSorgente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewSorgente.Location = new System.Drawing.Point(3, 16);
            this.treeViewSorgente.Name = "treeViewSorgente";
            this.treeViewSorgente.Size = new System.Drawing.Size(290, 613);
            this.treeViewSorgente.TabIndex = 0;
            // 
            // groupBoxAmbienti
            // 
            this.groupBoxAmbienti.Controls.Add(this.treeViewSorgente);
            this.groupBoxAmbienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAmbienti.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAmbienti.Name = "groupBoxAmbienti";
            this.groupBoxAmbienti.Size = new System.Drawing.Size(296, 632);
            this.groupBoxAmbienti.TabIndex = 1;
            this.groupBoxAmbienti.TabStop = false;
            this.groupBoxAmbienti.Text = "Ambienti";
            // 
            // FormAmbiente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 726);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormAmbiente";
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
            this.groupBoxAmbienti.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBoxPath;
        private System.Windows.Forms.TextBox textBoxSorgente;
        private System.Windows.Forms.Button butSorgente;
        private System.Windows.Forms.Button butApri;
        private System.Windows.Forms.SplitContainer splitContainer1B2;
        private System.Windows.Forms.GroupBox groupBoxAmbienti;
        private System.Windows.Forms.TreeView treeViewSorgente;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAlbum
{
    public partial class FormLog : Form
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================

        public string Log { set => richTextBoxLog.AppendText(value); } 



        // ==================================================================================================================
        /// <summary>
        /// Mette qui i refatoring generati automaticamente
        /// </summary>
        private bool mettiloQui;
        public bool MettiloQui { get => mettiloQui; set => mettiloQui = value; }





        // ==================================================================================================================
        // Metodi
        // ==================================================================================================================
        /// <summary>
        /// costruttore
        /// </summary>
        public FormLog()
        {
            InitializeComponent();
        }
        /// <summary>
        ///  Chiudel la dialog
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buOK_Click(object sender, EventArgs e)
        {
            Close();
        }
    } // fine class FormLog
} // fine namespace GAlbum

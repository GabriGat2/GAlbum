using System;
using System.Windows.Forms;

namespace GAlbum
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Costruttore
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Attiva il form per selezionare le foto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSelezione_Click(object sender, EventArgs e)
        {
            FormSelezione formSelezione = new FormSelezione();
            formSelezione.ShowDialog();


        }
        // attiva il form per selezionare le foto
        private void ButSelezioneFoto_Click(object sender, EventArgs e)
        {
            FormSelezioneFoto dlg = new FormSelezioneFoto();
            dlg.ShowDialog();
        }
    }
}

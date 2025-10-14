using System;
using System.Windows.Forms;

namespace GAlbum
{
    public partial class FormMain : Form
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================
        public CAreaArchivio AreaArchivio = new CAreaArchivio();


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
        /// <summary>
        /// Attiva il form per selezionare l'area archivio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAreaArchivio_Click(object sender, EventArgs e)
        {
            FormAreaArchivio dlg = new FormAreaArchivio(ref this.AreaArchivio);
            dlg.ShowDialog();

        }



    }// fine class FormMain
}// fine namespace GAlbum


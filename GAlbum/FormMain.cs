using System;
using System.Drawing;
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
            InizializzaClasse();
        }
        /// <summary>
        /// inizializza la classe
        /// </summary>
        private void InizializzaClasse()
        {
            AggiornaForm();
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

            // aggiorna form
            AggiornaForm();

        }
        /// <summary>
        /// aggiorna il form 
        /// </summary>
        private void AggiornaForm()
        {
            // archivio base
            textBoxAreaArchivioBase.Text = AreaArchivio.DirArchivioBase;
            textBoxPathAreaArchivioBase.Text = AreaArchivio.PathArchivioBase;
            if (AreaArchivio.ArchivioBaseOK)
            {
                textBoxAreaArchivioBase.BackColor = Color.LightGreen;
                textBoxPathAreaArchivioBase.BackColor = Color.LightGreen;
            }
            else
            {
                textBoxAreaArchivioBase.BackColor = Color.LightPink;
                textBoxPathAreaArchivioBase.BackColor = Color.LightPink;
            }

            // Archivio attivo
            textBoxArchivioAttivo.Text = AreaArchivio.DirArchivioAttivo;
            textBoxPathArchivioAttivo.Text = AreaArchivio.PathArchivioAttivo;
            if (AreaArchivio.ArchivioAttivoOK)
            {
                textBoxArchivioAttivo.BackColor = Color.LightGreen;
                textBoxPathArchivioAttivo.BackColor = Color.LightGreen;

                ButSelezioneFoto.Enabled = true;
            }
            else
            {
                textBoxArchivioAttivo.BackColor = Color.LightPink;
                textBoxPathArchivioAttivo.BackColor = Color.LightPink;

                ButSelezioneFoto.Enabled = false;
            }


            butSelezione.Enabled = false;


        }

    }// fine class FormMain
}// fine namespace GAlbum


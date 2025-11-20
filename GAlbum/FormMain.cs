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
        // attiva il form per selezionare le foto
        private void ButSelezioneFoto_Click(object sender, EventArgs e)
        {
            FormSelezioneFoto dlg = new FormSelezioneFoto(ref this.AreaArchivio);
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

                groupBoxOperazioni.Enabled = true;
                //ButSelezioneFoto.Enabled = true;
            }
            else
            {
                textBoxArchivioAttivo.BackColor = Color.LightPink;
                textBoxPathArchivioAttivo.BackColor = Color.LightPink;

                groupBoxOperazioni.Enabled = false;
                //ButSelezioneFoto.Enabled = false;
            }
        }
        /// <summary>
        /// Apre in exprorer l'archivio base
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butExplorerArchvioBase_Click(object sender, EventArgs e)
        {
            // recupera il path dell'escursione e avvia explore
            if (AreaArchivio.ArchivioBaseOK)
                ApreExplorer(AreaArchivio.PathArchivioBase);
        }
        /// <summary>
        /// Avvia explorer dal path specificato
        /// </summary>
        /// <param name="path"></param>
        private void ApreExplorer(string path)
        {
            string target = "Explorer";

            try
            {
                System.Diagnostics.Process.Start(target, path);
            }
            catch (System.ComponentModel.Win32Exception noBrowser)
            {
                if (noBrowser.ErrorCode == -2147467259)
                    MessageBox.Show(noBrowser.Message);
            }
            catch (System.Exception other)
            {
                MessageBox.Show(other.Message);
            }

        }
        /// <summary>
        /// Apre in exprorer l'archivio attivo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butExplorerArchvioAttivo_Click(object sender, EventArgs e)
        {
            // recupera il path dell'escursione e avvia explore
            if(AreaArchivio.ArchivioAttivoOK)
                ApreExplorer(AreaArchivio.PathArchivioAttivo);

        }
        /// <summary>
        /// Attiva il form per acquisire foto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAcquisire_Click(object sender, EventArgs e)
        {
            FormAcquisire dlg = new FormAcquisire(ref this.AreaArchivio);
            dlg.ShowDialog();
        }
        /// <summary>
        /// Attiva il form per selezione data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSelezioneData_Click(object sender, EventArgs e)
        {
            FormSelezionaPerData formSelezionaPerData = new FormSelezionaPerData(ref this.AreaArchivio);
            formSelezionaPerData.ShowDialog();
        }
    }// fine class FormMain
}// fine namespace GAlbum


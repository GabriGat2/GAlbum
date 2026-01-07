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
    public partial class FormConfigTreeView : Form
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================
        private CInfoTreeView InfoTV;

        // ==================================================================================================================
        // Metodi
        // ==================================================================================================================
        public FormConfigTreeView(ref CInfoTreeView infoTV)
        {
             // assegna riferimento alla info treeView
            InfoTV = infoTV;           
            
            
            InitializeComponent();
            inizializzaClasse();


        }
        /// <summary>
        /// inizializza classe
        /// </summary>
        private void inizializzaClasse()
        {
            // mostra il tipo della info tree view
            this.Text = "Configurazione dell'info " + InfoTV.TipoTreeView.ToString();

            // inizializa pannello visualizzazione
            AggiornaForm();
        }
        /// <summary>
        /// Aggiorna tutti gli oggetti del form
        /// </summary>
        private void AggiornaForm()
        {
            // inizializa pannello visualizzazione
            this.checkBoxFoglie.Checked = InfoTV.MostraFoglie;
            this.checkBoxRami.Checked = InfoTV.MostraRami;
            this.checkBoxRamiRiservati.Checked = InfoTV.MostraRamiRiservati;
            this.numericUpDownLivello.Value = InfoTV.MaxLivello;

            // inizializa pannello archivia
            this.checkBoxCopiaParallela.Checked = InfoTV.CopiaParallela;
        }
        /// <summary>
        /// é cambiata la check box mostra stati 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxRami_CheckedChanged(object sender, EventArgs e)
        {
            InfoTV.MostraRami = this.checkBoxRami.Checked;
        }
        /// <summary>
        /// é cambiata la check box mostra stati 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxFoglie_CheckedChanged(object sender, EventArgs e)
        {
            InfoTV.MostraFoglie = this.checkBoxFoglie.Checked;
        }
        /// <summary>
        /// é cambiata la check box mostra stati 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxRamiRiservati_CheckedChanged(object sender, EventArgs e)
        {
            InfoTV.MostraRamiRiservati = this.checkBoxRamiRiservati.Checked;
        }
        /// <summary>
        /// Riassegna i valori di default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butDefault_Click(object sender, EventArgs e)
        {
            InfoTV.RipristinaDefault();
            AggiornaForm();
        }
        /// <summary>
        /// il valore del livello é cambiato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void numericUpDownLivello_ValueChanged(object sender, EventArgs e)
        {
            InfoTV.MaxLivello = ((uint)numericUpDownLivello.Value);
        }
        /// <summary>
        /// il valore di copia parallela é cambiato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxCopiaParallela_CheckedChanged(object sender, EventArgs e)
        {
            InfoTV.CopiaParallela = this .checkBoxCopiaParallela.Checked;
        }
    }// fine class  FormConfigTreeView
}// fine namespace GAlbum

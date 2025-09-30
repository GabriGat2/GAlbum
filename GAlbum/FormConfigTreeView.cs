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
        private CInfoTreeView InfoTW;

        // ==================================================================================================================
        // Metodi
        // ==================================================================================================================
        public FormConfigTreeView(ref CInfoTreeView infoTW)
        {
             // assegna riferimento alla info treeView
            InfoTW = infoTW;           
            
            
            InitializeComponent();
            inizializzaClasse();


        }
        /// <summary>
        /// inizializza classe
        /// </summary>
        private void inizializzaClasse()
        {
            // mostra il tipo della info tree view
            this.Text = "Configurazione dell'info " + InfoTW.TipoTreeView.ToString();

            // inizializa pannello visualizzazione
            AggiornaForm();
        }
        /// <summary>
        /// Aggiorna tutti gli oggetti del form
        /// </summary>
        private void AggiornaForm()
        {
            // inizializa pannello visualizzazione
            this.checkBoxFoglie.Checked = InfoTW.MostraFoglie;
            this.checkBoxRami.Checked = InfoTW.MostraRami;
            this.checkBoxRamiRiservati.Checked = InfoTW.MostraRamiRiservati;
        }
        /// <summary>
        /// é cambiata la check box mostra stati 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxRami_CheckedChanged(object sender, EventArgs e)
        {
            InfoTW.MostraRami = this.checkBoxRami.Checked;
        }
        /// <summary>
        /// é cambiata la check box mostra stati 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxFoglie_CheckedChanged(object sender, EventArgs e)
        {
            InfoTW.MostraFoglie = this.checkBoxFoglie.Checked;
        }
        /// <summary>
        /// é cambiata la check box mostra stati 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxRamiRiservati_CheckedChanged(object sender, EventArgs e)
        {
            InfoTW.MostraRamiRiservati = this.checkBoxRamiRiservati.Checked;
        }
        /// <summary>
        /// Riassegna i valori di default
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butDefault_Click(object sender, EventArgs e)
        {
            InfoTW.RipristinaDefault();
            AggiornaForm();
        }
    }// fine class  FormConfigTreeView
}// fine namespace GAlbum

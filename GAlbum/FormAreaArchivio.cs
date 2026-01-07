using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;

namespace GAlbum
{
    public partial class FormAreaArchivio : Form
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================
        /// <summary>
        /// riferiemnto all'area archivio
        /// </summary>
        protected CAreaArchivio AreaArchivio = null;

        /// <summary>
        /// Nodo sorgente selezionato
        /// </summary>
        private CInfoDirFoto InfoNodoSelezionato;

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
        public FormAreaArchivio(ref CAreaArchivio areaArchivio)
        {
            // Assegna il riferimento a AreaArchivio
            this.AreaArchivio = areaArchivio;

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
        /// eleziono l'area archivio che contiene gli archivi delle foto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAreaArchivioBase_Click(object sender, EventArgs e)
        {
            string path = string.Empty;

           
            // seleziona la direcory dell'area archivio
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.SelectedPath = this.AreaArchivio.PathArchivioBase;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                this.AreaArchivio.PathArchivioBase = dlg.SelectedPath;
                AggiornaForm(); 
            }

        }
        /// <summary>
        /// crea una nuova area archivio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butNuova_Click(object sender, EventArgs e)
        {
            // estra il nome dell'archivio
            string dirArchivio = textBoxArchivioSelezionato.Text;

            // verifica se esiste
            if (! AreaArchivio.VerificaNomeArchivioSelezionato(dirArchivio))
            {
                //  l'Archivio non esiste chiede conferma per crearlo
                string titolo = " Archivio non esiste";
                string messaggio = "L'archivio " + dirArchivio + " NON esiste! \n\n Vuoi crearlo?";

                var result = MessageBox.Show(messaggio, titolo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    GstErrori.StampaMessaggioErrore(GstErrori.EErrore.E1388_FileArchivioNonCreato);
                    return;

                }

                // crea l'archivio
                GstErrori.EErrore esito = AreaArchivio.CreaAreaArchivio(textBoxArchivioSelezionato.Text);
                if (esito != GstErrori.EErrore.E0000_OK)
                {
                    GstErrori.StampaMessaggioErrore(esito);
                    return;
                } 
            }

            // Attiva l'archivio selezionato
            AreaArchivio.DirArchivioAttivo = dirArchivio;

            // Aggiorna il form
            AggiornaForm();

            return;

        }
        /// <summary>
        /// aggiorna la tree view delle aree archivio
        /// </summary>
        private void AggiornaTreeview()
        {
            //// assegna la directory sorgente
            //PathDirAcquisire = textBoxSorgente.Text;

            // verifica che la directory esiste 
            if (!Directory.Exists(AreaArchivio.PathArchivioBase))
            {
                return;
            }

            // Crea la lista delle sub directory
            string[] listaSubDir = Directory.GetDirectories(AreaArchivio.PathArchivioBase);

            //// annulla riferimento InfoNodoSelezionato
            //InfoNodoSelezionato = null;

            // inizia aggiornamnto tree view
            treeViewAreeArchivio.BeginUpdate();

            // Azzera Tree view
            treeViewAreeArchivio.Nodes.Clear();

            // crea classe info dir foto vuota
            CInfoDirFoto info = new CInfoDirFoto("");

            // creiamo il nodo base
            TreeNode nodoBase = new TreeNode("Aree Archivio");
            nodoBase.Tag = info;
            treeViewAreeArchivio.Nodes.Add(nodoBase);

            // Aggiunge un nodo per ogni subdirectory
            foreach (var subDir in listaSubDir)
            {
                AggiungiNodo(subDir, ref nodoBase, 1 /*, ref InfoTVAcqusire */);

            }

            // Espandi il sommario
            treeViewAreeArchivio.ExpandAll();

            // termina aggiornamnto
            treeViewAreeArchivio.EndUpdate();

        }
        /// <summary>
        /// Aggiunge un nodo
        /// </summary>
        /// <param name="pathDir"></param>
        /// <param name="nodoBase"></param>
        /// <param name="livello"></param>
        private void AggiungiNodo(string pathDir, ref TreeNode nodoBase, int livello /* , ref CInfoTreeView infoTV*/) 
        {
            // crea classe info dir foto
            CInfoDirFoto info = new CInfoDirFoto(pathDir);

            // verifichiamo se può essere aggiunta all'albero della tree vie
            //if (!infoTV.NomeVisibile(info.Nome))
            //    return;

            // crea il nodo
            TreeNode nodo = new TreeNode(info.Nome);
            nodo.Tag = info;
            nodoBase.Nodes.Add(nodo);

            // Aggiungiamo il riferimento al nodo all'info
            info.SetNodo(ref nodo);


            // verifica se ha raggiunto il livello di massima indentazione
            return;
            //if (livello >= infoTV.MaxLivello)
            //{
            //    return;
            //}


            // Crea la lista delle sub directory
            try
            {
                string[] listaSubDir = Directory.GetDirectories(pathDir);


                // Aggiunge un nodo per ogni subdirectory
                foreach (var subDir in listaSubDir)
                {
                    AggiungiNodo(subDir, ref nodo, ++livello/*, ref infoTV*/);

                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
        /// <summary>
        /// Seleziona un archivio foto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewAreeArchivio_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // verifica lo stato del form
            //if (StatoInEsecuzione)
            //    return;

            // recuprea il nodo selezionato 
            TreeNode nodo = treeViewAreeArchivio.SelectedNode;


            // Estrae le info della classe 
            CInfoDirFoto info = (CInfoDirFoto)nodo.Tag;

            // mostra il nome dell'archivio selezionato
            textBoxArchivioSelezionato.Text = info.Nome;


            // aggiorna nodo sorgente selezionato 
            AggiornaNodoSorgenteSelezionato(ref info);

            //     // commuta la selezione
            //info.CommutaSelezione();

        }
        /// <summary>
        /// Aggiorna il nodo sorgente selezionato 
        /// </summary>
        /// <param name="infoNodo"></param>
        private void AggiornaNodoSorgenteSelezionato(ref CInfoDirFoto infoNodo)
        {
            // Verifica se il nodo sorgente é assegnato
            if (InfoNodoSelezionato != null)
            {
                InfoNodoSelezionato.Selezione = false;
            }

            // aggiona il nodo sorgente selezionato
            InfoNodoSelezionato = infoNodo;

            // seleziona il nodo
            InfoNodoSelezionato.Selezione = true;
        }
        /// <summary>
        /// Colora opportunamente il campo archivio foto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAreaArchivio_TextChanged(object sender, EventArgs e)
        {
            // Aggiorna textBoxArchivioSelezionato
            AggiornaArchivioSelezionato();

            //// compone il path archvio
            //string pathArchivio = AreaArchivio.PathArchivioBase + "//" + textBoxArchivioSelezionato.Text;

            //// verifica se esiste
            //if (Directory.Exists(pathArchivio))
            //{
            //    // verifica se il path archivio è uguale all'archvio attivo
            //    if (AreaArchivio.PathArchivioAttivo.ToLower().Equals(pathArchivio.ToLower()))
            //        textBoxArchivioSelezionato.BackColor = Color.LightGreen;
            //    else
            //        textBoxArchivioSelezionato.BackColor = Color.LightSalmon;
            //}
            //else
            //{
            //    textBoxArchivioSelezionato.BackColor = Color.LightYellow;
            //}
        }
        /// <summary>
        /// Aggiorna la text box dell'archivio selezionato
        /// </summary>
        private void AggiornaArchivioSelezionato()
        {
            // compone il path archvio
            string pathArchivio = AreaArchivio.PathArchivioBase + "\\" + textBoxArchivioSelezionato.Text;

            // verifica se esiste
            if (Directory.Exists(pathArchivio))
            {
                // verifica se il path archivio è uguale all'archvio attivo
                if (AreaArchivio.PathArchivioAttivo.ToLower().Equals(pathArchivio.ToLower()))
                    textBoxArchivioSelezionato.BackColor = Color.LightGreen;
                else
                    textBoxArchivioSelezionato.BackColor = Color.LightSalmon;
            }
            else
            {
                textBoxArchivioSelezionato.BackColor = Color.LightYellow;
            }
        }
        /// <summary>
        /// Aggiorna il form
        /// </summary>
        private void AggiornaForm()
        {
            // Archivio Base
            textAreaArchivioBase.Text = this.AreaArchivio.PathArchivioBase;
            if (AreaArchivio.ArchivioBaseOK)
            {
                textAreaArchivioBase.BackColor = Color.LightGreen;
            }
            else
            {
                textAreaArchivioBase.BackColor = Color.LightPink;
            }

            // Archivio Attivo
            textBoxArchivioAttivo.Text = this.AreaArchivio.DirArchivioAttivo;
            if (AreaArchivio.ArchivioAttivoOK)
            {
                textBoxArchivioAttivo.BackColor = Color.LightGreen;
            }
            else
            {
                textBoxArchivioAttivo.BackColor = Color.LightPink;
            }

            // Archivio selezionato
            //textBoxArchivioSelezionato.Text = this.AreaArchivio.DirArchivioAttivo;
            AggiornaArchivioSelezionato();

            AggiornaTreeview();

        }
        /// <summary>
        /// Apre area archivio base
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
        /// Apre in explorer archivio selezionato 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butExplorerArchvioSelezionato_Click(object sender, EventArgs e)
        {
            // recupera il path dell'archivio selezionato e avvia explore
            if (AreaArchivio.ArchivioBaseOK)
            {
                // Verifica che dir Archivio Sellezionato non sia vuoto
                string dirArchvioSelezionato = textBoxArchivioSelezionato.Text;
                if (dirArchvioSelezionato.Length < 1)
                    return;


                // comporre il path dell'archivio selezionato
                string pathArchivioSelezionato = AreaArchivio.PathArchivioBase + "\\" + dirArchvioSelezionato;    

                // verifica che larchivio esiste
                if (Directory.Exists(pathArchivioSelezionato))
                    ApreExplorer(pathArchivioSelezionato);
            }
               
        }
        /// <summary>
        /// Apre in explorer archivio attivo 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butExplorerArchvioAttivo_Click(object sender, EventArgs e)
        {
            // recupera il path dell'attivo e avvia explore
            if (AreaArchivio.ArchivioAttivoOK)
                ApreExplorer(AreaArchivio.PathArchivioAttivo);
        }
    }// fine class FormAreaArchivio
}// fine namespace GAlbum

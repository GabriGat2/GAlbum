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
using System.Windows.Forms.VisualStyles;

namespace GAlbum
{
    public partial class FormAreaArchivio : Form
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================
        protected CAreaArchivio AreaArchivio = null;


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
            textAreaArchivioBase.Text = this.AreaArchivio.PathArchivioBase;

            AggiornaTreeview();
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
                textAreaArchivioBase.Text = this.AreaArchivio.PathArchivioBase;
            }



            // verifica se la directory esiste
            //VerificaAreaArchivio(path);
        }
        /// <summary>
        /// crea una nuova area archivio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butNuova_Click(object sender, EventArgs e)
        {
            GstErrori.EErrore esito;

            // crea la classe 
            esito = AreaArchivio.CreaAreaArchivio(textBoxAreaArchivio.Text);
            if (esito != GstErrori.EErrore.E0000_OK)
            {
                GstErrori.StampaMessaggioErrore(esito);
            }

            // Aggiorna la treeView
            AggiornaTreeview();
        }
        /// <summary>
        /// aggiorna la tree view delle aree archivio
        /// </summary>
        private void AggiornaTreeview()
        {
            //// assegna la directory sorgente
            //PathDirSorgente = textBoxSorgente.Text;

            // verifica che la directory esiste 
            if (!Directory.Exists(AreaArchivio.PathArchivioBase))
            {
                return;
            }

            // Crea la lista delle sub directory
            string[] listaSubDir = Directory.GetDirectories(AreaArchivio.PathArchivioBase);

            //// annulla riferimento InfoNodoSorgenteSelezionato
            //InfoNodoSorgenteSelezionato = null;

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
                AggiungiNodo(subDir, ref nodoBase, 1 /*, ref InfoTVSorgente */);

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


    }// fine class FormAreaArchivio
}// fine namespace GAlbum

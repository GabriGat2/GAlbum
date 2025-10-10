using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GAlbum.GstErrori;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace GAlbum
{
    public partial class FormSelezioneFoto : Form
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================
        /// <summary>
        /// lista delle foto sorgente
        /// </summary>
        private string[] fotoSrcList;
        /// <summary>
        /// indice della lista delle foto sorgente
        /// </summary>
        private int idFotoSrcList;
        /// <summary>
        /// Bitmap di appoggio per la foto il elaborazione
        /// </summary>
        private Bitmap MyImage;
        /// <summary>
        /// Path della directory sorgente attiva 
        /// </summary>
        private string PathDirSorgente = null;
        /// <summary>
        /// Path della directory destinazione attiva 
        /// </summary>
        private string PathDirDestinazione = null;
        /// <summary>
        /// Nodo sorgente selezionato
        /// </summary>
        private CInfoDirFoto InfoNodoSorgenteSelezionato;
        /// <summary>
        /// stato del form:
        /// False = Copia delle foto non attiva perchè, sta coonfigurando le operazioni da eseguire
        /// true = Copia delle foto  attiva, perchè esegue l'operazione richiesta
        /// </summary>
        private bool Stato;
        /// <summary>
        /// Infro tree view Sorgente
        /// </summary>
        private CInfoTreeView InfoTVSorgente;
        /// <summary>
        /// Infro tree view Destinazione
        /// </summary>
        private CInfoTreeView InfoTVDestinazione;
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
        public FormSelezioneFoto()
        {
            InitializeComponent();
            InizializzaClasse();
        }
        /// <summary>
        /// Inizializza classe
        /// </summary>
        private void InizializzaClasse()
        {
            // Inizializza lo stato del form
            AggiornaStato(false);

            // CRea info tree view
            InfoTVSorgente = new CInfoTreeViewSorgente ();
            InfoTVDestinazione = new CInfoTreeViewDestinazione();

            // DEBUG
            textBoxSorgente.Text = "E:\\Angelo\\Prj\\GAlbum\\Foto\\Sorgente";
            textBoxDestinazione.Text = "E:\\Angelo\\Prj\\GAlbum\\Foto\\Destinazione";

            // aggiorna la visualizzazione delle sub directory di destinazione
            //AggiornaDestinazione();
            AggiornaSorgente();


            
        }
        /// <summary>
        /// Seleziona la directory sorgente 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSorgente_Click(object sender, EventArgs e)
        {

            // definisci il path della directory delle foto da elaborare
            string path = string.Empty;

            // seleziona la directory delle foto
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            // inizializza path @DEBUG
            dlg.SelectedPath = textBoxSorgente.Text;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.SelectedPath;
            }
            //// verifica se ha selezionato una directory
            //if (path == string.Empty)
            //    return;

            // stampa il path della directory
            textBoxSorgente.Text = path;
        }
        /// <summary>
        ///  Apre directory di destinazione 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butDestinazione_Click(object sender, EventArgs e)
        {

            // definisci il path della directory delle foto da elaborare
            string path = string.Empty;

            // Crea l'oggetto del browser
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            // inizializza path 
            dlg.SelectedPath = textBoxDestinazione.Text;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.SelectedPath;
            }

            // stampa il path della directory
            textBoxDestinazione.Text = path;

            // aggiorna la visualizzazione delle sub directory di destinazione
            AggiornaDestinazione();
        }
        /// <summary>
        /// aggiorna le destinazioni, cioé visualizza le sotto directory contenute in destinazione
        /// </summary>
        private void AggiornaDestinazione()
        {
            // assegna la directory di destinazione
            PathDirDestinazione = textBoxDestinazione.Text;

            // verifica che la directory esiste 
            if (!Directory.Exists(PathDirDestinazione))
            {
                PathDirDestinazione = null;
                return;
            }


            // Crea la lista delle sub directory
            string [] listaSubDir = Directory.GetDirectories(PathDirDestinazione);


            // inizia aggiornamnto tree view
            treeViewDestinazione.BeginUpdate();

            // Azzera Tree view
            treeViewDestinazione.Nodes.Clear();

            // crea classe info dir foto vuota
            CInfoDirFoto info = new CInfoDirFoto("");

            // creiamo il nodo base
            TreeNode nodoBase = new TreeNode("Destinazione");
            nodoBase.Tag = info;
            treeViewDestinazione.Nodes.Add(nodoBase);

            // Aggiunge un nodo per ogni subdirectory
            foreach (var subDir in listaSubDir)
            {
                AggiungiNodo(subDir, ref nodoBase, 1, ref InfoTVDestinazione);
            }

            // Espandi il sommario
            treeViewDestinazione.ExpandAll();

            // termina aggiornamnto
            treeViewDestinazione.EndUpdate();

        }
        /// <summary>
        /// Aggiunge un nodo
        /// </summary>
        /// <param name="pathDir"></param>
        /// <param name="nodoBase"></param>
        /// <param name="livello"></param>
        private void AggiungiNodo(string pathDir, ref TreeNode nodoBase, int livello, ref CInfoTreeView infoTV)
        {
            // crea classe info dir foto
            CInfoDirFoto info = new CInfoDirFoto(pathDir);

            // verifichiamo se può essere aggiunta all'albero della tree vie
            if (!infoTV.NomeVisibile(info.Nome))
                return;

            // crea il nodo
            TreeNode nodo = new TreeNode(info.Nome);
            nodo.Tag = info;
            nodoBase.Nodes.Add(nodo);

            // Aggiungiamo il riferimento al nodo all'info
            info.SetNodo(ref nodo);


            // verifica se ha raggiunto il livello di massima indentazione
            if (livello >= infoTV.MaxLivello)
            {
                return;
            }


            // Crea la lista delle sub directory
            try
            { 
                string[] listaSubDir = Directory.GetDirectories(pathDir);   


                // Aggiunge un nodo per ogni subdirectory
                foreach (var subDir in listaSubDir)
                {
                    AggiungiNodo(subDir, ref nodo, ++livello,  ref infoTV);

                }
            }  
            catch (Exception ex) 
            {
                return;
            }
        }
        /// <summary>
        /// il testo della destinazione é cambiato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxDestinazione_TextChanged(object sender, EventArgs e)
        {
            // aggiorna la visualizzazione delle sub directory di destinazione
            AggiornaDestinazione();
        }
        /// <summary>
        /// Carica le fotografie contenute nella directory specificata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butApri_Click(object sender, EventArgs e)
        {
            // commuta stato
            AggiornaStato(!Stato);

            // Verifica se c'è un nodo sorgente selezionato
            if (InfoNodoSorgenteSelezionato == null)
            {
                return;
            }

            // stampa il path della directory
            string pathSrc = InfoNodoSorgenteSelezionato.Path;
            textBoxPathFoto.Text = pathSrc;

            // Cancella, eventuale, dir TMP
            CImmagine cImmagine = new CImmagine();
            GstErrori.EErrore esito = cImmagine.CancellaDirTemporanea(pathSrc);

            // Verifica che lo stato sia attivo
            if (Stato)
            {

                // carica la lista dei file contenuti nella directory
                fotoSrcList = Directory.GetFiles(pathSrc, "*.*");
                if (fotoSrcList.Length == 0)
                {
                    // Rimette lo stato falso
                    AggiornaStato(false);

                    // Mostra codice di errore
                    GstErrori.StampaMessaggioErrore(GstErrori.EErrore.E1315_DirectorySorgenteVuota, pathSrc);
                    return;
                }

                idFotoSrcList = 0;

                MostraFoto(fotoSrcList[0], ref butApri);
            }
        }
        /// <summary>
        /// Mostra la foto selezionata
        /// </summary>
        /// <param name="pathFoto"></param>
        private void MostraFoto(string pathFoto, ref System.Windows.Forms.Button button)
        {
            // stampa il path della foto
            textBoxPathFoto.Text = pathFoto;

            // salva il tipo di cursore
            Cursor saveCursor = button.Cursor;

            // Cambia il cursore in clessidra
            button.Cursor = Cursors.WaitCursor;

            CImmagine immagine = new CImmagine();
            EErrore esito = immagine.MostraImmagine(pathFoto, ref pictureBox1);

            // ripristina cursore
            button.Cursor = saveCursor;

        }
        /// <summary>
        ///  Mostra la foto precedente contenuta nella lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butPrecedente_Click(object sender, EventArgs e)
        {
            // controlla che la lista esiste 
            if (fotoSrcList == null)
                return;

            // verifica se l'idece puo essere decrementato
            if (idFotoSrcList < 1)
                return;

            // decrementa indice 
            idFotoSrcList--;

            MostraFoto(fotoSrcList[idFotoSrcList], ref butPrecedente);
        }
        /// <summary>
        ///  Mostra la prossima foto contenuta nella lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSuccessiva_Click(object sender, EventArgs e)
        {
            FotoSuccessiva();
            //if (fotoSrcList == null)
            //    return;
            //if (idFotoSrcList >= (fotoSrcList.Length - 1))
            //    return;

            //idFotoSrcList++;

            //MostraFoto(fotoSrcList[idFotoSrcList], ref butSuccessiva);
        }
        /// <summary>
        /// passa alla foto successiva
        /// </summary>
        private void FotoSuccessiva()
        {
            if (fotoSrcList == null)
                return;
            if (idFotoSrcList >= (fotoSrcList.Length - 1))
                return;

            idFotoSrcList++;

            MostraFoto(fotoSrcList[idFotoSrcList], ref butSuccessiva);
        }
        /// <summary>
        /// Estrae il nodo selezionato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewDestinazione_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // recuprea il nodo selezionato 
            TreeNode nodo = treeViewDestinazione.SelectedNode;

            // Estrae le info della classe 
            CInfoDirFoto info = (CInfoDirFoto) nodo.Tag;

            // stampa il path della directory 
            String path = info.Path;
            textBoxDebug.Text = path;

            // commuta la selezione
            info.CommutaSelezione();
        }
        /// <summary>
        /// aggiorna Sorgenti, cioé visualizza le sotto directory contenute in sorgente
        /// </summary>
        private void AggiornaSorgente()
        {
            // assegna la directory sorgente
            PathDirSorgente = textBoxSorgente.Text;

            // verifica che la directory esiste 
            if (!Directory.Exists(PathDirSorgente))
            {
                PathDirSorgente = null;
                return;
            }

            // Crea la lista delle sub directory
            string[] listaSubDir = Directory.GetDirectories(PathDirSorgente);

            // annulla riferimento InfoNodoSorgenteSelezionato
            InfoNodoSorgenteSelezionato = null;

            // inizia aggiornamnto tree view
            treeViewSorgente.BeginUpdate();

            // Azzera Tree view
            treeViewSorgente.Nodes.Clear();

            // crea classe info dir foto vuota
            CInfoDirFoto info = new CInfoDirFoto("");

            // creiamo il nodo base
            TreeNode nodoBase = new TreeNode("Sorgente");
            nodoBase.Tag = info;
            treeViewSorgente.Nodes.Add(nodoBase);

            // Aggiunge un nodo per ogni subdirectory
            foreach (var subDir in listaSubDir)
            {
                AggiungiNodo(subDir, ref nodoBase, 1, ref InfoTVSorgente);

            }

            // Espandi il sommario
            treeViewSorgente.ExpandAll();

            // termina aggiornamnto
            treeViewSorgente.EndUpdate();

        }
        /// <summary>
        /// cambiato il path di sorgente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSorgente_TextChanged(object sender, EventArgs e)
        {
            // aggiorna la visualizzazione delle sub directory sorgente
            AggiornaSorgente();
        }
        /// <summary>
        ///  estrae nodo selezionato 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewSorgente_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // verifica lo stato del form
            if (Stato)
                return;

            // recuprea il nodo selezionato 
            TreeNode nodo = treeViewSorgente.SelectedNode;

            // Estrae le info della classe 
            CInfoDirFoto info = (CInfoDirFoto)nodo.Tag;

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
            if (InfoNodoSorgenteSelezionato != null)
            {
                InfoNodoSorgenteSelezionato.Selezione = false;
            }

            // aggiona il nodo sorgente selezionato
            InfoNodoSorgenteSelezionato = infoNodo;

            // seleziona il nodo
            InfoNodoSorgenteSelezionato.Selezione = true;  
            

        }
        /// <summary>
        /// aggiorna lo stato del form e gli oggetti ad esso collegati 
        /// </summary>
        /// <param name="stato"></param>
        private void AggiornaStato(bool newStato)
        {
            //aggiorna lo stato del form
            this.Stato = newStato;

            // Debug: mostra stato
            textBoxDebug2.Text = Stato.ToString();

            // button Apri
            if (Stato)
            {
                butApri.Text = "Chiudi";
            }
            else
            {
                butApri.Text = "Apri";
            }

            // button Sorgente
            butSorgente.Enabled = !Stato;
            textBoxSorgente.ReadOnly = Stato;

            // button Detinazione
            butDestinazione.Enabled = !Stato;
            textBoxDestinazione .ReadOnly = Stato;

            // button Precedente
            butPrecedente.Enabled = Stato;

            // button Successiva
            butSuccessiva.Enabled = Stato;

            // button Assegna
            butAssegna.Enabled = Stato;

            // button NonAssegna
            butNonAssegna.Enabled = Stato;

            //pictureBox1
            if (!Stato)
            {
                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();

                pictureBox1.Image = null;

                textBoxPathFoto.Text = "";
            }


        }
        /// <summary>
        /// Doppio click suula tree view sorgente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewSorgente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // verifica se é stato premuto il tasto destro
            if (e.Button == MouseButtons.Right)
            {
                FormConfigTreeView formConfigTreeView = new FormConfigTreeView(ref InfoTVSorgente);
                formConfigTreeView.ShowDialog();

                // aggiorna la treeview
                AggiornaSorgente();

            }

        }
        /// <summary>
        /// Doppio click suula tree view destinazione
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewDestinazione_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // verifica se é stato premuto il tasto destro
            if (e.Button == MouseButtons.Right)
            {
                FormConfigTreeView formConfigTreeView = new FormConfigTreeView(ref InfoTVDestinazione);
                formConfigTreeView.ShowDialog();
            }

            // aggiorna la treeview
            AggiornaDestinazione();
        }
        /// <summary>
        /// Assegna la foto e passa alla successiva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAssegna_Click(object sender, EventArgs e)
        { 
            // Crea l'archivo per movimentare le foto
            CArchivia archivia = new CArchivia();

            // crea la lista dei nodi selezionati
            List<String> pathDestinazioni;
            TreeNode nodo = treeViewDestinazione.Nodes[0];
            archivia.EstraiNdodiSelezionati(ref nodo, out pathDestinazioni);

            // libera la risorsa della foto
            pictureBox1.Image = null;

            // Assegna la foto
            archivia.Assegna(textBoxPathFoto.Text, pathDestinazioni);

            // mostra la foto successiva
            FotoSuccessiva();
        }
        /// <summary>
        ///  Non Assegna la foto e passa alla successiva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butNonAssegna_Click(object sender, EventArgs e)
        {
            //mostra la foto successiva
            FotoSuccessiva();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int i = 0;
        }
    } // fine della classe
}// fine del name scope

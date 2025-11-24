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
using static GAlbum.GstErrori;

namespace GAlbum
{
    public partial class FormSelezionaPerData : Form
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================
        /// <summary>
        /// riferiemnto all'area archivio
        /// </summary>
        protected CAreaArchivio AreaArchivio = null;
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
        /// Path della directory Acquisire
        /// </summary>
        private string PathDirAcquisire = null;
        /// <summary>
        /// Path della directory Smistare
        /// </summary>
        private string PathDirSmistare = null;
        /// <summary>
        /// Path della directory Smistati
        /// </summary>
        private string PathDirSmistati = null;

        // -----------------------------------------------------------------------------------------------------------------
        // Info treeView Nodi selezionati
        /// <summary>
        /// Nodo Acquisire selezionato
        /// </summary>
        private CInfoDirFoto InfoNodoAcquisireSelezionato;
        /// <summary>
        /// Nodo Smistare selezionato
        /// </summary>
        private CInfoDirFoto InfoNodoSmistareSelezionato;
        /// <summary>
        /// Nodo Smistati selezionato
        /// </summary>
        private CInfoDirFoto InfoNodoSmistatiSelezionato;

        // -----------------------------------------------------------------------------------------------------------------
        // 
        /// <summary>
        /// stato del form:
        /// False = Copia delle foto non Attiva perchè, sta coonfigurando le operazioni da eseguire
        /// true = Copia delle foto  Attiva, perchè esegue l'operazione richiesta
        /// </summary>
        private bool StatoInEsecuzione;
        /// <summary>
        /// Infro tree view Acquisire
        /// </summary>
        private CInfoTreeView InfoTVAcqusire;
        /// <summary>
        /// Infro tree view Smistare
        /// </summary>
        private CInfoTreeView InfoTVSmistare;
        /// <summary>
        /// Infro tree view Smistati
        /// </summary>
        private CInfoTreeView InfoTVSmistati;
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
        public FormSelezionaPerData(ref CAreaArchivio areaArchivio)
        {
            // Assegna il riferimento a AreaArchivio
            this.AreaArchivio = areaArchivio;

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

            // Crea info tree view
            InfoTVAcqusire = new CInfoTreeViewAcquisire();
            InfoTVSmistare = new CInfoTreeViewSmistare();
            InfoTVSmistati = new CInfoTreeViewSmistati();
            // inizializza le text box
            textBoxAcquisire.Text = AreaArchivio.PathAcquisire;
            textBoxSmistare.Text = AreaArchivio.PathSmistare;
            textBoxSmistati.Text = AreaArchivio.PathSmistati;

            // aggiorna la visualizzazione delle tree view
            
            AggiornaAcquisire();
            AggiornaSmistare();
            AggiornaSmistati();

            // Abilita controlli
            AbilitaControlli(true);


        }
        /// <summary>
        /// Seleziona la directory Acquisire 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAcquisire_Click(object sender, EventArgs e)
        {

            // definisci il path della directory delle foto da elaborare
            string path = string.Empty;

            // seleziona la directory delle foto
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            // inizializza path @DEBUG
            dlg.SelectedPath = textBoxAcquisire.Text;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.SelectedPath;
            }
            // verifica se ha selezionato una directory
            if (path == string.Empty)
                return;

            // stampa il path della directory
            textBoxAcquisire.Text = path;
        }
        /// <summary>
        ///  Apre directory Smistare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSmistare_Click(object sender, EventArgs e)
        {

            // definisci il path della directory delle foto da elaborare
            string path = string.Empty;

            // Crea l'oggetto del browser
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            // inizializza path 
            dlg.SelectedPath = textBoxSmistare.Text;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.SelectedPath;
            }
            // verifica se ha selezionato una directory
            if (path == string.Empty)
                return;

            // stampa il path della directory
            textBoxSmistare.Text = path;
        }
        /// <summary>
        /// Aggiorna Smistare, cioé visualizza le sotto directory contenute in Smistare
        /// </summary>
        private void AggiornaSmistare()
        {
            // assegna la directory Smistare
            PathDirSmistare = textBoxSmistare.Text;

            // verifica che la directory esiste 
            if (!Directory.Exists(PathDirSmistare))
            {
                PathDirSmistare = null;
                return;
            }


            // Crea la lista delle sub directory
            string[] listaSubDir = Directory.GetDirectories(PathDirSmistare);


            // inizia aggiornamnto tree view
            treeViewSmistare.BeginUpdate();

            // Azzera Tree view
            treeViewSmistare.Nodes.Clear();

            // crea classe info dir foto vuota
            CInfoDirFoto info = new CInfoDirFoto("");

            // creiamo il nodo base
            TreeNode nodoBase = new TreeNode("Smistare");
            nodoBase.Tag = info;
            treeViewSmistare.Nodes.Add(nodoBase);

            // Aggiunge un nodo per ogni subdirectory
            foreach (var subDir in listaSubDir)
            {
                AggiungiNodo(subDir, ref nodoBase, 1, ref InfoTVSmistare);
            }

            // Espandi il sommario
            treeViewSmistare.ExpandAll();

            // termina aggiornamnto
            treeViewSmistare.EndUpdate();

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
                    AggiungiNodo(subDir, ref nodo, ++livello, ref infoTV);

                }
            }
            catch (Exception ex)
            {
                return;
            }
        }
        /// <summary>
        /// Aggiorna Smistati, cioé visualizza le sotto directory contenute in Smistati
        /// </summary>
        private void AggiornaSmistati()
        {
            // assegna la directory Smistati
            PathDirSmistati = textBoxSmistati.Text;

            // verifica che la directory esiste 
            if (!Directory.Exists(PathDirSmistati))
            {
                PathDirSmistati = null;
                return;
            }


            // Crea la lista delle sub directory
            string[] listaSubDir = Directory.GetDirectories(PathDirSmistati);


            // inizia aggiornamnto tree view
            treeViewSmistati.BeginUpdate();

            // Azzera Tree view
            treeViewSmistati.Nodes.Clear();

            // crea classe info dir foto vuota
            CInfoDirFoto info = new CInfoDirFoto("");

            // creiamo il nodo base
            TreeNode nodoBase = new TreeNode("Smistati");
            nodoBase.Tag = info;
            treeViewSmistati.Nodes.Add(nodoBase);

            // Aggiunge un nodo per ogni subdirectory
            foreach (var subDir in listaSubDir)
            {
                AggiungiNodo(subDir, ref nodoBase, 1, ref InfoTVSmistati);
            }

            // Espandi il sommario
            treeViewSmistati.ExpandAll();

            // termina aggiornamnto
            treeViewSmistati.EndUpdate();

        }


        ///// <summary>
        ///// Aggiunge un nodo
        ///// </summary>
        ///// <param name="pathDir"></param>
        ///// <param name="nodoBase"></param>
        ///// <param name="livello"></param>
        //private void AggiungiNodo(string pathDir, ref TreeNode nodoBase, int livello, ref CInfoTreeView infoTV)
        //{
        //    // crea classe info dir foto
        //    CInfoDirFoto info = new CInfoDirFoto(pathDir);

        //    // verifichiamo se può essere aggiunta all'albero della tree vie
        //    if (!infoTV.NomeVisibile(info.Nome))
        //        return;

        //    // crea il nodo
        //    TreeNode nodo = new TreeNode(info.Nome);
        //    nodo.Tag = info;
        //    nodoBase.Nodes.Add(nodo);

        //    // Aggiungiamo il riferimento al nodo all'info
        //    info.SetNodo(ref nodo);


        //    // verifica se ha raggiunto il livello di massima indentazione
        //    if (livello >= infoTV.MaxLivello)
        //    {
        //        return;
        //    }


        //    // Crea la lista delle sub directory
        //    try
        //    {
        //        string[] listaSubDir = Directory.GetDirectories(pathDir);


        //        // Aggiunge un nodo per ogni subdirectory
        //        foreach (var subDir in listaSubDir)
        //        {
        //            AggiungiNodo(subDir, ref nodo, ++livello, ref infoTV);

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        return;
        //    }
        //}


        /// <summary>
        /// il testo della Smistare é cambiato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSmistare_TextChanged(object sender, EventArgs e)
        {
            // aggiorna la visualizzazione delle sub directory di Smistare
            AggiornaSmistare();
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
        private void treeViewSmistare_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // verifica lo stato del form
            if (StatoInEsecuzione)
                return;

            // recuprea il nodo selezionato
            TreeNode nodo = treeViewSmistare.SelectedNode;

            // Estrae le info della classe 
            CInfoDirFoto info = (CInfoDirFoto)nodo.Tag;

            // aggiorna nodo Acquisire selezionato 
            AggiornaNodoSelezionato(ref info, ref InfoNodoSmistareSelezionato);

            // stampa il path della directory 
            String path = info.Path;
            textBoxDebug.Text = path;

            // commuta la selezione
            //info.CommutaSelezione();
        }
        /// <summary>
        /// Aggiorna Acquisire, cioé visualizza le sotto directory contenute in Acquisire
        /// </summary>
        private void AggiornaAcquisire()
        {
            // assegna la directory Acquisire
            PathDirAcquisire = textBoxAcquisire.Text;

            // verifica che la directory esiste 
            if (!Directory.Exists(PathDirAcquisire))
            {
                PathDirAcquisire = null;
                return;
            }

            // Crea la lista delle sub directory
            string[] listaSubDir = Directory.GetDirectories(PathDirAcquisire);

            // annulla riferimento InfoNodoSelezionato
            InfoNodoAcquisireSelezionato = null;
            InfoNodoSmistareSelezionato = null;
            InfoNodoSmistatiSelezionato = null;

            // inizia aggiornamnto tree view
            treeViewAcquisire.BeginUpdate();

            // Azzera Tree view
            treeViewAcquisire.Nodes.Clear();

            // crea classe info dir foto vuota
            CInfoDirFoto info = new CInfoDirFoto("");

            // creiamo il nodo base
            TreeNode nodoBase = new TreeNode("Acquisire");
            nodoBase.Tag = info;
            treeViewAcquisire.Nodes.Add(nodoBase);

            // Aggiunge un nodo per ogni subdirectory
            foreach (var subDir in listaSubDir)
            {
                AggiungiNodo(subDir, ref nodoBase, 1, ref InfoTVAcqusire);

            }

            // Espandi il sommario
            treeViewAcquisire.ExpandAll();

            // termina aggiornamnto
            treeViewAcquisire.EndUpdate();

        }
        /// <summary>
        /// cambiato il path di Acquisire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAcquisire_TextChanged(object sender, EventArgs e)
        {
            // aggiorna la visualizzazione delle sub directory Acquisire
            AggiornaAcquisire();
        }
        /// <summary>
        ///  estrae nodo selezionato 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewAcquisire_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // verifica lo stato del form
            if (StatoInEsecuzione)
                return;

            // recuprea il nodo selezionato 
            TreeNode nodo = treeViewAcquisire.SelectedNode;

            // Estrae le info della classe 
            CInfoDirFoto info = (CInfoDirFoto)nodo.Tag;

            // aggiorna nodo Acquisire selezionato 
            AggiornaNodoSelezionato(ref info, ref InfoNodoAcquisireSelezionato);

            //     // commuta la selezione
            //info.CommutaSelezione();

        }
        /// <summary>
        /// Aggiorna il nodo selezionato 
        /// </summary>
        /// <param name="infoNodo"></param>
        /// <param name="InfoNodoSelezionato"></param>
        private void AggiornaNodoSelezionato(ref CInfoDirFoto infoNodo, ref CInfoDirFoto InfoNodoSelezionato)
        {
            // Verifica se il nodo é assegnato
            if (InfoNodoSelezionato != null)
            {
                InfoNodoSelezionato.Selezione = false;
            }

            // aggiona il nodo Acquisire selezionato
            InfoNodoSelezionato = infoNodo;

            // seleziona il nodo
            InfoNodoSelezionato.Selezione = true;
        }
        /// <summary>
        /// aggiorna lo stato del form e gli oggetti ad esso collegati 
        /// </summary>
        /// <param name="stato"></param>
        private void AggiornaStato(bool newStato)
        {
            //aggiorna lo stato del form
            this.StatoInEsecuzione = newStato;

            // Debug: mostra stato
            //textBoxDebug2.Text = StatoInEsecuzione.ToString();

            //// button Apri
            //if (StatoInEsecuzione)
            //{
            //    butApri.Text = "Chiudi";
            //}
            //else
            //{
            //    butApri.Text = "Apri";
            //}

            // button Acquisire
            butAcquisire.Enabled = false;
            textBoxAcquisire.ReadOnly = true;

            // button Smistare
            butSmistare.Enabled = false;
            textBoxSmistare.ReadOnly = true;

            // button Smistati
            butSmistati.Enabled = false;
            textBoxSmistati.ReadOnly = true;

            // button Precedente
            butPrecedente.Enabled = StatoInEsecuzione;

            // button Successiva
            butSuccessiva.Enabled = StatoInEsecuzione;

            // button Assegna
            butAssegna.Enabled = StatoInEsecuzione;

            // button NonAssegna
            butNonAssegna.Enabled = StatoInEsecuzione;

            //pictureBox1
            if (!StatoInEsecuzione)
            {
                if (pictureBox1.Image != null)
                    pictureBox1.Image.Dispose();

                pictureBox1.Image = null;

                textBoxPathFoto.Text = "";
            }


        }
        /// <summary>
        /// Doppio click suula tree view Acquisire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewAcquisire_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // verifica che sia in stato false
            if ((this.StatoInEsecuzione))
                return;

            // verifica se é stato premuto il tasto destro
            if (e.Button == MouseButtons.Right)
            {
                FormConfigTreeView formConfigTreeView = new FormConfigTreeView(ref InfoTVAcqusire);
                formConfigTreeView.ShowDialog();

                // aggiorna la treeview
                AggiornaAcquisire();

            }

        }
        /// <summary>
        /// Doppio click sulla tree view smistare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewSmistare_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // verifica se é stato premuto il tasto destro
            if (e.Button == MouseButtons.Right)
            {
                FormConfigTreeView formConfigTreeView = new FormConfigTreeView(ref InfoTVSmistare);
                formConfigTreeView.ShowDialog();
            }

            // aggiorna la treeview
            AggiornaSmistare();
        }
        /// <summary>
        /// Assegna la foto e passa alla successiva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAssegna_Click(object sender, EventArgs e)
        {
            EseguiAssegna((true));
        }
        /// <summary>
        ///  Non Assegna la foto e passa alla successiva
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butNonAssegna_Click(object sender, EventArgs e)
        {
            EseguiAssegna(false);
        }
        /// <summary>
        /// Attiva l'assegnazione
        /// </summary>
        /// <param name="copia"></param>
        protected void EseguiAssegna(bool copia)
        {
            // Crea l'archivo per movimentare le foto
            CArchivia archivia = new CArchivia();

            // crea la lista dei nodi selezionati
            List<String> pathDestinazioni;
            TreeNode nodo = treeViewSmistare.Nodes[0];
            archivia.EstraiNdodiSelezionati(ref nodo, out pathDestinazioni);

            // libera la risorsa della foto
            pictureBox1.Image = null;

            // Assegna la foto
            archivia.Assegna(textBoxPathFoto.Text, pathDestinazioni, copia, InfoTVAcqusire.CopiaParallela);

            // mostra la foto successiva
            FotoSuccessiva();



        }
        /// <summary>
        /// seleziona la directory degli smistati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSmistati_Click(object sender, EventArgs e)
        {
            // definisci il path della directory delle foto da elaborare
            string path = string.Empty;

            // seleziona la directory delle foto
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            // inizializza path @DEBUG
            dlg.SelectedPath = textBoxSmistati.Text;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.SelectedPath;
            }
            // verifica se ha selezionato una directory
            if (path == string.Empty)
                return;

            // stampa il path della directory
            textBoxSmistati.Text = path;
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
        /// Apre in exprorer Acquisire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butExplorerAcquisire_Click(object sender, EventArgs e)
        {
          
        
            // recupera il path dell'archivio e avvia explore
            if (AreaArchivio.ArchivioBaseOK)
                ApreExplorer(AreaArchivio.PathAcquisire);
        }
        /// <summary>
        /// Apre in exprorer Smistare
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butExplorerSmistare_Click(object sender, EventArgs e)
        {
            // recupera il path dell'archivio e avvia explore
            if (AreaArchivio.ArchivioBaseOK)
                ApreExplorer(AreaArchivio.PathSmistare);
        }
        /// <summary>
        /// Apre in exprorer Smistati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butExplorerSmistati_Click(object sender, EventArgs e)
        {
            // recupera il path dell'archivio e avvia explore
            if (AreaArchivio.ArchivioBaseOK)
                ApreExplorer(AreaArchivio.PathSmistati);
        }
        ///Estrae il nodo selezionato
        private void treeViewSmistati_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // verifica lo stato del form
            if (StatoInEsecuzione)
                return;

            // recuprea il nodo selezionato
            TreeNode nodo = treeViewSmistati.SelectedNode;

            // Estrae le info della classe 
            CInfoDirFoto info = (CInfoDirFoto)nodo.Tag;

            // aggiorna nodo Acquisire selezionato 
            AggiornaNodoSelezionato(ref info, ref InfoNodoSmistatiSelezionato);

            // stampa il path della directory 
            String path = info.Path;
            textBoxDebug.Text = path;

            // commuta la selezione
            //info.CommutaSelezione();
        }
        /// <summary>
        ///  Doppio click sulla tree view smistati
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewSmistati_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // verifica se é stato premuto il tasto destro
            if (e.Button == MouseButtons.Right)
            {
                FormConfigTreeView formConfigTreeView = new FormConfigTreeView(ref InfoTVSmistati);
                formConfigTreeView.ShowDialog();
            }

            // aggiorna la treeview
            AggiornaSmistati();
        }
        /// <summary>
        /// esegue l'acquisizione di un archivio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butEsegui_Click(object sender, EventArgs e)
        {
            // recupera il path dell'archivio sorgente in Smistare 
            // ---------------------------------------------------
            
            // Verifica se c'è un nodo sorgente selezionato
            if (InfoNodoSmistareSelezionato == null)
                return;
            if (InfoNodoSmistareSelezionato.Path == string.Empty)
                return;
            string pathArchivioSrc = InfoNodoSmistareSelezionato.Path;

            // recupera il path dell'archivio destinazione in Smistati
            // ---------------------------------------------------

            // Verifica se c'è un nodo destinazione in smistati
            if (InfoNodoSmistatiSelezionato == null)
                return;
            if (InfoNodoSmistatiSelezionato.Path == string.Empty)
                return;
            string pathArchivioDst = InfoNodoSmistatiSelezionato.Path;

            // disabilta i gruppi del form
            AbilitaControlli(false);

            // Cambia il cursore in clessidra
            Cursor.Current = Cursors.WaitCursor;

            // Eseguire l'aquisizione
            GstErrori.EErrore esito = AreaArchivio.SelezionePerData(pathArchivioSrc, pathArchivioDst, ref progressBar1);   

            // riabilita i gruppi del form
            AbilitaControlli(true);

            // ripristina il cursore originale
            Cursor.Current = Cursors.Default;
        }
        /// <summary>
        /// Abilita disabibilita i controlli del form 
        /// </summary>
        /// <param name="abilita"></param>
        private void AbilitaControlli(bool abilita) 
        {
            // disabilta i gruppi del form
            this.groupBoxPath.Enabled = abilita;
            this.groupBoxAcquisire.Enabled = abilita && false;
            this.groupBoxSmistare.Enabled = abilita;
            this.groupBoxSmistati.Enabled = abilita;
        }


    }// fine class FormSelezionaPerData
}// fine namespace GAlbum


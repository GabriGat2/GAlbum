using ImageMagick;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static GAlbum.GstErrori;
using Image = System.Drawing.Image;

namespace GAlbum
{
    public partial class FormSelezione : Form
    {
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
        /// Costruttore
        /// </summary>
        public FormSelezione()
        {
            InitializeComponent();
            InizializzaClasse();
        }
        /// <summary>
        /// Inizializza classe
        /// </summary>
        private void InizializzaClasse()
        {
            // DEBUG
            textBoxSorgente.Text = "D:\\Angelo\\Prj\\GAlbum\\Foto\\Sorgente\\Heic";
            textBoxDestinazione.Text = "D:\\Angelo\\Prj\\GAlbum\\Foto\\Destinazione";
        }
        /// <summary>
        /// Carica le fotografie contenute nella directory specificata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butApri_Click(object sender, EventArgs e)
        {
 
            // stampa il path della directory
            string path = textBoxSorgente.Text;
            textBoxPathFoto.Text = path;

            // carica la lista dei file contenuti nella directory
            fotoSrcList = Directory.GetFiles(path, "*.*");
            idFotoSrcList = 0;

            MostraFoto(fotoSrcList[0], ref butApri);
        }
        /// <summary>
        /// Mostra la prossima foto contenuta nella lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSuccessiva_Click(object sender, EventArgs e)
        {

            if (fotoSrcList == null)
                return;
            if (idFotoSrcList >= (fotoSrcList.Length - 1))
                return;

            idFotoSrcList++;

            MostraFoto(fotoSrcList[idFotoSrcList], ref butSuccessiva);
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
            EErrore esito =  immagine.MostraImmagine(pathFoto, ref pictureBox1);

            // ripristina cursore
            button.Cursor = saveCursor;

        }
        /// <summary>
        /// Mostra la foto precedente contenuta nella lista
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
        /// Apre directory di destinazione 
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
        }
    }
}

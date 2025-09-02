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
        }
        /// <summary>
        /// Carica le fotografie contenute nella directory specificata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butApri_Click(object sender, EventArgs e)
        {
            // definisci il path della directory delle foto da elaborare
            string path = string.Empty;

            // seleziona la directory delle foto
            FolderBrowserDialog dlg = new FolderBrowserDialog();

            // inizializza path @DEBUG
            dlg.SelectedPath = "D:\\Angelo\\Prj\\GAlbum\\Foto\\Heic";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.SelectedPath;
            }
            // verifica se ha selezionato una directory
            if (path == string.Empty)
                return;

            // stampa il path della directory
            textBoxPathFoto.Text = path;

            // carica la lista dei file contenuti nella directory
            fotoSrcList = Directory.GetFiles(path, "*.*");
            idFotoSrcList = 0;

            MostraFoto(fotoSrcList[0]);
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

            MostraFoto(fotoSrcList[idFotoSrcList]);
        }
        /// <summary>
        /// Mostra la foto selezionata
        /// </summary>
        /// <param name="pathFoto"></param>
        private void MostraFoto(string pathFoto)
        {
            // stampa il path della foto
            textBoxPathFoto.Text = pathFoto;

            CImmagine immagine = new CImmagine();
            EErrore esito =  immagine.MostraImmagine(pathFoto, ref pictureBox1);

            //MostraFotoStream(pathFoto);
            //MostraFotoFile(pathFoto);
        }
        /// <summary>
        /// Converte un a foto da HEIC a Jpeg appoggiandosi allo stream
        /// </summary>
        /// <param name="pathFoto"></param>
        private void MostraFotoStream(string pathFoto)
        {
            // rilascia eventuale foto visualizzata
            if (MyImage != null)
                MyImage.Dispose();

            // stampa il path della foto
            textBoxPathFoto.Text = pathFoto;


            // Assegna il nome della foto HEIC
            string inputHeicPath = @pathFoto;

            try
            {
                // Carica l'immagine HEIC
                using (var image = new MagickImage(inputHeicPath))
                {
                    // Seleziona il formato desiderato: JPEG
                    image.Format = MagickFormat.Jpeg;

                    // Salva l'immagine nello stram                   
                    using (MemoryStream memStream = new MemoryStream(image.ToByteArray()))
                    {
                        // visualizza l'immagina
                        pictureBox1.Image = Image.FromStream(memStream);


                        memStream.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante la conversione: {ex.Message}");
            }
        }
        /// <summary>
        /// Converte un a foto da HEIC a Jpeg appoggiandosi a un file
        /// </summary>
        /// <param name="pathFoto"></param>
        private void MostraFotoFile(string pathFoto)
        {
            // rilascia eventuale foto visualizzata
            if (MyImage != null)
                MyImage.Dispose();

            // stampa il path della foto
            textBoxPathFoto.Text = pathFoto;

            // Assegna il nome della foto HEIC
            string inputHeicPath = @pathFoto;

            // compone il nome della foto di appoggio
            string outputJpgPath = @"C:\Temp\ConvHeic.jpg";

            // Verifica se la direcrory Temp esiste, nel caso contrario la crea
            Directory.CreateDirectory("C:\\Temp\\");

            // verifica se il nome della foto di appoggio esiste
            if (File.Exists(outputJpgPath))
            {
                // cancella il file di appoggio
                try
                {
                    File.Delete(outputJpgPath);

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Non si cancella: {ex.Message}");
                }
            }


            try
            {
                // Carica l'immagine HEIC
                using (var image = new MagickImage(inputHeicPath))
                {
                    // Seleziona il formato desiderato: JPEG
                    image.Format = MagickFormat.Jpeg;

                    // Salva l'immagine in formato JPG
                    image.Write(outputJpgPath, MagickFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante la conversione: {ex.Message}");
            }


            MyImage = new Bitmap(outputJpgPath);

            // Carica l'immagine dal file
            //pictureBox1.Image = (Image)MyImage;
            pictureBox1.Image = Image.FromFile(@pathFoto);
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

            MostraFoto(fotoSrcList[idFotoSrcList]);
        }
    }
}

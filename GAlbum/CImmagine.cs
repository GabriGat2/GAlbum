using System;
using System.Collections.Generic;
using System.Drawing;
//using Image = System.Drawing.Image;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GAlbum.GstErrori;

namespace GAlbum
{
    public class CImmagine
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================
        /// <summary>
        /// nome della directory di archivio
        /// </summary>
        private const string DirTMP = "_TMP_";
        /// <summary>
        /// Immagine di appoggio
        /// </summary>
        /// <param name=""></param>
        /// <returns></returns>
        private System.Drawing.Image image;
        /// <summary>
        /// Costruttore
        /// </summary>
        public CImmagine()
        {
        }
        /// <summary>
        /// Mostra l'immagine nella picture box,dopo averla opportunamente convertita 
        /// </summary>
        /// <param name="pathFoto">"path dell'immagine"</param>
        /// <param name="pictureBox">"picture box dove é visualizzata l'immagine "</param>
        /// <returns></returns>
        /// 
        public EErrore MostraImmagine(string pathFoto, ref System.Windows.Forms.PictureBox pictureBox)
        {
            EErrore esito = MostraImmagine2(pathFoto, ref pictureBox);
            if (esito != EErrore.E0000_OK)
            {
                CreaImmagineErrore(ref pictureBox, esito, pathFoto);
            }

            return esito;
        }
        /// <summary>
        /// Mostra l'immagine nella picture box,dopo averla opportunamente convertita 
        /// </summary>
        /// <param name="pathFoto"></param>
        /// <param name="pictureBox"></param>
        /// <returns></returns>
        private EErrore MostraImmagine2(string pathFoto, ref System.Windows.Forms.PictureBox pictureBox)
        {
            EErrore esito = EErrore.E0001_NOK;

            // libero pctureBox
            if (pictureBox.Image != null)
            {

                pictureBox.Image.Dispose();
            }
            pictureBox.Image = null;

            // libera this.image
            if (this.image != null)
            {

                this.image.Dispose();
            }
            this.image = null;


            // verifico che picture box contenga un indirizzo corretto
            if (pictureBox == null) 
                return EErrore.E0001_NOK;

            // verifico se il file dell'immagine esiste
            if (!File.Exists(pathFoto))
                return EErrore.E1401_ImmagineNonEsiste;
            
            // scompone il path dell'immagine e ricava il nome dell'immagine
            string [] campiImmagine = pathFoto.Split('\\');
            String nomeImmagine = campiImmagine[campiImmagine.Length - 1];

            // scompone il nome dell'immagine e ricava l'estenzione del file 
            string[] campiNomeFile = campiImmagine[campiImmagine.Length - 1].Split('.');
            String estensioneNomeImmagine = campiNomeFile[campiNomeFile.Length - 1];

            // Analizza estensione file
            switch (estensioneNomeImmagine.ToLowerInvariant())
            {
                // immagini Jpeg
                case "jpg":
                case "jpeg":
                case "jpe":
                case "jfif":
                // immagini png
                case "png":
                    esito = CaricaFoto(pathFoto, ref pictureBox);
                    if (esito != EErrore.E0000_OK)
                        return esito;
                    break;
                // immagini bmp
                case "bmp":
                case "dib":
                    esito = CaricaFoto(pathFoto, ref pictureBox);
                    if (esito != EErrore.E0000_OK)
                        return esito;
                    break;

                // immagini mov
                case "mov":
                    CDevFilm_Vlc film = new CDevFilm_Vlc();
                    esito = film.MostraFilm(pathFoto, out image);
                    if (esito != EErrore.E0000_OK)
                        return esito;
                    else
                        pictureBox.Image = image;
                    break;

                // immagini heic
                case "heic":
                    CDevImmagine dev = new CDevImmagine_Magic();
                    esito = dev.ConvertiHeicJpeg(pathFoto, out image);
                    if (esito != EErrore.E0000_OK)
                        return esito;
                    else
                        pictureBox.Image = image;
                    break;

                default:
                    return EErrore.E1402_TipoImmagineNonGestita;

            }

            return EErrore.E0000_OK;
        }
        /// <summary>
        /// Crea un immagine con la causa di errore
        /// </summary>
        /// <param name="pictureBox"></param>
        /// <param name="esito"></param>
        /// <param name="pathImmagine"></param>
        private void CreaImmagineErrore(ref System.Windows.Forms.PictureBox pictureBox, EErrore esito, string pathImmagine)
        {
            // crea una bitmap
            int larghezza = 400;
            int altezza = 200;
            Bitmap immagine = new Bitmap(larghezza, altezza);

            // Crea un oggetto Graphics
            Graphics g = Graphics.FromImage(immagine);

            // Imposta il colore di sfondo
            Brush coloreSfondo = new SolidBrush(Color.LightYellow); // O un altro colore desiderato
            g.FillRectangle(coloreSfondo, 0, 0, larghezza, altezza);

            // Definisce il font e la dimensione del testo
            Font fontTesto = new Font("Arial", 10, FontStyle.Regular);

            // Definisce il colore del testo
            Brush coloreTesto = new SolidBrush(Color.Red); // O un altro colore desiderato


            // coverte l'errore in testo
            string messaggio;
            string titolo;
            bool reso = TestoMessaggioErrore(esito, pathImmagine, out messaggio, out titolo);


            // Usa il metodo DrawString() per scrivere il testo nella posizione desiderata sull'immagine. 
            float x = 50; // Posizione orizzontale
            float y = 50; // Posizione verticale
            g.DrawString(messaggio, fontTesto, coloreTesto, x, y);
            y = 150; // Posizione verticale
            g.DrawString(titolo, fontTesto, coloreTesto, x, y);


            // Libera le risorse
            g.Dispose();
            fontTesto.Dispose();
            coloreTesto.Dispose();

            // Stampa immagine
            pictureBox.Image = immagine;

        }
        /// <summary>
        /// Fa una copia del file nella directory _TMP
        /// </summary>
        /// <param name="pathSrc"></param>
        /// <param name="pathSrcTmp"></param>
        /// <returns></returns>
        private EErrore CopiaImmagineTemporanea(string pathSrc, out string pathSrcTmp)
        {
            // inizializza pathSrcTmp
            pathSrcTmp = "";


            // verifica se esite il file sorgente
            if (!File.Exists(pathSrc))
            {
                return GstErrori.EErrore.E1360_FileSorgenteNonEsiste;
            }

            // scompone path sorgente
            string[] campiSrc = pathSrc.Split('\\');
            if (campiSrc.Length < 3)
            {
                return GstErrori.EErrore.E1312_DirectorySorgenteCampiMinimiNonPresenti;
            }

            // Estrae i dati notevoli da pathSorgente
            string ramoSrc = campiSrc[campiSrc.Length - 3];
            string foglia = campiSrc[campiSrc.Length - 2].ToUpper();
            string nome = campiSrc[campiSrc.Length - 1];

            // ----------------------------------------------------------------------------------------

            // compone path archivio
            string pathArchivio = campiSrc[0];
            for (int i = 1; i < campiSrc.Length - 3; i++)
            {
                pathArchivio += "\\" + campiSrc[i];
            }
            // aggiunge dir Archivio
            pathArchivio += "\\" + DirTMP;

            // verifica se esite la  directory Archivio
            if (!Directory.Exists(pathArchivio))
            {

                // dir Archivio non esiste, la crea
                try
                {
                    Directory.CreateDirectory(pathArchivio);
                }
                catch (IOException dirError)
                {
                    // DEBUG GG: migliorare la gestione
                    return GstErrori.EErrore.E1330_DirectoryArchivioNonEsiste;
                    //Console.WriteLine(copyError.Message);
                }
            }

            // ----------------------------------------------------------------------------------------
            // comporre path archivioFoglia
            string pathArchivioFoglia = pathArchivio + "\\" + foglia;

            // verifica se esite la  directory foglia
            if (!Directory.Exists(pathArchivioFoglia))
            {

                // la foglia non esiste, la crea
                try
                {
                    Directory.CreateDirectory(pathArchivioFoglia);
                }
                catch (IOException dirError)
                {
                    return GstErrori.EErrore.E1334_DirectoryFogliaArchivioNonEsiste;
                    //Console.WriteLine(copyError.Message);
                }
            }

            // ----------------------------------------------------------------------------------------
            // Compone il path file destinazione completo
            string pathFileDst = pathArchivioFoglia + "\\" + DirTMP + nome;

            //// verifica se esite il file destinazione
            //if (File.Exists(pathFileDst))
            //{
            //    // DEBUG GG: gestire la duplicazione
            //    return GstErrori.EErrore.E1381_FileArchivioEsiste;
            //}

            // ----------------------------------------------------------------------------------------
            // copia il file
            try
            {
                File.Copy(pathSrc, pathFileDst, true);
            }
            catch (IOException copyError)
            {
                return GstErrori.EErrore.E1382_FileArchivioNonSpostato;
                //Console.WriteLine(copyError.Message);
            }


            // Assegna path src
            pathSrcTmp = pathFileDst;


            return GstErrori.EErrore.E0000_OK;
        }
        /// <summary>
        /// cancella dir temporanea e tutto il suo contenuto
        /// </summary>
        /// <param name="pathSrc"></param>
        /// <returns></returns>
        public EErrore CancellaDirTemporanea(string pathSrc)
        {
            // scompone path della directory  sorgente
            string[] campiSrc = pathSrc.Split('\\');
            if (campiSrc.Length < 2)
            {
                return GstErrori.EErrore.E1312_DirectorySorgenteCampiMinimiNonPresenti;
            }

            // ----------------------------------------------------------------------------------------

            // compone path archivio
            string pathArchivio = campiSrc[0];
            for (int i = 1; i < campiSrc.Length - 2; i++)
            {
                pathArchivio += "\\" + campiSrc[i];
            }
            // aggiunge dir Archivio
            pathArchivio += "\\" + DirTMP;

            // verifica se esite la  directory Archivio
            if (!Directory.Exists(pathArchivio))
            {
                return EErrore.E0000_OK;

            }
            
            // Cancella la directory temporanea e tutto il suo contenuto
            try
            {
                Directory.Delete(pathArchivio, true);
            }
            catch (IOException dirError)
            {
                // DEBUG GG: migliorare la gestione
                return GstErrori.EErrore.E1330_DirectoryArchivioNonEsiste;
                //Console.WriteLine(copyError.Message);
            }

            return GstErrori.EErrore.E0000_OK;
        }
        /// <summary>
        /// Cancella file temporanei
        /// </summary>
        /// <param name="pathSrc"></param>
        /// <returns></returns>
        public EErrore CancellaFileTemporanei(string pathSrc)
        {
            // scompone path della directory  sorgente
            string[] campiSrc = pathSrc.Split('\\');
            if (campiSrc.Length < 2)
            {
                return GstErrori.EErrore.E1312_DirectorySorgenteCampiMinimiNonPresenti;
            }

            // ----------------------------------------------------------------------------------------

            // compone path archivio
            string pathArchivio = campiSrc[0];
            for (int i = 1; i < campiSrc.Length - 2; i++)
            {
                pathArchivio += "\\" + campiSrc[i];
            }
            // aggiunge dir Archivio
            pathArchivio += "\\" + DirTMP;

            // verifica se esite la  directory Archivio
            if (!Directory.Exists(pathArchivio))
            {
                return EErrore.E0000_OK;

            }

            // Cancella la directory temporanea e tutto il suo contenuto
            string fileRicerca = DirTMP + "*.*";
            try
            {
                string [] fotoTmpList = Directory.GetFiles(pathArchivio, fileRicerca, SearchOption.AllDirectories);

                foreach (var fileTMP in fotoTmpList)
                {
                    try 
                    { 
                        File.Delete(fileTMP);
                    }
                    catch 
                    {
                        ;
                    }   
                }

                //Directory.Delete(pathArchivio, true);
            }
            catch (IOException dirError)
            {
                // DEBUG GG: migliorare la gestione
                return GstErrori.EErrore.E1330_DirectoryArchivioNonEsiste;
                //Console.WriteLine(copyError.Message);
            }

            return GstErrori.EErrore.E0000_OK;
        }
        /// <summary>
        /// Carica un immagine in picturBox lasciando il file immagine libero
        /// </summary>
        /// <param name="pathFoto"></param>
        /// <param name="pictureBox"></param>
        /// <returns></returns>
        protected GstErrori.EErrore CaricaFoto(string pathFoto, ref System.Windows.Forms.PictureBox pictureBox)
        {
            // Crea uno Stream dal percorso del file
            using (FileStream fileStream = new FileStream(pathFoto, FileMode.Open, FileAccess.Read))
            {
                try
                {
                    // Carica l'immagine dallo Stream
                    this.image = Image.FromStream(fileStream);

                    // chiude il file stream
                    fileStream.Close();

                    // Assegna l'immagine al PictureBox
                    pictureBox.Image = this.image;
                }
                catch (Exception ex)
                {
                    return EErrore.E0001_NOK;
                    //MessageBox.Show("Errore nel caricamento dell'immagine: " + ex.Message);
                }
            }

            return EErrore.E0000_OK;
        }


    }// fine classe CImmagine

}// fine namespace GAlbum

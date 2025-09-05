using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Image = System.Drawing.Image;
using System.Drawing.Imaging;
using static GAlbum.GstErrori;
using System.Drawing;
using System.Security.Cryptography;

namespace GAlbum
{
    public class CImmagine
    {
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
                    pictureBox.Image = System.Drawing.Image.FromFile(@pathFoto);
                    break;
                // immagini bmp
                case "bmp":
                case "dib":
                    pictureBox.Image = System.Drawing.Image.FromFile(@pathFoto);
                    break;

                case "heic":
                    CDevImmagine dev = new CDevImmagine_Magic();
                    System.Drawing.Image image;
                    EErrore esito = dev.ConvertiHeicJpeg(pathFoto, out image);
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

    }
}

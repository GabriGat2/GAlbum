using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GAlbum
{
    public class CDevImmagine_Magic : CDevImmagine
    {
        /// <summary>
        /// costruttore
        /// </summary>
        public CDevImmagine_Magic()
        {
        }
        /// <summary>
        /// Converte un immagine heic in jpeg
        /// </summary>
        /// <param name="pathImmagine"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        public override GstErrori.EErrore ConvertiHeicJpeg(string pathImmagine, out System.Drawing.Image image)
        {
            return ConvertiHeicJpegStream(pathImmagine, out image);
        }
        /// <summary>
        /// Converte un immagine heic in jpeg usando lo stream
        /// </summary>
        /// <param name="pathImmagine"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        private GstErrori.EErrore ConvertiHeicJpegStream(string pathImmagine, out System.Drawing.Image image)
        {
            // inizializza image
            image = null;

            // Assegna il nome della foto HEIC
            string inputHeicPath = @pathImmagine;

            try
            {
                // Carica l'immagine HEIC
                using (var devImage = new MagickImage(inputHeicPath))
                {
                    // Seleziona il formato desiderato: JPEG
                    devImage.Format = MagickFormat.Jpeg;

                    // Salva l'immagine nello stram                   
                    using (MemoryStream memStream = new MemoryStream(devImage.ToByteArray()))
                    {
                        // visualizza l'immagina
                        ///using Image = System.Drawing.Image;
                        ///
                        image = System.Drawing.Image.FromStream(memStream);

                        memStream.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                return GstErrori.EErrore.E1405_ProblemiNellaConversioneDellaImmagine;
            }

            return GstErrori.EErrore.E0000_OK;

        }
        /// <summary>
        /// Converte un immagine heic in jpeg usando un file di appoggio !!! NON FUNZIONA
        /// </summary>
        /// <param name="pathImmagine"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        private GstErrori.EErrore ConvertiHeicJpegFile(string pathImmagine, out System.Drawing.Image image)
        {
            // inizializza image
            image = null;

             // Assegna il nome della foto HEIC
            string inputHeicPath = @pathImmagine;

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
                    return GstErrori.EErrore.E1403_NonRiesceACancellareImmagineAppoggio;
                }
            }


            try
            {
                // Carica l'immagine HEIC
                using (var lImage = new MagickImage(inputHeicPath))
                {
                    // Seleziona il formato desiderato: JPEG
                    lImage.Format = MagickFormat.Jpeg;

                    // Salva l'immagine in formato JPG
                    lImage.Write(outputJpgPath, MagickFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {
                return GstErrori.EErrore.E1404_NonRiesceAAggiornareImmagineAppoggio;
            }


            Bitmap MyImage = new Bitmap(outputJpgPath);

            // Carica l'immagine dal file
            //pictureBox1.Image = (Image)MyImage;
            //pictureBox1.Image = Image.FromFile(@pathFoto);
            image = System.Drawing.Image.FromFile(@outputJpgPath);
            //image = (Image)(MyImage.Clone());
            //MyImage.Dispose();



            return GstErrori.EErrore.E0000_OK;
        }


    }
}

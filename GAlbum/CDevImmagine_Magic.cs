using ImageMagick;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    Console.WriteLine($"Non si cancella: {ex.Message}");
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
                Console.WriteLine($"Errore durante la conversione: {ex.Message}");
            }


            // MyImage = new Bitmap(outputJpgPath);

            // Carica l'immagine dal file
            //pictureBox1.Image = (Image)MyImage;
            //pictureBox1.Image = Image.FromFile(@pathFoto);
            image =  Image.FromFile(@outputJpgPath);

            return GstErrori.EErrore.E0000_OK;
        }
    }
}

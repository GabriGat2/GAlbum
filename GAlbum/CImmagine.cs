using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Image = System.Drawing.Image;
using static GAlbum.GstErrori;

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
       public EErrore MostraImmagine(string pathFoto, ref System.Windows.Forms.PictureBox pictureBox)
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
                case "jpg":
                    pictureBox.Image = Image.FromFile(@pathFoto);
                    break;

                default:
                    return EErrore.E1402_TipoImmagineNonGestita;

            }

            return EErrore.E0000_OK;
        }



    }
}

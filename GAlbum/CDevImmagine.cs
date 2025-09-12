using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAlbum
{
    public class CDevImmagine
    {   
        /// <summary>
        /// costruttore
        /// </summary>
        public CDevImmagine()
        { 
        }
        /// <summary>
        /// Converte un immagine heic in jpeg
        /// </summary>
        /// <param name="pathImmagine"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        public virtual GstErrori.EErrore ConvertiHeicJpeg(string pathImmagine, out System.Drawing.Image image)
        {
            image = null;
            return GstErrori.EErrore.E1502_TipoFilmNonGestita;
        }
        /// <summary>
        /// Mostra un film, nell'immagine rende il nome del file e del tool usato per visualizzarlo
        /// </summary>
        /// <param name="pathFilm"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        public virtual GstErrori.EErrore MostraFilm(string pathFilm, out System.Drawing.Image image)
        {
            image = null;
            return GstErrori.EErrore.E1502_TipoFilmNonGestita;
        }
    }
}

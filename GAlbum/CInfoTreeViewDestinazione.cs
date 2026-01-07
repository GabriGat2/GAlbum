using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAlbum
{
    public class CInfoTreeViewDestinazione : CInfoTreeView
    { // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================



        // ==================================================================================================================
        // Metodi
        // ==================================================================================================================
        /// <summary>
        /// costruttore
        /// </summary>
        public CInfoTreeViewDestinazione()
        {
            // Definisce il tipo della tree view
            tipoTreeView = ETipoTreeView.Destinazione;

            // Configurazione di default
            RipristinaDefault();
        }
        /// <summary>
        /// ripristina i valori di default
        /// </summary>
        public override void RipristinaDefault()
        {
            // ripristina i valori di default base
            base.RipristinaDefault();

            // Configurazione di default
            MostraRami = true;
        }
    }// fine class CInfoTreeViewDestinazione
}// fine namespace GAlbum


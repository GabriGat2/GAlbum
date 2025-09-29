using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GAlbum.CInfoTreeView;

namespace GAlbum
{
    public class CInfoTreeViewSorgente : CInfoTreeView
    { // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================



        // ==================================================================================================================
        // Metodi
        // ==================================================================================================================
        /// <summary>
        /// costruttore
        /// </summary>
        public CInfoTreeViewSorgente()
        {
            // Definisce il tipo della tree view
            tipoTreeView = ETipoTreeView.Sorgente;

            // Configurazione di default
            MostraFoglie = true;
        }
    }// fine class CInfoTreeViewSorgente
}// fine namespace GAlbum


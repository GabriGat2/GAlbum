using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GAlbum.CInfoTreeView;

namespace GAlbum
{
    public class CInfoTreeViewAggiornaArgomenti : CInfoTreeView
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================



        // ==================================================================================================================
        // Metodi
        // ==================================================================================================================
        /// <summary>
        /// costruttore
        /// </summary>
        public CInfoTreeViewAggiornaArgomenti()
        {
            // Definisce il tipo della tree view
            tipoTreeView = ETipoTreeView.Sorgente;

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
            MostraFoglie = true;
            MostraRamiRiservati = false;
            MaxLivello = 1;
        }
    }// fine class CInfoTreeViewAggiornaArgomenti
}// fine namespace GAlbum

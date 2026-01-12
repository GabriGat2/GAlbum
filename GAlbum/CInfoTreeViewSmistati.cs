using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAlbum
{
    public class CInfoTreeViewSmistati : CInfoTreeView
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
        public CInfoTreeViewSmistati()
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
            MaxLivello = 10;
        }

    }//fine class CInfoTreeViewSmistati
}// fine namespace GAlbum

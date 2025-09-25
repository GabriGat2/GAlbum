using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAlbum
{
    public class CInfoTreeView
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================
        /// <summary>
        /// abilita la visualizzazione di un ramo
        /// </summary>
        public bool MostraRami { get => mostraRami; set => mostraRami = value; }
        private bool mostraRami;
        /// <summary>
        /// abilita la visualizzazione delle foglie
        /// </summary>
        public bool MostraFoglie { get => mostraFoglie; set => mostraFoglie = value; }
        private bool mostraFoglie;
        /// <summary>
        /// Abilita la visualizzazione dei rami riservati
        /// </summary>
        public bool MostraRamiRiservati { get => mostraRamiRiservati; set => mostraRamiRiservati = value; }        
        private bool mostraRamiRiservati;
        // ==================================================================================================================
        // Metodi
        // ==================================================================================================================
        /// <summary>
        /// costruttore
        /// </summary>
        public CInfoTreeView()
        {
            
        }

        
    }// fine class CInfoTreeView
}// fine namespace GAlbum

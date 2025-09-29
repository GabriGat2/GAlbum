using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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
        /// Enum dei tipi di treeView
        /// </summary>
        public enum ETipoTreeView
        {
            NonDefinito,            // 0
            Sorgente,               // 1
            Destinazione,           // 2               
        };
        /// <summary>
        /// Tipo della treeView
        /// </summary>
        public ETipoTreeView TipoTreeView { get => tipoTreeView; /* set => tipoTreeView = value;*/ }
        private ETipoTreeView tipoTreeView;
        /// <summary>
        /// abilita la visualizzazione di un ramo
        /// </summary>
        public bool MostraRami { get => mostraRami; set => mostraRami = value; }
        private bool mostraRami = false;
        /// <summary>
        /// abilita la visualizzazione delle foglie
        /// </summary>
        public bool MostraFoglie { get => mostraFoglie; set => mostraFoglie = value; }
        private bool mostraFoglie = false;
        /// <summary>
        /// Abilita la visualizzazione dei rami riservati
        /// </summary>
        public bool MostraRamiRiservati { get => mostraRamiRiservati; set => mostraRamiRiservati = value; }
        private bool mostraRamiRiservati = false;
        // ==================================================================================================================
        /// <summary>
        /// Mette qui i refatoring generati automaticamente
        /// </summary>
        private bool mettiloQui;
        public bool MettiloQui { get => mettiloQui; set => mettiloQui = value; }

        // ==================================================================================================================
        // Metodi
        // ==================================================================================================================
        /// <summary>
        /// costruttore
        /// </summary>
        public CInfoTreeView()
        {
            // Definisce il tipo della tree view
            tipoTreeView = ETipoTreeView.NonDefinito;
        }
        /// <summary>
        /// Verifica se la directory puo essere visualizzata
        /// </summary>
        /// <param name="nomeDir"></param>
        /// <returns></returns>

        public bool NomeVisibile(string nomeDir)
        {
            // verifica se è una directory riservata
            if (nomeDir[0] == '_')
                return mostraRamiRiservati;

            // verifica se è un ramo foglia
            if (Foglia(nomeDir))
                return mostraFoglie;

            // se arriva qui è un ramo
            return mostraRami;
        }

        /// <summary>
        /// Verifica se la directory è una foglia 
        /// </summary>
        /// <param name="nomeDir"></param>
        /// <returns></returns>
        private bool Foglia(string nomeDir)
        {
            switch (nomeDir.ToLower())
            {
                case "heic":
                case "jpeg":
                case "raw":
                    return true;
             
                default:
                    return false;
                    

            }

       }

    }// fine class CInfoTreeView
}// fine namespace GAlbum

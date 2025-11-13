using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAlbum
{
    public class CStatisticaOperazioni
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================
        
        public UInt32 NumeroFile;
        public UInt32 NumeroFileElaborati;
        public UInt32 NumeroFileAssegnati;
        public UInt32 NumeroFileCopiati;
        public UInt32 NumeroFileDuplicati;
        public UInt32 NumeroFileCopiati_Rinomintati;
        public UInt32 NumeroFileDuplicati_Rinomintati;

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
        public CStatisticaOperazioni()
        {
            Azzera();
        }
        /// <summary>
        /// Azzera tutti i dati statistici
        /// </summary>
        public void Azzera()
        {
            NumeroFile = 0;
            NumeroFileElaborati = 0;
            NumeroFileAssegnati = 0;
            NumeroFileCopiati = 0;
            NumeroFileDuplicati = 0;
            NumeroFileCopiati_Rinomintati = 0;
            NumeroFileDuplicati_Rinomintati = 0;
        }

    }// fine class CStatisticaOperazioni
}// fine namespace GAlbum

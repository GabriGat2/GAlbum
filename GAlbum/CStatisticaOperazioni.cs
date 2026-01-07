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
        public UInt32 NumeroFileArchiviati;
        public UInt32 NumeroFileCopiati;
        public UInt32 NumeroFileDuplicati;
        public UInt32 NumeroFileCopiati_Rinomintati;
        public UInt32 NumeroFileDuplicati_Rinomintati;

        /// <summary>
        /// Rende la percentuale di avanzamento lavoro, con un valore compreso tra 1 e 100
        /// </summary>
        public int AvanzamentoLavoro { get => CalcolaAvanzamentoLavoro(); }
     
 
        // ------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// A capo linea
        /// </summary>
        public const string ACapo = "\n";



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
            NumeroFileArchiviati = 0;
            NumeroFileCopiati = 0;
            NumeroFileDuplicati = 0;
            NumeroFileCopiati_Rinomintati = 0;
            NumeroFileDuplicati_Rinomintati = 0;
        }
        /// <summary>
        /// rende il log della statistica 
        /// </summary>
        /// <returns></returns>
        public string GetLog()
        {
            string log = string.Empty;

            log = "Numero file : " + NumeroFile.ToString() + ACapo;
            log += "NumeroFileAssegnati :" + NumeroFileAssegnati.ToString() + ACapo;
            log += "NumeroFileArchiviati :" + NumeroFileCopiati.ToString() + ACapo;
            log += ACapo;
            log += "NumeroFileCopiati :" + NumeroFileCopiati.ToString() + ACapo;
            log += "NumeroFileCopiati_Rinomintati :" + NumeroFileCopiati_Rinomintati.ToString() + ACapo;
            log += ACapo;
            log += "NumeroFileDuplicati :" + NumeroFileDuplicati.ToString() + ACapo;
            log += "NumeroFileDuplicati_Rinomintati :" + NumeroFileDuplicati_Rinomintati.ToString() + ACapo;

            return log;
        }

        /// <summary>
        /// Calcola Avanzamento Lavoro
        /// </summary>
        /// <returns></returns>
        private int CalcolaAvanzamentoLavoro()
        {
            double parziale = NumeroFileElaborati;
            double totale = NumeroFile;
            double percentuale = parziale / totale * 100.0;
            return (int)percentuale;
        }

    }// fine class CStatisticaOperazioni
}// fine namespace GAlbum

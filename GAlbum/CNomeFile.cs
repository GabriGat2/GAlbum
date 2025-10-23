using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GAlbum.CInfoTreeView;

namespace GAlbum
{
    internal class CNomeFile
    {
        // ==================================================================================================================
        // Descrizione della classe CNome File
        // ==================================================================================================================
        //
        // E:\Angelo\Prj\GAlbum\AreaArchivioBaseFoto\ArchvioTest_01\Acquisire\Andalusia\Granada\2025-05-07\Pomeriggio\GiroInTreno\JPEG\IMG_0146.jpg
        // |                                                                                                                                      |
        // |                                                                                                                                      |
        // ___  Z _________________________________________________________________________________________________________________________________
        //
        // Z = pathNomeFile
        //
        //
        //
        // E:\Angelo\Prj\GAlbum\AreaArchivioBaseFoto\ArchvioTest_01\Acquisire\Andalusia\Granada\2025-05-07\Pomeriggio\GiroInTreno\JPEG\IMG_0146.jpg
        // |                                                       |         |         |                             |           |    |        |   |
        // |                                                       |         |         |                             |           |    |        |   |
        // |                                                       |         |         |                             |           |    |        |   |
        // |___  A ________________________________________________|___ B ___|____ C __|___ D _______________________|___ E _____|_ F |___ G __|_H_|
        //
        // A = pathArchivioAttivo
        // B = dirSezione
        // C = dirArchivio
        // D = pathInterno
        // E = dirRamo
        // F = dirFoglia
        // G = nome
        // H = estensione
        //
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================
        //
        // ------------------------------------------------------------------------------------------------------------------
        // Costanti
        private const char SD = '\\';   // Separatore di directory
        //
        // ------------------------------------------------------------------------------------------------------------------
        // Porzioni del path Nome file
        //
        private string pathArchivioAttivo;      // A
        private string dirSezione;              // B
        private string dirArchivio;             // C
        private string pathInterno;             // D
        private string dirRamo;                 // E
        private string dirFoglia;               // F
        private string nome;                    // G
        private string estensione;              // H
        //
        // ------------------------------------------------------------------------------------------------------------------
        // Path nome file = A + B + C + D + E + F + G + H
        //
        private string pathNomeFile;        






        // ==================================================================================================================
        // Metodi
        // ==================================================================================================================
        //
        /// <summary>
        /// Costruttore
        /// </summary>
        /// <param name="pathArchivioAttivo"></param>
        public CNomeFile(string pathArchivioAttivo)
        {
            // Assegna path archivio base
            this.pathArchivioAttivo = pathArchivioAttivo;

            // inizializzare le porzioni del path nome file
            AzzeraPorzioni();
            
        }
        /// <summary>
        /// Azzera tutte le porzioni del path nome file ad eccezione del pathArchivioAttivo
        /// </summary>
        protected void AzzeraPorzioni()
        {
            dirSezione = String.Empty;              // B
            dirArchivio = String.Empty;             // C
            pathInterno = String.Empty;             // D
            dirRamo = String.Empty;                 // E
            dirFoglia = String.Empty;               // F
            nome = String.Empty;                    // G
            estensione = String.Empty; ;            // H
        }


        /// <summary>
        /// Set del pathNomeFile
        /// </summary>
        /// <param name="pathNomeFile"></param>
        /// <returns></returns>
        public GstErrori.EErrore SetPathNomeFile(string pathNomeFile)
        {

            // verifica che il path contenga il pathArchvioBase
            string locPathArchivioAttivo = pathNomeFile.Remove(pathArchivioAttivo.Length, pathNomeFile.Length - pathArchivioAttivo.Length);
            if (locPathArchivioAttivo.ToLower() != pathArchivioAttivo.ToLower())
            {
                AzzeraPorzioni();
                return GstErrori.EErrore.E0001_NOK;
            }

            // Estrae la porzione di archivio a valle dell'archvio attivo
            string pathNomeFileInterno = pathNomeFile.Substring(pathArchivioAttivo.Length + 1);

            // scompone il pathNomeFileInterno in campi e Verifica che ci siano i campi minimi
            string[] campi = pathNomeFileInterno.Split(SD);
            if (campi.Length < 3)
            {
                AzzeraPorzioni();
                return GstErrori.EErrore.E0001_NOK;
            }

            // Estrae il nome della sezione
            this.dirSezione = campi[0];

            // Estrae il nome dell' archivio 
            this.dirArchivio = campi[1];

            // estrae nome e estensione 
            string LNomeFile = campi[campi.Length - 1];
            string[] campiNome = LNomeFile.Split('.');
            if (campiNome.Length != 2)
            {
                AzzeraPorzioni();
                return GstErrori.EErrore.E0001_NOK;
            }
            this.nome = campiNome[0];
            this.estensione = campiNome[1];

            // estrarre il nome della foglia







            return GstErrori.EErrore.E0001_NOK;
        }


    }// fine class CNomeFile
}// fine namespace GAlbum

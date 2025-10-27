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
        //
        // ------------------------------------------------------------------------------------------------------------------
        // Sezione
        //
        /// <summary>
        /// Dir sezione
        /// </summary>
        public string DirSezione { get => dirSezione; set => dirSezione = value; }
        /// <summary>
        /// Path sezione = A + B
        /// </summary>
        public string PathSezione { get => pathSezione; set => pathSezione = value; }
        private string pathSezione;

        // ------------------------------------------------------------------------------------------------------------------
        // Archivio
        //
        /// <summary>
        /// Dir Archivio
        /// </summary>
        public string DirArchivio { get => dirArchivio; set => dirArchivio = value; }
        /// <summary>
        /// pathArchivio A + B + C 
        /// </summary>
        public string PathArchivio { get => pathArchivio; set => pathArchivio = value; }
        private string pathArchivio;


        // ------------------------------------------------------------------------------------------------------------------
        // pathInterno
        //
        /// <summary>
        /// pathInterno
        /// </summary>
        public string PathInterno { get => pathInterno; set => pathInterno = value; }

        // ------------------------------------------------------------------------------------------------------------------
        // Ramo
        //
        /// <summary>
        /// DirRamo
        /// </summary>
        public string DirRamo { get => dirRamo; set => dirRamo = value; }

        // ------------------------------------------------------------------------------------------------------------------
        // Foglia
        //
        /// <summary>
        /// DirFoglia
        /// </summary>
        public string DirFoglia { get => dirFoglia; set => dirFoglia = value; }

        // ------------------------------------------------------------------------------------------------------------------
        // Nome
        //
        /// <summary>
        /// dirNome
        /// </summary>
        public string Nome { get => nome; set => nome = value; }

        // ------------------------------------------------------------------------------------------------------------------
        // Estensione
        //
        /// <summary>
        /// DirEstensione
        /// </summary>
        public string Estensione { get => estensione; set => estensione = value; }

        // ==================================================================================================================
        /// <summary>
        /// Mette qui i refatoring generati automaticamente
        /// </summary>
        private bool mettiloQui;
        public bool MettiloQui { get => mettiloQui; set => mettiloQui = value; }
        








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
            DirSezione = String.Empty;              // B
            DirArchivio = String.Empty;             // C
            PathInterno = String.Empty;             // D
            DirRamo = String.Empty;                 // E
            DirFoglia = String.Empty;               // F
            Nome = String.Empty;                    // G
            Estensione = String.Empty; ;            // H
        }


        /// <summary>
        /// Set del pathNomeFile
        /// </summary>
        /// <param name="pathNomeFile"></param>
        /// <returns></returns>
        public GstErrori.EErrore SetPathNomeFile(string pathNomeFile)
        {

            // verifica che il path contenga il pathArchvioAttivo
            string locPathArchivioAttivo = pathNomeFile.Remove(pathArchivioAttivo.Length, pathNomeFile.Length - pathArchivioAttivo.Length);
            if (locPathArchivioAttivo.ToLower() != pathArchivioAttivo.ToLower())
            {
                AzzeraPorzioni();
                return GstErrori.EErrore.E0001_NOK;
            }

            // Estrae la porzione di archivio a valle dell'archvio attivo
            string pathNomeFileInterno = pathNomeFile.Substring(pathArchivioAttivo.Length + 1);

            // scompone il pathNomeFileInterno in campi e Verifica che ci siano i campi minimi
            string [] campi = pathNomeFileInterno.Split(SD);
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
            if (campi.Length < 4)
            {
                this.dirFoglia = string.Empty;
                this.dirRamo = string.Empty; 
                this.pathInterno = string.Empty;
                return GstErrori.EErrore.E0000_OK;
            }
            else
            {
                this.dirFoglia = campi[campi.Length - 2];
            }

            // estrarre il nome del ramo 
            if (campi.Length < 5)
            {
                this.dirRamo = string.Empty;
                this.pathInterno = string.Empty;
                return GstErrori.EErrore.E0000_OK;
            }
            else
            {
                this.dirRamo = campi[campi.Length - 3];
            }

            // estrarre il nome del path interno 
            if (campi.Length < 6)
            {
                this.pathInterno = string.Empty;
                return GstErrori.EErrore.E0000_OK;
            }
            else
            {
                this.pathInterno = campi[2];
                for (int i = 3; i < campi.Length - 3; i++)
                {
                    this.pathInterno = this.pathInterno + SD + campi[i];
                }
            }

            return GstErrori.EErrore.E0001_NOK;
        }


    }// fine class CNomeFile
}// fine namespace GAlbum

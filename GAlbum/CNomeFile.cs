using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
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
        // D = DirInterno anche se a tutti gli effetti è un dirInterno
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
        private string dirInterno;             // D
        private string dirRamo;                 // E
        private string dirFoglia;               // F
        private string nome;                    // G
        private string estensione;              // H
        //
        // ------------------------------------------------------------------------------------------------------------------
        //
        // ------------------------------------------------------------------------------------------------------------------
        // Sezione
        //
        /// <summary>
        /// Dir sezione
        /// </summary>
        public string DirSezione { get => dirSezione; set { dirSezione = value; Popola(); }}
        /// <summary>
        /// Path sezione = A + B
        /// </summary>
        //public string PathSezione { get => pathArchivioAttivo +  SD + dirSezione; /* set => pathSezione = value; */ }
        public string PathSezione { get => pathSezione; /* set => pathSezione = value; */ }
        private string pathSezione;
        /// <summary>
        /// Se conforme = TRUE significa che la il path è con forme alle regole stabilite
        /// </summary>
        public bool PathSezioneConforme { get => pathSezioneConforme; /* set => pathSzioneConforme = value;*/ }
        private bool pathSezioneConforme;

        // ------------------------------------------------------------------------------------------------------------------
        // Archivio
        //
        /// <summary>
        /// Dir Archivio
        /// </summary>
        public string DirArchivio { get => dirArchivio; set { dirArchivio = value; Popola(); }}
        /// <summary>
        /// pathArchivio =  A + B + C 
        /// </summary>
        public string PathArchivio { get => pathArchivio; /*set => pathArchivio = value;*/ }
        private string pathArchivio;
        /// <summary>
        /// Se conforme = TRUE significa che la il path è con forme alle regole stabilite
        /// </summary>
        public bool PathArchivioConforme { get => pathArchivioConforme; /* set => pathArchivioConforme = value;*/ }
        private bool pathArchivioConforme;


        // ------------------------------------------------------------------------------------------------------------------
        // dirInterno anche se a tutti gli effetti è un path
        //
        /// <summary>
        /// pathInterno
        /// </summary>
        public string DirInterno { get => dirInterno; set{ dirInterno = value; Popola(); } }
        /// <summary>
        ///  PathInterno =  A + B + C + D
        /// </summary>
        public string PathInterno { get => pathInterno; /*set => pathInterno = value;*/
        }
        private string pathInterno;
        /// <summary>
        /// Se conforme = TRUE significa che la il path è con forme alle regole stabilite
        /// </summary>
        public bool PathInternoConforme { get => pathInternoConforme; /* set => pathInternoConforme = value; */}
        private bool pathInternoConforme;

        // ------------------------------------------------------------------------------------------------------------------
        // Ramo
        //
        /// <summary>
        /// DirRamo
        /// </summary>
        public string DirRamo { get => dirRamo; set { dirRamo = value; Popola(); } }
        /// <summary>
        /// PathDirRamo = A + B + C + D + E
        /// </summary>
        public string PathRamo { get => pathRamo; /*set => pathRamo = value;*/ }
        private string pathRamo;
        /// <summary>
        /// Se conforme = TRUE significa che la il path è con forme alle regole stabilite
        /// </summary>
        public bool PathRamoConforme { get => pathRamoConforme; set => pathRamoConforme = value; }
        private bool pathRamoConforme;

        // ------------------------------------------------------------------------------------------------------------------
        // Foglia
        //
        /// <summary>
        /// DirFoglia
        /// </summary>
        public string DirFoglia { get => dirFoglia; set { dirFoglia = value; Popola(); } }
        /// <summary>
        /// pathDirFoglia= A + B + C + D + E + F
        /// </summary>
        public string PathFoglia { get => pathFoglia; /*set => pathDirFoglia = value;*/ }
        private string pathFoglia;
        /// <summary>
        ///  se conforme = TRUE significa che la il path è con forme alle regole stabilite
        /// </summary>
        public bool PathFogliaConforme { get => pathFogliaConforme; /*set => pathFogliaConforme = value;*/ }
        private bool pathFogliaConforme;

        // ------------------------------------------------------------------------------------------------------------------
        // Nome
        //
        /// <summary>
        /// Nome
        /// </summary>
        public 
            string Nome { get => nome; set  { nome = value; Popola(); } }

        // ------------------------------------------------------------------------------------------------------------------
        // Estensione
        //
        /// <summary>
        /// Estensione
        /// </summary>
        public string Estensione { get => estensione; set { estensione = value; Popola(); } }

        // ------------------------------------------------------------------------------------------------------------------
        // Nome file = Nome + estensione = G  + H
        //
        /// <summary>
        /// NomeFile
        /// </summary>
        /// 
        public string NomeFile { get => nomeFile; set => SetNomeFile(value); }
        private string nomeFile;
        /// <summary>
        /// pathNomeFile = A + B + C + D + E + F + G + H  
        /// </summary>
        public string PathNomeFile { get => pathNomeFile; /*set => pathNomeFile = value;*/ }
        private string pathNomeFile;
        /// <summary>
        /// NomeFileOk = true quando esiste none e estensione
        /// </summary>
        public bool NomeFileOK { get => nomeFileOK; set => nomeFileOK = value; }
        private bool nomeFileOK;
        /// <summary>
        ///  se conforme = TRUE significa che la il path è con forme alle regole stabilite
        /// </summary>
        public bool PathNomeFileConforme { get => pathNomeFileConforme; /*set => pathNomeFileConforme = value;*/ }
        private bool pathNomeFileConforme;

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
            DirInterno = String.Empty;              // D
            DirRamo = String.Empty;                 // E
            DirFoglia = String.Empty;               // F
            Nome = String.Empty;                    // G
            Estensione = String.Empty; ;            // H

            Popola();
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
                this.dirInterno = string.Empty;
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
                this.dirInterno = string.Empty;
                return GstErrori.EErrore.E0000_OK;
            }
            else
            {
                this.dirRamo = campi[campi.Length - 3];
            }

            // estrarre il nome del path interno 
            if (campi.Length < 6)
            {
                this.dirInterno = string.Empty;
                return GstErrori.EErrore.E0000_OK;
            }
            else
            {
                this.dirInterno = campi[2];
                for (int i = 3; i < campi.Length - 3; i++)
                {
                    this.dirInterno = this.dirInterno + SD + campi[i];
                }
            }

            // Popola variabili derivate
            Popola();

            return GstErrori.EErrore.E0000_OK;
        }
        /// <summary>
        /// Popola tutte le variabili derivate 
        /// </summary>
        private void Popola()
        {
            // popola Sezione
            if (dirSezione == string.Empty)
            {
                pathSezione = pathArchivioAttivo;
                pathSezioneConforme = false;
            }
            else 
            {
                pathSezione = pathArchivioAttivo + SD + dirSezione;
                pathSezioneConforme = true; ;
            }

            // popola Archivio
            if (dirArchivio == string.Empty)
            {
                pathArchivio = pathSezione;
                pathArchivioConforme = false;
            }
            else
            {
                pathArchivio = pathSezione + SD + dirArchivio;
                pathArchivioConforme = pathSezioneConforme;
            }

            // popola dirInterno
            if (dirInterno == string.Empty)
            {
                pathInterno = pathArchivio;
                pathInternoConforme = pathArchivioConforme; /* false; */
            }
            else
            {
                pathInterno = pathArchivio + SD + dirInterno;
                pathInternoConforme = pathArchivioConforme;
            }

            // popola dirRamo
            if (dirRamo == string.Empty)
            {
                pathRamo = pathInterno;
                pathRamoConforme = pathInternoConforme;  /* false ; */
            }
            else
            {
                pathRamo = pathInterno  + SD + dirRamo ;
                pathRamoConforme = pathInternoConforme;
            }

            // popola  DirFoglia
            if (dirFoglia == string.Empty)
            {
                pathFoglia = pathRamo;
                pathFogliaConforme = false;
            }
            else
            {
                pathFoglia = pathRamo  + SD + dirFoglia;
                pathFogliaConforme = pathRamoConforme;
            }

            // popola nome file
            if ((nome == string.Empty) || (estensione == string.Empty))
            {
                nomeFile = string.Empty;
                nomeFileOK = false;

                pathNomeFile = pathFoglia;
                pathNomeFileConforme = false;
            }
            else
            {
                nomeFile = nome + "." + estensione;
                nomeFileOK = true; 


                pathNomeFile = pathFoglia + SD + nomeFile;
                pathNomeFileConforme = pathFogliaConforme;
            }

        }
        /// <summary>
        /// imposta il nome del file
        /// </summary>
        /// <param name="nomeFile"></param>
        /// <returns></returns>
        public GstErrori.EErrore SetNomeFile(String nomeDelFile)
        {
            // estrae nome e estensione 
            string[] campiNome = nomeDelFile.Split('.');
            if (campiNome.Length != 2)
            {
                AzzeraPorzioni();
                return GstErrori.EErrore.E0001_NOK;
            }

            // Assegna nome ed estensione
            this.nome = campiNome[0];
            this.estensione = campiNome[1];

            // Ripopola tutto
            Popola();

            return GstErrori.EErrore.E0000_OK;
        }
        /// <summary>
        /// Sposta un file
        /// </summary>
        /// <param name="pathNomeFilesSrc"></param>
        /// <returns></returns>
        public GstErrori.EErrore SpostaFile(string pathNomeFileSrc)
        {
            // crea le directory di destinazione se non esistono
            try
            {
                Directory.CreateDirectory(pathFoglia);
            }
            catch (IOException errore)
            {
                return GstErrori.EErrore.E0001_NOK;
            }


            // Esegue lo spostamento del file
            try
            {
                File.Move(pathNomeFileSrc, pathNomeFile);
            }
            catch (IOException errore)
            {
                return GstErrori.EErrore.E0001_NOK;
            }

            return GstErrori.EErrore.E0000_OK;
        }



    }// fine class CNomeFile
}// fine namespace GAlbum

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAlbum
{
    public class CAreaArchivio
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================
        
        // ------------------------------------------------------------------------------------------------------------------
        // Archivio Base
        /// <summary>
        /// Path archivio base
        /// </summary>
        public string PathArchivioBase { get => pathArchivioBase; set => pathArchivioBase = SetPathArchivioBase(value); }
        private string pathArchivioBase;
        /// <summary>
        /// nome archivio base
        /// </summary>
        public string DirArchivioBase { get => GetDirArchivioBase(); /* set => dirArchivioBase = value; */ }
        private string dirArchivioBase;
        /// <summary>
        /// Vero se l'archivio base é disponibile all'uso
        /// </summary>
        public bool ArchivioBaseOK { get => TestPathArchivioBase(); /* set => archivioBaseOK = value; */ }
                
        // ------------------------------------------------------------------------------------------------------------------
        // Archivio Attivo
        /// <summary>
        /// Nome archivio Attivo
        /// </summary>
        public string DirArchivioAttivo { get => dirArchivioAttivo;  set => dirArchivioAttivo = SetArchivioAttivo(value); }
        private string dirArchivioAttivo;
        /// <summary>
        /// Path archivio attivo
        /// </summary>
        public string PathArchivioAttivo { get => GetPathArchivioAttivo(); /* set => dirArchivioAttivo = value; */ }
        /// <summary>
        /// Vero se l'archivio attivo é disponibile all'uso
        /// </summary>
        public bool ArchivioAttivoOK { get => TestPathArchivioAttivo(); /* set => archivioBaseOK = value; */ }
        /// <summary>
        /// Separa directory
        /// </summary>
        public const string SepDir = "\\";

        // ------------------------------------------------------------------------------------------------------------------
        // Archivio Attivo:  Acquisire
        /// <summary>
        /// Nome della dir:  Acquisire
        /// </summary>
        public const string DirAcquisire = "Acquisire";
        /// <summary>
        /// path della dir: Acquisire
        /// </summary>
        public string PathAcquisire { get => PathArchivioAttivo + SepDir + DirAcquisire; /* set => pathDaAcquisire = value; */ }

        // ------------------------------------------------------------------------------------------------------------------
        // Archivio Attivo:  Smistare
        /// <summary>
        /// Nome della dir:  smistare
        /// </summary>
        public const string DirSmistare = "Smistare";
        /// <summary>
        /// path della dir:  Smistare
        /// </summary>
        public string PathSmistare { get => PathArchivioAttivo + SepDir + DirSmistare; /* set => pathDaSmistare = value; */ }


        // ------------------------------------------------------------------------------------------------------------------
        // Archivio Attivo: Smistati
        /// <summary>
        /// Nome della dir: Smistati
        /// </summary>
        public const string DirSmistati = "Smistati";
        /// <summary>
        /// path della dir: Smistati
        /// </summary>
        public string PathSmistati { get => PathArchivioAttivo + SepDir + DirSmistati; /* set => pathSmistati = value; */ }


        // ------------------------------------------------------------------------------------------------------------------
        // Prefissi
        private const string prefissoCopia = "_C_";
        private const string prefissoDuplica = "_D_";



        //-------------------------------------------------------------------------------------------------------------------
        // Nomi delle directory

        private const string DirArchivio = "_Archivio";

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
        public CAreaArchivio() 
        {
            InizializzaClasse();
        }
        /// <summary>
        /// Inizializza la classe
        /// </summary>
        private void InizializzaClasse()
        {
            // DUBUG_GG 
            //pathArchivioAttivo = "";
            pathArchivioBase = "E:\\Angelo\\Prj\\GAlbum\\AreaArchivioBaseFoto";
            dirArchivioAttivo = "";


        }
        /// <summary>
        /// crea area archivio
        /// </summary>
        /// <param name="NomeAreaArchivio"></param>
        public GstErrori.EErrore CreaAreaArchivio(string NomeAreaArchivio)
        {
            GstErrori.EErrore esito = GstErrori.EErrore.E0001_NOK;

            // verifica se archivio base esiste 
            if (!Directory.Exists(pathArchivioBase))
            {
                return GstErrori.EErrore.E1340_ArchivioBaseNonEsiste;
            }

            // verifica che il nome archivio non sia illecito
            if (NomeAreaArchivio.Length < 1)
            {
                return GstErrori.EErrore.E1352_NomeArchivioIllecito;
            }

            // compone il path del nome archivio
            string pathNomeArchivio = pathArchivioBase + "\\" + NomeAreaArchivio;

            // verifica che l'archivio non esista
            if (Directory.Exists(pathNomeArchivio))
            {
                return GstErrori.EErrore.E1351_ArchivioEsiste;
            }

            // crea la directory archivio 
            try
            {
                Directory.CreateDirectory(pathNomeArchivio);
            }
            catch (Exception e)
            {
                return GstErrori.EErrore.E1353_NonPuoCreareArchivio;
            }

            // crea le sotto directory principali
            // ----------------------------------

            // compone il path della directory acquisire
            string pathDaAcquisire = pathNomeArchivio + "\\" + DirAcquisire;

            // crea directory acquisire
            try
            {
                Directory.CreateDirectory(pathDaAcquisire);
            }
            catch (Exception e)
            {
                return GstErrori.EErrore.E1353_NonPuoCreareArchivio;
            }

            // compone il path della directory DaSmistare
            string pathDaSmistare = pathNomeArchivio + "\\" + DirSmistare;

            // crea directory DaSmistare
            try
            {
                Directory.CreateDirectory(pathDaSmistare);
            }
            catch (Exception e)
            {
                return GstErrori.EErrore.E1353_NonPuoCreareArchivio;
            }

            // compone il path della directory Smistati
            string pathSmistati = pathNomeArchivio + "\\" + DirSmistati;

            // crea directory DaSmistare
            try
            {
                Directory.CreateDirectory(pathSmistati);
            }
            catch (Exception e)
            {
                return GstErrori.EErrore.E1353_NonPuoCreareArchivio;
            }

            // compone il path della directory _Archivio
            string path_Archivio = pathDaSmistare + "\\" + DirArchivio;

            // crea directory _Archivio in DaSmistare
            try
            {
                Directory.CreateDirectory(path_Archivio);
            }
            catch (Exception e)
            {
                return GstErrori.EErrore.E1353_NonPuoCreareArchivio;
            }

            return GstErrori.EErrore.E0000_OK;
        }
        /// <summary>
        /// Rende il path dell'archivio attivo
        /// </summary>
        /// <returns></returns>
        public string GetPathArchivioAttivo()
        {
            // verifica che il nome dell'archivio attivo sia coerente
            if (dirArchivioAttivo.Length < 1)
                return "";

            // compone il path dell'archivio attivo
            string pathArchivioAttivo = PathArchivioBase + "\\" + dirArchivioAttivo;

            // verifica che la directory esiste
            if (!Directory.Exists(pathArchivioAttivo))
                return "";

            // L'archivio attivo esiste rende il relativo path
            return pathArchivioAttivo;

        }
        /// <summary>
        /// Rende il path dell'archivio attivo
        /// </summary>
        /// <returns></returns>
        protected string SetArchivioAttivo(string dirArchivio)
        {
            // verifica il nome dell Archivio
            if (!VerificaNomeArchivioSelezionato(dirArchivio))
                return "";

            //// verifica che il nome dell'archivio attivo sia coerente
            //if (dirArchivio.Length < 1)
            //    return "";

            //// compone il path dell'archivio attivo
            //string pathArchivioAttivo = PathArchivioBase + "//" + dirArchivioAttivo;

            //// verifica che la directory esiste
            //if (!Directory.Exists(pathArchivioAttivo))
            //    return "";

            // L'archivio attivo esiste rende il nome dell'archivio attivo\
            return dirArchivio;

        }
        /// <summary>
        /// Verifica il nome dell'archivio selezionato
        /// </summary>
        /// <param name="dirArchivioSelezionato"></param>
        /// <returns></returns>
        public bool VerificaNomeArchivioSelezionato(string dirArchivioSelezionato)
        {
            // verifica che il nome dell'archivio attivo sia coerente
            if (dirArchivioSelezionato.Length < 1)
                return false;

            // compone il path dell'archivio selezionato
            string pathArchivioSelezionato = PathArchivioBase + "//" + dirArchivioSelezionato;

            // verifica che la directory esiste
            if (!Directory.Exists(pathArchivioSelezionato))
                return false;

            return true;
        }
        /// <summary>
        /// Verifica se l'archivio attivo è disponibile
        /// </summary>
        /// <returns></returns>
        protected Boolean TestPathArchivioAttivo()
        {
            // verifica l'archivio base 
            if (!ArchivioBaseOK)
                return false;

            // verifica che il nome dell'archivio attivo sia coerente
            if (dirArchivioAttivo.Length < 1)
                return false;

            // compone il path dell'archivio attivo
            string pathArchivioAttivo = PathArchivioBase + "//" + dirArchivioAttivo;

            // verifica che la directory esiste
            if (!Directory.Exists(pathArchivioAttivo))
                return false;

            return true;
        }
        /// <summary>
        /// Verifica ed eventualmente imposta il Path dell'archivio base
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        protected string SetPathArchivioBase(string path)
        {
            // verifica che la directory esiste
            if (!Directory.Exists(path))
                return "";

            // Azzera il nome della directory
            this.dirArchivioAttivo = "";

            return path;
        }
        /// <summary>
        /// Verifica se l'archivio base è disponibile
        /// </summary>
        /// <returns></returns>
        protected Boolean TestPathArchivioBase()
        {
            // verifica che la directory esiste
            return  Directory.Exists(pathArchivioBase);
        }
        /// <summary>
        /// Rende il nome dell'archivio base
        /// </summary>
        /// <returns></returns>
        protected string GetDirArchivioBase()
        {
            // verifica lo stato dell'archivio base
            if (!ArchivioBaseOK)
                return "";

            // Scompone il path dell'archivio base
            string[] campi = pathArchivioBase.Split('\\');
            return campi[campi.Length - 1];
        }
        /// <summary>
        ///  Esegue l'acquisizione di un archivio
        /// </summary>
        /// <param name="pathArchivio"></param>
        /// <returns></returns>
         public GstErrori.EErrore Acquisire(string pathArchivio)
         {
            GstErrori.EErrore esito;
            bool acquisito;

            // recupera il path di tutti i file contenuti in questa directory e le sue subdirerectory
            string [] listaPathFile = Directory.GetFiles(pathArchivio, "*.*", SearchOption.AllDirectories);

            // Crea gli oggetti per gestire la copia dei file
            CNomeFile fileSrc = new CNomeFile(PathArchivioAttivo);
            CNomeFile fileDst = new CNomeFile(PathArchivioAttivo);
            CNomeFile fileCopia = new CNomeFile(PathArchivioAttivo);
            CNomeFile fileDuplica = new CNomeFile(PathArchivioAttivo);

            // Elabola ogni file contenuto nella lista
            foreach (var pathFile in listaPathFile)
            {
                // inizializza le classi per la gestione del file
                esito = fileSrc.SetPathNomeFile(pathFile);
                if (esito != GstErrori.EErrore.E0000_OK)
                    return esito;
                esito = fileDst.SetPathNomeFile(pathFile);
                esito = fileCopia.SetPathNomeFile(pathFile);
                esito = fileDuplica.SetPathNomeFile(pathFile);

                // Aggiusta destinazione
                fileDst.DirSezione = DirSmistare;

                // Prepara per copia
                fileCopia.DirArchivio = prefissoCopia + fileCopia.DirArchivio;

                // Prepara per duplica
                fileDuplica.DirArchivio = prefissoDuplica + fileDuplica.DirArchivio;

                // Verifica se il file è già stato acquisito
                esito = fileDst.VerificaFileAssenteInSezione(fileSrc);
                acquisito = (esito == GstErrori.EErrore.E0000_OK);

                // esegue la copia 
                if (acquisito)
                {
                    esito = fileDst.CopiaFile(fileSrc);
                    if (esito != GstErrori.EErrore.E0000_OK)
                    {
                        return esito;   
                    }
                }

                // archivia il file dopo l'aquisizione
                if (acquisito)
                {
                    // Sposta il file sorgente nei file copiati
                    fileCopia.SpostaFile(fileSrc.PathNomeFile);


                }
                else
                {
                    // sposta il file sorgente nei file duplicati
                    fileDuplica.SpostaFile(fileSrc.PathNomeFile);
                }


            }





            return GstErrori.EErrore.E0000_OK;        
         }

    }// fine class CAreaArchivio
}// fine namespace CAreaArchivio

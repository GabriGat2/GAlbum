using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GAlbum.GstErrori;

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

        // ------------------------------------------------------------------------------------------------------------------
        // ------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// Separa directory
        /// </summary>
        public const string SepDir = "\\";
        /// <summary>
        /// A capo linea
        /// </summary>
        public const string ACapo = "\n";

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
        private const string DirCronologiaFoto = "CronologiaFoto";

        //-------------------------------------------------------------------------------------------------------------------
        // Statistica operazioni
        private CStatisticaOperazioni statisticaAcquisire = new CStatisticaOperazioni();
        private CStatisticaOperazioni statisticaSelezionaPerData = new CStatisticaOperazioni();
        private CStatisticaOperazioni statisticaAssegna = new CStatisticaOperazioni();


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

            // compone il path della directory CronologiaFoto
            string path_CronologiaFoto = pathSmistati + "\\" + DirCronologiaFoto;

            // crea directory CronologiaFoto in Smistati
            try
            {
                Directory.CreateDirectory(path_CronologiaFoto);
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
        public GstErrori.EErrore Acquisire(string pathArchivio, ref System.Windows.Forms.ProgressBar progressBar, bool stampaEsito = true)
        {
            // Azzera tutti i dati statistici di acquisire
            statisticaAcquisire.Azzera();
            
            // Inizilizza progressBar
            progressBar.Value = 0;
            progressBar.Visible = true;
            
            // Chiama Acquisire2
            GstErrori.EErrore esito = Acquisire2(pathArchivio, ref progressBar);

            // Verifica se deve stampare l'esito
            if (stampaEsito)
            {
                FormLog formLog = new FormLog();

                // Messaggio di intestazione
                formLog.Log = "Acquisire" + ACapo;
                formLog.Log = "====================================================================" + ACapo;
                formLog.Log = ACapo;
                formLog.Log = ACapo;

                formLog.Log = "L'operazione Acquisire si è conclusa con il seguente esito:" + ACapo;
                formLog.Log = GstErrori.RestultToSting(esito) + ACapo;
                formLog.Log = ACapo;
                formLog.Log = ACapo;
                formLog.Log = "I dati statistici dell'operazione sono i seguenti:" + ACapo;
                formLog.Log = statisticaAcquisire.GetLog();

                // Stampa il risultato
                formLog.ShowDialog();

            }

            // nasconde progressBar
            progressBar.Visible = false;

            return esito;
        }
        /// <summary>
        ///  Esegue l'acquisizione di un archivio
        /// </summary>
        /// <param name="pathArchivio"></param>
        /// <returns></returns>
        public GstErrori.EErrore Acquisire2(string pathArchivio, ref System.Windows.Forms.ProgressBar progressBar)
        {
            GstErrori.EErrore esito;
            bool assente;

            // recupera il path di tutti i file contenuti in questa directory e le sue subdirerectory
            string[] listaPathFile = Directory.GetFiles(pathArchivio, "*.*", SearchOption.AllDirectories);
            // aggiorna dati statistici
            statisticaAcquisire.NumeroFile = (UInt32) listaPathFile.Length;


            // Crea gli oggetti per gestire la copia dei file
            CNomeFile fileSrc = new CNomeFile(PathArchivioAttivo);
            CNomeFile fileDst = new CNomeFile(PathArchivioAttivo);
            CNomeFile fileCopia = new CNomeFile(PathArchivioAttivo);
            CNomeFile fileDuplica = new CNomeFile(PathArchivioAttivo);

            // Elabola ogni file contenuto nella lista
            foreach (var pathFile in listaPathFile)
            {
                // Incrementa file elaborati
                statisticaAcquisire.NumeroFileElaborati++;
                progressBar.Value = statisticaAcquisire.AvanzamentoLavoro;

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

                // Verifica se il file è già stato assente
                esito = fileDst.VerificaFileAssenteInSezione(fileSrc);
                assente = (esito == GstErrori.EErrore.E0000_OK);

                // esegue la copia 
                if (assente)
                {
                    esito = fileDst.CopiaFile(fileSrc);
                    if (esito != GstErrori.EErrore.E0000_OK)
                        return esito;

                    // aggiorna dati statistici
                    statisticaAcquisire.NumeroFileAssegnati++;
                }

                // archivia il file dopo l'aquisizione
                if (assente)
                {
                    // Sposta il file sorgente nei file copiati
                    esito = fileCopia.SpostaFile(fileSrc.PathNomeFile);
                    if (esito != GstErrori.EErrore.E0000_OK)
                        return esito;

                    // aggiorna dati statistici
                    statisticaAcquisire.NumeroFileCopiati++;

                    // controlla se ha rimonato il file prima di spostarlo in copiati
                    if (fileCopia.Nome != fileSrc.Nome)
                        statisticaAcquisire.NumeroFileCopiati_Rinomintati++;
                }
                else
                {
                    // sposta il file sorgente nei file duplicati
                    esito = fileDuplica.SpostaFile(fileSrc.PathNomeFile);
                    if (esito != GstErrori.EErrore.E0000_OK)
                        return esito;

                    // aggiorna dati statistici
                    statisticaAcquisire.NumeroFileDuplicati++;

                    // controlla se ha rimonato il file prima di spostarlo in duplicati
                    if (fileDuplica.Nome != fileSrc.Nome)
                        statisticaAcquisire.NumeroFileDuplicati_Rinomintati++;

                }
            }

            return GstErrori.EErrore.E0000_OK;
        }
         /// <summary>
        /// Ordina le foto in funzione della data
        /// </summary>
        /// <param name="pathArchivioSrc"></param>
        /// <param name="pathArchivioDst"></param>
        /// <param name="stampaEsito"></param>
        /// <returns></returns>
        public GstErrori.EErrore SelezionePerData(string pathArchivioSrc, string pathArchivioDst, ref System.Windows.Forms.ProgressBar progressBar, bool stampaEsito = true)
        {
            // Azzera tutti i dati statistici di acquisire
            statisticaSelezionaPerData.Azzera();

            // Inizilizza progressBar
            progressBar.Value = 0;
            progressBar.Visible = true;


            // Chiama SelezionePerData2
            GstErrori.EErrore esito = SelezionePerData2(pathArchivioSrc, pathArchivioDst, ref progressBar);

            // Verifica se deve stampare l'esito
            if (stampaEsito)
            {
                FormLog formLog = new FormLog();

                // Messaggio di intestazione
                formLog.Log = "Selezione Per Data" + ACapo;
                formLog.Log = "====================================================================" + ACapo;
                formLog.Log = ACapo;
                formLog.Log = ACapo;

                formLog.Log = "L'operazione di Selezione Per Data si è conclusa con il seguente esito:" + ACapo;
                formLog.Log = GstErrori.RestultToSting(esito) + ACapo;
                formLog.Log = ACapo;
                formLog.Log = ACapo;
                formLog.Log = "I dati statistici dell'operazione sono i seguenti:" + ACapo;
                formLog.Log = statisticaSelezionaPerData.GetLog();

                // Stampa il risultato
                formLog.ShowDialog();

            }

            // nasconde progressBar
            progressBar.Visible = false;

            return esito;

        }
        /// <summary>
        /// Ordina le foto in funzione della data
        /// </summary>
        /// <param name="pathArchivioSrc"></param>
        /// <param name="pathArchivioDst"></param>
        /// <returns></returns>
        public GstErrori.EErrore SelezionePerData2(string pathArchivioSrc, string pathArchivioDst, ref System.Windows.Forms.ProgressBar progressBar)
        {
            GstErrori.EErrore esito;
            bool duplica;

            // recupera il path di tutti i file contenuti in questa directory sorgente  e le sue subdirerectory
            string[] listaPathFile = Directory.GetFiles(pathArchivioSrc, "*.*", SearchOption.AllDirectories);
            // aggiorna dati statistici
            statisticaSelezionaPerData.NumeroFile = (UInt32)listaPathFile.Length;

            // Crea gli oggetti per gestire la copia dei file
            CNomeFile fileSrc = new CNomeFile(PathArchivioAttivo);
            CNomeFile fileDst = new CNomeFile(PathArchivioAttivo);
            CNomeFile fileCopia = new CNomeFile(PathArchivioAttivo);
            CNomeFile fileDuplica = new CNomeFile(PathArchivioAttivo);
            CNomeFile fileArchiviato = new CNomeFile(PathArchivioAttivo);

            // inizializza parzialmente il path del file destinazione
            esito = fileDst.SetPathArchivio(pathArchivioDst);
            if (esito != GstErrori.EErrore.E0000_OK)
                return esito;

            // inizializza parzialmente il path del file archiviato 
            fileArchiviato.DirSezione = DirSmistare;
            fileArchiviato.DirArchivio = DirArchivio;


            // Elabola ogni file contenuto nella lista
            foreach (var pathFile in listaPathFile)
            {
                // Incrementa file elaborati
                statisticaSelezionaPerData.NumeroFileElaborati++;
                progressBar.Value = statisticaSelezionaPerData.AvanzamentoLavoro;

                // inizializza fileSrc
                esito = fileSrc.SetPathNomeFile(pathFile);
                if (esito != GstErrori.EErrore.E0000_OK)
                    return esito;
                //  verifica che fileSrc esiste
                if (!fileSrc.PathNomeFileEsiste)
                    return GstErrori.EErrore.E1360_FileSorgenteNonEsiste;
                // estrae la data del file sorgente
                DateTime fileSrcData = File.GetLastWriteTime(fileSrc.PathNomeFile);


                // Aggiusta destinazione
                fileDst.DirInterno = fileSrcData.Year.ToString();
                fileDst.DirRamo = fileSrcData.Year.ToString() + "-" + fileSrcData.Month.ToString("00");
                fileDst.DirFoglia = fileSrc.DirFoglia;
                fileDst.NomeFile = fileSrc.NomeFile;

                // Prepara per copia
                esito = fileCopia.SetPathNomeFile(pathFile);
                fileCopia.DirArchivio = prefissoCopia + fileCopia.DirArchivio;

                // Prepara per duplica
                esito = fileDuplica.SetPathNomeFile(pathFile);
                fileDuplica.DirArchivio = prefissoDuplica + fileDuplica.DirArchivio;

                // prepara archiviato 
                fileArchiviato.DirFoglia = fileSrc.DirFoglia;
                fileArchiviato.NomeFile = fileSrc.NomeFile;

                // esegue la copia in destinazione
                duplica = false;
                esito = fileDst.CopiaFile(fileSrc);
                if (esito == GstErrori.EErrore.E1371_FileDestinazioneEsiste)
                {
                    // richiede la duplicazione
                    duplica = true;
                }
                else if (esito != GstErrori.EErrore.E0000_OK)
                    return esito;
                else if (esito == GstErrori.EErrore.E0000_OK)
                {
                    // aggiorna dati statistici
                    statisticaSelezionaPerData.NumeroFileAssegnati++;
                }

                // esegue la copia in _Archivio
                esito = fileArchiviato.CopiaFile(fileSrc);
                if (esito != GstErrori.EErrore.E0000_OK)
                {
                    if (!duplica)
                        return esito;
                }
                else
                {
                    // aggiorna dati statistici
                    statisticaSelezionaPerData.NumeroFileArchiviati++;
                }


                // archivia il file dopo l'aquisizione
                if (! duplica)
                {
                    // Sposta il file sorgente nei file copiati
                    esito = fileCopia.SpostaFile(fileSrc.PathNomeFile);
                    if (esito != GstErrori.EErrore.E0000_OK)
                        return esito;

                    // aggiorna dati statistici
                    statisticaSelezionaPerData.NumeroFileCopiati++;

                    // controlla se ha rimonato il file prima di spostarlo in copiati
                    if (fileCopia.Nome != fileSrc.Nome)
                        statisticaSelezionaPerData.NumeroFileCopiati_Rinomintati++;
                }
                else
                {
                    // sposta il file sorgente nei file duplicati
                    esito = fileDuplica.SpostaFile(fileSrc.PathNomeFile);
                    if (esito != GstErrori.EErrore.E0000_OK)
                        return esito;

                    // aggiorna dati statistici
                    statisticaSelezionaPerData.NumeroFileDuplicati++;

                    // controlla se ha rimonato il file prima di spostarlo in duplicati
                    if (fileDuplica.Nome != fileSrc.Nome)
                        statisticaSelezionaPerData.NumeroFileDuplicati_Rinomintati++;

                }
            }

            return GstErrori.EErrore.E0000_OK;
        }
        /// <summary>
        /// Asegue l'assegnazione di un file negli archivi specificati
        /// </summary>
        /// <param name="pathSrc"></param>
        /// <param name="pathDestinazioni"></param>
        /// <param name="copia"></param>
        /// <param name="copiaParallelo"></param>
        /// <param name="progressBar"></param>
        /// <param name="stampaEsito"></param>
        /// <returns></returns>
        public GstErrori.EErrore Assegna(   string pathSrc, 
                                            List<String> pathDestinazioni, 
                                            bool copia, 
                                            bool copiaParallelo,
                                            ref System.Windows.Forms.ProgressBar progressBar,
                                            bool stampaEsito = true)
        {
            // Azzera tutti i dati statistici di acquisire
            statisticaAssegna.Azzera();

            // Inizilizza progressBar
            progressBar.Value = 0;
            progressBar.Visible = true;


            // Chiama SelezionePerData2
            GstErrori.EErrore esito = AssegnaInterna(pathSrc, pathDestinazioni, copia, copiaParallelo, ref progressBar);

            // Verifica se deve stampare l'esito
            if (stampaEsito && (esito != GstErrori.EErrore.E0000_OK))
            {
                FormLog formLog = new FormLog();

                // Messaggio di intestazione
                formLog.Log = "Assegna" + ACapo;
                formLog.Log = "====================================================================" + ACapo;
                formLog.Log = ACapo;
                formLog.Log = ACapo;

                formLog.Log = "L'operazione Assegna si è conclusa con il seguente esito:" + ACapo;
                formLog.Log = GstErrori.RestultToSting(esito) + ACapo;
                formLog.Log = ACapo;
                formLog.Log = ACapo;
                formLog.Log = "I dati statistici dell'operazione sono i seguenti:" + ACapo;
                formLog.Log = statisticaSelezionaPerData.GetLog();

                // Stampa il risultato
                formLog.ShowDialog();

            }

            // nasconde progressBar
            progressBar.Visible = false;

            return esito;

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pathSrc"></param>
        /// <param name="pathDestinazioni"></param>
        /// <param name="copia"></param>
        /// <param name="copiaParallelo"></param>
        /// <param name="progressBar"></param>
        /// <returns></returns>
        public GstErrori.EErrore AssegnaInterna(string pathSrc,
                                            List<String> pathDestinazioni,
                                            bool copia,
                                            bool copiaParallelo,
                                            ref System.Windows.Forms.ProgressBar progressBar)
        {
            // Assegna il file specificato
            EErrore esito = Assegna2(pathSrc, pathDestinazioni, copia);
            if (esito != EErrore.E0000_OK)
            {
                GstErrori.StampaMessaggioErrore(esito, pathSrc);
            }

            // copia parallela: cerca nelle altre foglie il file specificato e lo assegna
            if (copiaParallelo)
            {
                esito = AssegnaInParallelo(pathSrc, pathDestinazioni, copia);
                if (esito != EErrore.E0000_OK)
                {
                    GstErrori.StampaMessaggioErrore(esito, pathSrc);
                }
            }


            return esito;
        }
        /// <summary>
        /// Assegna un file a varie destinazioni
        /// </summary>
        /// <param name="pathSrc"> path + nome del file sorgente </param>
        /// <param name="pathDestinazioni"> Lista dei path di destinazione senza il nome del file </param>
        /// <returns></returns>
        public GstErrori.EErrore Assegna2(string pathSrc, List<String> pathDestinazioni, bool copia)
        {
            GstErrori.EErrore esito = GstErrori.EErrore.E0001_NOK;

            // Dichiara gli oggetti file nome
            CNomeFile fileSrc = new CNomeFile(PathArchivioAttivo);
            CNomeFile fileDst = new CNomeFile(PathArchivioAttivo);
            CNomeFile fileArchiviato = new CNomeFile(PathArchivioAttivo);


            // inizializza fileSrc
            esito = fileSrc.SetPathNomeFile(pathSrc);
            if (esito != GstErrori.EErrore.E0000_OK)
                return esito;
            //  verifica che fileSrc esiste
            if (!fileSrc.PathNomeFileEsiste)
                return GstErrori.EErrore.E1360_FileSorgenteNonEsiste;

            // inizializza parzialmente il path del file archiviato 
            fileArchiviato.DirSezione = DirSmistare;
            fileArchiviato.DirArchivio = DirArchivio;


            // Esegue le copie nel numero specificato dalla lista destinazioni
            if (copia)
            {
                foreach (var pathDst in pathDestinazioni)
                {
                    // compone il path di destinazione
                    string pathNomeFileDst = pathDst + SepDir + fileSrc.DirFoglia + SepDir + fileSrc.NomeFile;
                    esito = fileDst.SetPathNomeFile(pathNomeFileDst);
                    if (esito != GstErrori.EErrore.E0000_OK)
                        return esito;

                    // Esegue la copia
                    esito = fileDst.CopiaFile(fileSrc);
                    if (esito != GstErrori.EErrore.E0000_OK)
                        return esito;
                    else if (esito == GstErrori.EErrore.E0000_OK)
                    {
                        // aggiorna dati statistici
                        statisticaAssegna.NumeroFileAssegnati++;
                    }
                }
            }


            // prepara archiviato 
            fileArchiviato.DirFoglia = fileSrc.DirFoglia;
            fileArchiviato.NomeFile = fileSrc.NomeFile;

            // esegue la copia in _Archivio
            esito = fileArchiviato.CopiaFile(fileSrc);
            if (esito != GstErrori.EErrore.E0000_OK)
            {
                return esito;
            }
            else
            {
                // aggiorna dati statistici
                statisticaAssegna.NumeroFileArchiviati++;
            }

            return GstErrori.EErrore.E0000_OK;
        }
        /// <summary>
        /// Esegue la copia in parallelo: assena un file, prelevato da tutte le foglie, a varie destinazioni
        /// </summary>
        /// <param name="pathSrc"></param>
        /// <param name="pathDestinazioni"></param>
        /// <returns></returns>
        private GstErrori.EErrore AssegnaInParallelo(string pathSrc, List<String> pathDestinazioni, bool copia)
        {
            GstErrori.EErrore esito = GstErrori.EErrore.E0001_NOK;

            // Dichiara gli oggetti file nome
            CNomeFile fileSrc = new CNomeFile(PathArchivioAttivo);
            CNomeFile fileDst = new CNomeFile(PathArchivioAttivo);
            CNomeFile fileSrcFoglia = new CNomeFile(PathArchivioAttivo);

            // inizializza fileSrc
            esito = fileSrc.SetPathNomeFile(pathSrc);
            if (esito != GstErrori.EErrore.E0000_OK)
                return esito;
            //  verifica che fileSrc esiste
            if (!fileSrc.PathNomeFileEsiste)
                return GstErrori.EErrore.E1360_FileSorgenteNonEsiste;




            //// scompone il file sorgente e ricava le sue caratteristiche
            //string pathBase;
            //string ramo;
            //string foglia;
            //string nome;
            //esito = ScomponePath(pathSrc, out pathBase, out ramo, out foglia, out nome);
            //if (esito != EErrore.E0000_OK)
            //    return esito;

            //// Scompone il nome del file
            //string nomeSE;
            //string estensione;
            //esito = ScomponeNome(nome, out nomeSE, out estensione);

            //// compone il path del ramo
            //string pathRamo = pathBase + "\\" + ramo;

            // compone la lista delle foglie 
            string[] pathFoglie = Directory.GetDirectories(fileSrc.PathRamo);
            //string[] pathFoglie = Directory.GetDirectories(pathRamo);

            foreach (var pathFoglia in pathFoglie)
            {
                // estrae nome foglia 
                string[] campiFoglia = pathFoglia.Split('\\');
                if (campiFoglia.Length < 2)
                {
                    return GstErrori.EErrore.E1312_DirectorySorgenteCampiMinimiNonPresenti;
                }
                string nomeFoglia = campiFoglia[campiFoglia.Length - 1];

                // verifica che non sia la foglia sorgente 
                if (nomeFoglia.ToUpper() == fileSrc.DirFoglia.ToUpper())
                    continue;

                // compone la lista dei file 
                string[] pathNomi = Directory.GetFiles(pathFoglia, fileSrc.Nome + ".*");

                // esamina i file nella lista 
                foreach (var pathNuovoNome in pathNomi)
                {
                    esito = Assegna2(pathNuovoNome, pathDestinazioni, copia);
                    if (esito != EErrore.E0000_OK)
                        return esito;
                }
            }

            return GstErrori.EErrore.E0000_OK;
        }


    }// fine class CAreaArchivio

}// fine namespace GAlbum

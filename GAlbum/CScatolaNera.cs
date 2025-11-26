using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GAlbum
{
    public class CScatolaNera
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================
        /// <summary>
        /// riferiemnto all'area archivio
        /// </summary>
        protected CAreaArchivio AreaArchivio = null;
        /// <summary>
        /// true quando la scatola nera é in registrazione
        /// </summary>
        private bool Attiva;
        /// <summary>
        /// Storia delle azioni registrate 
        /// </summary>
        private string Storia;
        /// <summary>
        /// nome del file di log
        /// </summary>
        private string NomeFile;
        /// <summary>
        /// Data inizio operazioni
        /// </summary>
        private DateTime DataInizio;
        /// <summary>
        ///Indentazione
        /// </summary>
        private int Indentazione { get => LIndentazione; set => CalcolaIndentazione(value); }
        private int LIndentazione;
        /// <summary>
        /// Stringa di indentazione
        /// </summary>
        private string SIndentazione;
        /// <summary>
        /// Numero della linea attuale
        /// </summary>
        private uint NumeroLinea;
        /// <summary>
        /// Penultima data-ora rilevata
        /// </summary>
        private DateTime DataPrecedente;
        /// <summary>
        /// Massimo tempo trascorso tra due istruzioni
        /// </summary>
        private TimeSpan MaxTempoTrascorso;
        /// <summary>
        /// Linea dell'istruzione dove si è registrato il massimo tempo di esecuzione
        /// </summary>
        private uint LineaMaxTempoTrascorso;


        // ------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// A capo linea
        /// </summary>
        public const string ACapo = "\n";
        /// <summary>
        /// Separa directory
        /// </summary>
        public const string SepDir = "\\";


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
        public CScatolaNera(ref CAreaArchivio areaArchivio)
        {
            // Assegna il riferimento a AreaArchivio
            this.AreaArchivio = areaArchivio;

            InizializzaClasse();
        }
        /// <summary>
        /// inizializza la classe
        /// </summary>
        private void InizializzaClasse()
        {
            Attiva = false;
            Storia = string.Empty;
        }
        /// <summary>
        /// Inizio registrazione
        /// </summary>
        /// <param name="titolo"></param>
        public void Inizio(string titolo)
        {
            // Estrae la data attuale
            DateTime dataAttuale = DateTime.Now;
            DataInizio = dataAttuale;

            // Assegna a penultima
            DataPrecedente = dataAttuale;
            MaxTempoTrascorso = new TimeSpan(0);

            // compone nomefile
            this.NomeFile = dataAttuale.Year.ToString("00") + "-" + 
                            dataAttuale.Month.ToString("00") + "-" + 
                            dataAttuale.Day.ToString("00") + "_" + 
                            dataAttuale.Hour.ToString("00") + "-" + 
                            dataAttuale.Minute.ToString("00") + "-" + 
                            dataAttuale.Second.ToString("00") + "_" + 
                            titolo + ".txt";

            // Inizializza Storia
            Storia = string.Empty;

            // Inizializza indentazione
            Indentazione = 0;

            // Inizializza numero linea
            NumeroLinea = 0;
            LineaMaxTempoTrascorso = 0;

            // Attivo la registrazione
            Attiva = true;

            // Aggiunge una frase
            AggiungiLinea("Operazione: " + titolo);
            AggiungiLinea("================================================================================");
            AggiungiLinea("");
            AggiungiLinea("GAlbum");
            AggiungiLinea("Data:" +
                            dataAttuale.Day.ToString("00") + "/" +
                            dataAttuale.Month.ToString("00") + "/" +
                            dataAttuale.Year.ToString("00") + " " +
                            dataAttuale.Hour.ToString("00") + ":" +
                            dataAttuale.Minute.ToString("00") + ":" +
                            dataAttuale.Second.ToString("00"));
            AggiungiLinea("================================================================================");
        }
        /// <summary>
        /// disttiva la registrazione
        /// </summary>
        public void Fine(GstErrori.EErrore esito)
        {
            // calcola il tempo impiegato
            TimeSpan tempoImpiegato = DateTime.Now - DataInizio;



            // prepara una frase
            AggiungiLinea("================================================================================");
            AggiungiLinea("Fine Operazione: ");
            AggiungiLinea("");
            AggiungiLinea("L'operazione è stata conclusa con esito:");
            AggiungiLinea(GstErrori.RestultToSting(esito));
            AggiungiLinea("");
            AggiungiLinea("Tempo impiegato: " + tempoImpiegato);
            AggiungiLinea("");
            AggiungiLinea("Massimo tempo impiegato da una istruzione: " + MaxTempoTrascorso.TotalMilliseconds.ToString() + " ms" + " alla linea " + LineaMaxTempoTrascorso.ToString());
            AggiungiLinea("================================================================================");


            // scrive il file storia
            ScriveFileStoria();

            Attiva = false;
                
        }
        /// <summary>
        /// Aggiunge un istruzione : titolo
        /// </summary>
        /// <param name="titolo"></param>
        public void InizioIstruzione(string titolo)
        {
            // aggiorna indentazione
            Indentazione++;

            // prepara titolo
            string sTitolo = "----- Inizio: " + titolo +  " ";
            sTitolo = sTitolo.PadRight(80, '-');

            // prepara una frase
            AggiungiLinea(sTitolo);
            AggiungiLinea("");

        }
        /// <summary>
        /// Aggiunge un istruzione : titolo + path nome file
        /// </summary>
        /// <param name="titolo"></param>
        /// <param name="pathNomeFile"></param>
        public void InizioIstruzione(string titolo, string pathNomeFile)
        {
            // aggiorna indentazione
            Indentazione++;

            // incaplsula pathNomeFile
            CNomeFile fileSrc = new CNomeFile(AreaArchivio.PathArchivioAttivo);
            GstErrori.EErrore esito = fileSrc.SetPathNomeFile(pathNomeFile);

            // prepara titolo
            string sTitolo = "----- Inizio: " + titolo + "   " + fileSrc.NomeFile + " ";
            sTitolo = sTitolo.PadRight(80, '-');


            // prepara una frase
            AggiungiLinea(sTitolo);
            AggiungiLinea(GetDataAttuale());
            AggiungiLinea("Path relativo: " + fileSrc.GetPathRelativo(fileSrc.PathFoglia));
            AggiungiLinea("Path Totale  : " + fileSrc.PathFoglia);
            AggiungiLinea(GetDataAttuale());
            AggiungiLinea("--------------------------------------------------------------------------------");
            AggiungiLinea("");

        }
        /// <summary>
        /// Aggiunge un istruzione : titolo + fileSrc + esito
        /// </summary>
        /// <param name="titolo"></param>
        /// <param name="fileSrc"></param>
        /// <param name="esito"></param>
        public void InizioIstruzione(string titolo, CNomeFile fileSrc, GstErrori.EErrore esito)
        {
            // aggiorna indentazione
            Indentazione++;

            // prepara titolo inizio\
            string sTitolo = "----- Inizio: " + titolo + "   " + fileSrc.NomeFile + " ";
            sTitolo = sTitolo.PadRight(80, '-');

            // prepara titolo fine
            string sTitoloFine = "----- Fine ";
            sTitoloFine = sTitoloFine.PadRight(80, '-');

            // prepara una frase
            AggiungiLinea(sTitolo);
            AggiungiLinea("NomeFileSrc     : " + fileSrc.NomeFile);
            AggiungiLinea("PathSrc relativo: " + fileSrc.GetPathRelativo(fileSrc.PathFoglia));
            AggiungiLinea("PathSrc Totale  : " + fileSrc.PathFoglia);
            AggiungiLinea("");
            AggiungiLinea("Esito           : " + GstErrori.RestultToSting(esito));
            AggiungiLinea(GetDataAttuale());
            AggiungiLinea("");
            AggiungiLinea(sTitoloFine);
            AggiungiLinea("");

            // aggiorna indentazione
            Indentazione--;

        }
        /// <summary>
        /// Aggiunge un istruzione : titolo + fileSrc + fileDst + esito
        /// </summary>
        /// <param name="titolo"></param>
        /// <param name="fileSrc"></param>
        /// <param name="fileDst"></param>
        /// <param name="esito"></param>
        public void InizioIstruzione(string titolo, CNomeFile fileSrc, CNomeFile fileDst, GstErrori.EErrore esito)
        {
            // aggiorna indentazione
            Indentazione++;

            // prepara titolo inizio\
            string sTitolo = "----- Inizio: " + titolo + "   " + fileSrc.NomeFile + " ";
            sTitolo = sTitolo.PadRight(80, '-');

            // prepara titolo fine
            string sTitoloFine = "----- Fine ";
            sTitoloFine = sTitoloFine.PadRight(80, '-');

            // prepara una frase
            AggiungiLinea(sTitolo);
            AggiungiLinea("NomeFileSrc     : " + fileSrc.NomeFile);
            AggiungiLinea("PathSrc relativo: " + fileSrc.GetPathRelativo(fileSrc.PathFoglia));
            AggiungiLinea("PathSrc Totale  : " + fileSrc.PathFoglia);
            AggiungiLinea("");
            AggiungiLinea("NomeFileDst     : " + fileDst.NomeFile);
            AggiungiLinea("PathDst relativo: " + fileDst.GetPathRelativo(fileDst.PathFoglia));
            AggiungiLinea("PathDst Totale  : " + fileDst.PathFoglia);
            AggiungiLinea("");
            AggiungiLinea("Esito           : " + GstErrori.RestultToSting(esito));
            AggiungiLinea(GetDataAttuale());
            AggiungiLinea("");
            AggiungiLinea(sTitoloFine);
            AggiungiLinea("");

            // aggiorna indentazione
            Indentazione--;

        }
        /// <summary>
        /// Chiude un istruzione
        /// </summary>
        public void FineIstruzione(GstErrori.EErrore esito)
        {

            // estrae la stringa dell'esito
            string sEsito = GstErrori.RestultToSting(esito);

            // prepara titolo
            string sTitolo = "----- Fine: " + sEsito + " ";
            sTitolo = sTitolo.PadRight(80, '-');

            // prepara una frase
            AggiungiLinea(sTitolo);
            AggiungiLinea("");

            // aggiorna indentazione
            Indentazione--;

        }


        /// <summary>
        /// Scrive il file log
        /// </summary>
        /// <returns></returns>
        private GstErrori.EErrore ScriveFileStoria()
        {
            // compone il path del file
            string pathNomeFile = AreaArchivio.PathLOG + SepDir + NomeFile;

            try
            {
                // Aprire il file e scrivere
                using (StreamWriter sw = new StreamWriter(pathNomeFile))
                {
                    string[] linee = Storia.Split('\n');

                    foreach (var linea in linee)
                    {
                        sw.WriteLine(linea);
                    }
                }
            }
            catch (Exception e)
            {
                return GstErrori.EErrore.E0001_NOK;
                //Console.WriteLine("Exception: " + e.Message);
            }
            return GstErrori.EErrore.E0000_OK;
        }   
        /// <summary>
        ///  calcola gli spazi di indentazione
        /// </summary>
        /// <returns></returns>
        private void CalcolaIndentazione(int nuovaIndentazione)
        {
            LIndentazione = nuovaIndentazione;
            SIndentazione = string.Empty;
            SIndentazione = SIndentazione.PadLeft(LIndentazione * 4, ' ');
        }
        /// <summary>
        /// Rende data e ora attuale
        /// </summary>
        /// <returns></returns>
        private string GetDataAttuale()
        {
            // Estrae la data attuale
            DateTime dataAttuale = DateTime.Now;

            // compone stringa data
            string sData = "Data:" +
                            dataAttuale.Day.ToString("00") + "/" +
                            dataAttuale.Month.ToString("00") + "/" +
                            dataAttuale.Year.ToString("00") + " " +
                            dataAttuale.Hour.ToString("00") + ":" +
                            dataAttuale.Minute.ToString("00") + ":" +
                            dataAttuale.Second.ToString("00") + ":" +
                            dataAttuale.Millisecond.ToString("000");

            // calcola il tempo trascorso
            TimeSpan tempoTrascorso = dataAttuale - DataPrecedente;

            // aggiorna massimo tempo trascorso
            if (tempoTrascorso.TotalMilliseconds > MaxTempoTrascorso.TotalMilliseconds)
            {
                MaxTempoTrascorso = tempoTrascorso;
                LineaMaxTempoTrascorso = NumeroLinea;
            }

            // compone stringa tempo trascorso
            string sTempoTrascorso = "Tempo trascorso:" + tempoTrascorso.TotalMilliseconds.ToString() + " ms";

                        // Aggiornate il tempo precedente
            DataPrecedente = dataAttuale;


            return sData + "    " + sTempoTrascorso;
        }

        /// <summary>
        /// Aggiunge una  linea a  storia 
        /// </summary>
        /// <param name="linea"></param>
        private void AggiungiLinea(string linea)
        {
            // incrementa il numero di linea
            NumeroLinea++;


            // Aggiunge la linea a storia
            Storia += NumeroLinea.ToString("00000") + "   " + SIndentazione + linea + ACapo;
        }

    }// fine classe CScatolaNera
}// fine namespace GAlbum



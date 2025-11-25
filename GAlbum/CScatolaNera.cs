using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        /// indentazione
        /// </summary>
        private int Indentazione;

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

            // compone nomefile
            this.NomeFile = dataAttuale.Year.ToString("00") + "-" + 
                            dataAttuale.Month.ToString("00") + "-" + 
                            dataAttuale.Day.ToString("00") + "_" + 
                            dataAttuale.Hour.ToString("00") + "-" + 
                            dataAttuale.Minute.ToString("00") + "-" + 
                            dataAttuale.Second.ToString("00") + "_" + 
                            titolo + ".txt";


            // prepara una frase
            String frase = "Operazione: " + titolo + ACapo;
            frase += "================================================================================" + ACapo;
            frase += ACapo;
            frase += "GAlbum" + ACapo;
            frase += "Data:" +
                            dataAttuale.Day.ToString("00") + "/" +
                            dataAttuale.Month.ToString("00") + "/" +
                            dataAttuale.Year.ToString("00") + " " +
                            dataAttuale.Hour.ToString("00") + ":" +
                            dataAttuale.Minute.ToString("00") + ":" +
                            dataAttuale.Second.ToString("00") + ACapo;
            frase += "================================================================================" + ACapo;


            // Aggiuge a stroria
            Storia = frase;

            // Inizializza indentazione
            Indentazione = 0;

            // Attivo la registrazione
            Attiva = true;

        }
        /// <summary>
        /// disttiva la registrazione
        /// </summary>
        public void Fine(GstErrori.EErrore esito)
        {

            // prepara una frase
            string frase = "================================================================================" + ACapo;
            frase += "Fine Operazione: " + ACapo;
            frase += ACapo;
            frase += "L'operazione è stata conclusa con esito:" + ACapo;
            frase += GstErrori.RestultToSting(esito) + ACapo;
            frase += "================================================================================" + ACapo;

            // Aggiuge a stroria
            Storia += frase;


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
            String sIndentazione = CalcolaIndentazione();

            // prepara titolo
            string sTitolo = "----- Inizio: " + titolo +  " ";
            sTitolo = sTitolo.PadRight(80, '-');



            // prepara una frase
            string frase = sIndentazione + sTitolo + ACapo;
            frase += sIndentazione + ACapo;

            // Aggiuge a stroria
            Storia += frase;
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
            String sIndentazione = CalcolaIndentazione();

            // incaplsula pathNomeFile
            CNomeFile fileSrc = new CNomeFile(AreaArchivio.PathArchivioAttivo);
            GstErrori.EErrore esito = fileSrc.SetPathNomeFile(pathNomeFile);

            // prepara titolo
            string sTitolo = "----- Inizio: " + titolo + "   " + fileSrc.NomeFile + " ";
            sTitolo = sTitolo.PadRight(80, '-');


            // prepara una frase
            string frase = sIndentazione + sTitolo + ACapo;
            frase += sIndentazione + "Path relativo: " + fileSrc.GetPathRelativo(fileSrc.PathFoglia) + ACapo;
            frase += sIndentazione + "Path Totale  : " + fileSrc.PathFoglia + ACapo;
            frase += sIndentazione + "--------------------------------------------------------------------------------" + ACapo;
            frase += sIndentazione + ACapo;

            // Aggiuge a stroria
            Storia += frase;
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
            String sIndentazione = CalcolaIndentazione();

            // prepara titolo inizio\
            string sTitolo = "----- Inizio: " + titolo + "   " + fileSrc.NomeFile + " ";
            sTitolo = sTitolo.PadRight(80, '-');

            // prepara titolo fine
            string sTitoloFine = "----- Fine ";
            sTitoloFine = sTitoloFine.PadRight(80, '-');

            // prepara una frase
            string frase = sIndentazione + sTitolo + ACapo;
            frase += sIndentazione + "NomeFileSrc     : " + fileSrc.NomeFile + ACapo;
            frase += sIndentazione + "PathSrc relativo: " + fileSrc.GetPathRelativo(fileSrc.PathFoglia) + ACapo;
            frase += sIndentazione + "PathSrc Totale  : " + fileSrc.PathFoglia + ACapo;
            frase += sIndentazione + ACapo;
            frase += sIndentazione + "NomeFileDst     : " + fileDst.NomeFile + ACapo;
            frase += sIndentazione + "PathDst relativo: " + fileDst.GetPathRelativo(fileDst.PathFoglia) + ACapo;
            frase += sIndentazione + "PathDst Totale  : " + fileDst.PathFoglia + ACapo;
            frase += sIndentazione + ACapo;
            frase += sIndentazione + "Esito           : " + GstErrori.RestultToSting(esito) + ACapo;
            frase += sIndentazione + ACapo;
            frase += sIndentazione + sTitoloFine + ACapo;
            frase += sIndentazione + ACapo;

            // Aggiuge a stroria
            Storia += frase;

            // aggiorna indentazione
            Indentazione--;

        }
        /// <summary>
        /// Chiude un istruzione
        /// </summary>
        public void FineIstruzione(GstErrori.EErrore esito)
        {
            // recupera indentazione
            String sIndentazione = CalcolaIndentazione();

            // estrae la stringa dell'esito
            string sEsito = GstErrori.RestultToSting(esito);


            // prepara titolo
            string sTitolo = "----- Fine: " + sEsito + " ";
            sTitolo = sTitolo.PadRight(80, '-');

            // prepara una frase
            string frase = sIndentazione + sTitolo + ACapo;
            frase += sIndentazione + ACapo;

            // aggiorna indentazione
            Indentazione--;

            // Aggiuge a stroria
            Storia += frase;
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
        private string CalcolaIndentazione()
        {
            string sIndentazione = string.Empty;

            for (int i = 0; i < Indentazione; i++)
            {
                sIndentazione += "    ";
            }
            return sIndentazione;
            
        }

    }// fine classe CScatolaNera
}// fine namespace GAlbum



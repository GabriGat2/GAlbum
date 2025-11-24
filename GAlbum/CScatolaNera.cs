using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                            dataAttuale.Hour.ToString("00") + "/" +
                            dataAttuale.Minute.ToString("00") + "/" +
                            dataAttuale.Second.ToString("00") + ACapo;
            frase += "================================================================================" + ACapo;


            // Aggiuge a stroria
            Storia = frase;

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



    }// fine classe CScatolaNera
}// fine namespace GAlbum



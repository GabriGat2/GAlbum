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
        /// <summary>
        /// Path archivio base
        /// </summary>
        public string PathArchivioBase { get => pathArchivioBase; set => pathArchivioBase = SetPathArchivioBase(value); }
        private string pathArchivioBase;
        /// <summary>
        /// Nome archivio Attivo
        /// </summary>
        public string DirArchivioAttivo { get => dirArchivioAttivo;  set => dirArchivioAttivo = SetArchivioAttivo(value); }
        private string dirArchivioAttivo;
        /// <summary>
        /// Path archivio attivo
        /// </summary>
        public string PathArchivioAttivo { get => GetPathArchivioAttivo(); /* set => dirArchivioAttivo = value; */ }
        
        //-------------------------------------------------------------------------------------------------------------------
        // Nomi delle directory
        public const string DirDaAcquisire = "DaAcquisire";
        public const string DirDaSmistare = "DaSmistare";
        public const string DirSmistati = "Smistati";

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
            //pathArchivioBase = "";
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
            string pathDaAcquisire = pathNomeArchivio + "\\" + DirDaAcquisire;

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
            string pathDaSmistare = pathNomeArchivio + "\\" + DirDaSmistare;

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
            string pathArchivioAttivo = PathArchivioBase + "//" + dirArchivioAttivo;

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
            if (!VerificaNomeArchivio(dirArchivio))
                return "";

            //// verifica che il nome dell'archivio attivo sia coerente
            //if (dirArchivio.Length < 1)
            //    return "";

            //// compone il path dell'archivio attivo
            //string pathArchivioAttivo = PathArchivioBase + "//" + dirArchivioAttivo;

            //// verifica che la directory esiste
            //if (!Directory.Exists(pathArchivioAttivo))
            //    return "";

            // L'archivio attivo esiste rende il nome dell'archivio attivo
            return dirArchivio;

        }
        /// <summary>
        /// Verifica il nome dell'archivio
        /// </summary>
        /// <param name="dirArchivio"></param>
        /// <returns></returns>
        public bool VerificaNomeArchivio(string dirArchivio)
        {
            // verifica che il nome dell'archivio attivo sia coerente
            if (dirArchivio.Length < 1)
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

    }// fine class CAreaArchivio
}// fine namespace CAreaArchivio

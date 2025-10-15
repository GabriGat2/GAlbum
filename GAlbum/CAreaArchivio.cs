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
        public string PathArchivioBase { get => pathArchivioBase; set => pathArchivioBase = value; }
        private string pathArchivioBase;

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
        

        


    }// fine class CAreaArchivio
}// fine namespace CAreaArchivio

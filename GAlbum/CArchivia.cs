using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GAlbum.CInfoTreeView;

namespace GAlbum
{
    public class CArchivia
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================
        /// <summary>
        /// nome della directory di archivio
        /// </summary>
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
        public CArchivia()
        {
            
        }
        /// <summary>
        /// Assena un file a varie destinazioni
        /// </summary>
        /// <param name="pathSrc"> path + nome del file sorgente </param>
        /// <param name="pathDestinazioni"> Lista dei path di destinazione senza il nome del file </param>
        /// <returns></returns>
        public GstErrori.EErrore Assegna(string pathSrc, List<String> pathDestinazioni)
        {
            GstErrori.EErrore esito = GstErrori.EErrore.E0001_NOK;


            // Esegue le copie nel numero specificato dalla lista destinazioni
            foreach (var pathDst in pathDestinazioni)
            {
                // esegue la copia
                esito = Copia(pathSrc, pathDst);
                if (esito != GstErrori.EErrore.E0000_OK)
                    return esito;

            }

            // archivia la foto sorgente
            esito = Archivia(pathSrc, DirArchivio);


            return GstErrori.EErrore.E0000_OK;
        }        
        /// <summary>
        /// Copia un file
        /// </summary>
        /// <param name="pathSrc"> path + nome del file sorgente </param>
        /// <param name="pathDst"> path di destinazione senza il nome del file </param>
        /// <returns></returns>
        public GstErrori.EErrore Copia(string pathSrc, string pathDst)
        {
            // verifica se esite il file sorgente
            if (!File.Exists(pathSrc))
            {
                return GstErrori.EErrore.E1360_FileSorgenteNonEsiste;
            }

            // verifica se esite la directory di destinazione
            if (!Directory.Exists(pathDst))
            {
                return GstErrori.EErrore.E1320_DirectoryDestinazioneNonEsiste;
            }

            // scompone path sorgente
            string[] campiSrc = pathSrc.Split('\\');
            if (campiSrc.Length < 3)
            {
                return GstErrori.EErrore.E1312_DirectorySorgenteCampiMinimiNonPresenti;
            }    

            // Estrae i dati notevoli da pathSorgente
            string ramoSrc = campiSrc [campiSrc.Length - 3];
            string foglia = campiSrc[campiSrc.Length - 2].ToUpper();
            string nome = campiSrc[campiSrc.Length - 1];
                        
            // Compone il path foglia destinazione fino alla foglia
            string pathFogliaDst = pathDst + "\\" + foglia;

            // verifica se esite la  directory foglia
            if (!Directory.Exists(pathFogliaDst))
            {

                // la foglia non esiste, la crea
                try
                {
                    Directory.CreateDirectory(pathFogliaDst);
                }
                catch (IOException dirError)
                {
                    return GstErrori.EErrore.E1324_DirectoryFogliaDestinazioneNonEsiste;
                    //Console.WriteLine(copyError.Message);
                }
            }

            // Compone il path file destinazione completo
            string pathFileDst = pathFogliaDst + "\\" + nome;

            // verifica se esite il file destinazione
            if (File.Exists(pathFileDst))
            {
                // DEBUG GG: gestire la duplicazione
                return GstErrori.EErrore.E1370_FileDestinazioneNonEsiste;
            }

            // copia il file
            try
            {
                File.Copy(pathSrc, pathFileDst, false);
            }
            catch (IOException copyError)
            {
                return GstErrori.EErrore.E1371_FileDestinazioneEsiste;
                //Console.WriteLine(copyError.Message);
            }

            return GstErrori.EErrore.E0000_OK;
        }
        /// <summary>
        /// estrai nodi selezionati
        /// </summary>
        /// <param name="nodoBase"></param>
        /// <param name="pathDestinazioni"></param>
        /// <returns></returns>
        public GstErrori.EErrore EstraiNdodiSelezionati(ref TreeNode nodoBase, out List<String> pathDestinazioni)
        {
            // crea una lista di stringhe
            pathDestinazioni = new List<String>();


            //// Estrae le info del nodo 
            //CInfoDirFoto info = (CInfoDirFoto)nodoBase.Tag;


            //// verifica se il nodo è selezionato
            //if (info.Selezione)
            //{
            //    pathDestinazioni.Add(info.Path);
            //}


            // Analizza i nodi figlio
            return NodiSelezionati(nodoBase, ref pathDestinazioni);
        }
        /// <summary>
        /// Ricerca i nodi selezionati
        /// </summary>
        /// <param name="nodo"></param>
        /// <param name="pathDestinazioni"></param>
        /// <returns></returns>
        protected GstErrori.EErrore NodiSelezionati(TreeNode nodo, ref List<String> pathDestinazioni)
        {
            GstErrori.EErrore esito = GstErrori.EErrore.E0001_NOK;

            // Estrae le info del nodo 
            CInfoDirFoto info = (CInfoDirFoto)nodo.Tag;


            // verifica se il nodo è selezionato
            if (info.Selezione)
            {
                // Aggiunge il path alla lista delle destinazioni
                pathDestinazioni.Add(info.Path);
            }

            // Analizza i nodi figlio
            try
            {
                // Analizza i nodi figlio
                foreach (TreeNode nodoFiglio in nodo.Nodes)
                {
                    esito = NodiSelezionati(nodoFiglio, ref pathDestinazioni);
                    if (esito != GstErrori.EErrore.E0000_OK)
                        return esito;
                }
            }
            catch (Exception ex)
            {
                return GstErrori.EErrore.E0001_NOK;
            }

            return GstErrori.EErrore.E0000_OK;
        }
        /// <summary>
        /// archivia un file
        /// </summary>
        /// <param name="pathSrc"></param>
        /// <param name="dirArchivio"></param>
        /// <returns></returns>
        public GstErrori.EErrore Archivia(string pathSrc, string dirArchivio)
        {
            // verifica se esite il file sorgente
            if (!File.Exists(pathSrc))
            {
                return GstErrori.EErrore.E1360_FileSorgenteNonEsiste;
            }

            // scompone path sorgente
            string[] campiSrc = pathSrc.Split('\\');
            if (campiSrc.Length < 3)
            {
                return GstErrori.EErrore.E1312_DirectorySorgenteCampiMinimiNonPresenti;
            }

            // Estrae i dati notevoli da pathSorgente
            string ramoSrc = campiSrc[campiSrc.Length - 3];
            string foglia = campiSrc[campiSrc.Length - 2].ToUpper();
            string nome = campiSrc[campiSrc.Length - 1];

            // coporre path archivio
            string pathArchivio = "";
            for (int i = 0; i < campiSrc.Length - 3; i++)
            {
                pathArchivio += campiSrc[i] + "\\";    
            }



            //string pathArchivio = campiSrc[campiSrc.Length - 3];


            // verifica se esite la directory di destinazione
            if (!Directory.Exists(dirArchivio))
            {
                return GstErrori.EErrore.E1320_DirectoryDestinazioneNonEsiste;
            }

             // Compone il path foglia destinazione fino alla foglia
            string pathFogliaDst = dirArchivio + "\\" + foglia;

            // verifica se esite la  directory foglia
            if (!Directory.Exists(pathFogliaDst))
            {

                // la foglia non esiste, la crea
                try
                {
                    Directory.CreateDirectory(pathFogliaDst);
                }
                catch (IOException dirError)
                {
                    return GstErrori.EErrore.E1324_DirectoryFogliaDestinazioneNonEsiste;
                    //Console.WriteLine(copyError.Message);
                }
            }

            // Compone il path file destinazione completo
            string pathFileDst = pathFogliaDst + "\\" + nome;

            // verifica se esite il file destinazione
            if (File.Exists(dirArchivio))
            {
                // DEBUG GG: gestire la duplicazione
                return GstErrori.EErrore.E1370_FileDestinazioneNonEsiste;
            }

            // copia il file
            try
            {
                File.Copy(pathSrc, pathFileDst, false);
            }
            catch (IOException copyError)
            {
                return GstErrori.EErrore.E1371_FileDestinazioneEsiste;
                //Console.WriteLine(copyError.Message);
            }

            return GstErrori.EErrore.E0000_OK;
        }


    }// fine class CArchivia
    }// fine namespace GAlbum

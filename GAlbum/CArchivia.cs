using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GAlbum.CInfoTreeView;
using static GAlbum.GstErrori;

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
        public GstErrori.EErrore Assegna(string pathSrc, List<String> pathDestinazioni, bool copiaParallelo)
        {
            // Assegna il file specificato
            EErrore esito = Assegna2(pathSrc, pathDestinazioni);
            if (esito != EErrore.E0000_OK)
            {
                GstErrori.StampaMessaggioErrore(esito, pathSrc);
            }

            // copia parallela: cerca nelle altre foglie il file specificato e lo assegna
            if (copiaParallelo)
            {
                esito = AssegnaInParallelo(pathSrc, pathDestinazioni);
                if (esito != EErrore.E0000_OK)
                {
                    GstErrori.StampaMessaggioErrore(esito, pathSrc);
                }
            }
           

            return esito;
        }
        /// <summary>
        /// Assena un file a varie destinazioni
        /// </summary>
        /// <param name="pathSrc"> path + nome del file sorgente </param>
        /// <param name="pathDestinazioni"> Lista dei path di destinazione senza il nome del file </param>
        /// <returns></returns>
        public GstErrori.EErrore Assegna2(string pathSrc, List<String> pathDestinazioni)
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
            if (esito != GstErrori.EErrore.E0000_OK)
                return esito;

            return GstErrori.EErrore.E0000_OK;
        }
        /// <summary>
        /// Esegue la copia in parallelo: assena un file, prelevato da tutte le foglie, a varie destinazioni
        /// </summary>
        /// <param name="pathSrc"></param>
        /// <param name="pathDestinazioni"></param>
        /// <returns></returns>
        private GstErrori.EErrore AssegnaInParallelo(string pathSrc, List<String> pathDestinazioni)
        {
            GstErrori.EErrore esito = GstErrori.EErrore.E0001_NOK;

            // scompone il file sorgente e ricava le sue caratteristiche
            string pathBase;
            string ramo;
            string foglia;
            string nome;
            esito = ScomponePath(pathSrc, out pathBase, out ramo, out foglia, out nome);
            if (esito != EErrore.E0000_OK)
                return esito;

            // Scompone il nome del file
            string nomeSE;
            string estensione;
            esito = ScomponeNome(nome, out nomeSE, out estensione);

            // compone il path del ramo
            string pathRamo = pathBase + "\\" + ramo;

            // compone la lista delle foglie 
            string [] pathFoglie = Directory.GetDirectories(pathRamo);

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
                if (nomeFoglia.ToUpper() == foglia) 
                    continue;

                // compone la lista dei file 
                string[] pathNomi = Directory.GetFiles(pathFoglia, nomeSE + ".*");

                // esamina i file nella lista 
                foreach (var pathNuovoNome in pathNomi)
                {
                    esito = Assegna2(pathNuovoNome, pathDestinazioni);
                    if (esito != EErrore.E0000_OK)
                        return esito;
                }
            }

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
            string ramoSrc = campiSrc[campiSrc.Length - 3];
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
                bool reso = GstErrori.StampaMessaggioErrore(GstErrori.EErrore.E1371_FileDestinazioneEsiste);
                if (reso)
                    return EErrore.E0000_OK;
                else
                    return GstErrori.EErrore.E1371_FileDestinazioneEsiste;
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

            // ----------------------------------------------------------------------------------------

            // comporre path archivio
            string pathArchivio = campiSrc[0];
            for (int i = 1; i < campiSrc.Length - 3; i++)
            {
                //pathArchivio += campiSrc[i] + "\\";
                pathArchivio += "\\" + campiSrc[i];
            }
            // aggiunge dir Archivio
            pathArchivio += "\\" + dirArchivio;

            // verifica se esite la  directory Archivio
            if (!Directory.Exists(pathArchivio))
            {

                // dir Archivio non esiste, la crea
                try
                {
                    Directory.CreateDirectory(pathArchivio);
                }
                catch (IOException dirError)
                {
                    // DEBUG GG: migliorare la gestione
                    return GstErrori.EErrore.E1330_DirectoryArchivioNonEsiste;
                    //Console.WriteLine(copyError.Message);
                }
            }

            // ----------------------------------------------------------------------------------------
            // compone path archivioFoglia
            string pathArchivioFoglia = pathArchivio + "\\" + foglia;

            // verifica se esite la  directory foglia
            if (!Directory.Exists(pathArchivioFoglia))
            {

                // la foglia non esiste, la crea
                try
                {
                    Directory.CreateDirectory(pathArchivioFoglia);
                }
                catch (IOException dirError)
                {
                    return GstErrori.EErrore.E1334_DirectoryFogliaArchivioNonEsiste;
                    //Console.WriteLine(copyError.Message);
                }
            }

            // ----------------------------------------------------------------------------------------
            // Compone il path file destinazione completo
            string pathFileDst = pathArchivioFoglia + "\\" + nome;

            // verifica se esite il file destinazione
            if (File.Exists(pathFileDst))
            {
                // DEBUG GG: gestire la duplicazione
                File.Delete(pathSrc);
                return GstErrori.EErrore.E0000_OK;
                //return GstErrori.EErrore.E1381_FileArchivioEsiste;
            }

            // ----------------------------------------------------------------------------------------
            // sposta il file
            int cnt = 10;
            while (cnt-- > 0)
            {
                try
                {
                    File.Move(pathSrc, pathFileDst);
                    return GstErrori.EErrore.E0000_OK;
                }
                catch (IOException moveError)
                {
                    bool reso = GstErrori.StampaMessaggioErrore(GstErrori.EErrore.E1382_FileArchivioNonSpostato);
                    if (reso)
                        ;
                    else
                        return GstErrori.EErrore.E1382_FileArchivioNonSpostato;
                }
            }

            return GstErrori.EErrore.E1382_FileArchivioNonSpostato;
        }
        /// <summary>
        /// Scopone il path di una foto
        /// </summary>
        /// <param name="path"></param>
        /// <param name="pathBase"></param>
        /// <param name="ramo"></param>
        /// <param name="foglia"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        private GstErrori.EErrore ScomponePath (string path, out string pathBase, out string ramo, out string foglia, out string nome)
        {
            // Inizializza le variabili rese
            pathBase = "";
            ramo = "";
            foglia = "";
            nome = "";

            // scompone path sorgente
            string[] campiSrc = path.Split('\\');
            if (campiSrc.Length < 3)
            {
                return GstErrori.EErrore.E1312_DirectorySorgenteCampiMinimiNonPresenti;
            }

            // Estrae i dati notevoli da pathSorgente
            ramo = campiSrc[campiSrc.Length - 3];
            foglia = campiSrc[campiSrc.Length - 2].ToUpper();
            nome = campiSrc[campiSrc.Length - 1];

            // ricompone pathBase
            pathBase = campiSrc[0];
            for (int i = 1; i < campiSrc.Length - 3; i++)
            {
                // pathBase += campiSrc[i] + "\\";
                pathBase += "\\" + campiSrc[i];
            }

            return EErrore.E0000_OK;

        }
        /// <summary>
        /// Scompone nome da estensione
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="nomeSE"></param>
        /// <param name="estensione"></param>
        /// <returns></returns>
        private GstErrori.EErrore ScomponeNome(string nome, out string nomeSE, out string estensione)
        {
            // Inizializza le variabili rese
            nomeSE = "";
            estensione = "";

            // scompone nome
            string[] campiNome = nome.Split('.');
            if (campiNome.Length != 2)
            {
                return GstErrori.EErrore.E1358_FileNomeNonCorretto;
            }

            // Estrae i dati notevoli da pathSorgente
            nomeSE = campiNome[campiNome.Length - 2];
            estensione = campiNome[campiNome.Length - 1];

            return EErrore.E0000_OK;
        }

    }// fine class CArchivia
}// fine namespace GAlbum

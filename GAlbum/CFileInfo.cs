using MetadataExtractor;
using MetadataExtractor.Formats.Exif;
using MetadataExtractor.Formats.QuickTime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace GAlbum
{
    public class CFileInfo
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================

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
        /// Costruttore
        /// </summary>
        public CFileInfo()
        { 

        }
        /// <summary>
        /// Verifica che il file esista ed abbia una dimensione maggiore di 0
        /// </summary>
        /// <param name="nomeFile"></param>
        /// <returns></returns>
        private bool VerificaFile(string nomeFile)
        {
            FileInfo fileInfo = new FileInfo(nomeFile);

            // Verifica esistenza
            if (!fileInfo.Exists)
                return false;

            // verifica dimensione
            if (fileInfo.Length <= 0)
                return false;

            return true;
        }
        /// <summary>
        /// Rende la data di acqusizione di un file in particolare di una foto
        /// </summary>
        /// <param name="pathNomeFile"></param>
        /// <param name="dataAcquisizione"></param>
        /// <returns></returns>
        public GstErrori.EErrore GetDataAcquisizioneOrg1(CNomeFile file, out DateTime dataAcquisizione, bool cercaData = true)
        {
            // inizializza data di acquisizione
            dataAcquisizione = new DateTime(2100, 12, 01);

            // verifica se il file esiste
            if (!VerificaFile(file.PathNomeFile))
                return GstErrori.EErrore.E0001_NOK;

            try
            {

                var directories = ImageMetadataReader.ReadMetadata(file.PathNomeFile);

                // INIZIO TEST ##############################################################################
                string Testo = string.Empty;

                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        Testo += ($"{directory.Name} - {tag.Name} = {tag.Description}" + "\n");
                    }
                }


                // FINE TEST   ##############################################################################

                // Estrae la subdirectory delle informazioni EXIF
                var subIfdDirectory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();
                if (subIfdDirectory == null)
                {
                    // se attiva qui significa che la subdirectory non esiste,
                    // quindi, se abilitato, cerca una data in modo alternativo
                    if (cercaData)
                        CercaData(file, out dataAcquisizione);
                    return GstErrori.EErrore.E0001_NOK;
                }


                // Estrae il Tag 0x9003 che corrisponde alla data originale di scatto cioè, dataTaken
                bool reso = subIfdDirectory.TryGetDateTime(ExifDirectoryBase.TagDateTimeOriginal, out DateTime dateTaken);
                if (reso)
                {
                    // se attiva qui significa che la data è disponibile
                    dataAcquisizione = dateTaken;
                    return GstErrori.EErrore.E0000_OK;
                }
                else
                {
                    // se attiva qui significa che la data non è disponibile,
                    // quindi, se abilitato, cerca una data in modo alternativo
                    if (cercaData)
                        CercaData(file, out dataAcquisizione);
                    return GstErrori.EErrore.E0001_NOK;
                }
            }
            catch (Exception ex)
            {
                if (cercaData)
                {
                    CercaData(file, out dataAcquisizione);
                }

                return GstErrori.EErrore.E1359_FileDataNonDisponibile;
            }
        }
        /// <summary>
        /// Rende la data di acqusizione di un file in particolare di una foto
        /// </summary>
        /// <param name="pathNomeFile"></param>
        /// <param name="dataAcquisizione"></param>
        /// <returns></returns>
        public GstErrori.EErrore GetDataAcquisizione(CNomeFile file, out DateTime dataAcquisizione, bool cercaData = true)
        {
            // inizializza data di acquisizione
            dataAcquisizione = new DateTime(2100, 12, 01);
            // imposta data minima accettabile
            DateTime dataMinima = new DateTime(1990, 1, 1);

            // verifica se il file esiste
            if (!VerificaFile(file.PathNomeFile))
                return GstErrori.EErrore.E0001_NOK;

            try
            {
                bool reso;

                var directories = ImageMetadataReader.ReadMetadata(file.PathNomeFile);

                // INIZIO TEST ##############################################################################
                string Testo = string.Empty;

                foreach (var directory in directories)
                {
                    foreach (var tag in directory.Tags)
                    {
                        Testo += ($"{directory.Name} - {tag.Name} = {tag.Description}" + "\n");
                    }
                }


                // FINE TEST   ##############################################################################

                // Estrae la subdirectory delle informazioni EXIF
                var subIfdDirectory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();
                if (subIfdDirectory != null)
                {
                    // Estrae il Tag 0x9003 che corrisponde alla data originale di scatto cioè, dataTaken
                    reso = subIfdDirectory.TryGetDateTime(ExifDirectoryBase.TagDateTimeOriginal, out DateTime dataExif);
                    if (reso)
                    {
                        // verifica che la data sia sensata
                        if (dataExif < dataMinima)
                        {
                            if (cercaData)
                                CercaData(file, out dataAcquisizione);
                            return GstErrori.EErrore.E0001_NOK;
                        }

                        // se attiva qui significa che la data è disponibile
                        dataAcquisizione = dataExif;
                        return GstErrori.EErrore.E0000_OK;
                    }
                    else
                    {
                        // se attiva qui significa che la data non è disponibile,
                        // quindi, se abilitato, cerca una data in modo alternativo
                        if (cercaData)
                            CercaData(file, out dataAcquisizione);
                        return GstErrori.EErrore.E0001_NOK;
                    }
                }

                // Estrae la subdirectory delle informazioni QuickTime
                var qtDir = directories.OfType<QuickTimeMovieHeaderDirectory>().FirstOrDefault();
                if (qtDir != null)
                {
                    // Estrae il Tag 0x9003 che corrisponde alla data originale di scatto cioè, dataTaken
                    reso = qtDir.TryGetDateTime(QuickTimeMovieHeaderDirectory.TagCreated, out DateTime dataQT);
                    if (reso)
                    {
                        // verifica che la data sia sensata
                        if (dataQT < dataMinima)
                        {
                            if (cercaData)
                                CercaData(file, out dataAcquisizione);
                            return GstErrori.EErrore.E0001_NOK;
                        }

                        // se attiva qui significa che la data è disponibile
                        dataAcquisizione = dataQT;
                        return GstErrori.EErrore.E0000_OK;
                    }
                    else
                    {
                        // se attiva qui significa che la data non è disponibile,
                        // quindi, se abilitato, cerca una data in modo alternativo
                        if (cercaData)
                            CercaData(file, out dataAcquisizione);
                        return GstErrori.EErrore.E0001_NOK;
                    }
                }


                //var directories = ImageMetadataReader.ReadMetadata(path);
                //var qtDir = directories.OfType<QuickTimeMovieHeaderDirectory>().FirstOrDefault();

                //if (qtDir != null && qtDir.TryGetDateTime(QuickTimeMovieHeaderDirectory.TagCreated, out var date))
                //{
                //    Console.WriteLine("Data registrazione video: " + date);
                //}


                // se attiva qui significa che la subdirectory non esiste,
                // quindi, se abilitato, cerca una data in modo alternativo
                if (cercaData)
                    CercaData(file, out dataAcquisizione);
                return GstErrori.EErrore.E0001_NOK;
                



                //// Estrae il Tag 0x9003 che corrisponde alla data originale di scatto cioè, dataTaken
                //bool reso = subIfdDirectory.TryGetDateTime(ExifDirectoryBase.TagDateTimeOriginal, out DateTime dateTaken);
                //if (reso)
                //{
                //    // se attiva qui significa che la data è disponibile
                //    dataAcquisizione = dateTaken;
                //    return GstErrori.EErrore.E0000_OK;
                //}
                //else
                //{
                //    // se attiva qui significa che la data non è disponibile,
                //    // quindi, se abilitato, cerca una data in modo alternativo
                //    if (cercaData)
                //        CercaData(file, out dataAcquisizione);
                //    return GstErrori.EErrore.E0001_NOK;
                //}
            }
            catch (Exception ex)
            {
                if (cercaData)
                {
                    CercaData(file, out dataAcquisizione);
                }

                return GstErrori.EErrore.E1359_FileDataNonDisponibile;
            }
        }




        /// <summary>
        /// Cerca la data del file per vie traverse
        /// </summary>
        /// <param name="file"></param>
        /// <param name="dataAcquisizione"></param>
        /// <returns></returns>
        private bool CercaData(CNomeFile file, out DateTime dataAcquisizione)
        {
            dataAcquisizione = new DateTime(2100, 11, 01);
            DateTime dataSimile = new DateTime(2100, 10, 01);
            DateTime dataMigliore = new DateTime(2100, 09, 01);

            // Cerca la data simile cioè, in un file che ha lo stesso nome
            // !!! Escluso perchè inaffidabile

            //bool esito1 = CercaDataFileSimile(file, out dataSimile);
            //if (dataSimile < dataAcquisizione)
            //    dataAcquisizione = dataSimile;

            // Cerca data migliore cioè, utilizza le date disponibili del file
            bool esito2 = CercaDataMigliore(file, out dataMigliore);
            if (dataMigliore < dataAcquisizione)
                dataAcquisizione = dataMigliore;

            return true;
        }
        /// <summary>
        /// Cerca la data migliore del file cioè, la più vecchia disponibile
        /// </summary>
        /// <param name="pathNomeFile"></param>
        /// <param name="dataAcquisizione"></param>
        /// <returns></returns>
        private bool CercaDataMigliore(CNomeFile file, out DateTime dataAcquisizione)
        {
            // inizializza data di acquisizione
            dataAcquisizione = new DateTime(2100, 01, 01);

            // recura le date del file 
            DateTime dataScrittura = System.IO.File.GetLastWriteTime(file.PathNomeFile);
            DateTime dataCreazione = System.IO.File.GetCreationTime(file.PathNomeFile);
            DateTime dataAccesso = System.IO.File.GetLastAccessTime(file.PathNomeFile);

            // cerca la data più vecchia
            if (dataScrittura < dataCreazione)
            {
                if (dataScrittura < dataAccesso)
                    dataAcquisizione = dataScrittura;
                else
                    dataAcquisizione = dataAccesso;
            }
            else
            {
                if (dataCreazione < dataAccesso)
                    dataAcquisizione = dataCreazione;
                else
                    dataAcquisizione = dataAccesso;

            }

            return true;
        }
        /// <summary>
        /// Cerca la data del file specificato in altri file con lo stesso nome ma estensione diversa
        /// </summary>
        /// <param name="file"></param>
        /// <param name="dataAcquisizione"></param>
        /// <returns></returns>
        private bool CercaDataFileSimile(CNomeFile file,  out DateTime dataAcquisizione)
        {
            // inizializza data di acquisizione
            dataAcquisizione = new DateTime(2100, 01, 01);

            // Crea il file di riferimento
            CNomeFile fileRif = new CNomeFile(file.PathArchivioAttivo);

            GstErrori.EErrore esito;

            // recupera il path di tutti i file contenuti in questa directory e le sue subdirerectory
            string[] listaPathFile = System.IO.Directory.GetFiles(file.PathArchivioAttivo, file.Nome + ".*", SearchOption.AllDirectories);

            foreach (string pathFileRif in listaPathFile)
            {
                // Aggiunde il path del file di riferimento
                esito = fileRif.SetPathNomeFile(pathFileRif);
                if (esito != GstErrori.EErrore.E0000_OK)
                    continue;


                // confronta le estensioni dei file
                if (file.Estensione.ToLower() == fileRif.Estensione.ToLower())
                    continue;

                // estrae la data di questo file 
                GetDataAcquisizione(fileRif, out DateTime dataAcquisizioneNuova, false);

                // confronta le date
                if (dataAcquisizioneNuova < dataAcquisizione)
                    dataAcquisizione = dataAcquisizioneNuova;
            }

            return true;
        }
    }// fine class CDataFile
}// fine namespace GAlbum

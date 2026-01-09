using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

using MetadataExtractor;
using MetadataExtractor.Formats.Exif;

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
        /// Rende la data di acqusizione di un file in particolare di una foto
        /// </summary>
        /// <param name="pathNomeFile"></param>
        /// <param name="dataAcquisizione"></param>
        /// <returns></returns>
        public GstErrori.EErrore GetDataAcquisizione(string pathNomeFile, out DateTime dataAcquisizione)
        {
            // inizializza data di acquisizione
            dataAcquisizione = new DateTime(1980, 01, 01);

            var directories = ImageMetadataReader.ReadMetadata(pathNomeFile);

            // Estrae la subdirectory ??? (non ho ben capito che cosa è)
            var subIfdDirectory = directories.OfType<ExifSubIfdDirectory>().FirstOrDefault();
            if (subIfdDirectory == null)
            {
                return GstErrori.EErrore.E0001_NOK;
            }

            // Estrae il Tag 0x9003 che corrisponde alla data originale di scatto cioè, dataTaken
            bool reso = subIfdDirectory.TryGetDateTime(ExifDirectoryBase.TagDateTimeOriginal, out DateTime dateTaken);
            if (reso)
            {
                dataAcquisizione = dateTaken;    
                return GstErrori.EErrore.E0000_OK;
            }
            else
                return GstErrori.EErrore.E0001_NOK;
        }

    }// fine class CDataFile
}// fine namespace GAlbum

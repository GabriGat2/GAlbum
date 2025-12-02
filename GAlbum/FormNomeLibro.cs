using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace GAlbum
{
    public partial class FormNomeLibro : Form
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================
        /// <summary>
        /// riferiemnto all'area archivio
        /// </summary>
        protected CAreaArchivio AreaArchivio = null;
        /// <summary>
        /// Nome file sorgente
        /// </summary>
        public string PathNomeFileSrc { get => FileSrc.PathNomeFile; set => FileSrc.SetPathNomeFile(value); }
        /// <summary>
        /// Nome file sorgente scoposto 
        /// </summary>
        private CNomeFile FileSrc;
        /// <summary>
        /// Nome file destinazione
        /// </summary>
        public string PathNomeFileDst { get => FileDst.PathNomeFile; set => FileDst.SetPathNomeFile(value); }
        /// <summary>
        /// Nome file destinazionew scomposto 
        /// </summary>
        private CNomeFile FileDst;



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
        public FormNomeLibro(ref CAreaArchivio areaArchivio)
        {
            // Assegna il riferimento a AreaArchivio
            this.AreaArchivio = areaArchivio;

            InitializeComponent();
            inizializzaClasse();
        }
        /// <summary>
        /// inizializza classe
        /// </summary>
        private void inizializzaClasse()
        {
            FileSrc = new CNomeFile(AreaArchivio.PathArchivioAttivo);
            FileDst = new CNomeFile(AreaArchivio.PathArchivioAttivo);
        }
        /// <summary>
        /// Autore 1 modificato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void textBoxAutore1_TextChanged(object sender, EventArgs e)
        {

            AreaArchivio.NLibro.Autore1 = textBoxAutore1.Text;

            textBoxAutore2.Text = AreaArchivio.NLibro.NomeFileLibro; 

            textBoxNomeFileDst.Text = AreaArchivio.NLibro.NomeFileLibro;

            //textBoxNomeFileDst.Text = textBoxAutore1.Text; 
        }
    }//fine della classe  FormNomeLibro
}// fine del name scope


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAlbum
{
    public partial class FormStatisticaAcquisire : Form
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================

        public uint StatisticaAcquisire_NumeroFile {set => labelNumeroFileValore.Text = value.ToString(); }
        public uint StatisticaAcquisire_NumeroFileAssegnati { set => NumeroFileAssegnati.Text = value.ToString(); }
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
        public FormStatisticaAcquisire()
        {
            InitializeComponent();
        }


    } // fine class FormStatisticaAcquisire
} // fine namespace GAlbum

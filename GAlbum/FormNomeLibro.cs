using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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

        /// <summary>
        /// limite minimo di cancellazione delle voci della combobox del supporto 
        /// </summary>
        private int limiteMinimo;


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

            // Popola comboBox supporto 
            limiteMinimo = 0;
            comboBoxSupporto.Items.Add("Libro");
            limiteMinimo++;

            comboBoxSupporto.Items.Add("eBook");
            limiteMinimo++;

            comboBoxSupporto.Items.Add("Audio");
            limiteMinimo++;

            comboBoxSupporto.Items.Add("Video");
            limiteMinimo++;

            // Aggiorna campi autore
            textBoxAutore1.Text = AreaArchivio.NLibro.Autore1;
            if (AreaArchivio.NLibro.Autore1DaConfermare  )
            {
                textBoxAutore1.BackColor = SystemColors.Info;
            }
            else
            {
                textBoxAutore1.BackColor = SystemColors.Window;
            }

            textBoxAutore2.Text = AreaArchivio.NLibro.Autore2;
            if (AreaArchivio.NLibro.Autore2DaConfermare)
            {
                textBoxAutore2.BackColor = SystemColors.Info;
            }
            else
            {
                textBoxAutore2.BackColor = SystemColors.Window;
            }
            textBoxAutore3.Text = AreaArchivio.NLibro.Autore3;
            if (AreaArchivio.NLibro.Autore3DaConfermare)
            {
                textBoxAutore3.BackColor = SystemColors.Info;
            }
            else
            {
                textBoxAutore3.BackColor = SystemColors.Window;
            }

            // Aggiorna campi titolo
            textBoxTitolo1.Text = AreaArchivio.NLibro.Titolo1;
            if (AreaArchivio.NLibro.Titolo1DaConfermare)
            {
                textBoxTitolo1.BackColor = SystemColors.Info;
            }
            else
            {
                textBoxAutore1.BackColor = SystemColors.Window;
            }
            textBoxTitolo2.Text = AreaArchivio.NLibro.Titolo2;
            if (AreaArchivio.NLibro.Titolo2DaConfermare)
            {
                textBoxTitolo2.BackColor = SystemColors.Info;
            }
            else
            {
                textBoxAutore2.BackColor = SystemColors.Window;
            }
            textBoxTitolo3.Text = AreaArchivio.NLibro.Titolo3;
            if (AreaArchivio.NLibro.Titolo3DaConfermare)
            {
                textBoxTitolo3.BackColor = SystemColors.Info;
            }
            else
            {
                textBoxAutore3.BackColor = SystemColors.Window;
            }

            // aggiorna volume - volumi
            textBoxVolumi.Text = AreaArchivio.NLibro.Volume;
            if (AreaArchivio.NLibro.VolumeDaConfermare)
            {
                textBoxVolumi.BackColor = SystemColors.Info;
            }
            else
            {
                textBoxVolumi.BackColor = SystemColors.Window;
            }
            textBoxTotVolumi.Text = AreaArchivio.NLibro.Volumi;
            if (AreaArchivio.NLibro.VolumiDaConfermare)
            {
                textBoxTotVolumi.BackColor = SystemColors.Info;
            }
            else
            {
                textBoxTotVolumi.BackColor = SystemColors.Window;
            }
            checkBoxVolumi.Checked = AreaArchivio.NLibro.AbilitaVolume;

            // Aggiorna i campi comboBox
            int indice = comboBoxSupporto.FindString(AreaArchivio.NLibro.Supporto);
            if (indice < 0)
            {
                comboBoxSupporto.Items.Add(AreaArchivio.NLibro.Supporto);
            }
            else
            {
                comboBoxSupporto.SelectedIndex = indice;
            }
            if (AreaArchivio.NLibro.SupportoDaConfermare)
            {
                comboBoxSupporto.BackColor = SystemColors.Info;
            }
            else
            {
                comboBoxSupporto.BackColor = SystemColors.Window;
            }
            checkBoxSupporto.Checked = AreaArchivio.NLibro.AbilitaSupporto;
            
   
            // aggiorna data
            dateTimePickerDataLettura.Value = AreaArchivio.NLibro.Data;
            if (AreaArchivio.NLibro.DataDaConfermare)
            {
                groupBoxDataLettura2.BackColor = SystemColors.Info; ;
                dateTimePickerDataLettura.BackColor = SystemColors.Info;
                dateTimePickerDataLettura.CalendarTitleBackColor = SystemColors.Info;
                dateTimePickerDataLettura.CalendarMonthBackground = SystemColors.Info;
            }
            else
            {
                groupBoxDataLettura2.BackColor = SystemColors.Window;
                dateTimePickerDataLettura.BackColor = SystemColors.Window;
            }
            checkBoxDataLettura.Checked = AreaArchivio.NLibro.AbilitaData;


            AggiornaForm();
        }
        /// <summary>
        /// Autore 1 modificato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void textBoxAutore1_TextChanged(object sender, EventArgs e)
        {

            AreaArchivio.NLibro.Autore1 = textBoxAutore1.Text;


            AggiornaForm();

        }
        /// <summary>
        /// Autore 2 modificato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAutore2_TextChanged(object sender, EventArgs e)
        {
            // Assegna autore 2 
            AreaArchivio.NLibro.Autore2 = textBoxAutore2.Text;


            AggiornaForm();
        }
        /// <summary>
        /// aggiorna il form
        /// </summary>
        private void AggiornaForm()
        {
            // Aggiorna il path sorgente
            textBoxPathSrc.Text = AreaArchivio.NLibro.FileSrc.PathFoglia;

            // aggiorna il nome del file sorgente
            textBoxNomeFileSrc.Text = AreaArchivio.NLibro.FileSrc.NomeFile;

            // aggiorna il path destinazione
            textBoxPathDst.Text = AreaArchivio.NLibro.FileDst.PathNomeFile;

            // aggiona il nome del file destinazione 
            textBoxNomeFileDst.Text = AreaArchivio.NLibro.NomeFileLibro;
        }
        /// <summary>
        /// Autore 3 modificato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxAutore3_TextChanged(object sender, EventArgs e)
        {
            // Assegna autore 3
            AreaArchivio.NLibro.Autore3 = textBoxAutore3.Text;


            AggiornaForm();
        }
        /// <summary>
        /// Titolo 1 modificato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxTitolo1_TextChanged(object sender, EventArgs e)
        {
            // Assegna titolo 1
            AreaArchivio.NLibro.Titolo1 = textBoxTitolo1.Text;
            AggiornaForm();
        }
        /// <summary>
        /// Titolo 2 modificato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxTitolo2_TextChanged(object sender, EventArgs e)
        {
            // Assegna titolo 2
            AreaArchivio.NLibro.Titolo2 = textBoxTitolo2.Text;
            AggiornaForm();
        }
        /// <summary>
        /// Titolo 3 modificato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxTitolo3_TextChanged(object sender, EventArgs e)
        {
            // Assegna titolo 3
            AreaArchivio.NLibro.Titolo3 = textBoxTitolo3.Text;
            AggiornaForm();
        }
        /// <summary>
        /// Volume modificato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxVolumi_TextChanged(object sender, EventArgs e)
        {
            // Assegna Voulume
            AreaArchivio.NLibro.Volume = textBoxVolumi.Text;
            AggiornaForm();
        }
        /// <summary>
        /// Volumi modificato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxTotVolumi_TextChanged(object sender, EventArgs e)
        {
            // Assegna Voulume
            AreaArchivio.NLibro.Volumi = textBoxTotVolumi.Text;
            AggiornaForm();
        }
        /// <summary>
        /// Selezione supporto cambiata 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSupporto_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBoxSupporto.Text = comboBoxSupporto.SelectedIndex.ToString();
            textBoxSupporto.Text = comboBoxSupporto.Text;

        }
        /// <summary>
        /// gestione combobox supporto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxSupporto_KeyUp(object sender, KeyEventArgs e)
        {
            // Verifca se è un tanto di enter
            if (e.KeyCode == Keys.Enter)
            {
                // estrae la nuova voce
                string nuovaVoce = comboBoxSupporto.Text;

                // Verifica se nella comboBox c'è una voce uguale a nuovaVoce
                int indice = comboBoxSupporto.FindString(nuovaVoce);
                if (indice < 0)
                {
                    comboBoxSupporto.Items.Add(comboBoxSupporto.Text);
                }

                textBoxSupporto.Text = nuovaVoce;
            }

        }
        /// <summary>
        /// Cancella una voce dalla combo box del supporto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butDelete_Click(object sender, EventArgs e)
        {
            // estrae l'indice della vode selezionata
            int indice = comboBoxSupporto.SelectedIndex;
            if (indice >= limiteMinimo) 
            {
                comboBoxSupporto.Items.RemoveAt(indice);
            }


        }
        /// <summary>
        /// supporto mmodificato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSupporto_TextChanged(object sender, EventArgs e)
        {
            AreaArchivio.NLibro.Supporto = textBoxSupporto.Text;
            AggiornaForm();
        }
        /// <summary>
        /// la data è stata cambiata;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dateTimePickerDataLettura_ValueChanged(object sender, EventArgs e)
        {
            AreaArchivio.NLibro.Data = dateTimePickerDataLettura.Value;
            AggiornaForm();
        }
        /// <summary>
        /// L'abiltazione del volume è cambiata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxVolumi_CheckedChanged(object sender, EventArgs e)
        {
            AreaArchivio.NLibro.AbilitaVolume = checkBoxVolumi.Checked;
            AggiornaForm();
        }
        /// <summary>
        /// L'abiltazione della data è cambiata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxDataLettura_CheckedChanged(object sender, EventArgs e)
        {
            AreaArchivio.NLibro.AbilitaData = checkBoxDataLettura.Checked;
            AggiornaForm();
        }
        /// <summary>
        /// L'abiltazione del supporto  è cambiato
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSupporto_CheckedChanged(object sender, EventArgs e)
        {
            AreaArchivio.NLibro.AbilitaSupporto = checkBoxSupporto.Checked;
            AggiornaForm();
        }
        /// <summary>
        /// esegue l'assegnazione del file copertina libro 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butAssegna_Click(object sender, EventArgs e)
        {
            EseguiAssegna();            
        }
        /// <summary>
        /// Esegui assegna
        /// </summary>
        /// <param name="copia"></param>
        protected void EseguiAssegna(bool copia = true)
        {

            // Assegna la foto copertina libro
            GstErrori.EErrore esito = AreaArchivio.AssegnaLibro(AreaArchivio.NLibro.FileSrc, AreaArchivio.NLibro.FileDst);

            if (esito != GstErrori.EErrore.E0000_OK)
            {
                GstErrori.StampaMessaggioErrore(esito);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


    }//fine della classe  FormNomeLibro
}// fine del name scope


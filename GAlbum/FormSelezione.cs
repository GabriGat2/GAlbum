using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace GAlbum
{
    public partial class FormSelezione: Form
    {
        /// <summary>
        /// lista delle foto sorgente
        /// </summary>
        private string[] fotoSrcList;
        /// <summary>
        /// indice della lista delle foto sorgente
        /// </summary>
        private int idFotoSrcList;

        private Bitmap MyImage;

        /// <summary>
        /// Costruttore
        /// </summary>
        public FormSelezione()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Carica le fotografie contenute nella directory specificata
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butApri_Click(object sender, EventArgs e)
        {
            string path = string.Empty;

            // seleziona la directory delle foto
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                path = dlg.SelectedPath;
            }
            // verifica se ha selezionato una directory
            if (path == string.Empty)
                return;

            textBoxPathFoto.Text = path;

            // carica la lista dei file contenuti nella directory
            fotoSrcList = Directory.GetFiles(path, "*.jpg");
            idFotoSrcList = 0;

            // Per caricare un'immagine da un file
            pictureBox1.Image = Image.FromFile(@fotoSrcList[0]);
            //pictureBox1.Image = Image.FromFile(@"D:\Angelo\Prj\Album\Foto\JPeg\HJPV5326.JPG");

        }
        /// <summary>
        /// Mostra la prossima foto contenuta nella lista
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void butSuccessiva_Click(object sender, EventArgs e)
        {
            if (fotoSrcList == null)
                return;
            if (idFotoSrcList >= (fotoSrcList.Length - 1))
                return;

            idFotoSrcList++;

            MostraFoto(fotoSrcList[idFotoSrcList]);
        }
        /// <summary>
        /// Mostra la foto indicata
        /// </summary>
        /// <param name="path"></param>
        private void MostraFoto(string pathFoto)
        {
            // mostra il path della foto
            textBoxPathFoto.Text = pathFoto;


            if (MyImage != null)
                MyImage.Dispose();

            MyImage = new Bitmap(pathFoto);


            // Carica l'immagine dal file
            pictureBox1.Image = (Image)MyImage;
            //pictureBox1.Image = Image.FromFile(@pathFoto);
        }

    }
}

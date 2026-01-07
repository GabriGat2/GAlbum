using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAlbum
{
    public class CInfoDirFoto
    {
        /// <summary>
        /// path della directory
        /// </summary>
        public string Path { get => path; /* set => AssegnaPath(value); */ }  
        private string path;
        /// <summary>
        ///  nome della directory
        /// </summary>
        public string Nome { get => nome; }
        private string nome;
        /// <summary>
        /// directory selezionata
        /// </summary>
        public bool Selezione { get => selezione; set => ImpostaSelezione(value); }
        private bool selezione;
        /// <summary>
        /// Nodo associato all'info
        /// </summary>
        //public TreeNode Nodo { get => nodo; set => nodo = value; }
        private TreeNode nodo;
        /// <summary>
        /// costruttore
        /// </summary>
        public CInfoDirFoto(string path)
        {
            AssegnaPath(path);
            nodo = null;
        }
        /// <summary>
        /// assegna il path, il nome e resetta la selezione
        /// </summary>
        /// <param name="path"></param>
        private void AssegnaPath(string path)
        {
            // assegna il path
            this.path = path;

            // Assegna il nome, estrae il nome della sub directory
            string[] campi = this.path.Split('\\');
            this.nome = campi[campi.Length - 1];

            // resetta selezione
            this.selezione = false;

        }
        /// <summary>
        /// commuta lo stato di selezione
        /// </summary>
        /// <param name="nodo"></param>
        public void CommutaSelezione(/* ref TreeNode nodo*/)
        {
            // commuta selezione 
            selezione = !selezione;

            // aggiorna stato nodo 
            AggiornaStatoNodo();
        }
        /// <summary>
        /// imposta il valore di selezionato 
        /// </summary>
        /// <param name="selezione"></param>
        
        private void ImpostaSelezione(bool selezione)
        {
            // imposta nuovo valore di selezionato 
            this.selezione = selezione;

            // aggiorna stato nodo 
            AggiornaStatoNodo();
        }

        // aggiorna lo stato del nodo
        private void AggiornaStatoNodo()
        {
            // verifica che il riferimento al nodo sia impostato 
            if (this.nodo == null)
            {
                return;
            }

            // mostra la selezione 
            if (selezione)
            {
                nodo.BackColor = Color.LightGreen;
                nodo.Text = "-> " + nome;
            }
            else
            {
                nodo.Text = nome;
                nodo.BackColor = Color.White;
            }

        }
        /// <summary>
        /// Aggiunge il riferimento al nodo associato
        /// </summary>
        /// <param name="nodo"></param>
        public void SetNodo(ref TreeNode nodo)
        {
            this.nodo = nodo;
        }

    }
}

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
        public GstErrori.EErrore Assegna(string pathSrc, string [] pathDestinazioni)
        {
            GstErrori.EErrore esito = GstErrori.EErrore.E0001_NOK;


            // Esegue le copie
            foreach (var pathDst in pathDestinazioni)
            {
                // esegue la copia
                esito = Copia(pathSrc, pathDst);
                if (esito != GstErrori.EErrore.E0000_OK)
                    return esito;

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


            return GstErrori.EErrore.E0000_OK;
        }


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




    }// fine class CArchivia
    }// fine namespace GAlbum

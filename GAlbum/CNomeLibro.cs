using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAlbum
{
    public class CNomeLibro
    {
        // ==================================================================================================================
        // Proprietà
        // ==================================================================================================================

        // ------------------------------------------------------------------------------------------------------------------
        // Autore 1
        /// <summary>
        /// Nome esplicito autore 1
        /// </summary>
        public string Autore1 { get => autore1; set =>  SetAutore1 (value); }
        private string autore1;
        /// <summary>
        ///  nome compresso autore 1 
        /// </summary>
        private string Autore1Cmp;

        // ------------------------------------------------------------------------------------------------------------------
        // Nome file libro
        /// <summary>
        /// Nome del file del libro
        /// </summary>
        public string NomeFileLibro { get => nomeFileLibro; /*set => nomeFileLibro = value;*/ }
        private string nomeFileLibro;




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
        public CNomeLibro()
        {
            InizializzaClasse();
        }
        /// <summary>
        /// inizializza classe
        /// </summary>
        private void InizializzaClasse() 
        {
            AzzeraTutto();
        }
        /// <summary>
        /// Azzera tutte le variabili 
        /// </summary>
        public void AzzeraTutto()
        {
            autore1 = string.Empty;
            nomeFileLibro = string.Empty;
        }
        /// <summary>
        ///  Aggiorna autore 1 
        /// </summary>
        /// <param name="nome"></param>
        private void SetAutore1(string nome)
        {
            // salva il nome esplicito dell'autore 
            autore1 = nome;

            // Comprime autore 1
            Autore1Cmp = ComprimiNome(autore1);


            nomeFileLibro = "==>" + Autore1Cmp + "<==";
        }
        /// <summary>
        /// comprime il nome 
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        private string ComprimiNome(string nome)
        {
            // rimuove gli spazi alle estremità
            string nome1 = nome.Trim();

            // trasforma tutto in minuscolo
            string nome2 = nome1.ToLower();

            // Inizializza nome compresso 
            string nomeCmp = string.Empty;
            bool maiuscolo = true; 

            // Analiza i caratteri di nome 2  
            foreach (char c in nome2) 
            {
                // analizza gli spazi
                if (c == ' ')
                {
                    // se arriva qui é uno spazio 
                    maiuscolo = true;
                }
                else
                {
                    // se arriva qui non é uno spazio
                    if (maiuscolo)
                        nomeCmp += c.ToString().ToUpper();
                    else
                        nomeCmp += c;
                    maiuscolo = false;
                }

            }



            return nomeCmp;
        }


    }// fine class  CNomeLibro
}// fine namespace GAlbum


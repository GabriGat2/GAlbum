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
        //public string Autore1 { get => autore1; set =>  SetAutore1 (value); }
        public string Autore1 { get => autore1; set => autore1 = SetNome(value, ref Autore1Cmp); }
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


        // ------------------------------------------------------------------------------------------------------------------
        // Caratteri accentati 
        private const string Separatori = " '-";
        private const string accenti_A = "á Á à À â Â å Å ã Ã ä Ä æ Æ";
        private const string accenti_B = "ß";
        private const string accenti_C = "ç Ç";
        private const string accenti_E = "é É è È ê Ê ë Ë";
        private const string accenti_I = "í Í ì Ì î Î ï Ï";
        private const string accenti_N = "ñ Ñ";
        private const string accenti_O = "ó Ó ò Ò ô Ô ø Ø õ Õ ö Ö";
        private const string accenti_U = "ú Ú ù Ù û Û ü Ü";
        private const string accenti_Y = "ÿ";
        

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
        /// Assegna il nome e il nome compresso
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="nomeCMP"></param>
        /// <returns></returns>
        private string SetNome(string nome, ref string nomeCmp)
        {
            // Comprime nome
            nomeCmp = ComprimiNome(nome);

            // Compone nome file libro 
            ComponeNomeFileLibro();

            return nome;
        }
        /// <summary>
        /// Compone nome file libro 
        /// </summary>
        private void ComponeNomeFileLibro()
        {
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
                    // analizza i separatori
                //if (c == ' ')
                if (Separatori.IndexOf(c) >= 0)
                {
                    // se arriva qui é un separatore 
                    maiuscolo = true;
                }
                    // analizza i numeri
                else if ((c >= '0') && (c <= '9'))
                {
                    nomeCmp += c;
                    maiuscolo = false;
                }
                    // analizza le lettere
                else if ((c >= 'a') && (c <= 'z'))
                {
                    if (maiuscolo)
                        nomeCmp += c.ToString().ToUpper();
                    else
                        nomeCmp += c;
                    maiuscolo = false;
                }
                    // Analizza accento sulla A
                else if (accenti_A.IndexOf(c) >= 0)
                {
                    if (maiuscolo)
                        nomeCmp += 'A';
                    else
                        nomeCmp += 'a';
                    maiuscolo = false;
                }
                // Analizza accento sulla B
                else if (accenti_B.IndexOf(c) >= 0)
                {
                    if (maiuscolo)
                        nomeCmp += 'B';
                    else
                        nomeCmp += 'b';
                    maiuscolo = false;
                }
                // Analizza accento sulla C
                else if (accenti_C.IndexOf(c) >= 0)
                {
                    if (maiuscolo)
                        nomeCmp += 'C';
                    else
                        nomeCmp += 'c';
                    maiuscolo = false;
                }
                // Analizza accento sulla E
                else if (accenti_E.IndexOf(c) >= 0)
                {
                    if (maiuscolo)
                        nomeCmp += 'E';
                    else
                        nomeCmp += 'e';
                    maiuscolo = false;
                }
                // Analizza accento sulla I
                else if (accenti_I.IndexOf(c) >= 0)
                {
                    if (maiuscolo)
                        nomeCmp += 'I';
                    else
                        nomeCmp += 'i';
                    maiuscolo = false;
                }
                // Analizza accento sulla N
                else if (accenti_N.IndexOf(c) >= 0)
                {
                    if (maiuscolo)
                        nomeCmp += 'N';
                    else
                        nomeCmp += 'n';
                    maiuscolo = false;
                }
                // Analizza accento sulla O
                else if (accenti_O.IndexOf(c) >= 0)
                {
                    if (maiuscolo)
                        nomeCmp += 'O';
                    else
                        nomeCmp += 'o';
                    maiuscolo = false;
                }
                // Analizza accento sulla O
                else if (accenti_U.IndexOf(c) >= 0)
                {
                    if (maiuscolo)
                        nomeCmp += 'U';
                    else
                        nomeCmp += 'u';
                    maiuscolo = false;
                }
                // Analizza accento sulla Y
                else if (accenti_Y.IndexOf(c) >= 0)
                {
                    if (maiuscolo)
                        nomeCmp += 'Y';
                    else
                        nomeCmp += 'y';
                    maiuscolo = false;
                }
                // carattere sconosciuto 
                else
                {
                    nomeCmp += '°';
                    maiuscolo = false;
                }

            }



            return nomeCmp;
        }


    }// fine class  CNomeLibro
}// fine namespace GAlbum


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
        public string Autore1 { get => autore1; set => autore1 = SetNome(value, ref Autore1Cmp); }
        private string autore1 = string.Empty;
        /// <summary>
        ///  nome compresso autore 1 
        /// </summary>
        private string Autore1Cmp = string.Empty;
        // ------------------------------------------------------------------------------------------------------------------
        // Autore 2
        /// <summary>
        /// Nome esplicito autore 2
        /// </summary>
        public string Autore2 { get => autore2; set => autore2 = SetNome(value, ref Autore2Cmp); }
        private string autore2 = string.Empty;
        /// <summary>
        ///  nome compresso autore 2 
        /// </summary>
        private string Autore2Cmp = string.Empty;
        // ------------------------------------------------------------------------------------------------------------------
        // Autore 3
        /// <summary>
        /// Nome esplicito autore 3
        /// </summary>
        public string Autore3 { get => autore3; set => autore3 = SetNome(value, ref Autore3Cmp); }
        private string autore3 = string.Empty;
        /// <summary>
        ///  nome compresso autore 3 
        /// </summary>
        private string Autore3Cmp = string.Empty;
        // ------------------------------------------------------------------------------------------------------------------
        // Titolo 1
        /// <summary>
        /// Nome esplicito Titolo 1
        /// </summary>
        public string Titolo1 { get => titolo1; set => titolo1 = SetNome(value, ref Titolo1Cmp); }
        private string titolo1 = string.Empty;
        /// <summary>
        ///  nome compresso titolo 1 
        /// </summary>
        private string Titolo1Cmp = string.Empty;
        // ------------------------------------------------------------------------------------------------------------------
        // Titolo 2
        /// <summary>
        /// Nome esplicito Titolo 2
        /// </summary>
        public string Titolo2 { get => titolo2; set => titolo2 = SetNome(value, ref Titolo2Cmp); }
        private string titolo2 = string.Empty;
        /// <summary>
        ///  nome compresso titolo 2
        /// </summary>
        private string Titolo2Cmp = string.Empty;
        // ------------------------------------------------------------------------------------------------------------------
        // Titolo 3
        /// <summary>
        /// Nome esplicito Titolo 3
        /// </summary>
        public string Titolo3 { get => titolo3; set => titolo3 = SetNome(value, ref Titolo3Cmp); }
        private string titolo3 = string.Empty;
        /// <summary>
        ///  nome compresso titolo 3
        /// </summary>
        private string Titolo3Cmp = string.Empty;
        // ------------------------------------------------------------------------------------------------------------------
        // Volume
        /// <summary>
        /// Nome esplicito Volume
        /// </summary>
        public string Volume { get => volume; set => volume = SetNome(value, ref VolumeCmp, true); }
        private string volume = string.Empty;
        /// <summary>
        ///  nome compresso Volume
        /// </summary>
        private string VolumeCmp = string.Empty;
        // ------------------------------------------------------------------------------------------------------------------
        // Volumi
        /// <summary>
        /// Nome esplicito Volumi
        /// </summary>
        public string Volumi { get => volumi; set => volumi = SetNome(value, ref VolumiCmp, true); }
        private string volumi = string.Empty;
        /// <summary>
        ///  nome compresso Volumi
        /// </summary>
        private string VolumiCmp = string.Empty;
        // ------------------------------------------------------------------------------------------------------------------
        // Supporto
        /// <summary>
        ///  Nome esplicito Supporto
        /// </summary>
        private string supporto = string.Empty;
        public string Supporto { get => supporto; set => supporto = SetNome(value, ref SupportoCmp); }
        /// <summary>
        ///  nome compresso supporto
        /// </summary
        private string SupportoCmp = string.Empty;

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
            Autore1 = string.Empty;
            Autore2 = string.Empty;
            Autore3 = string.Empty;

            Titolo1= string.Empty;
            Titolo2= string.Empty;
            Titolo3 = string.Empty;

            Volume = string.Empty;
            Volumi = string.Empty;

            nomeFileLibro = string.Empty;            
        }
        /// <summary>
        /// Assegna il nome e il nome compresso
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="nomeCMP"></param>
        /// <returns></returns>
        private string SetNome(string nome, ref string nomeCmp, bool soloNumeri = false)
        {
            if (soloNumeri)
            {
                // Comprime numero
                nomeCmp = ComprimiNumero(nome);
            }
            else
            {
                // Comprime nome
                nomeCmp = ComprimiNome(nome);
            }

            

            // Compone nome file libro 
            ComponeNomeFileLibro();

            return nome;
        }
        /// <summary>
        /// Compone nome file libro 
        /// </summary>
        private void ComponeNomeFileLibro()
        {
            // inizio composizione nome titolo 
            nomeFileLibro = "==>";

            // Aggiunge AUTORI
            // ----------------------------------------------------------------------------------
            bool trattino = false;

            if (Autore1Cmp.Length > 0)
            {
                nomeFileLibro += Autore1Cmp;
                trattino = true;
            }

            if (Autore2Cmp.Length > 0)
            {
                if (trattino)
                    nomeFileLibro += "-";
                nomeFileLibro += Autore2Cmp;
                trattino = true;
            }

            if (Autore3Cmp.Length > 0)
            {
                if (trattino)
                    nomeFileLibro += "-";
                nomeFileLibro += Autore3Cmp;
                trattino = true;
            }



            // Aggiunge Titoli
            // ----------------------------------------------------------------------------------
            nomeFileLibro += "_";
            trattino = false;

            if (Titolo1Cmp.Length > 0)
            {
                nomeFileLibro += Titolo1Cmp;
                trattino = true;
            }
            if (Titolo2Cmp.Length > 0)
            {
                if (trattino)
                    nomeFileLibro += "-";
                nomeFileLibro += Titolo2Cmp;
                trattino = true;
            }

            if (Titolo3Cmp.Length > 0)
            {
                if (trattino)
                    nomeFileLibro += "-";
                nomeFileLibro += Titolo3Cmp;
                trattino = true;
            }
            // Aggiunge i volumi 
            // ----------------------------------------------------------------------------------
            nomeFileLibro += "_#";
            trattino = false;

            if (VolumeCmp.Length > 0)
            {
                nomeFileLibro += VolumeCmp;
                trattino = true;
            }
            if (VolumiCmp.Length > 0)
            {
                if (trattino)
                    nomeFileLibro += "-";
                nomeFileLibro += VolumiCmp;
                trattino = true;
            }
            // Aggiunge supporto
            // ----------------------------------------------------------------------------------
            nomeFileLibro += "_§";
            trattino = false;

            if (SupportoCmp.Length > 0)
            {
                nomeFileLibro += SupportoCmp;
                trattino = true;
            }

            // fine composizione nome titolo 
            nomeFileLibro += "<==";

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
        /// <summary>
        /// scrive solo il numero  
        /// </summary>
        /// <param name="nome"></param>
        /// <returns></returns>
        private string ComprimiNumero(string nome)
        {
            // rimuove gli spazi alle estremità
            string nome1 = nome.Trim();

             // Inizializza nome compresso 
            string nomeCmp = string.Empty;

            // Analiza i caratteri di nome 1 
            foreach (char c in nome1)
            {
                // analizza i numeri
                if ((c >= '0') && (c <= '9'))
                {
                    nomeCmp += c;
                }
                // carattere sconosciuto 
                else
                {
                    nomeCmp += '°';

                }

            }

            return nomeCmp;
        }
    }// fine class  CNomeLibro
}// fine namespace GAlbum


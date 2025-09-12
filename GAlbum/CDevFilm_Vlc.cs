using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GAlbum.GstErrori;


namespace GAlbum
{
    public class CDevFilm_Vlc : CDevImmagine
    {
        /// <summary>
        /// costruttore
        /// </summary>
        public CDevFilm_Vlc()
        {
        }
        /// <summary>
        /// Mostra un film, nell'immagine rende il nome del file e del tool usato per visualizzarlo
        /// </summary>
        /// <param name="pathFilm"></param>
        /// <param name="image"></param>
        /// <returns></returns>
        public virtual GstErrori.EErrore MostraFilm(string pathFilm, out System.Drawing.Image image)
        {
            // inizializza image
            image = null;

            // trova il path del vlc
            string pathVlc = GetVlcPath();
            if (string.IsNullOrEmpty(pathVlc))
                return GstErrori.EErrore.E1503_VlcExeNonInstallato;

            // verifica se il film esiste
            if (!File.Exists(pathFilm))
            {
                return GstErrori.EErrore.E1501_FilmNonEsiste;
            }

            // prova a visualizzare il film con Vlc
            try
            {
                // prepara i dati per l'esecuzione
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = pathVlc, // Percorso dell'eseguibile VLC
                    Arguments = $"\"{pathFilm}\"", // Percorso del file video tra virgolette
                    UseShellExecute = false // Importante per evitare errori con le virgolette
                };

                // esegue Vlc
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                // La visualizzazione del film é fallita
                return GstErrori.EErrore.E1502_TipoFilmNonGestita;
            }

            // compone immagine con informazioni sul film visualizzato 
            CreaImmagineInfoFilm(pathFilm, out image);        
            return GstErrori.EErrore.E0000_OK;

        }
        /// <summary>
        /// trova il path vlc
        /// </summary>
        /// <returns></returns>
        private string GetVlcPath()
        {
            string vlcPath = null;

            // Prova ad accedere alla chiave di HKEY_LOCAL_MACHINE
            vlcPath = GetPathFromRegistry(Registry.LocalMachine);

            // Se non trovato, prova ad accedere alla chiave di HKEY_CURRENT_USER
            if (string.IsNullOrEmpty(vlcPath))
            {
                vlcPath = GetPathFromRegistry(Registry.CurrentUser);
            }

            return vlcPath;
        }
        /// <summary>
        /// Trova il path vlc nel gruppo dei registri specificato
        /// </summary>
        /// <param name="hive"></param>
        /// <returns></returns>
        private string GetPathFromRegistry(RegistryKey hive)
        {
            string path = null;
            string keyPath = @"SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\vlc.exe";

            using (RegistryKey registryKey = hive.OpenSubKey(keyPath))
            {
                if (registryKey != null)
                {
                    // Il valore predefinito (senza nome) contiene il path
                    path = registryKey.GetValue(null) as string;
                }
            }
        
            return path;
        }
        /// <summary>
        /// Crea un immagine con le informazioni sul film che sta visualizzanfo
        /// </summary>
        /// <param name="pathFilm"></param>
        private void CreaImmagineInfoFilm(string pathFilm, out System.Drawing.Image image)
        {
            // crea una bitmap
            int larghezza = 400;
            int altezza = 200;
            Bitmap immagine = new Bitmap(larghezza, altezza);

            // Crea un oggetto Graphics
            Graphics g = Graphics.FromImage(immagine);

            // Imposta il colore di sfondo
            Brush coloreSfondo = new SolidBrush(Color.LightGreen); // O un altro colore desiderato
            g.FillRectangle(coloreSfondo, 0, 0, larghezza, altezza);

            // Definisce il font e la dimensione del testo
            Font fontTesto = new Font("Arial", 10, FontStyle.Regular);

            // Definisce il colore del testo
            Brush coloreTesto = new SolidBrush(Color.Blue); // O un altro colore desiderato


            // informazioni sul tool usato per visualizzare il film
            string messaggioTool = "VLC visualizza:";
            string messaggioFilm = pathFilm;
       
            // Usa il metodo DrawString() per scrivere il testo nella posizione desiderata sull'immagine. 
            float x = 50; // Posizione orizzontale
            float y = 50; // Posizione verticale
            g.DrawString(messaggioTool, fontTesto, coloreTesto, x, y);
            y = 150; // Posizione verticale
            g.DrawString(messaggioFilm, fontTesto, coloreTesto, x, y);


            // Libera le risorse
            g.Dispose();
            fontTesto.Dispose();
            coloreTesto.Dispose();

            // Stampa immagine
            image = immagine;

        }



    }
}

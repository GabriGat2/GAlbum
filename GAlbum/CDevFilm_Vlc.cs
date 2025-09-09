using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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
        /// Mostra un film
        /// </summary>
        /// <param name="pathFilm"></param>
        /// <returns></returns>
        public override GstErrori.EErrore MostraFilm(string pathFilm)
        {
            // trova il path del vlc
            string pathVlc = GetVlcPath();
            if (string.IsNullOrEmpty(pathVlc))
                return GstErrori.EErrore.E1503_VlcExeNonInstallato;


            if (!File.Exists(pathFilm))
            {
                return GstErrori.EErrore.E1502_TipoFilmNonGestita;
            }

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = pathVlc, // Percorso dell'eseguibile VLC
                    Arguments = $"\"{pathFilm}\"", // Percorso del file video tra virgolette
                    UseShellExecute = false // Importante per evitare errori con le virgolette
                };

                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                return GstErrori.EErrore.E1502_TipoFilmNonGestita;
            }




            return GstErrori.EErrore.E1502_TipoFilmNonGestita;
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


        // ============================================================================================
        // ============================================================================================
        // ============================================================================================

    //using System.Diagnostics;
    //using System.IO;

    //public static void PlayVideoWithVLC(string vlcPath, string videoPath)
    //{
    //    if (!File.Exists(vlcPath))
    //    {
    //        Console.WriteLine($"Errore: Il file eseguibile di VLC non è stato trovato in '{vlcPath}'");
    //        return;
    //    }

    //    if (!File.Exists(videoPath))
    //    {
    //        Console.WriteLine($"Errore: Il file video non è stato trovato in '{videoPath}'");
    //        return;
    //    }

    //    try
    //    {
    //        ProcessStartInfo startInfo = new ProcessStartInfo
    //        {
    //            FileName = vlcPath, // Percorso dell'eseguibile VLC
    //            Arguments = $"\"{videoPath}\"", // Percorso del file video tra virgolette
    //            UseShellExecute = false // Importante per evitare errori con le virgolette
    //        };

    //        Process.Start(startInfo);
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine($"Errore nell'avvio di VLC: {ex.Message}");
    //    }
    //}

    // Esempio di utilizzo:
    // string vlcExecutablePath = @"C:\Program Files\VideoLAN\VLC\vlc.exe"; // Modifica questo percorso
    // string myVideo = @"C:\Percorso\Del\Tuo\Video.mp4"; // Modifica questo percorso
    // PlayVideoWithVLC(vlcExecutablePath, myVideo);


    // ============================================================================================
    // ============================================================================================
    // ============================================================================================


    }
}

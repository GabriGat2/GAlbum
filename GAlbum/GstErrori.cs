using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAlbum
{
    public class GstErrori
    {

        // =====================================================================================
        // ====== Codice errore
        // =====================================================================================
        public enum EErrore
        {
            E0000_OK = 0,
            E0001_NOK = 1,
            E0002_ValoreNonRichiesto,
            E0003_FinestraDeiMessaggiNonDefinita,
            E0004_QuestaFunzioneNonPuoEssereChiamataFareOverride,
            E0005_Exception,


            // Errori relativi alla gestione di una tabelle
            //E1000_TabellaInesistente,
            //E1001_ColonnaTabellaFuoriLimiti,
            //E1002_RigaTabellaFuoriLimiti,
            //E1003_CellaTabellaFuoriLimiti,
            //E1004_IndiceColonnaTabellaFuoriLimiti,
            //E1005_IndiceRigaTabellaFuoriLimiti,
            //E1006_IndiceCellaTabellaFuoriLimiti,
            //E1007_LaDimensioniDelleTabelleSorgenteEDestinazioneSonoDiverse,


            // Operazioni
            E1200_UnaOperazioneInCorso,

            // Errori relativi una directory
            // =======================
            E1300_DirectoryNonEsiste,
            E1301_DirectoryEsiste,
            E1302_DirectoryCampiMinimiNonPresenti,
            E1303_DirectoryRamoonEsiste,
            E1304_DirectoryFogliaNonEsiste,
            E1305_DirectoryVuota,


            // Errori relativi una directory sorgente
            // =======================
            E1310_DirectorySorgenteNonEsiste,
            E1311_DirectorySorgenteEsiste,
            E1312_DirectorySorgenteCampiMinimiNonPresenti,
            E1313_DirectoryRamoSorgenteNonEsiste,
            E1314_DirectoryFogliaSorgenteNonEsiste,
            E1315_DirectorySorgenteVuota,

            // Errori relativi una directory Destinazione
            // =======================
            E1320_DirectoryDestinazioneNonEsiste,
            E1321_DirectoryDestinazioneEsiste,
            E1322_DirectoryDestinazioneCampiMinimiNonPresenti,
            E1323_DirectoryRamoDestinazioneNonEsiste,
            E1324_DirectoryFogliaDestinazioneNonEsiste,
            E1325_DirectoryDestinazioneVuota,
            E1326_TroppeDirectoryDiDestinazione,

            // Errori relativi una directory Archivio
            // =======================
            E1330_DirectoryArchivioNonEsiste,
            E1331_DirectoryArchivioEsiste,
            E1332_DirectoryArchivioCampiMinimiNonPresenti,
            E1333_DirectoryRamoArchivioNonEsiste,
            E1334_DirectoryFogliaArchivioNonEsiste,
            E1335_DirectoryArchivioVuota,

            // Errori relativi a archivio base
            // =======================
            E1340_ArchivioBaseNonEsiste,
            E1341_ArchivioBaseEsiste,

            // Errori relativi a archivio base
            // =======================
            E1350_ArchivioNonEsiste,
            E1351_ArchivioEsiste,
            E1352_NomeArchivioIllecito,
            E1353_NonPuoCreareArchivio,

            // Gestione directory
            //E1300_NomeArchivioErrato,

            //E1310_PathArchivioErrato,
            //E1311_PathAreaArchivioErrata,
            //E1312_PathEscursioneErrato,
            //E1313_PathTracciaErrato,

            //E1320_PathArchivioNonEsiste,
            //E1321_PathAreaArchivioNonEsiste,
            //E1322_PathEscursioneNonEsiste,
            //E1323_PathTracciaNonEsiste,

            //E1330_PathArchivioEsiste,
            //E1331_PathAreaArchivioEsiste,
            //E1332_PathEscursioneEsiste,
            //E1333_PathTracciaEsiste,

            //E1330_PathArchivioCreazioneFallita,
            //E1331_PathAreaArchivioCreazioneFallita,
            //E1332_PathEscursioneCreazioneFallita,
            //E1333_PathTracciaCreazioneFallita,
            //E1334_DirectoryCreazioneFallita,

            //E1340_NonEsiste,
            //E1341_Esiste,
            //E1342_AreaArchivioNonEsiste,
            //E1343_AreaArchivioEsiste,
            //E1344_EscursioneNonEsiste,
            //E1345_Escursionesiste,
            //E1346_TracciaNonEsiste,
            //E1347_TracciaEsiste,

            // Errori relativi a file
            // =======================
            E1350_FileNonEsiste,
            E1351_FileEsiste,
            E1352_FileNonSpostato,
            E1353_FileSpostato,
            E1354_FileNonCopiato,
            E1355_FileCopiato,
            E1356_FileNonCancellato,
            E1357_FileCancellato,
            E1358_FileNomeNonCorretto,

            // Errori relativi a file sorgente
            // =======================
            E1360_FileSorgenteNonEsiste,
            E1361_FileSorgenteEsiste,
            E1362_FileSorgenteNonSpostato,
            E1363_FileSorgenteSpostato,
            E1364_FileSorgenteNonCopiato,
            E1365_FileSorgenteCopiato,
            E1366_FileSorgenteNonCancellato,
            E1367_FileSorgenteCancellato,

            // Errori relativi a file Destinazione
            // =======================
            E1370_FileDestinazioneNonEsiste,
            E1371_FileDestinazioneEsiste,
            E1372_FileDestinazioneNonSpostato,
            E1373_FileDestinazioneSpostato,
            E1374_FileDestinazioneNonCopiato,
            E1375_FileDestinazioneCopiato,
            E1376_FileDestinazioneNonCancellato,
            E1377_FileDestinazioneCancellato,

            // Errori relativi a file Archivio
            // =======================
            E1380_FileArchivioNonEsiste,
            E1381_FileArchivioEsiste,
            E1382_FileArchivioNonSpostato,
            E1383_FileArchivioSpostato,
            E1384_FileArchivioNonCopiato,
            E1385_FileArchivioCopiato,
            E1386_FileArchivioNonCancellato,
            E1387_FileArchivioCancellato,
            E1388_FileArchivioNonCreato,

            //E1360_IstruzioneErrata,
            //E1360_IstruzioneSconosciuta,

            //E1370_IdentitaOK,
            //E1371_IdentitaNOK,
            //E1372_IdentitaEsiste,
            //E1373_IdentitaNonEsiste,
            //E1374_IdentitaGenitore,
            //E1375_IdentitaParente,


            //E1310_PathArchivioNonEsiste,
            //E1310_PathAreaArchivioNonEsiste,
            //E1310_PathEscursioneNonEsiste,
            //E1310_PathTracciaNonEsiste,


            //E1301_CreazioneDirectoryFallita,
            //E1302_CreazioneArchivioFallita,

            //E1303_PathAreaArchivioErrata,
            //E1304_PathArchivioEscursioneErrato,
            //E1305_PathArchivioTracciaErrato,
            //E1306_ArchivioEsiste,



            //E1324_EscursionePresente,

            // Errori relativi a immagini
            // ==========================
            E1400_ImmagineEsiste,
            E1401_ImmagineNonEsiste,
            E1402_TipoImmagineNonGestita,
            E1403_NonRiesceACancellareImmagineAppoggio,
            E1404_NonRiesceAAggiornareImmagineAppoggio,
            E1405_ProblemiNellaConversioneDellaImmagine,

            // Errori relativi a filmati
            // ==========================
            E1500_FilmEsiste,
            E1501_FilmNonEsiste,
            E1502_TipoFilmNonGestita,
            E1503_VlcExeNonInstallato,

            // Errori relativi ad un tipo di dato
            //10 sbyte System.SByte
            //20 byte System.Byte
            //30 short System.Int16
            //40 ushort System.UInt16
            //50 int System.Int32
            //60 uint System.UInt32
            //70 long System.Int64
            //80 ulong System.UInt64
            //90 char System.Char
            //100 float System.Single

            E2100_double_LaStringaNonContieneUnValoreDouble,
            // 110 bool System.Boolean
            // 120 decimal System.Decimal


        }



        /// <summary>
        /// Costruttore
        /// </summary>
        //public GstErrori()
        //{

        //}
        /// <summary>
        /// Esamina una stringa e sostituisce:
        /// - La lettera maiuscola con spazio + lettera maiuscola
        /// - il cratttere '_' con spazio
        /// </summary>
        /// <param name="error"></param>
        /// <returns></returns>
        public static string RestultToSting(EErrore error)
        {
            string errore = error.ToString();
            string messaggioErrore = "";

            // sostituisci tutte le lettere maiuscole con spazio-lettera
            bool maiuscola = true;
            for (int i = 0; i < errore.Length; i++)
            {

                if (Char.IsUpper(errore[i]) && i > 0)
                {
                    messaggioErrore += " ";
                    if (maiuscola)
                    {
                        messaggioErrore += errore[i];
                        maiuscola = false;
                    }
                    else
                        messaggioErrore += Char.ToLower(errore[i]);
                }
                else if (errore[i] == '_')
                {
                    messaggioErrore += ":";
                    messaggioErrore += " ";
                    maiuscola = true;
                }
                else
                    messaggioErrore += errore[i];
            }

            return messaggioErrore;
        }
        /// <summary>
        /// Stampa un messaggio di errore
        /// </summary>
        /// <param name="result"></param>
        /// <param name="messaggio2"></param>
        /// <param name="stampaMessaggio"></param>
        /// <returns></returns>
        public static bool StampaMessaggioErrore(GstErrori.EErrore esito, string messaggio2 = "", bool stampaMessaggio = true, bool continuo = true)
        {
            // controlla l'esito del risultatao
            if (esito != EErrore.E0000_OK)
            {
                if (stampaMessaggio)
                {
                    // compone il messaggio da stampare
                    string titolo = "Errore!";
                    string messaggio = "Problema: \n" + messaggio2 + "\n\n" +
                                       "ha generato l'errore: \n\n" +
                                       RestultToSting(esito);

                    // Chiede la conferma per continuare                    
                    if (continuo)
                    {
                        messaggio += "\n\n" + "Continuo?";

                        //  stampa il messaggio con l'esito
                        var result3 = MessageBox.Show(messaggio, titolo, MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result3 == DialogResult.Yes)
                            return true;
                        else
                            return false;
                    }

                    // Rende sempre FALSE
                    if (!continuo)
                    {
                        //  stampa il messaggio con l'esito
                        var result3 = MessageBox.Show(messaggio, titolo, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    return false;
                }
                else
                    return false;
            }

            return true;
        }
        public static bool TestoMessaggioErrore(GstErrori.EErrore esito, string messaggio2, out string messaggio, out string titolo)
        {
            messaggio = "";
            titolo = "";

            // controlla l'esito del risultatao
            if (esito != EErrore.E0000_OK)
            {
                if (true)
                {
                    // compone il messaggio da stampare
                    titolo = "Errore!";
                    messaggio = "Problema: \n" + messaggio2 + "\n\n" +
                                "ha generato l'errore: \n\n" +
                                     RestultToSting(esito);
                }
            }

            return true;
        }
        /// <summary>
        /// Stampa un avviso
        /// </summary>
        /// <param name="esito"></param>
        /// <param name="messaggio2"></param>
        /// <param name="stampaMessaggio"></param>
        /// <param name="continuo"></param>
        /// <returns></returns>
        public static bool StampaMessaggioAvviso(GstErrori.EErrore esito, string messaggio2 = "", bool stampaMessaggio = true, bool continuo = true)
        {
            // controlla l'esito del risultatao
            if (esito != EErrore.E0000_OK)
            {
                if (stampaMessaggio)
                {
                    // compone il messaggio da stampare
                    string titolo = "Attenzione";
                    string messaggio = "Problema: \n" + messaggio2 + "\n\n" +
                                       "ha generato l'avviso: \n\n" +
                                       RestultToSting(esito);

                    // Chiede la conferma per continuare                    
                    if (continuo)
                    {
                        messaggio += "\n\n" + "Continuo?";

                        //  stampa il messaggio con l'esito
                        var result3 = MessageBox.Show(messaggio, titolo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result3 == DialogResult.Yes)
                            return true;
                        else
                            return false;
                    }

                    // Rende sempre FALSE
                    if (!continuo)
                    {
                        //  stampa il messaggio con l'esito
                        var result3 = MessageBox.Show(messaggio, titolo, MessageBoxButtons.OK, MessageBoxIcon.Question);
                        return false;
                    }

                    return false;
                }
                else
                    return false;
            }

            return true;
        }
    }
}

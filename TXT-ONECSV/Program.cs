using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UglyToad.PdfPig;
using UglyToad.PdfPig.Content;

namespace TXT_CSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string percorsoCartellaInput = "C:\\Users\\qiupa\\Downloads\\rfreedommobilitybridge";//Inserisco il percorso della cartella
            string percorsoCartellaTxt = "P:\\TXTConvertito";//Inserisco il percorso della cartella convertita in TXT
            string percorsoFileCsvUnico = "P:\\CSVConvertito\\FileCSV.csv"; // Percorso del file CSV unico
            if (!Directory.Exists(percorsoCartellaInput))//Verifica esistenza della cartella di input
            {
                Console.WriteLine("Cartella input insesistente cosa stai facendo");
                return;
            }
            if (!Directory.Exists(percorsoCartellaTxt))
            {
                Directory.CreateDirectory(percorsoCartellaTxt);//Creo la cartella di output TXT se non esiste
            }
            string percorsoCartellaCsv = Path.GetDirectoryName(percorsoFileCsvUnico);//Creare la cartella di output per il CSV unico, se non esiste
            if (!Directory.Exists(percorsoCartellaCsv))
            {
                Directory.CreateDirectory(percorsoCartellaCsv);
            }
            if (File.Exists(percorsoFileCsvUnico))//Cancello il contenuto precedente del file CSV unico se esiste
            {
                File.Delete(percorsoFileCsvUnico);
            }
            ConvertiPdfInCartella(percorsoCartellaInput, percorsoCartellaTxt, percorsoFileCsvUnico);//Passo il metodo e avviene la conversione dei PDF nella cartella principale
            Console.WriteLine("Si godeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
            Console.ReadLine();
        }
        static void ConvertiPdfInCartella(string percorsoCartellaInput, string percorsoCartellaTxt, string percorsoFileCsvUnico)
        {
            string[] filePdf = Directory.GetFiles(percorsoCartellaInput, "*.pdf");//Ottengo tramite un'array tutti i file PDF nella cartella specificata
            foreach (string x in filePdf)//Con un foreach scorro intero array 
            {
                string percorsoFileTxtOutput = Path.Combine(percorsoCartellaTxt, Path.GetFileNameWithoutExtension(x) + ".txt");//Determino il nome del file di output TXT uguale come quello del pdf
                ConvertiPdfInTxt(x, percorsoFileTxtOutput);//Passo il metodo converto il pdf in txt
                ConvertiTxtInCsvConLimiti(percorsoFileTxtOutput, percorsoFileCsvUnico);//Converti il TXT in CSV unico con limitazioni specifiche
                Console.WriteLine($"Congratulazioni il file è stato convertito in TXT e aggiunto al CSV unico: {percorsoFileCsvUnico}");
            }
            string[] sottocartelle = Directory.GetDirectories(percorsoCartellaInput);//Recupero con la creazione di un'altra cartella tutte le sottocartelle presenti nella cartella principale
            foreach (string o in sottocartelle)//Converto i pdf della sottocartella scorrendo inero array con un foreach
            {
                ConvertiPdfInCartella(o, percorsoCartellaTxt, percorsoFileCsvUnico);
            }

        }
        static void ConvertiPdfInTxt(string percorsoFilePdf, string percorsoFileTxtOutput)//Metodo converto pdf in txt la vera eseguzione avviene qui
        {
            try
            {
                using (PdfDocument documentoPdf = PdfDocument.Open(percorsoFilePdf))//Uso la classe PDFDocumnet e la funzione open per aprire il documento pdf
                {
                    using (StreamWriter writer = new StreamWriter(percorsoFileTxtOutput))//Uso streamWriter per scrivere nel file txt
                    {
                        foreach (Page pagina in documentoPdf.GetPages())//Scorro ogni pagina del pdf con un foreach
                        {
                            List<(double x, double y, string testo)> paroleConCoordinate = new List<(double x, double y, string testo)>();//Creo una lista per memorizzare parole e le coordinate
                            foreach (var parola in pagina.GetWords())//Ottengo scorrendo con un foreach tutte le parole e le coordinate
                            {
                                paroleConCoordinate.Add((parola.BoundingBox.BottomLeft.X, parola.BoundingBox.BottomLeft.Y, parola.Text));//Aggiunge le parole e le loro coordinate
                            }
                            paroleConCoordinate.Sort((a, b) =>//Ordino le parole con la funzione Sort per x e y
                            {
                                int risultato = b.y.CompareTo(a.y);//Confronto la posizione
                                if (risultato == 0)
                                {
                                    risultato = a.x.CompareTo(b.x);//Se y è uguale confronto la posizione x
                                }
                                return risultato;
                            });
                            double posizioneYCorrente = -1;
                            foreach (var parola in paroleConCoordinate)
                            {
                                if (posizioneYCorrente != parola.y)//Verifico se la riga x o y sono cambiate
                                {
                                    writer.WriteLine();//Inizio a scrivere una nuova riga nel file txt
                                    posizioneYCorrente = parola.y;//Aggiorno la posizione del y
                                }
                                writer.Write(parola.testo + " ");//Scrivo le parole nel txt
                            }
                            writer.WriteLine();
                            writer.WriteLine("------------------------------------------------------------------------------------------------");//Stampo una riga vuota per separare la pagina
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante la conversione del file PDF '{percorsoFilePdf}': {ex.Message}");

            }
        }
        static void ConvertiTxtInCsvConLimiti(string percorsoFileTxtInput, string percorsoFileCsvUnico)
        {
            try
            {
                using (StreamReader reader = new StreamReader(percorsoFileTxtInput))
                {
                    using (StreamWriter writer = new StreamWriter(percorsoFileCsvUnico, append: true)) // Apre il CSV unico in modalità append
                    {
                        string linea;
                        int numeroRiga = 0;
                        List<string> paroleTotali = new List<string>();//Creo una lista per raccogliere tutte le parole
                        while ((linea = reader.ReadLine()) != null)
                        {
                            if (numeroRiga >= 19)//Limite di 19 righe
                            {
                                break;
                            }
                            string[] parole = linea.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                            string[] paroleLimitate = parole.Take(50).ToArray(); // Limite di 50 parole per riga
                            paroleTotali.AddRange(paroleLimitate); // Aggiunge le parole alla lista totale
                            numeroRiga++;
                        }
                        string lineaCsv = $"{Path.GetFileName(percorsoFileTxtInput)},{string.Join(",", paroleTotali)}";//Unisco tutte le parole raccolte in una singola riga CSV
                        writer.WriteLine(lineaCsv);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante la conversione del file TXT in CSV '{percorsoFileTxtInput}': {ex.Message}");//Genera un'eccezione se non viene creata correttamente
            }
        }
    }
}
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
            string percorsoCartellaTxt = "C:\\Users\\qiupa\\Downloads\\TXTConvertito";//Inserisco il percorso della cartella convertita in TXT
            string percorsoCartellaCsv = "C:\\Users\\qiupa\\Downloads\\CSVConvertito";//Inserisco il percorso della cartella convertita in CSV
            if (!Directory.Exists(percorsoCartellaInput))//Verifica esistenza della cartella di input
            {
                Console.WriteLine("Cartella output insesistente cosa stai facendo");
                return;
            }
            if (!Directory.Exists(percorsoCartellaTxt))
            {
                Directory.CreateDirectory(percorsoCartellaTxt);//Creo la cartella di output TXT se non esiste
            }
            if (!Directory.Exists(percorsoCartellaCsv))
            {
                Directory.CreateDirectory(percorsoCartellaCsv);//Creo la cartella di output CSV se non esiste
            }
            ConvertiPdfInCartella(percorsoCartellaInput, percorsoCartellaTxt, percorsoCartellaCsv);//Passo il metodo e avvien la conversione dei PDF nella cartella principale
            Console.WriteLine("Si godeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee");
            Console.ReadLine();
        }

        static void ConvertiPdfInCartella(string percorsoCartellaInput, string percorsoCartellaTxt, string percorsoCartellaCsv)
        {
            string[] filePdf = Directory.GetFiles(percorsoCartellaInput, "*.pdf");//Ottengo tramite un'array tutti i file PDF nella cartella specificata
            foreach (string x in filePdf)//Con un foreach scorro intero array
            {
                string percorsoFileTxtOutput = Path.Combine(percorsoCartellaTxt, Path.GetFileNameWithoutExtension(x) + ".txt");//Determino il nome del file di output TXT uguale come quello del pdf
                string percorsoFileCsvOutput = Path.Combine(percorsoCartellaCsv, Path.GetFileNameWithoutExtension(x) + ".csv");//Stessa cosa vale per il csv
                ConvertiPdfInTxt(x, percorsoFileTxtOutput);//Passo il metodo converto il pdf in txt
                ConvertiTxtInCsvConLimiti(percorsoFileTxtOutput, percorsoFileCsvOutput);//Converto alla sua volta txt in csv con limitazioni stabilite

                Console.WriteLine($"Congratulazioni il file è stato convertito in TXT e CSV: {percorsoFileCsvOutput}");
            }
            string[] sottocartelle = Directory.GetDirectories(percorsoCartellaInput);//Recupero con la creazione di un'altra cartella tutte le sottocartelle presenti nella cartella principale
            foreach (string o in sottocartelle)//Converto i pdf della sottocartella scorrendo inero array con un foreach
            {
                ConvertiPdfInCartella(o, percorsoCartellaTxt, percorsoCartellaCsv);
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
                                    writer.WriteLine();//Inizia a scrivere una nuova iga nel file txt
                                    posizioneYCorrente = parola.y;//Aggiorna la posizione del y
                                }
                                writer.Write(parola.testo + " ");//Scrive le parole nel txt
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

        static void ConvertiTxtInCsvConLimiti(string percorsoFileTxtInput, string percorsoFileCsvOutput)
        {
            try
            {
                using (StreamReader reader = new StreamReader(percorsoFileTxtInput))
                {
                    using (StreamWriter writer = new StreamWriter(percorsoFileCsvOutput))
                    {
                        string linea;
                        int numeroRiga = 0;
                        while ((linea = reader.ReadLine()) != null)//Leggo ogni linea del file txt
                        {
                            if (numeroRiga >= 9)//Stabilisco un limite di 9 righe
                            {
                                break;
                            }
                            string[] parole = linea.Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//Con la funzione split elimino e rimuovo le parti che non mi servono
                            string[] paroleLimitate = parole.Take(50).ToArray();//Stabilisco un limite di 50 parole
                            string lineaCsv = string.Join(" ", paroleLimitate);//Unisco le parole con la funzione join in csv e separate da uno spazio per renderlo più pulito
                            writer.WriteLine(lineaCsv);
                            numeroRiga++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore durante la conversione dal file TXT in file CSV {percorsoFileTxtInput} : {ex.Message}");//Genera un eccezione se non viene creata correttamente
            }
        }
        
    }
    
}

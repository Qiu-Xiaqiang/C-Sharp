using System.IO;
using System;
using System.Threading.Tasks;
using System.Xml.Linq;
using Aspose.Pdf;
using Aspose.Pdf.Devices;
using Aspose.Pdf.Text;
using static Aspose.Pdf.SaveOptions;

namespace PdfTotsxt
{
    internal class Program
    {
        static void Main()
        {
            string cartellaPdf = "C:\\Users\\qiupa\\Downloads\\PDFFolder"; // Cartella contenente i file PDF nel percorso del tuo computer
            string cartellaWord = "C:\\Users\\qiupa\\Downloads\\Word"; // Cartella dove salvare i file Word nel percorso del tuo computer
            Conversione(cartellaPdf, cartellaWord);
        }
        static void Conversione(string cartellaPdf, string cartellaWord)
        {
            string[] filePDF = Directory.GetFiles(cartellaPdf, "*.pdf");//Ottengo tutti i file nella cartella iniziale con un array
            try
            {
                if (!Directory.Exists(cartellaWord))
                {
                    Directory.CreateDirectory(cartellaWord);//Creo la cartella di word se utente non lo ha creato
                }
                foreach (string x in filePDF)//Ciclo foreach per scorrere intera cartella pdf contente i file pdf dove ho dichiarato una variabile x
                {
                    try
                    {
                        Document documentoPDF = new Document(x);//Creo un'istanza di Document 
                        DocSaveOptions salvataggio = new DocSaveOptions();
                        salvataggio.Format = DocSaveOptions.DocFormat.DocX;//Salvo in formato DocX
                        string nomeFile = Path.GetFileNameWithoutExtension(x);//Funzione per determinare il percorso di output per il file word
                        string percorsoOutput = Path.Combine(cartellaWord, nomeFile + ".docx");//Funzione combine per dare al nome degli file convertito con lo stesso nome del pdf 
                        Console.WriteLine($"Convertito con successo big congratulazioni :{x,-10}  {percorsoOutput,-10}");
                        documentoPDF.Save(percorsoOutput, salvataggio);//Infine salvo il file in word 
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Errore {x}: {e.Message}");//Genera un'eccezione se il compito non andato a buon fine
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore:" + e.Message);//Stamperà eccezione se non è andato a buon fine
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Aspose.Pdf;

namespace ConversioneSottocartelle
{
    internal class Program
    {
        static void Main()
        {
            string cartellaPrincipale = "C:\\Users\\qiupa\\Downloads\\rfreedommobilitybridge";//Percorso della cartella principale contente pdf
            string cartellaWord = "C:\\Users\\qiupa\\Downloads\\WordConvertito";//Percorso della cartella convertito
            ConversioneConSottocartelle(cartellaPrincipale, cartellaWord);//Passo il metodo Conversione con sotto cartelle dove all'interno di questo metodo trovo anche il metodo Conversione Pdf in Word
        }
        static void ConversioneConSottocartelle(string cartellaPrincipale, string cartellaWord)//Passo due parametri stringhe
        {
            try
            {
                ConvertiPdfInWord(cartellaPrincipale, cartellaWord);//Passo il metodo
                string[] sottocartelle = Directory.GetDirectories(cartellaPrincipale);//Array per prendere le sottocartelle presente nel directory
                foreach (string x in sottocartelle)//Foreach per scorrere intera sottocartella
                {
                    ConversioneConSottocartelle(x, cartellaWord);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: " + e.Message);//Genererà un eccezione 
            }
        }
        static void ConvertiPdfInWord(string cartellaPdf, string cartellaWord)
        {
            string[] filePDF = Directory.GetFiles(cartellaPdf, "*.pdf");//Array per prendere tutti i documenti pdf della cartella principale
            try
            {
                if (!Directory.Exists(cartellaWord))//Verifico esistenza della cartella se non esiste viene creato
                {
                    Directory.CreateDirectory(cartellaWord);//Creo la cartella se non esiste
                }
                foreach (string x in filePDF)//Scorro intera array del filePDF
                {
                    try
                    {
                        Document documentoPDF = new Document(x);//Creo un variabile di tipo Document
                        DocSaveOptions salvataggio = new DocSaveOptions();
                        salvataggio.Format = DocSaveOptions.DocFormat.DocX;//Salvo in formato doc
                        string nomeFile = Path.GetFileNameWithoutExtension(x);//Prende il nome come estensione della pdf
                        string percorsoOutput = Path.Combine(cartellaWord, nomeFile + ".docx");//Funzione combine in modo di associare lo stesso nome del pdf in word
                        Console.WriteLine($"Convertito con successo: {x} => {percorsoOutput}");
                        documentoPDF.Save(percorsoOutput, salvataggio);//Salvo il documento
                    }
                    catch (Exception e2)
                    {
                        Console.WriteLine("Errore: " + x + " - " + e2.Message);//Altrimenti genera un errore
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: " + e.Message);//Genera un errore
            }
        }
    }
}

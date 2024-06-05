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
            string cartellaPrincipale = "C:\\Users\\qiupa\\Downloads\\rfreedommobilitybridge";
            string cartellaWord = "C:\\Users\\qiupa\\Downloads\\WordConvertito";
            ConversioneConSottocartelle(cartellaPrincipale, cartellaWord);
        }
        static void ConversioneConSottocartelle(string cartellaPrincipale, string cartellaWord)
        {
            try
            {
                ConvertiPdfInWord(cartellaPrincipale, cartellaWord);
                string[] sottocartelle = Directory.GetDirectories(cartellaPrincipale);
                foreach (string sottocartella in sottocartelle)
                {
                    ConversioneConSottocartelle(sottocartella, cartellaWord);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: " + e.Message);
            }
        }
        static void ConvertiPdfInWord(string cartellaPdf, string cartellaWord)
        {
            string[] filePDF = Directory.GetFiles(cartellaPdf, "*.pdf");
            try
            {
                if (!Directory.Exists(cartellaWord))
                {
                    Directory.CreateDirectory(cartellaWord);
                }
                foreach (string x in filePDF)
                {
                    try
                    {
                        Document documentoPDF = new Document(x);
                        DocSaveOptions salvataggio = new DocSaveOptions();
                        salvataggio.Format = DocSaveOptions.DocFormat.DocX;
                        string nomeFile = Path.GetFileNameWithoutExtension(x);
                        string percorsoOutput = Path.Combine(cartellaWord, nomeFile + ".docx");
                        Console.WriteLine($"Convertito con successo: {x} -> {percorsoOutput}");
                        documentoPDF.Save(percorsoOutput, salvataggio);
                    }
                    catch (Exception e2)
                    {
                        Console.WriteLine("Errore: " + x + " - " + e2.Message);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: " + e.Message);
            }
        }
    }
}

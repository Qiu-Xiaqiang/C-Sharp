using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Pdf;
using Aspose.Pdf.Text;

namespace ConversioneInCsv
{
    internal class Program
    {

        static void Main()
        {
            string cartellaPrincipale = "C:\\Users\\qiupa\\Downloads\\rfreedommobilitybridge"; // Percorso della cartella principale contenente pdf
            string cartellaCsv = "C:\\Users\\qiupa\\Downloads\\CsvConvertito"; // Percorso della cartella convertito
            ConversioneConSottocartelle(cartellaPrincipale, cartellaCsv); // Passo il metodo Conversione con sotto cartelle dove all'interno di questo metodo trovo anche il metodo Conversione Pdf in Csv
        }

        static void ConversioneConSottocartelle(string cartellaPrincipale, string cartellaCsv) //Passo due parametri stringhe
        {
            try
            {
                ConvertiPdfInCsv(cartellaPrincipale, cartellaCsv); //Passo il metodo
                string[] sottocartelle = Directory.GetDirectories(cartellaPrincipale); //Array per prendere le sottocartelle presenti nella directory
                foreach (string x in sottocartelle) //Foreach per scorrere intera sottocartella
                {
                    ConversioneConSottocartelle(x, cartellaCsv);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: " + e.Message); //Genererà un'eccezione 
            }
        }

        static void ConvertiPdfInCsv(string cartellaPdf, string cartellaCsv)
        {
            string[] filePDF = Directory.GetFiles(cartellaPdf, "*.pdf"); //Array per prendere tutti i documenti pdf della cartella principale
            try
            {
                if (!Directory.Exists(cartellaCsv)) //Verifico l'esistenza della cartella, se non esiste viene creata
                {
                    Directory.CreateDirectory(cartellaCsv); //Creo la cartella se non esiste
                }
                foreach (string x in filePDF) //Scorro intera array del filePDF
                {
                    try
                    {
                        Document documentoPDF = new Document(x); // Creo una variabile di tipo Document
                        string nomeFile = Path.GetFileNameWithoutExtension(x); // Prende il nome come estensione del pdf
                        string percorsoOutput = Path.Combine(cartellaCsv, nomeFile + ".csv"); // Funzione combine in modo di associare lo stesso nome del pdf in csv

                        using (StreamWriter writer = new StreamWriter(percorsoOutput))
                        {
                            TextFragmentAbsorber textFragmentAbsorber = new TextFragmentAbsorber();//Creo un'istanza di textFragmentAbsorder in modo di metterlo in colonna
                            documentoPDF.Pages.Accept(textFragmentAbsorber);

                            foreach (TextFragment textFragment in textFragmentAbsorber.TextFragments)
                            {
                                writer.WriteLine(textFragment.Text.Replace("\n", ",").Replace("\r", "").Replace(",,", ","));//Con la funzione replace restituisco una nuova stringa corrente dove vengono sostituite con stringhe specificati.
                            }
                        }

                        Console.WriteLine($"Convertito con successo: {x} => {percorsoOutput}");
                    }
                    catch (Exception e2)
                    {
                        Console.WriteLine("Errore: " + x + " - " + e2.Message); // Altrimenti genera un errore
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore: " + e.Message); // Genera un errore
            }
        }
    }
}


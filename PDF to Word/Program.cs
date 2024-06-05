using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Pdf;

namespace pdfToWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string percorsoP = "C:\\Users\\qiupa\\Downloads\\Filepd.pdf";
            string percorsoW = "C:\\Users\\qiupa\\Downloads\\documento.docx";
            try
            {
                Document documentoPDF = new Document(percorsoP);
                DocSaveOptions salvataggio = new DocSaveOptions();//Creo un'istanza di DocSave
                salvataggio.Format = DocSaveOptions.DocFormat.DocX;//Lo imposto come output il formato in DocX
                Console.WriteLine("Convertito con successo");
                documentoPDF.Save(percorsoW, salvataggio);//Alla fine lo salvo in word
            }
            catch (Exception e)
            {
                Console.WriteLine("Errore" + e.Message);
            }

        }
    }
}

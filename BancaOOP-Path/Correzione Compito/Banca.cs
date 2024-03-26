using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Correzione_Compito
{
    internal class Banca
    {
        static int id;
        List<ContoCorrente> contoCorrente;
        string nomeBanca;

        public Banca(string nome)
        {
            contoCorrente = new List<ContoCorrente>();
            nomeBanca = nome;
            id = 0;
        }
        public static int Id
        {
            get { return ++id; } 
        }
        public ContoCorrente AggiungiConto
        {
            set 
            {
                contoCorrente.Add(value);
            }
        }
        public void Prelievo(int id,double soldi)
        {
            if (Esiste(id) != null)
            {
                try
                {

                    Esiste(id).Saldo = soldi;
                    FileLog(Esiste(id), soldi);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            else
            {
                throw new Exception("conto non esiste");
            }
        }
         private ContoCorrente Esiste(int id)
        {
            return contoCorrente.Find(x => x.Id == id);
            
        }
        public List<ContoCorrente> GetList()
        {
            return contoCorrente.ToList();
        }
        public void Aggiungi(ContoCorrente cc)
        {
            contoCorrente.Add(cc);
        }
        private void FileLog(ContoCorrente cc,double Movimento)
        {
            
            StreamWriter sW = File.AppendText(Environment.CurrentDirectory+"\\" + "Log.txt");
            sW.WriteLine(DateTime.Now.ToString() + cc.ToString() +" "+ Movimento);
            sW.Close();
        }


    }
}

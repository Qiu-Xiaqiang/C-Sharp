using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace FrigoDiPaoloooooo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FrigoSmart frigo = new FrigoSmart("Haier", 2500);
            for (int i = 0;i<1;i++)
            {
                Console.WriteLine($"Inserisci gli prodotti del frigo {i + 1}");
                Prodotto aggiungoProdotto = DatiProdotto();
                frigo.Inserimento( aggiungoProdotto );//Aggiungo nello frigo i prodotti 
                
            }
            List<Prodotto> tuttiProdotti = new List<Prodotto>();
            Console.WriteLine("Ecco tutti gli prodotti che hai nello frigo");
            tuttiProdotti=frigo.ElencoProdotti();
            tuttiProdotti.ForEach( p => Console.WriteLine(p.ToString()));

            Console.WriteLine("Prodotti scaduti:");
            tuttiProdotti = frigo.ProdottiScaduti();
            tuttiProdotti.ForEach( s => Console.WriteLine(s.ToString()));

            Console.WriteLine("Quale prodotto cerchi?");
            string descrizione= Console.ReadLine();
            Console.WriteLine(frigo.RimuovoProdotto(descrizione));

            Console.WriteLine("Prodotti del frigo dopo la rimozione");
            tuttiProdotti = frigo.ElencoProdotti();
            tuttiProdotti.ForEach(p => Console.WriteLine(p.ToString()));


           
            Console.ReadLine();
        }
        static Prodotto DatiProdotto()
        {
            Console.WriteLine("Metti la descrizione del prodotto");
            string descrizione = Console.ReadLine();
            Console.WriteLine("Inserisci la data di scadenza del prodotto gg/mm/aaaa");
            DateTime dataProdotto= Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Inserisci la caloria del prodotto");
            double caloria=Convert.ToDouble(Console.ReadLine());
            //Posso fare anche un metodo per raccogliere dati dall'utente con writeline ma solo in questo caso qui
            return new Prodotto(Supermercato.CodiceProgressivo, descrizione,caloria,dataProdotto);
        }
    }
}

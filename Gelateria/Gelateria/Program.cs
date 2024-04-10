using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelateria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Prodotti> lista = new List<Prodotti>();
            Gelateria gelateria = new Gelateria("Via Alcide de Gasperi", "Rovigo");
            gelateria.Inserimento(gelateria);
            gelateria.Visualizzazione();
            lista.Add(new Torta("Pan di spagna", "Medio", 23, "Torta cinese", Torta.Gusto.crema));
            lista.Add(new Gelato("Paolo", "Grande", 88, 6, Gelato.Gusto.anguria));
            lista.Add(new Gelato("Qiu", "Grande", 888, 66, Gelato.Gusto.melone));
            lista.Add(new Gelato("Xia", "Grande", 88, 6, Gelato.Gusto.mango));
            Console.WriteLine("Lista degli prodotti iniziali e con il loro nome");
            lista.ForEach(x => { Console.WriteLine(x.Visualizzazione() + " " + x.GetType().Name); });
            Prodotti rimozione = lista.Find(x => x.Descrizione == "Xia");
            lista.Remove(rimozione);
            Prodotti ricerca = lista.Find(x => x.Costo == 88);
            if (ricerca != null)
            {
                lista.Add(new Gelato("Qiang", "Grande", 8888, 6, Gelato.Gusto.pistacchio));
            }
            else
            {
                Console.WriteLine("Prodotto inesistente");
            }
            Prodotti ricerca2 = lista.Find(x => x.Dimensione == "Piccolo");
            if (ricerca2 == null) { Console.WriteLine("Non c'è niente"); }
            Console.WriteLine("Lista dopo una rimozione e ricerca del prodotto");
            lista.ForEach(x => { Console.WriteLine(x.Visualizzazione()); });
            lista.ForEach(x => { if (x is Gelato) { Console.WriteLine(((Gelato)x).Go("Ciao")); } });
            lista.ForEach(x => { if (x as Torta != null) { Console.WriteLine(((Torta)x).Go("GoodBye")); } });

            Console.ReadLine();

        }
    }
}

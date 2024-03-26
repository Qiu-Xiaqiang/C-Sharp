using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lezione_3
{
    internal class Fioreria
    {
        string _nomeFioreria;
        string _indirizzo;
        List<Fiore> listaDiFiori;//Dichiarare una lista
        public Fioreria(string nomeFioreria, string indirizzo)
        {
            _nomeFioreria = nomeFioreria;
            _indirizzo = indirizzo;
            listaDiFiori = new List<Fiore>();//Qua stiamo creando il vero e proprio lista
        }
        public string NomeFioreria
        {
            get { return _nomeFioreria; }
        }
        public string Indirizzo
        {
            get { return _indirizzo; }
            set { _indirizzo = value; } //Con set posso modificare il valore iniziare stabilito
        }
        public void Inserimento(Fiore fior)
        {
            listaDiFiori.Add(fior);
        }
        public void VisualizzaLista()
        {
            ////Possibilità 1
            //for(int i=0;i<listaDiFiori.Count;i++)
            //{
            //    Console.WriteLine("Visaulizzazione con for");
            //    Console.WriteLine("{0},{1}", listaDiFiori[i].Nome, listaDiFiori[i].Prezzo);
            //}
            ////Possibilità 2
            //foreach(Fiore fior in listaDiFiori)
            //{
            //    Console.WriteLine("Visaulizzazione con foreach");
            //    Console.WriteLine("{0},{1}",fior.Nome, fior.Prezzo);
            //}
            ////Possibilità superrrrrrrrrrrrrrrrrrr
            //Console.WriteLine("Visaulizzazione con lambda");
            //listaDiFiori.ForEach(p => { Console.WriteLine("{0},{1}",p.Nome, p.Prezzo); });
            //Ovveride con la stringa
            Console.WriteLine("Visaulizzazione con ovveride");
            listaDiFiori.ForEach(a => { Console.WriteLine(a.ToString()); });//Facilito grazie a ovveride
        }
        public bool Ricerca(string nome)
        {
            bool trovato = false;
            listaDiFiori.ForEach(o => { if (o.Nome == nome) trovato = true; });
            return trovato;
        }
        public bool RicercaPrezzo(double prezzo)
        {
            bool trovato = false;
            listaDiFiori.ForEach(l => { if (l.Prezzo == prezzo) trovato = true; });
            return trovato;
        }
        public double Confronta(string nome)
        {
            double prezzo=0;
            listaDiFiori.ForEach(q => { if (q.Nome == nome) prezzo = q.Prezzo; }) ;
            return prezzo;
        }
        public Fiore TrovaFiore(string nome)
        {
            Fiore Flower = new Fiore();
            Flower = null;
            listaDiFiori.ForEach(o => { if (o.Nome == nome) o = Flower; });
            return Flower;

        }

    }
}

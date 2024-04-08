using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigoDiPaoloooooo
{
    internal class FrigoSmart
    {
        string _marca;
        int _potenza;
        List<Prodotto> listaProdotti;//Dichiarazione della lista di prodotti nella classe più generale per memorizzare gli prodotti
        public FrigoSmart(string marca, int potenza)
        {
            _marca = marca;
            _potenza = potenza;
            listaProdotti = new List<Prodotto>();//In questo punto arriva la vera e propria creazione della lista
        }
        public string Marca
        {
            get { return _marca; }
        }
        public int Potenza
        {
            get { return _potenza; }
            set { _potenza = value; }
        }
        public bool Inserimento(Prodotto prodottiDaIns)//Metto bool per vedere se gli prodotti sono inseriti correttamente o no
        //Ritornando un false o true
        {
            if(prodottiDaIns.DataScadenza >= DateTime.Now)//Inserisco il prodotto solo se la data di scadenza
            //é più avanti di Datetime.Now cioè di adesso
            {
                listaProdotti.Add(prodottiDaIns);//Ritorna true se viene inserito correttamente
                return true;
            }
            else
            {
                return false;//Altrimenti ritorna false
            }
        }
        public bool RimuovoProdotto(string descrizione)
        {
            //Funzione FindIndex che mi va a scorrere intera lista ritornando un valore int tarmite la descrizione
            int indice = listaProdotti.FindIndex(x=>x.Descrizione == descrizione);
            //Posso fare anche  int indice = listaProdotti.FindIndex(x=>x.Caloria == caloria);
            if(indice >= 0)
            {
                listaProdotti.RemoveAt(indice);//Mi rimuove il prodotto che hoo trovato per indice 
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool PresenzaProdotto(string descrizione)
        {
           return (listaProdotti.FindIndex(x => x.Descrizione == descrizione) >= 0);
           //Ritornerà indice/posizione del prodotto nella lista che sta 
           //Se non trova un prodotto mi ritorna -1 e non ritorna mai true e false con FindIndex
        }
        public List<Prodotto> ElencoProdotti()
        {
            //listaProdotti.ForEach(x => { Console.WriteLine(x.ToString()); });
            return listaProdotti.ToList();//Ritorna una copia della lista - basta fare questo mi va bene
        }
        public List<Prodotto>ProdottiScaduti()
        {
            List<Prodotto> prodottiScaduti = new List<Prodotto>();
            foreach(Prodotto prodottiOriginali in listaProdotti)
            {
                if(prodottiOriginali.DataScadenza<DateTime.Now)
                {
                    prodottiScaduti.Add(prodottiOriginali);
                }
            }
            return prodottiScaduti;
        }
    }
}

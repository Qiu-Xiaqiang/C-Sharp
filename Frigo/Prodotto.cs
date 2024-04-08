using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrigoDiPaoloooooo
{
    internal class Prodotto
    {
        //Questi sono attributi del prodotto
        int _codice;
        string _descrizione;
        double _calorie;
        DateTime _dataScadenza;
        public override string ToString()//Metodo override per la stampa in forma tabellare
        {
            return String.Format($"Codice:{_codice,-15}Descrizione:{_descrizione,-15}Calorie:{_calorie,-15}Data di scadenza:{_dataScadenza.ToShortDateString(),-15}");
        }
        public Prodotto(int codice, string descrizione, double calorie, DateTime dataScadenza)//Costruttore
        {
            _codice = codice;
            _descrizione = descrizione;
            _calorie = calorie;
            _dataScadenza = dataScadenza;
        }
        public int Codice//Proprietà del codice
        {
            get { return _codice; }
            //set { _codice = value; }Non serve perchè il codice non cambia
        }
        public string Descrizione//Proprietà 
        { 
            get { return _descrizione;} //Non serve set neanche qui
        }
        public double Calorie//Proprietà
        {
            get { return _calorie; }//Anche la caloria non cambia quindi non serve il set
        }
        public DateTime DataScadenza//Proprietà
        {
            get { return _dataScadenza;}
        }
    }
}

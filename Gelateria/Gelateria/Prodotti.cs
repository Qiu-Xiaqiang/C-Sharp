using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gelateria
{
    internal abstract class Prodotti
    {
        protected string _dimensione;
        protected double _costo;
        protected string _descrizione;
        protected  Prodotti(string descrizione,string dimensione,double costo)
        {
            _descrizione = descrizione;
            _dimensione = dimensione;
            _costo = costo;
        }
        public string Dimensione
        { get { return _dimensione; } }
        public string Descrizione
        { get { return _descrizione;} }
        public double Costo
        { get { return _costo; } set { _costo = value; } }
        public abstract string Visualizzazione();

    }
}

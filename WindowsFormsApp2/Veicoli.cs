using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal abstract class Veicoli
    {
        protected string _marca;
        protected string _modello;
        protected double _kmPercorsi;
        protected double _CostoKm;
        protected Veicoli(string marca, string modello, double kmPercorsi, double costoKm)
        {
            _marca = marca;
            _modello = modello;
            _kmPercorsi = kmPercorsi;
            _CostoKm = costoKm;
        }
        static public  bool operator == (Veicoli v1, Veicoli v2)
        {
            return string.Equals(v1._marca, v2._marca) && string.Equals(v1._modello, v2._modello);
        }
        static public bool operator != (Veicoli v1,Veicoli v2)
        {
            return !(v1 == v2);
        }
        public abstract string Stampa();
        public abstract string Rimozione();

    }
}

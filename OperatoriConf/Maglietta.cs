using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMetodi
{
    internal class Maglietta:Vestito
    {
        double prezzo;
        public Maglietta(double prezzo, string colore, string materiale):base(colore, materiale)
        {
            Prezzo = prezzo;
        }
        public double Prezzo { get => prezzo; set => prezzo = value; }
        new public void MetodoQualsiasi()
        {
            base.MetodoQualsiasi();
            Console.WriteLine("Sono il metodo qualsiasi di Maglietta, il mio prezzo è: {0} ", prezzo);
        }
        static public bool operator == (Maglietta m1, Maglietta m2)
        {
            //return (String.Compare(m1.Colore, m2.Colore) == 0 && String.Compare(m1.Materiale,m2.Materiale) == 0);
            return String.Equals(m1.Colore, m2.Colore) && String.Equals(m1.Materiale, m2.Materiale);
        }
        static public bool operator !=(Maglietta m1, Maglietta m2)
        {
            return !(m1==m2);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMetodi
{
    internal class Vestito
    {
        string colore;
        string _materiale;
        public Vestito(string colore, string materiale)
        {
            Colore = colore;
            _materiale = materiale;
        }
        public string Colore { get => colore; private set => colore = value; }
        public string Materiale { get => _materiale;}
        public void MetodoQualsiasi()
        {
            Console.WriteLine("Sono il metodo qualsiasi di Vestito, il mio colore è: {0}, il mio materiale è:  {1}",colore, Materiale);
        }
    }
}

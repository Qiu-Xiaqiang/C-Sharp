using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Lezione_3
{
    internal class Fiore
    {
        string _nome;
        double _prezzo;
        public Fiore(string nome)
        {
            _nome = nome;
        }
        public Fiore()
        {

        }
       public double Prezzo
        {
            get { return _prezzo; }
            set { _prezzo = value; }
        }
        public string Nome
        { 
            get { return _nome; } 
        }
        public override string ToString()
        {
           return String.Format($"Nome del fiore{Nome,-10} -- e prezzo del fiore{Prezzo,-10}");
        }

    }
}

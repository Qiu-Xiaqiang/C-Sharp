using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaleScuola
{
    internal class Impiegato : Dipedente
    {
        string _ufficio;
        public Impiegato(string ufficio,string nominativo,string genere,string indirizzo): base(nominativo,genere,indirizzo)
        {
            _ufficio = ufficio;
        }
        public string Ufficio
        { get { return _ufficio; } private set { _ufficio = value; } }
        public override string ToString()
        {
            return String.Format($"Nominativo:{_nominativo,-15}Genere:{_genere,-15}Indirizzo{_indirizzo,-15}{_ufficio,-15}");
        }
    }
}

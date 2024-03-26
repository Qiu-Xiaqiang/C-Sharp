using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace PersonaleScuola
{
    internal class Dipedente
    {
        protected string _nominativo;
        protected string _genere;
        protected string _indirizzo;
        public Dipedente(string nominativo, string genere, string indirizzo)
        {
            _nominativo = nominativo;
            _genere = genere;
            _indirizzo = indirizzo;
        }
        public Dipedente()
        {

        }
        public string Nominativo
        {
            get { return _nominativo; }
        }
        public string Genere
        { get { return _genere; } }
        public string Indirizzo
        { get { return _indirizzo; } set { _indirizzo = value; } }
        public override string ToString()
        {
            return String.Format($"Nominativo:{_nominativo,-15}Genere:{_genere,-15}Indirizzo{_indirizzo,-15}");
        }
    }
}

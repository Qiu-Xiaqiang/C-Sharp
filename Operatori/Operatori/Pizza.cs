using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori
{
    internal class Pizza
    {
        protected string _nome;
        protected string _dimensione;
        public Pizza (string nome, string dimensione)
        {
            _nome = nome;
            _dimensione = dimensione;
        }
        public string Nome
        { get { return _nome; } }
        public string Dimensione { get { return _dimensione;} }
        public virtual string Visualizza()
        {
            return String.Format($"Nome:{_nome,10}Dimensione{_dimensione,10}");
        }
        static public bool operator ==(Pizza p1, Pizza p2)
        {
            return string.Equals(p1.Nome, p2.Nome) && string.Equals(p1.Dimensione, p2.Dimensione);
        }
        static public bool operator !=(Pizza p1, Pizza p2)
        {
            return !(p1 == p2);
        }

    }
}

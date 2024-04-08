using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripasso
{
    internal class Pizzeria : Cibo
    {
        protected string _via;
        protected string _luogo;
        public Pizzeria(string via, string luogo,string origine,string gusto) : base (origine,gusto)
        {
            _via = via;
            _luogo = luogo;
        }
        public string Via
        {
            get { return _via; }
            set { _via = value; }
        }
        public string Luogo
        {
            get { return _luogo; }
            set { _luogo = value; }
        }

        public override string Visualizzazione()
        {
            return string.Format($"Pizzeria più buono del mondo => Origine:{_origine,-5}Gusto:{_gusto,-5}Via:{_via,-5}Luogo:{_luogo,-5}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ripasso
{
    abstract internal class Cibo 
    {
        protected string _gusto;
        protected string _origine;
        protected Cibo(string gusto, string origine)
        {
            _gusto = gusto;
            _origine = origine;
        }   
        protected string Gusto
        {
            get { return _gusto; }
            set { _gusto = value; }
        }
        protected string Origine
        {
            get { return _origine; }
            set { _origine = value; }
        }
        public abstract string Visualizzazione();

        
    }
}

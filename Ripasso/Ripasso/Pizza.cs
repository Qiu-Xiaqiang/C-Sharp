using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ripasso
{
    internal class Pizza : Pizzeria
    {
        string _tipo;
        double _costo;
        public Pizza (string tipo, double costo,string origine,string gusto,string via,string luogo):base (via,gusto,luogo,origine)
        {
            _tipo = tipo;
            _costo = costo; 
        }
        public string Tipo
        {
            get { return _tipo; }
        }
        public double Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }
        public override string Visualizzazione()
        {
            return string.Format($"{base.Visualizzazione()}+Tipo:{_tipo,-5}Costo:{_costo,-5}");
        }

    }
}

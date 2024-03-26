using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoNave
{
    internal class NaveMercantile : Nave
    {
        static double _costoCaricoMerce = 0.20;
        double _caricoPagante;

        public NaveMercantile(string nome, double miglia, double caricoPagante) : base(nome, miglia)
        {
            _caricoPagante = caricoPagante;
        }

        override public double CostoViaggio() // il new non serve più, perché il CostoViaggio della classe base è virutale. Serve override per sobrascrivere
        {
            return _costoCaricoMerce * _caricoPagante + base.CostoViaggio(); //costo nave + costo merce = costo nave mercantile
        }
    }
}

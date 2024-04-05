using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAstrattaIntroduzione
{
    internal class NaveDaBattaglia : Nave
    {
        double _potenzaSparoDistanza = 20000;
        double _costoNave;
        public NaveDaBattaglia(string nome,double miglia,double costoNave) : base(nome, miglia)
        {
            _costoNave= costoNave;
        }
        public override double CostoViaggio()
        {
            return (_costoNave * _potenzaSparoDistanza) + base.CostoViaggio();
        }
    }
}

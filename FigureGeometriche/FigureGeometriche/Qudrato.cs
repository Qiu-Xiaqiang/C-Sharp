using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Qudrato : Figure
    {
        double _lato;
        public Qudrato(double lato )
        {
            _lato = lato;
        }
        public double lato
        {
            get { return _lato; }
            set { _lato = value; }
        }
        public double Altezza
        {
            get;
        }
        public double Perimetro()
        {
            return _lato * 4;
        }
        public double Area()
        {
            return _lato * _lato;
        }
        public override string ToString()
        {
            return string.Format($"Quadrato:- Lato:{_lato,-10} Area:{Area(),-10} Perimetro:{Perimetro(),-10}");
        }

    }
}

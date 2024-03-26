using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Cerchio : Figure
    {
        double _raggio;
        public Cerchio(double raggio) 
        {
            _raggio = raggio;
        }
        public double lato
        {
            get;
        }
        public double Altezza
        {
            get;
        }
        public double Raggio
        {
            get { return _raggio; }
            set { _raggio = value; }
        }
        public double Perimetro()
        {
            return (_raggio * 2) * 3.14;
        }
        public double Area()
        {
            return (_raggio * _raggio) * 3.14;
        }
        public override string ToString()
        {
            return string.Format($"Cerchio:- Raggio:{_raggio,-10} Area:{Area(),-10} Perimetro:{Perimetro(),-10}");
        }
    }
}

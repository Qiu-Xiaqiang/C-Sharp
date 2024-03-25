using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Rettangolo : Figure
    {
        protected double _Base;
        protected double _altezza;
        public Rettangolo(double Base, double altezza)
        {
            _Base = Base;
            _altezza = altezza;
        }
        public double Base
        { get { return _Base; } set { _Base = value; } }
        public double Altezza
        { get { return _altezza;} }
        virtual public double Area()//Metodo polimorfico che usa virtual che dopo io lo implemnto nella classe parallelopipedo utilizzando override
        {
            return _altezza*_Base;
        }
        public double Perimetro()
        {
            return (_Base*2+_altezza*2);
        }
        public override string ToString()
        {
            return string.Format($"Rettangolo-: Base:{_Base,-10}Altezza:{_altezza,-10}Area:{Area(),-10}Perimetro:{Perimetro(),-10}");
        }

    }
}

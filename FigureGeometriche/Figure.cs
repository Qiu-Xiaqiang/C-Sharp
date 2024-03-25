using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal interface Figure
    {
        double Base { get; }
        double Altezza { get; }
        double Area();
        double Perimetro();

    }
}

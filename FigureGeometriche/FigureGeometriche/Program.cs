using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace FigureGeometriche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Figure> listaFigure = new List<Figure>();
            listaFigure.Add(new Qudrato(4));
            listaFigure.Add(new Rettangolo(9,3));
            listaFigure.Add(new Parallelopipedo(7, 4, 2));
            listaFigure.Add(new Cerchio(3));
            listaFigure.ForEach(x=> { Console.WriteLine(x.ToString()); });
            Console.ReadLine();
        }
    }
}

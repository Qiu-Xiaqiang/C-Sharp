using ClasseAstratta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoBase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ClasseBase> listaNumeri= new List<ClasseBase>();
            listaNumeri.Add(new ClasseBase(2));
            listaNumeri.Add(new ClasseEredita1(8, 3));
            listaNumeri.Add(new ClasseEredita1(9,3));
            listaNumeri.Add(new ClasseEreditata2(88, 188));
            listaNumeri.Add(new ClassEreditataDa1(99, 88, 128));
            listaNumeri.ForEach(x => { Console.WriteLine(x.Visualizza() + "" + x.GetType().Name); }) ;
            //Stamperà tre volte perchè anche la classe ereditata da 1 fa parte della classe ereditata 1
            listaNumeri.ForEach(x => { if (x is ClasseEredita1) Console.WriteLine("Sono la classe Ereditata 1"); });
            Console.ReadLine();
        }
    }
}

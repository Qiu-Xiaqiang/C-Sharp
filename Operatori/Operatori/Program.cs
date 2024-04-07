
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatori
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> list = new List<Pizza>();
            Pizza pizza = new Pizza("Diavola", "Grande");
            Pizza pizza2 = new Pizza("Capricciosa", "Piccola");
            PizzaDiavola diavola = new PizzaDiavola("Salamino", "Diavola", "Grande");
            PizzaDiavola diavola1 = new PizzaDiavola("Salamino", "Diavola", "piccola");
            if(diavola1==diavola)
            {
                Console.WriteLine("Siamo pizze uguali");
            }
            else
            {
                Console.WriteLine("Non siamo pizze uguali");
            }

            list.Add(pizza);
            list.Add(diavola1);
            list.Add(diavola);
            list.Add(pizza2);
            list.ForEach(controllo => { if (controllo is PizzaDiavola) { Console.WriteLine("Sono la pizza diavola"); }; });
            //list.ForEach(a => { if (a as Pizza != null) { Console.WriteLine("Sono la pizza"); } });
            list.ForEach(x => { Console.WriteLine(x.Visualizza() + " " + x.GetType().Name); });
            Console.ReadLine();
        }
    }
}

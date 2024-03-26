using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoNave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nave nave1 = new Nave("Nave 1", 30);
            //NaveMercantile naveMerc1 = new NaveMercantile("Nave Mercantile", 20, 100);

            //Console.WriteLine(nave1.CostoViaggio());
            //Console.WriteLine(naveMerc1.CostoViaggio());

            Nave[] flotta = new Nave[3];
            flotta[0] = new Nave("Nave 0", 10);
            flotta[1] = new NaveMercantile("Nave Mercantile 1", 30, 100);
            flotta[2] = new Nave("Nave 2", 75);

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(flotta[i].Nome);
                Console.WriteLine(flotta[i].CostoViaggio()); //metodo polimorfico 
            }
            Console.ReadLine();


            Object oggetto = new Object();
            oggetto.ToString();


        }
    }
}

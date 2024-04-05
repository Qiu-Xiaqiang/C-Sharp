using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PreVerifica
{
    internal class Program
    {

        static void Main(string[] args)
        {
            ////List<ClasseBase> lista = new List<ClasseBase>
            ////{
            ////    new Derivata1(2,3),
            ////    new Derivata2(2,4),
            ////    new Derivata2(2,4),
            ////    new Derivata2(2,4),
            ////    new Derivata2(2,4),
            ////    new Derivata11(2,4,5),
            ////};

            //lista.ForEach(x => Console.WriteLine(x.Stampa() + " " + x.GetType().Name));
            //lista.ForEach(x =>
            //{
            //    if(x is Derivata2)
            //    {
            //        Console.WriteLine(((Derivata2)x).Saluto("saluto"));
            //    }
            //    //if (x as Derivata2 != null)
            //    //{
            //    //    Derivata2 temp = (Derivata2)x;
            //    //    Console.WriteLine(temp.Saluto("mike"));
            //    //}
            //});

            Contenitore cont = new Contenitore();
            List<Object> lista = cont.ReturnList();
            List<ClasseBase> listaUff = new List<ClasseBase>();
            lista.ForEach(x => listaUff.Add((ClasseBase)x));
            listaUff.ForEach(x => Console.WriteLine(x.Stampa() + " " + x.GetType().Name));
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAstrattaIntroduzione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Battello> listaNavi = new List<Battello>();    
            listaNavi.Add(new Nave("Nave cinese",88));
            listaNavi.Add(new NaveDaBattaglia("Nave italiano", 8, 35000));
            listaNavi.Add(new Gommone("ChinaTown", 9));
            listaNavi.ForEach(a => { Console.WriteLine(a.CostoViaggio()+ " "+ listaNavi.GetType().Name); }) ;
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideMetodi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vestito vest1 = new Vestito("Rosso", "Lino");
            Maglietta magl1 = new Maglietta(15.99,"Nero", "Cotone");
            Maglietta magl2 = new Maglietta(15.99, "Blu", "Cotone");
            if(magl1 == magl2)
            {
                Console.WriteLine("Le due magliette sono uguali");
            }
            else
            {
                Console.WriteLine("Le due magliette sono diverse");
            }
            vest1.MetodoQualsiasi();
            magl1.MetodoQualsiasi();
            Console.ReadLine();
        }
    }
}

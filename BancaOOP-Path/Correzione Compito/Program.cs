using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correzione_Compito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banca banca = new Banca("Intesa Sanpaolo");
            banca.Aggiungi(new ContoCorrente(Banca.Id, "Marco", "Hu"));
            banca.Prelievo(1,10);
            banca.Aggiungi(new ContoCorrente(Banca.Id, "Paolo", "Qiu"));
            banca.Aggiungi(new ContoCorrente(Banca.Id, "Grappegia", "Hu"));
            try
            {
                banca.Prelievo(4, -100);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            List<ContoCorrente> copia = banca.GetList();
            copia.ForEach(c => { Console.WriteLine(c.ToString()); });
            Console.ReadLine();
        }
        
    }
}

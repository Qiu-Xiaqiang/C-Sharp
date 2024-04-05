using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreVerifica
{
    internal class Contenitore : InterfaceReturnList
    {
        List<ClasseBase> lista = new List<ClasseBase>
            {
                new Derivata1(2,3),
                new Derivata2(2,4),
                new Derivata2(2,4),
                new Derivata2(2,4),
                new Derivata2(2,4),
                new Derivata11(2,4,5),
            };

        public List<Object> ReturnList()
        {
            List<Object> ret = new List<Object>();
            lista.ForEach(x => ret.Add((Object)x));

            return ret.ToList();
        }
    }
}

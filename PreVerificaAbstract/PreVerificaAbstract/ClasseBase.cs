using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreVerifica
{
    abstract internal class ClasseBase
    {
        int nBase;

        protected ClasseBase(int _nBase)
        {
            nBase = _nBase;
        }

        protected int NBase { get => nBase; set => nBase = value; }
        public abstract string Stampa();
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfismoIntroduzione
{
    internal class Docente : Dipedente
    {
        string _ruolo;
        int _oreInsegnati;
        static double _pagamento = 15;
        public override string ToString()
        {
            return string.Format($"Nominativo{_nominativo,-15}Genere{_genere,-15}Ruolo{_ruolo,-15}Ore Insegnati{_oreInsegnati,-15}");
        }
        public Docente (string nominativo,string genere,string ruolo,int oreInsegnati,int oreLavorati) : base (nominativo,genere,oreLavorati)
        {
            _ruolo = ruolo;
            _oreInsegnati = oreInsegnati;
        }
        public string Ruolo
        {
            get { return _ruolo; }
            set { _ruolo = value; }
        }
        public int OreInsegnati
        {
            get { return _oreInsegnati;}
            set { _oreInsegnati = value;}
        }
        public override double Stipendio()//Nella classe derivata si usa override e si passa con il base davanti della classe piu generare in modo di usare 
        //Il polimorfismo
        {
            return _oreInsegnati *_pagamento + base.Stipendio();
        }

    }
}

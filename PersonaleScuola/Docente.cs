using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaleScuola
{
    internal class Docente : Dipedente
    {
        public enum Ruolo
        {
            supplente,
            insegnante,
            diplomato,
            insegnanteLaureato
        }
        string _disciplina;
        Ruolo _ruolo;
        public Docente(string disciplina, Ruolo ruolo,string nominativo,string genere,string indirizzo): base(nominativo,genere,indirizzo)
        {
            _disciplina = disciplina;
            _ruolo = ruolo;
        }
        public Ruolo ruolo
        { get { return _ruolo; } private set { _ruolo = value; } }
        public string disciplina { get {  return _disciplina; } private set { _disciplina= value; } }
        public override string ToString()
        {
            return String.Format($"Nominativo:{_nominativo,-15}Genere:{_genere,-15}Indirizzo{_indirizzo,-15}Disciplina{_disciplina,-15}Ruolo{_ruolo,-15}");
        }
    }
}

namespace PolimorfismoIntroduzione
{
    internal class Dipedente
    {
        protected string _nominativo;
        protected string _genere;
        protected double _pagamentoOrario = 12;
        protected int _oreLavorati;

        public override string ToString()
        {
            return string.Format($"Nominativo{_nominativo,-15}Genere{_genere,-15}Ore lavorati{_oreLavorati,-15}");
        }
        public Dipedente(string nominativo, string genere,int oreLavorati )
        {
            _nominativo= nominativo;
            _genere= genere;
            _oreLavorati= oreLavorati;
        }
        public string Nominativo
        {
            get { return _nominativo;}
            set { _nominativo = value; }
        }
        public string Genere
        {
            get { return _genere;} 
        }
        public int OreLavorati
        {
            get { return _oreLavorati;}
        }
        virtual public double Stipendio()//La classe piu generare si usa virtual
        {
            return _pagamentoOrario * _oreLavorati;
        }

    }
}

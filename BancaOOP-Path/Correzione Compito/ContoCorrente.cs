using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correzione_Compito
{
    internal class ContoCorrente
    {

        int _id;
        double _saldo;
        string _nome;
        string _cognome;

        public ContoCorrente(int id, string nome, string cognome)
        {
            _saldo = 10;
            _nome = nome;
            _cognome = cognome;
            _id = id;
        }

        public double Saldo
        {
            get { return _saldo; }

            set
            {
                if (_saldo + value < 0)
                {
                    throw new Exception("Soldi insufficienti");
                }
                else
                {
                    
                    _saldo = _saldo + value;
                }

            }
        }
        public int Id
        {
            get { return _id; }
        }
        public override string ToString()
        {
            return string.Format($"ID: {_id} - Nome: {_nome} - Cognome: {_cognome} - Saldo: {Saldo}");
        }

        


    }
}

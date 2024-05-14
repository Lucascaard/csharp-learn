using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassLibrary.Models
{
    public class Corrente : Conta
    {
        public Corrente(string tipo) : base(tipo)
        {
            
        }
        public override void Creditar(double valor)
        {
            Saldo += valor;
        }
    }
}
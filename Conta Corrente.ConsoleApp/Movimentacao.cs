using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta_Corrente.ConsoleApp
{
    internal class Movimentacao
    {
        private decimal valor;
        private string tipo;
        public decimal Valor
        {
            get
            {
                return this.valor;
            }
        }

        public string Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        public Movimentacao(decimal valor, string tipo)
        {
            this.valor = valor;
            this.tipo = tipo;
        }
    }
}

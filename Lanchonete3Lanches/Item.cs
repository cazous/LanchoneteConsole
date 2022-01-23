using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete3Lanches
{
    internal class Item
    {
        private double PrecoVenda;
        private string DataValidade;
        private double Peso;

        public double precoVenda
        {
            get { return PrecoVenda; }
            set { PrecoVenda = value; }
        }
        public string dataValidade
        {
            get { return DataValidade; }
            set { DataValidade = value; }
        }
        public double peso
        {
            get { return Peso; }
            set { Peso = value; }
        }
    }
}

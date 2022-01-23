using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete3Lanches
{
    internal class Salgadinho : Item
    {
        private string Tipo;
        private string Massa;
        private string Recheio;

        public string tipo
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
        public string massa
        {
            get { return Massa; }
            set { Massa = value; }
        }
        public string recheio
        {
            get { return Recheio; }
            set { Recheio = value; }
        }
        public override string ToString()
        {
            return "R$" + precoVenda + "  " + dataValidade + "  " + peso + "g   " + tipo + "  " + massa + "  " + recheio;
        }
        public Salgadinho EscolherSalgadinho()
        {
            precoVenda = 6.99;
            dataValidade = "28/11/2022";
            peso = 150.00; //gramas
            Console.WriteLine("Escolha o tipo do salgado");
            tipo = Console.ReadLine();
            Console.WriteLine("Escolha a massa");
            massa = Console.ReadLine();
            Console.WriteLine("Escolha o recheio");
            recheio = Console.ReadLine();

            return this;
        }
    }
}

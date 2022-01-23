using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete3Lanches
{
    internal class Lanche : Item
    {
        private string TipoDoPao;
        private string Recheio;
        private string Molho;

        public string tipoDoPao
        {
            get { return TipoDoPao; }
            set { TipoDoPao = value;}
        }
        public string recheio
        {
            get { return Recheio; }
            set { Recheio = value; }
        }
        public string molho
        {
            get { return Molho; }
            set { Molho = value; }
        }
        public override string ToString()
        {
            return "R$" + precoVenda + "  " + dataValidade + "  " + peso + "g   " + tipoDoPao + "  " + recheio + "  " + molho;
        }
        public Lanche EscolherLanche()
        {
            precoVenda = 15.00;
            dataValidade = "28/11/2022";
            peso = 300.00; //gramas

            Console.WriteLine("Escolher tipo do pão");
            tipoDoPao = Console.ReadLine();
            Console.WriteLine("Escolher recheio");
            recheio = Console.ReadLine();
            Console.WriteLine("Escolher molho");
            molho = Console.ReadLine();

            return this;
        }
    }
}

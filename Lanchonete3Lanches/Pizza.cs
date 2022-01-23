using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Lanchonete3Lanches
{
    internal class Pizza : Item
    {
        private string Recheio;
        private bool Borda;
        private string Molho;

        public string recheio
        {
            get { return Recheio; }
            set { Recheio = value; }
        }
        public bool borda
        {
            get { return Borda; }
            set { Borda = value; }
        }
        private string molho
        {
            get { return Molho; }
            set { Molho = value; }
        }
        public override string ToString()
        {
            return "R$"+ precoVenda + "  " + dataValidade + "  " + peso + "g   " + recheio + "  " + borda + "  " + molho;
        }
        public Pizza EscolherPizza()
        {
            precoVenda = 59.99;
            dataValidade = "28/11/2022";
            peso = 500.00; //gramas
            
            Console.WriteLine("Escolha o recheio");
            recheio = Console.ReadLine();
            Console.WriteLine("Borda? 'S' para Sim, outra tecla para não.");
            string opcao = Console.ReadLine();
            if(opcao.ToUpper() == "S")
            {
                borda = true;
            }
            else
            {
                borda = false;
            }
            Console.WriteLine("Escolha o molho");
            molho = Console.ReadLine();

            return this;
        }
    }
}

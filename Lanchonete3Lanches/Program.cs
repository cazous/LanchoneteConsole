using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete3Lanches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        public static void Menu()
        {
            Console.WriteLine("Fazer pedido?   Digite '1' para Sim");
            string opcao = (Console.ReadLine());
            if(opcao == "1")
            {
                AdicionarPedido();
            }
            else
            {
                Menu();
            }
        }

        public static void AdicionarPedido()
        {
            Pedido p1 = new Pedido();
            List<Item> itens = new List<Item>();

            Console.WriteLine("Informe o nome do cliente: ");
            p1.nomeDoCliente = Console.ReadLine();

            p1.AdicionarItem(itens);
            p1.OpcoesDePedido(itens);
            p1.GerarNota(itens);

            Console.WriteLine("Pagamento em dinheiro? Digite '1' para sim.");
            string pagamentoDinheiro = Console.ReadLine();
            
            if (pagamentoDinheiro == "1")
            {
                Console.WriteLine("Digite dinheiro recebido:");
                double dinheiroRecebido = double.Parse(Console.ReadLine());
                p1.CalcularTroco(dinheiroRecebido, itens);
            }
               
        }
    }
}

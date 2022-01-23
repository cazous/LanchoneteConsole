using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanchonete3Lanches
{
    internal class Pedido
    {
        private string NomeDoCliente;
        private List<Item> Itens;
        private readonly double TaxaDeServiço = 15.00;

        public string nomeDoCliente
        {
            get { return NomeDoCliente; }
            set { NomeDoCliente = value; }
        }
        public List<Item> _items
        {
            get { return Itens; }
            set { Itens = value; }
        }
        public List<Item> AdicionarItem(List<Item> itens)
        {
            int opcaoADDItem = 1;

            while (opcaoADDItem == 1)
            {

                Console.WriteLine("Escolha o item: ");
                Console.WriteLine("1. Pizzas   2. Lanches  3. Salgadinhos");
                int opcaoItem = int.Parse(Console.ReadLine());

                switch (opcaoItem)
                {
                    case 1:
                        Pizza pizza = new Pizza();
                        pizza.EscolherPizza();
                        itens.Add(pizza);
                        break;
                    case 2:
                        Lanche lanche = new Lanche();
                        lanche.EscolherLanche();
                        itens.Add(lanche);
                        break;
                    case 3:
                        Salgadinho salgadinho = new Salgadinho();
                        salgadinho.EscolherSalgadinho();
                        itens.Add(salgadinho);
                        break;
                    default:
                        Console.WriteLine("Valor inválido, tente novamente");
                        AdicionarItem(itens);
                        break;
                }

                Console.WriteLine("Digite 1 caso queira adicionar mais itens à lista: ");
                opcaoADDItem = int.Parse(Console.ReadLine());
            }

            return itens;
        }
        public void OpcoesDePedido(List<Item> _items)
        {
            int opcaoDePedido = 0;
            Console.WriteLine("1. Finalizar pedido?");
            Console.WriteLine("2. Editar item?");
            Console.WriteLine("3. Deletar item?");
            opcaoDePedido = int.Parse(Console.ReadLine());

            switch (opcaoDePedido)
            {
                case 1:
                    Console.Clear();
                    VisualizarPedido(_items);
                    break;
                case 2:
                    Console.Clear();
                    VisualizarPedido(_items);
                    Console.WriteLine("Digite o número do item a ser editado: ");
                    int itemEditado = int.Parse(Console.ReadLine());
                    EditarItem(itemEditado, _items);
                    OpcoesDePedido(_items);
                    break;
                case 3:
                    Console.Clear();
                    VisualizarPedido(_items);
                    Console.WriteLine("Digite o número do item a ser deletado: ");
                    int itemDeletado = int.Parse(Console.ReadLine());
                    DeletarItem(itemDeletado, _items);
                    OpcoesDePedido(_items);
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente.");
                    OpcoesDePedido(_items);
                    break;
            }
        }
        public void VisualizarPedido(List<Item> _items)
        {
            int id = 0;
            Console.WriteLine("------- PEDIDO--------");
            foreach (var item in _items)
            {
                id++;
                Console.WriteLine(id + " - " + item);
            }
        }
        //**
        public void EditarItem(int _indice, List<Item> _items)
        {
            if (_items.ElementAt(_indice - 1).GetType() == typeof(Pizza))
            {
                _items.RemoveAt(_indice - 1);
                Pizza pizza = new Pizza();
                pizza.EscolherPizza();

                _items.Insert(_indice - 1, pizza);
            }

            if(_items.ElementAt(_indice - 1).GetType() == typeof(Lanche))
            {
                _items.RemoveAt(_indice - 1);
                Lanche lanche = new Lanche();
                lanche.EscolherLanche();

                _items.Insert(_indice - 1, lanche);
            }

            if(_items.ElementAt(_indice - 1).GetType() == typeof(Salgadinho))
            {
                _items.RemoveAt (_indice - 1);
                Salgadinho salgadinho = new Salgadinho();
                salgadinho.EscolherSalgadinho();

                _items.Insert(_indice - 1, salgadinho);
            }
        }
        //**
        public void DeletarItem(int _indice, List<Item> _items)
        {
            _items.RemoveAt(_indice - 1);
        }
        public void GerarNota(List<Item> _items)
        {
            double totalDosItens = 0;
            double totalDoPedido = 0;
            Console.WriteLine("-------NOTA FISCAL------");
            Console.WriteLine(NomeDoCliente);
            Console.WriteLine("--------------------");
            Console.WriteLine("Items: ");
            foreach (var item in _items)
            {
                Console.WriteLine();
                Console.WriteLine(item);
                totalDosItens += item.precoVenda;
            }
            Console.WriteLine("Total dos items: R$" + totalDosItens);
            Console.WriteLine("Taxa de Serviço: R$" + TaxaDeServiço);
            totalDoPedido = totalDosItens + TaxaDeServiço;
            Console.WriteLine("Total do pedido: R$" + totalDoPedido);
        }
        public void CalcularTroco(double _dinheiro, List<Item> _items) //Calcular troco sem passar lista
        {
            double totalDoPedido = 0;
            double troco = 0;

            foreach (var item in _items)
            {
                totalDoPedido += item.precoVenda;
            }

            troco = _dinheiro - (totalDoPedido + TaxaDeServiço);
            Console.WriteLine(troco.ToString());
        }
    }
}

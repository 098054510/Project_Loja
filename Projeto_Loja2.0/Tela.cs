using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Projeto_Loja2._0
{
    class Tela
    {
        public static void MostrarTela()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("----Loja Virtual Sem Nome----");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1 - Cadastrar Produto");
            Console.WriteLine("2 - Cadastrar Pedido");
            Console.WriteLine("3 - Listar Pedidos Cadastrados");
            Console.WriteLine("4 - Listar Produtos Cadastrados");
            Console.WriteLine("5 - Sair");
            Console.Write("Sua Escolha: ");
        }
        public static void MostrarPedidos()
        {
            Console.WriteLine("Digite o Codigo do Produto: ");
            int CodProduto = int.Parse(Console.ReadLine());
            int pos = Program.pedidos.FindIndex(x => x.Codigo == CodProduto);
            if (pos == -1)
            {
                throw new ModelException("O Codigo " + CodProduto + " não foi encontrado.");
            }
            Console.WriteLine(Program.pedidos[pos]);
        }
        public static void MostrarProdutos()
        {   
            Console.WriteLine("Produtos Cadastrados: ");
            for (int i = 1; i < Program.produtos.Count; i++)
            {
                Console.WriteLine(Program.produtos[i]);
            }
        }
        public static void CadastrarProdutos()
        {
            Console.Write("Digite a quantidade de produtos que serão cadastrados: ");
            int N = int.Parse(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Digite os dados do " + i + "º Produto: ");
                Console.Write("Produto: ");
                string Descricao = Console.ReadLine();
                Console.Write("Codigo: ");
                int Codigo = int.Parse(Console.ReadLine());
                Console.Write("Preço: R$");
                double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Produto P = new Produto(Codigo, Descricao, Preco);
                Program.produtos.Add(P);
            }
        }
        public static void CadastrarPedido()
        {
            Console.WriteLine("Digite os dados do pedido: ");
            Console.Write("Codigo do Pedido: ");
            int Codigo = int.Parse(Console.ReadLine());
            Console.Write("Dia: ");
            int Dia = int.Parse(Console.ReadLine());
            Console.Write("Mes: ");
            int Mes = int.Parse(Console.ReadLine());
            Console.Write("Ano: ");
            int Ano = int.Parse(Console.ReadLine());
            Pedido PD = new Pedido(Codigo, Dia, Mes, Ano);
            Console.Write("Digite a quantidade de produtos que serão cadastrados: ");
            int M = int.Parse(Console.ReadLine());
            for (int i = 1; i<=M; i++)
            {
                Console.WriteLine("Digite os dados do " + i + "º produto: ");
                Console.Write("Codigo: ");
                int CodProduto = int.Parse(Console.ReadLine());
                int pos = Program.produtos.FindIndex(x => x.Codigo == CodProduto);
                if (pos == -1)
                {
                    throw new ModelException("O Codigo " + CodProduto + " não foi encontrado.");
                }

                Console.Write("Digite o total de unidades solicitadas: ");
                int Quantidade = int.Parse(Console.ReadLine());
                Console.Write("Digite a Porcentagem de Desconto: ");
                double PorcentagemDesconto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                ItemPedido I = new ItemPedido(Quantidade, PorcentagemDesconto, Program.produtos[pos], PD);
                Pedido.pedido.Add(I);
                Console.WriteLine("PEDIDO CADASTRADO");
            }
            Program.pedidos.Add(PD);
        }
    }
}
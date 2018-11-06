using System;
using System.Collections.Generic;

namespace Projeto_Loja2._0
{
    class Program
    {
        public static List<Produto> produtos = new List<Produto>();
        public static List<Pedido> pedidos = new List<Pedido>();

        static void Main(string[] args)
        {
            int opcao = 0;

            produtos.Add(new Produto(1001, "Cadeira", 50.00));
            produtos.Add(new Produto(1002, "Mesa", 100.00));
            produtos.Add(new Produto(3310, "Banco", 30.00));
            produtos.Add(new Produto(1014, "Sofá Simples", 400.00));
            produtos.Add(new Produto(1015, "Sofá Duplo", 450.00));
            produtos.Add(new Produto(1016, "Sofá Triplo", 470.00));

            while (opcao != 5)
            {
                Console.Clear();
                Tela.MostrarTela();

                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine("Erro Operacional " + e.Message);
                    opcao = 0;
                }

                if (opcao == 1)
                {
                    Tela.CadastrarProdutos();
                    Console.WriteLine("PRODUTO(S) CADASTRADO(S)");
                    Console.WriteLine("Pressione ENTER para Continuar");

                    try
                    {
                        opcao = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro Operacional " + e.Message);
                        opcao = 0;
                    }
                }

                else if (opcao == 2)
                {
                    Tela.CadastrarPedido();
                    try
                    {
                        opcao = int.Parse(Console.ReadLine());
                    }
                    catch (ModelException e)
                    {
                        Console.WriteLine("Erro de Negocio: " + e.Message);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro Operacional " + e.Message);
                        opcao = 0;
                    }
                }

                else if (opcao == 3)
                {
                    Tela.MostrarPedidos();
                    Console.WriteLine("Pressione ENTER para Continuar");

                }

                else if (opcao == 4)
                {
                    for (int i = 1; i < produtos.Count; i++)
                    {
                        Console.WriteLine(produtos[i]);
                    }
                }

                else if (opcao == 5)
                {
                    Console.WriteLine("Tenha Um Bom Dia");
                }

                else
                {
                    Console.WriteLine("O que tu tá tentando fazer Jão? Deu Erro Menó! Tem Essa Opção Não :(");
                    Console.WriteLine("Pressione ENTER para Continuar");
                }

                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Projeto_Loja2._0
{
    class Pedido
    {
        public int Codigo { get; set;}
        public DateTime Data { get; set; }
        public static List<ItemPedido> pedido = new List<ItemPedido>();

        public Pedido(int Codigo, int Dia, int Mes, int Ano)
        {
            this.Codigo = Codigo;
            Data = new DateTime(Ano, Mes, Dia);
            pedido = new List<ItemPedido>();
        }

        public double ValorTotal()
        {
            double soma = 0.0;
            for (int i = 0; i<pedido.Count; i++)
            {
                soma = soma + pedido[i].SubTotal();
            }
            return soma;
        }

        public override string ToString()
        {
            return "Codigo do Pedido: "
                + Codigo + "\n"
                + "Data de Solicitação: "
                + Data.Day + "/" + Data.Month + "/" + Data.Year + "\n"
                + "R$" + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
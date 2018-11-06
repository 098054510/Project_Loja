using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Projeto_Loja2._0
{
    class ItemPedido
    {
        public int Quantidade { get; set; }
        public double PorcentagemDesconto { get; set; }
        public Produto produto { get; set; }
        public Pedido pedido { get; set; }

        public ItemPedido(int Quantidade, double PorcentagemDesconto, Produto produto, Pedido pedido)
        {
            this.Quantidade = Quantidade;
            this.PorcentagemDesconto = PorcentagemDesconto;
            this.produto = produto;
            this.pedido = pedido;
        }

        public double SubTotal()
        {
            double Desconto = produto.Preco * PorcentagemDesconto / 100.0;
            return (produto.Preco - Desconto) * Quantidade;
        }

        public override string ToString()
        {
            return "Produto: "
                + produto.Descricao
                + ", Preço: "
                + produto.Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantidade: "
                + Quantidade
                + ", Desconto: "
                + PorcentagemDesconto.ToString("F2", CultureInfo.InvariantCulture)
                + ", SubTotal: "
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
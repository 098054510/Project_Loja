using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Projeto_Loja2._0
{
    class Produto
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }
        public double Preco { get; set; }

        public Produto(int Codigo, string Descricao, double Preco)
        {
            this.Codigo = Codigo;
            this.Descricao = Descricao;
            this.Preco = Preco;
        }

        public override string ToString()
        {
            return "Codigo: "
                + Codigo
                + ", Produto: "
                + Descricao
                + ", Preço; R$"
                + Preco.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

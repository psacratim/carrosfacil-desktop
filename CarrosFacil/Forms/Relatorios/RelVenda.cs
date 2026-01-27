using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil.Forms.Relatorios
{
    class RelVenda
    {
        public int id_venda { get; set; }
        public int id_funcionario { get; set; }
        public int id_cliente { get; set; }
        public decimal valor_total { get; set; }
        public int id_item_venda { get; set; }
        public int id_veiculo { get; set; }
        public int desconto { get; set; }
        public int quantidade { get; set; }
        public decimal valor_unitario { get; set; }
        public decimal valor_total_itens { get; set; }
        public List<int> id_pagamentos { get; set; }
        public int id_marca { get; set; }


        public RelVenda()
        {
            this.id_venda = 0;
            this.id_funcionario = 0;
            this.id_cliente = 0;
            this.valor_total = 0;

            this.id_item_venda = 0;
            this.id_veiculo = 0;
            this.quantidade = 0;
            this.valor_unitario = 0;
            this.valor_total_itens = 0;

            this.id_pagamentos = new List<int>();

            this.id_marca = 0;
        }

        public void GerarRelatorioPorData(DateTime inicio, DateTime fim)
        {
            string sql = string.Format("SELECT venda.id, venda.data_cadastro, venda.desconto, venda.valor_total, venda.valor_desconto, funcionario.nome, cliente.nome, pagamento_venda.metodo, modelo.nome FROM venda LEFT JOIN pagamento_venda ON pagamento_venda.id_venda = venda.id INNER JOIN item_venda ON item_venda.id_venda = venda.id INNER JOIN funcionario ON funcionario.id = venda.id_funcionario INNER JOIN cliente ON cliente.id = venda.id_cliente INNER JOIN veiculo ON veiculo.id = item_venda.id_veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo WHERE CAST(venda.data_cadastro AS DATE) BETWEEN '%s' AND '%s' GROUP BY venda.id ORDER BY venda.data_cadastro;", inicio.ToString("yyyy-MM-dd"), fim.ToString("yyyy-MM-dd"));

            Conexao conexao = new Conexao();
            conexao.ExecutaQuery(sql);
        }
    }
}

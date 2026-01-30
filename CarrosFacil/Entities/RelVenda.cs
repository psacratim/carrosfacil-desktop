using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil.Entities
{
    class RelVenda
    {
        public int id_venda { get; set; }
        public int id_funcionario { get; set; }
        public int id_cliente { get; set; }
        public decimal valor_total { get; set; }
        public int id_item_venda { get; set; }
        public int id_veiculo { get; set; }
        public int id_marca { get; set; }
        public int desconto { get; set; }
        public int quantidade { get; set; }
        public decimal valor_unitario { get; set; }
        public decimal valor_total_itens { get; set; }
        public int id_pagamento { get; set; }
        public DateTime data_cadastro { get; set; }

        public string metodo { get; set; }
        public decimal valor_pagamento { get; set; }


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

            this.id_marca = 0;
            this.data_cadastro = new DateTime();

            this.id_pagamento = 0;
            this.valor_pagamento = 0;
            this.metodo = "";
        }

        private string BASE_QUERY = "SELECT venda.id AS id_venda, veiculo.id AS id_veiculo, venda.data_cadastro, venda.desconto AS desconto, venda.valor_total AS valor_total, funcionario.nome AS id_funcionario, cliente.nome AS id_cliente, ( SELECT GROUP_CONCAT(pv.metodo SEPARATOR ', ') FROM pagamento_venda pv WHERE pv.id_venda = venda.id) AS metodo, modelo.nome AS id_modelo, marca.nome AS id_marca, item_venda.quantidade, item_venda.valor_unitario, item_venda.valor_total AS valor_total_itens FROM venda INNER JOIN item_venda ON item_venda.id_venda = venda.id INNER JOIN funcionario ON funcionario.id = venda.id_funcionario INNER JOIN cliente ON cliente.id = venda.id_cliente INNER JOIN veiculo ON veiculo.id = item_venda.id_veiculo INNER JOIN modelo ON modelo.id = veiculo.id_modelo INNER JOIN marca ON marca.id = modelo.id_marca";

        public DataTable GerarRelatorioPorData(DateTime inicio, DateTime fim)
        {
            string sql = string.Format(BASE_QUERY + " WHERE CAST(venda.data_cadastro AS DATE) BETWEEN '{0}' AND '{1}' ORDER BY venda.data_cadastro;", inicio.ToString("yyyy-MM-dd"), fim.ToString("yyyy-MM-dd"));
            Conexao conexao = new Conexao();
            return conexao.RetornaDados(sql);
        }

        public DataTable GerarRelatorioDetalhadoCliente(int idCliente)
        {
            string sql = string.Format(BASE_QUERY + " WHERE venda.id_cliente = {0} ORDER BY venda.data_cadastro;", idCliente);
            Conexao conexao = new Conexao();
            return conexao.RetornaDados(sql);
        }

        public DataTable GerarRelatorioPorPeriodoCliente(DateTime inicio, DateTime fim, int idCliente)
        {
            string sql = string.Format(BASE_QUERY + " WHERE CAST(venda.data_cadastro AS DATE) BETWEEN '{0}' AND '{1}' AND venda.id_cliente = {2} ORDER BY venda.data_cadastro;", inicio.ToString("yyyy-MM-dd"), fim.ToString("yyyy-MM-dd"), idCliente);
            Conexao conexao = new Conexao();
            return conexao.RetornaDados(sql);
        }


        public DataTable GerarRelatorioDetalhadoPorPeriodoFuncionario(DateTime inicio, DateTime fim, int idFuncionario)
        {
            string sql = string.Format(BASE_QUERY + " WHERE CAST(venda.data_cadastro AS DATE) BETWEEN '{0}' AND '{1}' AND venda.id_funcionario = {2} ORDER BY venda.data_cadastro;", inicio.ToString("yyyy-MM-dd"), fim.ToString("yyyy-MM-dd"), idFuncionario);
            Conexao conexao = new Conexao();
            return conexao.RetornaDados(sql);
        }


        public DataTable GerarRelatorioDetalhadoFuncionario(int idFuncionario)
        {
            string sql = string.Format(BASE_QUERY + " WHERE venda.id_funcionario = {0} ORDER BY venda.data_cadastro;", idFuncionario);
            Conexao conexao = new Conexao();
            return conexao.RetornaDados(sql);
        }

    }
}

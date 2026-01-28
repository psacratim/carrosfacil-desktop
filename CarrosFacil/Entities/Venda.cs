using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil.Entities
{
    class Venda
    {
        public int id { get; set; }
        public int id_funcionario { get; set; }
        public int id_cliente { get; set; }
        public decimal valor_total { get; set; }
        public decimal valor_desconto { get; set; }
        public decimal desconto { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        public Venda()
        {
            this.id = 0;
            this.id_funcionario = 0;
            this.id_cliente = 0;
            this.valor_total = 0;
            this.valor_desconto = 0;
            this.desconto = 0;
            this.data_cadastro = DateTime.Now;
            this.status = 0;
        }

        public bool Cadastrar()
        {
            string query = string.Format("INSERT INTO venda VALUES (0, {0}, {1}, {2}, {3}, {4}, NOW(), 1);",
                id_funcionario,
                id_cliente,
                valor_total.ToString().Replace(",", "."),
                valor_desconto.ToString().Replace(",", "."),
                desconto
            );

            Conexao conexao = new Conexao();

            id = 0;
            id = conexao.ExecutaQuery(query, true);

            return id != 0;
        }

        public static int Excluir(int codigo)
        {
            Conexao conexao = new Conexao();
            conexao.ExecutaQuery("UPDATE pagamento_venda SET status = 0 WHERE id_venda = " + codigo +";");

            string query = "UPDATE venda SET status = 0 WHERE id = " + codigo + ";";
            return conexao.ExecutaQuery(query);
        }
    }
}

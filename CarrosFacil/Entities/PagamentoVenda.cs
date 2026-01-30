using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil.Entities
{
    class PagamentoVenda
    {
        public int id { get; set; }
        public int id_venda { get; set; }
        public string metodo { get; set; }
        public decimal valor_final { get; set; }
        public int parcelas { get; set; }
        public int desconto { get; set; }
        public int status { get; set; }

        public PagamentoVenda()
        {
            this.id = 0;
            this.id_venda = 0;
            this.metodo = "";
            this.valor_final = 0;
            this.parcelas = 0;
            this.desconto = 0;
            this.status = 0;
        }

        public int Cadastrar()
        {
            string query = string.Format("INSERT INTO pagamento_venda (id_venda, metodo, valor_final, parcelas, status) VALUES ({0}, '{1}', {2}, {3}, 1);",
                id_venda,
                metodo,
                valor_final,
                parcelas
            );

            Conexao conexao = new Conexao();

            return conexao.ExecutaQuery(query);
        }

        public static int Excluir(int codigo)
        {
            string query = "UPDATE pagamento_venda SET status = 0 WHERE id=" + codigo + ";";

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }

        /*
         * Consulta Funcionario:
- Obter somente cargos, cidades que estão sendo usados por funcionários ativos.
- A consulta por CPF deve mostrar funcionários inativos também.


Veiculo tá salvando sem foto na edição
- tempo uso aceita letras, estoque tbm, kms tbm, 

Falta:
Limpar o item, estoque, qtde, vlr unit, total do item após vender.

Venda não cadastra os métodos de pagamento.
         * 
         */
    }
}

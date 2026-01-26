using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil.Entities
{
    class Caracteristica
    {
        // Atalho pra criar propriedade: escreva "prop" e aperta duas vezes a tecla tab.
        public int id { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public string icone { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        public Caracteristica()
        {
            this.id = 0;
            this.nome = null;
            this.observacao = null;
            this.icone = null;
            this.data_cadastro = DateTime.Now;
            this.status = 0;
        }

        // METHODS
        public int Cadastrar()
        {
            string query = string.Format("INSERT INTO caracteristica VALUES (0, '{0}', '{1}', '{2}', NOW(), 1);", nome, observacao, icone);
            Conexao conexao = new Conexao();

            return conexao.ExecutaQuery(query);
        }

        public DataTable CarregarCaracteristicas()
        {
            string query = "SELECT id, nome FROM caracteristica WHERE status = 1; ";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarSemFiltro()
        {
            string query = "SELECT id '#', nome 'Nome', observacao 'Descrição', icone 'Ícone', data_cadastro 'Data Cadastro', status 'Status' FROM caracteristica WHERE status = 1";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorNome(string nome)
        {
            string query = string.Format("SELECT id '#', nome 'Nome', observacao 'Descrição', icone 'Ícone', data_cadastro 'Data Cadastro', status 'Status' FROM caracteristica WHERE nome LIKE '%{0}%' AND status = 1 ", nome);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorStatus(int status)
        {
            // Incluindo 'observacao' e 'icone'
            string query = string.Format("SELECT id '#', nome 'Nome', observacao 'Descrição', icone 'Ícone', data_cadastro 'Data Cadastro', status 'Status' FROM caracteristica WHERE status = {0}", status);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorCodigo(int codigo)
        {
            // Incluindo 'observacao' e 'icone'
            string query = string.Format("SELECT id '#', nome 'Nome', observacao 'Descrição', icone 'Ícone', data_cadastro 'Data Cadastro', status 'Status' FROM caracteristica WHERE id = {0} AND status = 1 ", codigo);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public bool ConsultaCaracteristica(int id)
        {
            string query = "SELECT * FROM caracteristica WHERE id=" + id;

            Conexao conexao = new Conexao();
            DataTable dt = conexao.RetornaDados(query);

            if (dt.Rows.Count > 0)
            {
                this.id = Convert.ToInt32(dt.Rows[0]["id"]);
                this.nome = Convert.ToString(dt.Rows[0]["nome"]);
                this.observacao = Convert.ToString(dt.Rows[0]["observacao"]);
                this.icone = Convert.ToString(dt.Rows[0]["icone"]);
                this.data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                this.status = Convert.ToInt32(dt.Rows[0]["status"]);

                return true;
            }

            return false;
        }

        public int Atualizar()
        {
            string query = string.Format("UPDATE caracteristica SET nome = '{0}', observacao = '{1}', icone = '{2}', status = {3} WHERE id = {4};",
                this.nome, this.observacao, this.icone, this.status, this.id);

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }

        public DataTable ConsultarPorVeiculo(int codigoVeiculo)
        {
            string query = string.Format("SELECT cc.id_caracteristica '#', c.nome 'Nome' FROM caracteristica_carro AS cc INNER JOIN caracteristica AS c ON cc.id_caracteristica = c.id WHERE cc.id_veiculo = {0};", codigoVeiculo);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorCodigos(List<int> caracteristicasSelecionadas)
        {
            // 1. Verifica se a lista está vazia para evitar um erro SQL (ex: "IN ()")
            if (caracteristicasSelecionadas == null || caracteristicasSelecionadas.Count == 0)
            {
                // Retorna uma tabela vazia se não houver IDs para consultar
                return new DataTable();
            }

            // 2. Converte a lista de inteiros [1, 5, 10] para uma string "1,5,10"
            string ids = string.Join(",", caracteristicasSelecionadas);

            // 3. Monta a query usando a cláusula IN.
            //    Incluí "status = 1" para manter a consistência com o método "ConsultarPorCodigo" (singular).
            string query = string.Format(
                "SELECT id '#', nome 'Nome'" +
                "FROM caracteristica " +
                "WHERE id IN ({0}) AND status = 1",
                ids
            );

            // 4. Executa a consulta e retorna os dados
            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public static int Excluir(int codigo)
        {
            string query = "UPDATE caracteristica SET status = 0 WHERE id = " + codigo + ";";

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }
    }
}

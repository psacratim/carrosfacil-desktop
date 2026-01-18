using System;
using System.Data;
using System.Threading.Tasks;

namespace CarrosFacil.Entities
{
    class Cargo
    {
        // Atalho pra criar propriedade: escreva "prop" e aperta duas vezes a tecla tab.
        public int id { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        public Cargo()
        {
            this.id = 0;
            this.nome = null;
            this.observacao = null;
            this.data_cadastro = DateTime.Now;
            this.status = 0;
        }

        // METHODS
        public int Cadastrar()
        {
            string query = string.Format("INSERT INTO cargo VALUES (0, '{0}', '{1}', NOW(), 1);", nome, observacao);
            Conexao conexao = new Conexao();

            return conexao.ExecutaQuery(query);
        }

        public DataTable CarregarCargo()
        {
            string query = "SELECT id, nome FROM cargo WHERE status = 1; ";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarSemFiltro()
        {
            // O cargo não tem INNER JOIN com outra tabela como o modelo tem com a marca.
            string query = "SELECT id '#', nome 'Nome', data_cadastro 'Data Cadastro', status 'Status' FROM cargo WHERE status = 1";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorNome(string nome)
        {
            // Uso de LIKE para busca parcial e % para busca na substring.
            string query = string.Format("SELECT id '#', nome 'Nome', data_cadastro 'Data Cadastro', status 'Status' FROM cargo WHERE nome LIKE '%{0}%' AND status = 1 ", nome);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorStatus(int status)
        {
            string query = string.Format("SELECT id '#', nome 'Nome', data_cadastro 'Data Cadastro', status 'Status' FROM cargo WHERE status = {0}", status);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorCodigo(int codigo)
        {
            string query = string.Format("SELECT id '#', nome 'Nome', data_cadastro 'Data Cadastro', status 'Status' FROM cargo WHERE id = {0} AND status = 1 ", codigo);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public bool ConsultaCargo(int id)
        {
            string query = "SELECT * FROM cargo WHERE id=" + id;

            Conexao conexao = new Conexao();
            DataTable dt = conexao.RetornaDados(query);

            if (dt.Rows.Count > 0)
            {
                this.id = Convert.ToInt32(dt.Rows[0]["id"]);
                this.nome = Convert.ToString(dt.Rows[0]["nome"]);
                this.observacao = Convert.ToString(dt.Rows[0]["observacao"]);
                this.data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                this.status = Convert.ToInt32(dt.Rows[0]["status"]);

                return true;
            }

            return false;
        }

        public int Atualizar()
        {
            // String de query para UPDATE na tabela 'cargo'.
            string query = string.Format("UPDATE cargo SET nome = '{0}', observacao = '{1}', status = {2} WHERE id = {3};",
                this.nome, this.observacao, this.status, this.id);

            Conexao conexao = new Conexao();

            return conexao.ExecutaQuery(query);
        }

        public static int Excluir(int codigo)
        {
            string query = "UPDATE cargo SET status = 0 WHERE id = " + codigo + ";";

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil.Entities
{
    class Marca
    {

        public int id { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        public Marca()
        {
            this.id = 0;
            this.nome = "";
            this.observacao = "";
            this.data_cadastro = DateTime.Now;
            this.status = 0;
        }

        public int Cadastrar()
        {
            string query = string.Format("INSERT INTO marca VALUES({0}, '{1}', '{2}', {3}, {4});",
                0,
                nome,
                observacao,
                "NOW()",
                1
            );

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }

        public DataTable CarregarMarcas()
        {
            string query = "SELECT id, nome FROM marca WHERE status = 1; ";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarSemFiltro()
        {
            string query = "SELECT id '#', nome 'Nome', data_cadastro 'Data Cadastro', status 'Status' FROM marca WHERE status = 1";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorNome(string nome)
        {
            string query = string.Format("SELECT id '#', nome 'Nome', data_cadastro 'Data Cadastro', status 'Status' FROM marca WHERE nome LIKE '%{0}%' AND status = 1 ", nome);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorStatus(int status)
        {
            string query = string.Format("SELECT id '#', nome 'Nome', data_cadastro 'Data Cadastro', status 'Status' FROM marca WHERE status = {0}", status);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorCodigo(int codigo)
        {
            string query = string.Format("SELECT id '#', nome 'Nome', data_cadastro 'Data Cadastro', status 'Status' FROM marca WHERE id = {0} AND status = 1 ", codigo);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public bool ConsultaMarca(int id)
        {
            string query = "SELECT * FROM marca WHERE id=" + id;

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
            string query = string.Format("UPDATE marca SET nome = '{0}', observacao = '{1}', status = {2} WHERE id = {3};",
                this.nome, this.observacao, this.status, this.id);

            Conexao conexao = new Conexao();

            return conexao.ExecutaQuery(query);
        }

        public static int Excluir(int codigo)
        {
            string query = "UPDATE marca SET status = 0 WHERE id = " + codigo + ";";

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }
    }
}

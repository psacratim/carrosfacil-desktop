using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil.Entities
{
    class Modelo
    {
        public int id { get; set; }
        public int id_marca { get; set; }
        public string nome { get; set; }
        public string observacao { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        public Modelo()
        {
            id = 0;
            id_marca = 0;
            nome = null;
            observacao = null;
            data_cadastro = DateTime.MinValue;
            status = 0;
        }

        // METHODS
        public int Cadastrar()
        {
            string query = string.Format("INSERT INTO modelo VALUES (0, '{0}', '{1}', '{2}', NOW(), 1);", id_marca, nome, observacao);
            Conexao conexao = new Conexao();

            return conexao.ExecutaQuery(query);
        }

        public DataTable CarregarModelos()
        {
            string query = "SELECT id, nome FROM modelo WHERE status = 1; ";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarSemFiltro()
        {
            string query = "SELECT modelo.id '#', marca.nome 'Marca', modelo.nome 'Nome', modelo.status 'Status' FROM modelo INNER JOIN marca ON modelo.id_marca = marca.id WHERE modelo.status = 1";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorNome(string nome)
        {
            string query = string.Format("SELECT modelo.id '#', marca.nome 'Marca', modelo.nome 'Nome', modelo.status 'Status' FROM modelo INNER JOIN marca ON modelo.id_marca = marca.id WHERE modelo.nome LIKE '%{0}%' AND modelo.status = 1 ", nome);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorStatus(int status)
        {
            string query = string.Format("SELECT modelo.id '#', marca.nome 'Marca', modelo.nome 'Nome', modelo.status 'Status' FROM modelo INNER JOIN marca ON modelo.id_marca = marca.id WHERE modelo.status = {0}", status);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorCodigo(int codigo)
        {
            string query = string.Format("SELECT modelo.id '#', marca.nome 'Marca', modelo.nome 'Nome', modelo.status 'Status' FROM modelo INNER JOIN marca ON modelo.id_marca = marca.id WHERE modelo.id = {0} AND modelo.status = 1 ", codigo);

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public bool ConsultaModelo(int id)
        {
            string query = "SELECT * FROM modelo WHERE id=" + id;

            Conexao conexao = new Conexao();
            DataTable dt = conexao.RetornaDados(query);

            if (dt.Rows.Count > 0)
            {
                this.id = Convert.ToInt32(dt.Rows[0]["id"]);
                id_marca = Convert.ToInt32(dt.Rows[0]["id_marca"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                observacao = Convert.ToString(dt.Rows[0]["observacao"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);

                return true;
            }

            return false;
        }

        public int Atualizar()
        {
            string query = string.Format("UPDATE modelo SET id_marca = '{0}', nome = '{1}', observacao = '{2}', status = {3} WHERE id = {4};", id_marca, nome, observacao, status, id);
            Conexao conexao = new Conexao();

            return conexao.ExecutaQuery(query);
        }

        public static int Excluir(int codigo)
        {
            string query = "UPDATE modelo SET status = 0 WHERE id = " + codigo + ";";

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil.Entities
{
    class Cliente
    {
        public int id { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string nome { get; set; }
        public DateTime data_nascimento { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string telefone1 { get; set; }
        public string telefone2 { get; set; }
        public string email { get; set; }
        public string estado_civil { get; set; }
        public string sexo { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }
            
        public Cliente()
        {
            id = 0;
            cpf = null;
            rg = null;
            nome = null;
            data_nascimento = DateTime.Now;
            senha = null;
            sexo = null;
            usuario = null;
            estado_civil = null;
            telefone1 = null;
            telefone2 = null;
            endereco = null;
            numero = 0;
            complemento = null;
            bairro = null;
            cidade = null;
            estado = null;
            email = null;
            cep = null;
            data_cadastro = DateTime.Now;
            status = 0;
        }

        /*
         * CAMPOS DATE: propriedade.toString("yyyy-MM-dd");
         * CAMPOS DECIMAL: propriedade.replaceAll(",", ".");
         * SEM ASPAS SIMPLES EM CAMPO BIT!
        */
        public int Cadastrar()
        {
            string query = string.Format("INSERT INTO cliente VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}', '{12}', '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', {19}, {20});",
                0,
                cpf,
                rg,
                nome,
                data_nascimento.ToString("yyyy-MM-dd"),
                usuario,
                senha,
                endereco,
                cep,
                numero,
                complemento,
                bairro,
                cidade,
                estado,
                telefone1,
                telefone2,
                email,
                estado_civil,
                sexo,
                "NOW()",
                1
            );

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }

        public DataTable ConsultarPorCidade(string cidade)
        {
            string query = "SELECT id '#', nome 'Nome', cpf 'CPF', telefone1 'Telefone 1', telefone2 'Telefone 2', data_nascimento 'Data Nascimento', status 'Status' " +
                            "FROM cliente WHERE status = 1 AND cidade = '" + cidade + "' ORDER BY nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorEstado(string estado)
        {
            string query = "SELECT id '#', nome 'Nome', cpf 'CPF', telefone1 'Telefone 1', telefone2 'Telefone 2', data_nascimento 'Data Nascimento', status 'Status' " +
                            "FROM cliente WHERE status = 1 AND estado = '" + estado + "' ORDER BY nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorSexo(string sexo)
        {
            string query = "SELECT id '#', nome 'Nome', cpf 'CPF', telefone1 'Telefone 1', telefone2 'Telefone 2', data_nascimento 'Data Nascimento', status 'Status' " +
                            "FROM cliente WHERE status = 1 AND sexo = '" + sexo + "' ORDER BY nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorStatus(int status)
        {
            string query = "SELECT id '#', nome 'Nome', cpf 'CPF', telefone1 'Telefone 1', telefone2 'Telefone 2', data_nascimento 'Data Nascimento', status 'Status' " +
                            "FROM cliente WHERE status = " + status + " ORDER BY nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorSexoCidade(string cidade, string sexo)
        {
            string query = "SELECT id '#', nome 'Nome', cpf 'CPF', telefone1 'Telefone 1', telefone2 'Telefone 2', data_nascimento 'Data Nascimento', status 'Status' " +
                            "FROM cliente WHERE status = 1 AND sexo = '" + sexo + "' AND cidade = '" + cidade + "' ORDER BY nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorNome(string nome, bool somentePrimeiroNome)
        {
            string searchName = (somentePrimeiroNome ? "" : "%") + nome + "%";
            string query = "SELECT id '#', nome 'Nome', cpf 'CPF', telefone1 'Telefone 1', telefone2 'Telefone 2', data_nascimento 'Data Nascimento', status 'Status' " +
                            "FROM cliente WHERE status = 1 AND nome LIKE '" + searchName + "' ORDER BY nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorCpf(string cpf)
        {
            string query = "SELECT id '#', nome 'Nome', cpf 'CPF', telefone1 'Telefone 1', telefone2 'Telefone 2', data_nascimento 'Data Nascimento', status 'Status' " +
                            "FROM cliente WHERE status = 1 AND cpf = '" + cpf + "' ORDER BY nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorEstadoCivil(string estadoCivil)
        {
            string query = "SELECT id '#', nome 'Nome', cpf 'CPF', telefone1 'Telefone 1', telefone2 'Telefone 2', data_nascimento 'Data Nascimento', status 'Status' " +
                            "FROM cliente WHERE status = 1 AND estado_civil = '" + estadoCivil + "' ORDER BY nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorDataCadastro(DateTime inicio, DateTime fim)
        {
            string query = "SELECT id '#', nome 'Nome', cpf 'CPF', telefone1 'Telefone 1', telefone2 'Telefone 2', data_nascimento 'Data Nascimento', status 'Status' " +
                            "FROM cliente WHERE status = 1 AND data_cadastro BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fim.ToString("yyyy-MM-dd") + "' ORDER BY nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarSemFiltros()
        {
            string query = "SELECT id '#', nome 'Nome', cpf 'CPF', telefone1 'Telefone 1', telefone2 'Telefone 2', data_nascimento 'Data Nascimento', status 'Status' " +
                            "FROM cliente WHERE status = 1 ORDER BY nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorUsuario(string usuario)
        {
            string query = "SELECT id '#', nome 'Nome', cpf 'CPF', telefone1 'Telefone 1', telefone2 'Telefone 2', data_nascimento 'Data Nascimento', status 'Status' " +
                            "FROM cliente WHERE status = 1 AND usuario LIKE '%" + usuario + "%' ORDER BY nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable CarregarClientes()
        {
            string query = "SELECT id, nome FROM cliente WHERE status = 1;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable CarregarCidades()
        {
            string query = "SELECT DISTINCT cidade FROM cliente ORDER BY cidade;"; // DISTINCT = Evita repetições, tipo: Piracicaba, Piracicaba, Piracicaba, Sorocaba.

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public bool ConsultaCliente(int id)
        {
            string query = "SELECT * FROM cliente WHERE id=" + id;

            Conexao conexao = new Conexao();
            DataTable dt = conexao.RetornaDados(query);

            if (dt.Rows.Count > 0)
            {
                this.id = Convert.ToInt32(dt.Rows[0]["id"]);
                cpf = Convert.ToString(dt.Rows[0]["cpf"]);
                rg = Convert.ToString(dt.Rows[0]["rg"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                senha = Convert.ToString(dt.Rows[0]["senha"]);
                sexo = Convert.ToString(dt.Rows[0]["sexo"]);
                usuario = Convert.ToString(dt.Rows[0]["usuario"]);
                estado_civil = Convert.ToString(dt.Rows[0]["estado_civil"]);
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                telefone1 = Convert.ToString(dt.Rows[0]["telefone1"]);
                telefone2 = Convert.ToString(dt.Rows[0]["telefone2"]);
                endereco = Convert.ToString(dt.Rows[0]["endereco"]);
                cep = Convert.ToString(dt.Rows[0]["cep"]);
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                complemento = Convert.ToString(dt.Rows[0]["complemento"]);
                bairro = Convert.ToString(dt.Rows[0]["bairro"]);
                cidade = Convert.ToString(dt.Rows[0]["cidade"]);
                estado = Convert.ToString(dt.Rows[0]["estado"]);
                email = Convert.ToString(dt.Rows[0]["email"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);

                return true;
            }

            return false;
        }
        public int AtualizarCliente()
        {
            string query = string.Format(
                "UPDATE cliente SET cpf = '{0}', rg = '{1}', nome = '{2}', data_nascimento = '{3}', usuario = '{4}', senha = '{5}', endereco = '{6}', cep = '{7}', numero = {8}, complemento = '{9}', bairro = '{10}', cidade = '{11}', estado = '{12}', telefone1 = '{13}', telefone2 = '{14}', email = '{15}', estado_civil = '{16}', sexo = '{17}', status = {18} WHERE id = {19};",
                cpf,
                rg,
                nome,
                data_nascimento.ToString("yyyy-MM-dd"),
                usuario,
                senha,
                endereco,
                cep,
                numero,
                complemento,
                bairro,
                cidade,
                estado,
                telefone1,
                telefone2,
                email,
                estado_civil,
                sexo,
                status,
                id
            );

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }

        /*
         * 
         * MÉTODOS DE RELATORIO
         *
        */
        public DataTable RelatorioPorSexo(string sexo)
        {
            string query = "SELECT cliente.cpf, cliente.nome, cliente.estado_civil, cliente.data_nascimento, cliente.cidade, cliente.sexo FROM cliente WHERE cliente.status = 1 AND cliente.sexo = '" + sexo + "' ORDER BY cliente.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable RelatorioPorStatus(int status)
        {
            string query = "SELECT cliente.cpf, cliente.nome, cliente.estado_civil, cliente.data_nascimento, cliente.cidade, cliente.sexo FROM cliente WHERE cliente.status = " + status + " ORDER BY cliente.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
        public DataTable RelatorioPorCidade(string cidade)
        {
            string query = "SELECT cliente.cpf, cliente.nome, cliente.estado_civil, cliente.data_nascimento, cliente.cidade, cliente.sexo FROM cliente WHERE cliente.status = 1 AND cliente.cidade = '" + cidade + "' ORDER BY cliente.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable RelatorioPorMesAniversario(int mes)
        {
            string query = "SELECT cliente.cpf, cliente.nome, cliente.estado_civil, cliente.data_nascimento, cliente.cidade, cliente.sexo FROM cliente WHERE cliente.status = 1 AND MONTH(cliente.data_nascimento) = " + mes + " ORDER BY cliente.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable RelatorioPorIdade(int minima, int maxima)
        {
            string query = "SELECT cliente.cpf, cliente.nome, cliente.estado_civil, cliente.data_nascimento, cliente.cidade, cliente.sexo FROM cliente WHERE cliente.status = 1 AND TIMESTAMPDIFF(YEAR, cliente.data_nascimento, NOW()) BETWEEN " + minima + " AND " + maxima + " ORDER BY cliente.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        //VENDAS
        public DataTable CarregaGridClient(string nomec)
        {
            string query = "SELECT id, cpf, nome FROM cliente WHERE nome LIKE '%"+nomec+ "%' AND status = 1 ORDER BY nome";
                                    
            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public static int Excluir(int codigo)
        {
            string query = "UPDATE cliente SET status = 0 WHERE id = " + codigo + ";";

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }
    }
}

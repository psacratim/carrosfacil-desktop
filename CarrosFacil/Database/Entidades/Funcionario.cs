using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrosFacil.Entities
{
    class Funcionario
    {
        public int id { get; set; }
        public int id_cargo { get; set; }
        public string cpf { get; set; }
        public string rg { get; set; }
        public string nome { get; set; }
        public string nome_social { get; set; }
        public string senha { get; set; }
        public double salario { get; set; }
        public string sexo { get; set; }
        public string usuario { get; set; }
        public string estado_civil { get; set; }
        public DateTime data_nascimento { get; set; }
        public int tipo_acesso { get; set; }
        public string telefone_celular { get; set; }
        public string telefone_recado { get; set; }
        public string telefone_residencial { get; set; }
        public string cep { get; set; }
        public string foto { get; set; }
        public string endereco { get; set; }
        public int numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string email { get; set; }
        public DateTime data_cadastro { get; set; }
        public int status { get; set; }

        public Funcionario()
        {
            id = 0;
            id_cargo = 0;
            cpf = null;
            rg = null;
            nome = null;
            nome_social = null;
            senha = null;
            salario = 0;
            sexo = null;
            usuario = null;
            estado_civil = null;
            data_nascimento = DateTime.Now;
            tipo_acesso = 0;
            telefone_celular = null;
            telefone_recado = null;
            telefone_residencial = null;
            endereco = null;
            numero = 0;
            complemento = null;
            bairro = null;
            cidade = null;
            estado = null;
            email = null;
            cep = null;
            foto = null;
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
            string query = string.Format("INSERT INTO funcionario VALUES ({0}, {1}, '{2}', '{3}', '{4}', '{5}', '{6}', {7}, '{8}', '{9}', '{10}', '{11}', {12}, '{13}', '{14}', '{15}', '{16}', '{17}', '{18}', '{19}', '{20}', '{21}', '{22}', '{23}', '{24}', {25}, {26});",
                0,
                id_cargo,
                cpf,
                rg,
                nome,
                nome_social,
                senha,
                salario.ToString().Replace(",", "."),
                sexo,
                usuario,
                estado_civil,
                data_nascimento.ToString("yyyy-MM-dd"),
                tipo_acesso,
                telefone_celular,
                telefone_recado,
                telefone_residencial,
                endereco,
                cep,
                numero,
                complemento,
                bairro,
                cidade,
                estado,
                email,
                foto,
                "NOW()",
                1
            ); 

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }


        public DataTable ConsultarPorCargo(int idCargo)
        {
            string query = "SELECT funcionario.id '#', funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.cpf 'CPF', funcionario.telefone_Recado 'T. Recado', funcionario.data_nascimento 'Data Nascimento', funcionario.status 'Status' FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND funcionario.id_cargo = " + idCargo + " ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
        public DataTable ConsultarPorCidade(string cidade)
        {
            string query = "SELECT funcionario.id '#', funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.cpf 'CPF', funcionario.telefone_Recado 'T. Recado', funcionario.data_nascimento 'Data Nascimento', funcionario.status 'Status' FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND funcionario.cidade = '" + cidade + "' ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
        public DataTable ConsultarPorUsuario(string usuario)
        {
            string query = "SELECT funcionario.id '#', funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.cpf 'CPF', funcionario.telefone_Recado 'T. Recado', funcionario.data_nascimento 'Data Nascimento', funcionario.status 'Status' FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND funcionario.usuario = '" + usuario + "' ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
        public DataTable ConsultarPorSexo(string sexo)
        {
            string query = "SELECT funcionario.id '#', funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.cpf 'CPF', funcionario.telefone_Recado 'T. Recado', funcionario.data_nascimento 'Data Nascimento', funcionario.status 'Status' FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND funcionario.sexo = '" + sexo + "' ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorStatus(int status)
        {
            string query = "SELECT funcionario.id '#', funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.cpf 'CPF', funcionario.telefone_Recado 'T. Recado', funcionario.data_nascimento 'Data Nascimento', funcionario.status 'Status' FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = " + status + " ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorSexoCidade(string cidade, string sexo)
        {
            string query = "SELECT funcionario.id '#', funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.cpf 'CPF', funcionario.telefone_Recado 'T. Recado', funcionario.data_nascimento 'Data Nascimento', funcionario.status 'Status' FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND funcionario.sexo = '" + sexo + "' AND funcionario.cidade = '" + cidade + "' ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorNome(string nome, bool somentePrimeiroNome)
        {
            string searchName = (somentePrimeiroNome ? "" : "%") + nome + "%";

            string query = "SELECT funcionario.id '#', funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.cpf 'CPF', funcionario.telefone_Recado 'T. Recado', funcionario.data_nascimento 'Data Nascimento', funcionario.status 'Status' FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND funcionario.nome LIKE '" + searchName + "' ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorCpf(string cpf)
        {
            string query = "SELECT funcionario.id '#', funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.cpf 'CPF', funcionario.telefone_Recado 'T. Recado', funcionario.data_nascimento 'Data Nascimento', funcionario.status 'Status' FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND funcionario.cpf = '" + cpf + "' ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorEstadoCivil(string estadoCivil)
        {
            string query = "SELECT funcionario.id '#', funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.cpf 'CPF', funcionario.telefone_Recado 'T. Recado', funcionario.data_nascimento 'Data Nascimento', funcionario.status 'Status' FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND funcionario.estado_civil = '" + estadoCivil + "' ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarPorDataAdmissao(DateTime inicio, DateTime fim)
        {
            string query = "SELECT funcionario.id '#', funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.cpf 'CPF', funcionario.telefone_Recado 'T. Recado', funcionario.data_nascimento 'Data Nascimento', funcionario.status 'Status' FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND funcionario.data_cadastro BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fim.ToString("yyyy-MM-dd") + "' ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable ConsultarSemFiltros()
        {
            string query = "SELECT funcionario.id '#', funcionario.nome 'Nome', cargo.nome 'Cargo', funcionario.cpf 'CPF', funcionario.telefone_Recado 'T. Recado', funcionario.data_nascimento 'Data Nascimento', funcionario.status 'Status' FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public bool ConsultaFuncionario(int id)
        {
            string query = "SELECT * FROM funcionario WHERE id=" + id;

            Conexao conexao = new Conexao();
            DataTable dt = conexao.RetornaDados(query);

            if (dt.Rows.Count > 0)
            {
                this.id = Convert.ToInt32(dt.Rows[0]["id"]);
                id_cargo = Convert.ToInt32(dt.Rows[0]["id_cargo"]);
                cpf = Convert.ToString(dt.Rows[0]["cpf"]);
                rg = Convert.ToString(dt.Rows[0]["rg"]);
                nome = Convert.ToString(dt.Rows[0]["nome"]);
                nome_social = Convert.ToString(dt.Rows[0]["nome_social"]);
                senha = Convert.ToString(dt.Rows[0]["senha"]);
                salario = Convert.ToDouble(dt.Rows[0]["salario"]);
                sexo = Convert.ToString(dt.Rows[0]["sexo"]);
                usuario = Convert.ToString(dt.Rows[0]["usuario"]);
                estado_civil = Convert.ToString(dt.Rows[0]["estado_civil"]);
                data_nascimento = Convert.ToDateTime(dt.Rows[0]["data_nascimento"]);
                tipo_acesso = Convert.ToInt32(dt.Rows[0]["tipo_acesso"]);
                telefone_celular = Convert.ToString(dt.Rows[0]["telefone_celular"]);
                telefone_recado = Convert.ToString(dt.Rows[0]["telefone_recado"]);
                telefone_residencial = Convert.ToString(dt.Rows[0]["telefone_residencial"]);
                endereco = Convert.ToString(dt.Rows[0]["endereco"]);
                cep = Convert.ToString(dt.Rows[0]["cep"]);
                numero = Convert.ToInt32(dt.Rows[0]["numero"]);
                complemento = Convert.ToString(dt.Rows[0]["complemento"]);
                bairro = Convert.ToString(dt.Rows[0]["bairro"]);
                cidade = Convert.ToString(dt.Rows[0]["cidade"]);
                estado = Convert.ToString(dt.Rows[0]["estado"]);
                email = Convert.ToString(dt.Rows[0]["email"]);
                foto = Convert.ToString(dt.Rows[0]["foto"]);
                data_cadastro = Convert.ToDateTime(dt.Rows[0]["data_cadastro"]);
                status = Convert.ToInt32(dt.Rows[0]["status"]);

                return true;
            }

            return false;
        }
        public int AtualizarFuncionario()
        {
            string query = string.Format("UPDATE funcionario SET id_cargo = {0}, cpf = '{1}', rg = '{2}', nome = '{3}', nome_social = '{4}', senha = '{5}', salario = {6}, sexo = '{7}', usuario = '{8}', estado_civil = '{9}', data_nascimento = '{10}', tipo_acesso = '{11}', telefone_celular = '{12}', telefone_recado = '{13}', telefone_residencial = '{14}', endereco = '{15}', numero = {16}, complemento = '{17}', bairro = '{18}', cidade = '{19}', estado = '{20}', email = '{21}', cep = '{22}', foto = '{23}', status = {24} WHERE id = {25};",
                id_cargo,
                cpf,
                rg,
                nome,
                nome_social,
                senha,
                salario.ToString().Replace(",", "."),
                sexo,
                usuario,
                estado_civil,
                data_nascimento.ToString("yyyy-MM-dd"),
                tipo_acesso,
                telefone_celular,
                telefone_recado,
                telefone_residencial,
                endereco,
                numero,
                complemento,
                bairro,
                cidade,
                estado,
                email,
                cep,
                foto,
                status,
                id
            );

            Conexao conexao = new Conexao();
            return conexao.ExecutaQuery(query);
        }

        public DataTable CarregarCidades()
        {
            string query = "SELECT DISTINCT cidade FROM funcionario ORDER BY cidade;"; // DISTINCT = Evita repetições, tipo: Piracicaba, Piracicaba, Piracicaba, Sorocaba.

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public static int Excluir(int codigo)
        {
            string query = "UPDATE funcionario SET status = 0 WHERE id=" + codigo + ";";

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
            string query = "SELECT funcionario.cpf, funcionario.nome, cargo.nome 'id_cargo', funcionario.data_nascimento, funcionario.cidade, funcionario.sexo, funcionario.data_cadastro FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND funcionario.sexo = '" + sexo + "' ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable RelatorioPorStatus(int status)
        {
            string query = "SELECT funcionario.cpf, funcionario.nome, cargo.nome 'id_cargo', funcionario.data_nascimento, funcionario.cidade, funcionario.sexo, funcionario.data_cadastro FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = " + status + " ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
        public DataTable RelatorioPorCidade(string cidade)
        {
            string query = "SELECT funcionario.cpf, funcionario.nome, cargo.nome 'id_cargo', funcionario.data_nascimento, funcionario.cidade, funcionario.sexo, funcionario.data_cadastro FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND funcionario.cidade = '" + cidade + "' ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable RelatorioPorDataAdmissao(DateTime inicio, DateTime fim)
        {
            string query = "SELECT funcionario.cpf, funcionario.nome, cargo.nome 'id_cargo', funcionario.data_nascimento, funcionario.cidade, funcionario.sexo, funcionario.data_cadastro FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND funcionario.data_cadastro BETWEEN '" + inicio.ToString("yyyy-MM-dd") + "' AND '" + fim.ToString("yyyy-MM-dd") + "' ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable RelatorioPorCargo(int idCargo)
        {
            string query = "SELECT funcionario.cpf, funcionario.nome, cargo.nome 'id_cargo', funcionario.data_nascimento, funcionario.cidade, funcionario.sexo, funcionario.data_cadastro FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND funcionario.id_cargo = " + idCargo + " ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable RelatorioPorMesAniversario(int mes)
        {
            string query = "SELECT funcionario.cpf, funcionario.nome, cargo.nome 'id_cargo', funcionario.data_nascimento, funcionario.cidade, funcionario.sexo, funcionario.data_cadastro FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND MONTH(funcionario.data_nascimento) = " + mes + " ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        public DataTable RelatorioPorIdade(int minima, int maxima)
        {
            string query = "SELECT funcionario.cpf, funcionario.nome, cargo.nome 'id_cargo', funcionario.data_nascimento, funcionario.cidade, funcionario.sexo, funcionario.data_cadastro FROM funcionario INNER JOIN cargo ON cargo.id = funcionario.id_cargo WHERE funcionario.status = 1 AND TIMESTAMPDIFF(YEAR, funcionario.data_nascimento, NOW()) BETWEEN " + minima+ " AND " + maxima + " ORDER BY funcionario.nome;";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }

        //VENDAS
        public DataTable BuscarFuncionario()
        {
            string query = "SELECT id, nome FROM funcionario WHERE status = 1 ORDER BY nome";

            Conexao conexao = new Conexao();
            return conexao.RetornaDados(query);
        }
    }
}

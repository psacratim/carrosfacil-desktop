using System;
using System.Data;
using MySql.Data.MySqlClient;
using CarrosFacil.Entities;
using CarrosFacil.Database;

namespace CarrosFacil.Repositories
{
    public class CargoRepositorio
    {
        public int Cadastrar(Cargo cargo)
        {
            string sql = "INSERT INTO cargo (nome, observacao, data_cadastro, status) VALUES (@nome, @obs, NOW(), 1);";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@nome", cargo.Nome),
                new MySqlParameter("@obs", cargo.Observacao)
            };

            return DbConnection.ExecuteNonQuery(sql, parameters);
        }

        public int Atualizar(Cargo cargo)
        {
            string sql = "UPDATE cargo SET nome = @nome, observacao = @obs, status = @status WHERE id = @id;";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@nome", cargo.Nome),
                new MySqlParameter("@obs", cargo.Observacao),
                new MySqlParameter("@status", cargo.Status),
                new MySqlParameter("@id", cargo.Id)
            };

            return DbConnection.ExecuteNonQuery(sql, parameters);
        }

        public int Excluir(int id)
        {
            string sql = "UPDATE cargo SET status = 0 WHERE id = @id;";
            var parameters = new MySqlParameter[] { new MySqlParameter("@id", id) };

            return DbConnection.ExecuteNonQuery(sql, parameters);
        }

        public Cargo ObterPorId(int id)
        {
            string sql = "SELECT * FROM cargo WHERE id = @id;";
            var parameters = new MySqlParameter[] { new MySqlParameter("@id", id) };

            DataTable dt = DbConnection.ExecuteSelect(sql, parameters);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                return new Cargo
                {
                    Id = Convert.ToInt32(row["id"]),
                    Nome = row["nome"].ToString(),
                    Observacao = row["observacao"].ToString(),
                    DataCadastro = Convert.ToDateTime(row["data_cadastro"]),
                    Status = Convert.ToInt32(row["status"])
                };
            }
            return null;
        }

        public DataTable Consultar(Filter[] filters)
        {
            var builder = new QueryBuilder("SELECT id '#', nome 'Nome', data_cadastro 'Data Cadastro', status 'Status' FROM cargo")
                .AddFilters(filters)
                .Build();

            return DbConnection.ExecuteSelect(builder.sql, builder.parameters);
        }
    }
}
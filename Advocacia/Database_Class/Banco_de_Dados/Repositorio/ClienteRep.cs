using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Database_Class.Classes;

namespace Database_Class.Banco_de_Dados.Repositorio
{
    public class ClienteRep
    {
        public List<Cliente> GetAll()
        {
            List<Cliente> lista;
            string sql = @"SELECT c.idCliente as Id,
                                  c.Nome as Nome,
                                  c.DataNascimento as DataNascimento,
                                  c.Telefone as Telefone,
                                  c.Cpf as Cpf,
                                  c.Profissao as Profissao,
                                  c.Endereco as Endereco,
                                  c.Rg as Rg,
                                  c.NomePai as NomePai,
                                  c.NomeMae as NomeMae,
                                  c.Email as Email,
                                  c.EstadoCivil as EstadoCivil
                             FROM Cliente as c";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    lista = db.Query<Cliente>(sql).ToList();
                }
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }

        public int Insert(Cliente cliente)
        {
            int Id;
            string sql = @"INSERT INTO Cliente
                                       (Nome,
                                        DataNascimento,
                                        Telefone,
                                        Cpf,
                                        Profissao,
                                        Endereco,
                                        Rg,
                                        NomePai,
                                        NomeMae,
                                        Email,
                                        EstadoCivil)
                                 VALUES
                                       (@Nome,
                                        @DataNascimento,
                                        @Telefone,
                                        @Cpf,
                                        @Profissao,
                                        @Endereco,
                                        @Rg,
                                        @NomePai,
                                        @NomeMae,
                                        @Email,
                                        @EstadoCivil)
		                                SELECT SCOPE_IDENTITY()";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    Id = db.Query<int>(sql, cliente).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                Id = 0;
            }

            return Id;
        }

        public bool Update(Cliente cliente)
        {
            bool result;
            string sql = @"UPDATE Cliente 
                                    SET Nome = @Nome,
                                        DataNascimento = @DataNascimento,
                                        Telefone = @Telefone,
                                        Cpf = @Cpf,
                                        Profissao = @Profissao,
                                        Endereco = @Endereco,
                                        Rg = @Rg,
                                        NomePai = @NomePai,
                                        NomeMae = @NomeMae,
                                        Email = @Email,
                                        EstadoCivil = @EstadoCivil
                                    WHERE idCliente = @Id";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    result = db.Execute(sql, cliente) == 1;
                }
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        public bool Delete(int id)
        {
            bool result;
            string sql = @"DELETE FROM Cliente 
                           WHERE idCliente = @Id";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    result = db.Execute(sql, new { Id = id }) == 1;
                }
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }
    }
}

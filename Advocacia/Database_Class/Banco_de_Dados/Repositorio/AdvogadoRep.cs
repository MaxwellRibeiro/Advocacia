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
    public class AdvogadoRep
    {
        public List<Advogado> GetAll()
        {
            List<Advogado> lista;
            string sql = @"SELECT a.idAdvocado as Id,
                                  a.Nome as Nome,
                                  a.OAB as OAB,
                                  a.Cpf as Cpf,
                                  a.Telefone as Telefone,
                                  a.Email as Email
                             FROM Advogado as a";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    lista = db.Query<Advogado>(sql).ToList();
                }
            }
            catch (Exception)
            {
                lista = null;
            }


            return lista;
        }

        public int Insert(Advogado advogado)
        {
            int Id;
            string sql = @"INSERT INTO Advogado
                                       (Nome,
                                        OAB,
                                        Cpf,
                                        Telefone,
                                        Email)
                                 VALUES
                                       (@Nome,
                                        @OAB,
                                        @Cpf,
                                        @Telefone,
                                        @Email); 
                           SELECT SCOPE_IDENTITY()";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    Id = db.Query<int>(sql, advogado).FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Id = 0;
            }

            return Id;
        }

        public bool Update(Advogado advogado)
        {
            bool result;
            string sql = @"UPDATE Advogado 
                           SET Nome = @Nome,
                               OAB = @OAB,
                               Cpf = @Cpf,
                               Telefone = @Telefone,
                               Email = @Email
                           WHERE idAdvocado = @Id";


            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    result = db.Execute(sql, advogado) == 1;
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
            string sql = @"DELETE FROM Advogado 
                           WHERE idAdvocado = @Id";

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

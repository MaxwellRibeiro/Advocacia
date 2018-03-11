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
    public class AndamentoProcessualRep
    {
        public List<AndamentoProcessual> GetAll()
        {
            List<AndamentoProcessual> lista;
            string sql = @"SELECT ap.idAndamentoProcessual as Id, 
                                  ap.Situacao as Situacao
                             FROM AndamentoProcessual as ap";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    lista = db.Query<AndamentoProcessual>(sql).ToList();
                }
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }

        public int Insert(AndamentoProcessual andamentoProcessual)
        {
            int Id;
            string sql = @"INSERT INTO AndamentoProcessual
                                       (Situacao)
                                  VALUES
                                       (@Situacao); 
                                  SELECT SCOPE_IDENTITY()";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    Id = db.Query<int>(sql, andamentoProcessual).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                Id = 0;
            }

            return Id;
        }

        public bool Update(AndamentoProcessual andamentoProcessual)
        {
            bool result;

            string sql = @"UPDATE AndamentoProcessual 
                           SET Situacao = @Situacao
                           WHERE idAndamentoProcessual = @Id";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    result = db.Execute(sql, andamentoProcessual) == 1;
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
            string sql = @"DELETE FROM AndamentoProcessual 
                           WHERE idAndamentoProcessual = @Id";

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

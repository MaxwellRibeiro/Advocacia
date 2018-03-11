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
    public class ParametroRep
    {
        public List<Parametro> GetAll()
        {
            List<Parametro> lista;
            string sql = @"SELECT p.idParametro as Id,
                                  p.Nome as Nome,
                                  p.Byte as Byte
                             FROM Parametro as p";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    lista = db.Query<Parametro>(sql).ToList();
                }
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }

        public bool Update(Parametro parametro)
        {
            bool result;
            string sql = @"UPDATE Parametro 
                           SET Nome = @Nome,
                               Byte = @Byte
                           WHERE idParametro = @Id";


            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    result = db.Execute(sql, parametro) == 1;
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

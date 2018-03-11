using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using Database_Class.Classes;

namespace Database_Class.Banco_de_Dados.Repositorio
{
    public class ComarcaRep
    {
        public List<Comarca> GetAll()
        {
            List<Comarca> lista;
            string sql = @"SELECT c.idComarca as Id,
	                              c.Nome as Nome,
                                  c.Vara as Vara,
	                              c.Telefone as Telefone,
	                              c.Endereco as Endereco
                            FROM Comarca as c";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    lista = db.Query<Comarca>(sql).ToList();
                }
            }
            catch (Exception)
            {
                lista = null;
            }


            return lista;
        }

        public int Insert(Comarca comarca)
        {
            int Id;
            string sql = @"INSERT INTO Comarca
                                  (Nome,
                                   Vara,
                                   Telefone,
                                   Endereco)
                           VALUES
                                  (@Nome,
                                   @Vara,
                                   @Telefone,
                                   @Endereco); 
                           SELECT SCOPE_IDENTITY()";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    Id = db.Query<int>(sql, comarca).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                Id = 0;
            }
                  
            return Id;
        }

        public bool Update(Comarca comarca)
        {
            bool result;
            string sql = @"UPDATE Comarca 
                           SET Nome = @Nome,
                               Vara = @Vara,
                               Telefone = @Telefone,
                               Endereco = @Endereco
                           WHERE idComarca = @Id";
 

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    result = db.Execute(sql, comarca) == 1;
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
            string sql = @"DELETE FROM Comarca 
                           WHERE idComarca = @Id";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    result = db.Execute(sql, new {Id = id}) == 1;
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

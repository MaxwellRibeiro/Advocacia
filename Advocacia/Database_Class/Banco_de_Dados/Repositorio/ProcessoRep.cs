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
    public class ProcessoRep
    {
        public List<Processo> GetAll()
        {
            List<Processo> lista;
            string sql = @"SELECT p.idProcesso as Id,
	                              c.idComarca as IdComarca,
	                              c.Nome as NomeComarca,
	                              p.Numero as Numero,
	                              cl.idCliente as IdCliente,
	                              cl.Nome as NomeCliente,
	                              a.idAdvocado as IdAdvogado,
	                              a.Nome as NomeAdvogado
	                       FROM Processo as p
	                          INNER JOIN Comarca as c ON c.idComarca = p.idComarca
	                          INNER JOIN Cliente as cl ON cl.idCliente = p.idCliente
	                          INNER JOIN Advogado as a ON a.idAdvocado = p.idAdvogado";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    lista = db.Query<Processo>(sql).ToList();
                }
            }
            catch (Exception)
            {
                lista = null;
            }


            return lista;
        }

        public int Insert(Processo processo)
        {
            int Id;
            string sql = @"INSERT INTO Processo
                                       (idComarca,
                                        Numero,
                                        idCliente,
                                        idAdvogado)
                                 VALUES
                                       (@IdComarca,
                                        @Numero,
                                        @IdCliente,
                                        @IdAdvogado); 
                           SELECT SCOPE_IDENTITY()";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    Id = db.Query<int>(sql, processo).FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Id = 0;
            }

            return Id;
        }

        public bool Update(Processo processo)
        {
            bool result;
            string sql = @"UPDATE Processo 
                           SET idComarca = @IdComarca,
                               Numero = @Numero,
                               idCliente = @IdCliente,
                               idAdvogado = @IdAdvogado
                           WHERE idProcesso = @Id";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    result = db.Execute(sql, processo) == 1;
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
            string sql = @"DELETE FROM Processo 
                           WHERE idProcesso = @Id";

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

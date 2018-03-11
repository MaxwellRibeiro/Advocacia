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
    class MovimentacaoRep
    {
        public List<Movimentacao> GetAll()
        {
            List<Movimentacao> lista;
            string sql = @"SELECT m.idMovimentacao as Id,
	                              m.Data as Data,
	                              p.idProcesso as IdProcesso,
	                              p.Numero as NumeroProcesso,
	                              ap.idAndamentoProcessual as IdAndamentoProcessual,
	                              ap.Situacao as SituacaoAndamentoProcessual,
	                              m.Observacao as Observacao
                          FROM Movimentacao as m
                            INNER JOIN Processo as p ON p.idProcesso = m.idProcesso
                            INNER JOIN AndamentoProcessual as ap ON ap.idAndamentoProcessual = m.idAndamentoProcessual";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    lista = db.Query<Movimentacao>(sql).ToList();
                }
            }
            catch (Exception)
            {
                lista = null;
            }

            return lista;
        }

        public int Insert(Movimentacao movimentacao)
        {
            int Id;
            string sql = @"INSERT INTO Movimentacao
                                       (Data,
                                        idProcesso,
                                        idAndamentoProcessual,
                                        Observacao)
                                  VALUES
                                       (@Data,
                                        @IdProcesso,
                                        @IdAndamentoProcessual,
                                        @Observacao); 
                                  SELECT SCOPE_IDENTITY()";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    Id = db.Query<int>(sql, movimentacao).FirstOrDefault();
                }
            }
            catch (Exception e)
            {
                Id = 0;
            }

            return Id;
        }

        public bool Update(Movimentacao movimentacao)
        {
            bool result;
            string sql = @"UPDATE Movimentacao 
                           SET Data = @Data,
                               idProcesso = @IdProcesso,
                               idAndamentoProcessual = @IdAndamentoProcessual,
                               Observacao = @Observacao
                           WHERE idMovimentacao = @Id";


            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    result = db.Execute(sql, movimentacao) == 1;
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
            string sql = @"DELETE FROM Movimentacao 
                           WHERE idMovimentacao = @Id";

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

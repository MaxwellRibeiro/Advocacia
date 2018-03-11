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
    public class LoginRep
    {
        public List<Login> GetAll()
        {
            List<Login> lista;
            string sql = @"SELECT l.idLogin as Id,
                                  l.Usuario as Usuario,
                                  l.Senha as Senha,
                                  l.DicaSenha as DicaSenha
                             FROM Login as l";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    lista = db.Query<Login>(sql).ToList();
                }
            }
            catch (Exception)
            {
                lista = null;
            }


            return lista;
        }

        public int Insert(Login login)
        {
            int Id;
            string sql = @"INSERT INTO Login
                                  (Usuario,
                                   Senha,
                                   DicaSenha)
                           VALUES
                                  (@Usuario,
                                   @Senha,
                                   @DicaSenha); 
                           SELECT SCOPE_IDENTITY()";

            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    Id = db.Query<int>(sql, login).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                Id = 0;
            }

            return Id;
        }

        public bool Update(Login login)
        {
            bool result;
            string sql = @"UPDATE Login 
                           SET Usuario = @Usuario,
                               Senha = @Senha,
                               DicaSenha = @DicaSenha
                           WHERE idLogin = @Id";


            try
            {
                using (
               IDbConnection db =
                   new SqlConnection(ConfigurationManager.ConnectionStrings["Contexto"].ConnectionString))
                {
                    result = db.Execute(sql, login) == 1;
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
            string sql = @"DELETE FROM Login 
                           WHERE idLogin = @Id";

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

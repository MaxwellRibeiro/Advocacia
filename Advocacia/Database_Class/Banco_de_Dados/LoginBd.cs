using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Class.Banco_de_Dados.Repositorio;
using Database_Class.Classes;

namespace Database_Class.Banco_de_Dados
{
    public class LoginBd
    {
        readonly LoginRep _repositorio = new LoginRep();

        public async Task<List<Login>> GetAll()
        {
            List<Login> lista = _repositorio.GetAll();

            return lista;
        }

        public async Task<Login> Insert(Login login)
        {
            int Id = _repositorio.Insert(login);
            login.Id = Id;

            return login;
        }

        public async Task<bool> Update(Login login)
        {
            bool result = _repositorio.Update(login);

            return result;
        }

        public async Task<bool> Delete(int id)
        {
            bool result = _repositorio.Delete(id);

            return result;
        }
    }
}

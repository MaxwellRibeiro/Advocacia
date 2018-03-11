using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Class.Banco_de_Dados.Repositorio;
using Database_Class.Classes;

namespace Database_Class.Banco_de_Dados
{
    public class ClienteBd
    {
        readonly ClienteRep _repositorio = new ClienteRep();

        public async Task<List<Cliente>> GetAll()
        {
            List<Cliente> lista = _repositorio.GetAll();

            return lista;
        }

        public async Task<Cliente> Insert(Cliente cliente)
        {
            int Id = _repositorio.Insert(cliente);
            cliente.Id = Id;

            return cliente;
        }

        public async Task<bool> Update(Cliente cliente)
        {
            bool result = _repositorio.Update(cliente);

            return result;
        }

        public async Task<bool> Delete(int id)
        {
            bool result = _repositorio.Delete(id);

            return result;
        }
    }
}

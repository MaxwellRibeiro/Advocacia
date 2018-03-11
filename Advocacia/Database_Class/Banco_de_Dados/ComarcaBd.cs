using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Class.Banco_de_Dados.Repositorio;
using Database_Class.Classes;

namespace Database_Class.Banco_de_Dados
{
    public class ComarcaBd
    {
        readonly ComarcaRep _repositorio = new ComarcaRep();

        public async Task<List<Comarca>> GetAll()
        {
            List<Comarca> lista = _repositorio.GetAll();

            return lista;
        }

        public async Task<Comarca> Insert(Comarca comarca)
        {
            int Id =  _repositorio.Insert(comarca);
            comarca.Id = Id;

            return comarca;
        }

        public async Task<bool> Update(Comarca comarca)
        {
            bool result = _repositorio.Update(comarca);

            return result;
        }

        public async Task<bool> Delete(int id)
        {
            bool result = _repositorio.Delete(id);

            return result;
        }
    }
}

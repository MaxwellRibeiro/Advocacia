using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Class.Banco_de_Dados.Repositorio;
using Database_Class.Classes;

namespace Database_Class.Banco_de_Dados
{
    public class AdvogadoBd
    {
        readonly AdvogadoRep _repositorio = new AdvogadoRep();

        public async Task<List<Advogado>> GetAll()
        {
            List<Advogado> lista = _repositorio.GetAll();

            return lista;
        }

        public async Task<Advogado> Insert(Advogado advogado)
        {
            int Id = _repositorio.Insert(advogado);
            advogado.Id = Id;

            return advogado;
        }

        public async Task<bool> Update(Advogado advogado)
        {
            bool result = _repositorio.Update(advogado);

            return result;
        }

        public async Task<bool> Delete(int id)
        {
            bool result = _repositorio.Delete(id);

            return result;
        }
    }
}

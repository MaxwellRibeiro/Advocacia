using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Class.Banco_de_Dados.Repositorio;
using Database_Class.Classes;

namespace Database_Class.Banco_de_Dados
{
    public class AndamentoProcessualBd
    {
        readonly AndamentoProcessualRep _repositorio = new AndamentoProcessualRep();

        public async Task<List<AndamentoProcessual>> GetAll()
        {
            List<AndamentoProcessual> lista = _repositorio.GetAll();

            return lista;
        }

        public async Task<AndamentoProcessual> Insert(AndamentoProcessual andamentoProcessual)
        {
            int Id = _repositorio.Insert(andamentoProcessual);
            andamentoProcessual.Id = Id;

            return andamentoProcessual;
        }

        public async Task<bool> Update(AndamentoProcessual andamentoProcessual)
        {
            bool result = _repositorio.Update(andamentoProcessual);

            return result;
        }

        public async Task<bool> Delete(int id)
        {
            bool result = _repositorio.Delete(id);

            return result;
        }
    }
}

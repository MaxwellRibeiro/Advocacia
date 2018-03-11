using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Class.Banco_de_Dados.Repositorio;
using Database_Class.Classes;

namespace Database_Class.Banco_de_Dados
{
    public class ProcessoBd
    {
        readonly ProcessoRep _repositorio = new ProcessoRep();

        public async Task<List<Processo>> GetAll()
        {
            List<Processo> lista =  _repositorio.GetAll();

            return lista;
        }

        public async Task<Processo> Insert(Processo processo)
        {
            int Id = _repositorio.Insert(processo);
            processo.Id = Id;

            return processo;
        }

        public async Task<bool> Update(Processo processo)
        {
            bool result = _repositorio.Update(processo);

            return result;
        }

        public async Task<bool> Delete(int id)
        {
            bool result = _repositorio.Delete(id);

            return result;
        }
    }
}

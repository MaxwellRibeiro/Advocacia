using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Class.Banco_de_Dados.Repositorio;
using Database_Class.Classes;

namespace Database_Class.Banco_de_Dados
{
    public class MovimentacaoBd
    {
        readonly MovimentacaoRep _repositorio = new MovimentacaoRep();

        public async Task<List<Movimentacao>> GetAll()
        {
            List<Movimentacao> lista = _repositorio.GetAll();

            return lista;
        }

        public async Task<Movimentacao> Insert(Movimentacao movimentacao)
        {
            int Id = _repositorio.Insert(movimentacao);
            movimentacao.Id = Id;

            return movimentacao;
        }

        public async Task<bool> Update(Movimentacao movimentacao)
        {
            bool result = _repositorio.Update(movimentacao);

            return result;
        }

        public async Task<bool> Delete(int id)
        {
            bool result = _repositorio.Delete(id);

            return result;
        }
    }
}

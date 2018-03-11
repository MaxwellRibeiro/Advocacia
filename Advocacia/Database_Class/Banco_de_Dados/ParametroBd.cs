using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Class.Banco_de_Dados.Repositorio;
using Database_Class.Classes;

namespace Database_Class.Banco_de_Dados
{
    public class ParametroBd
    {
        readonly ParametroRep _repositorio = new ParametroRep();

        public async Task<List<Parametro>> GetAll()
        {
            List<Parametro> lista = _repositorio.GetAll();

            return lista;
        }

        public async Task<bool> Update(List<Parametro> parametros)
        {
            bool result = true;
            foreach (var parametro in parametros)
            {
                if (!_repositorio.Update(parametro))
                {
                    result = false;
                }
            }

            return result;
        }

    }
}

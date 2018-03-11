using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Class.Classes
{
    public class Movimentacao
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string DataByGrid { get; set; }

        public int IdProcesso { get; set; }
        public string NumeroProcesso { get; set; }

        public int IdAndamentoProcessual { get; set; }
        public string SituacaoAndamentoProcessual { get; set; }

        public string Observacao { get; set; }
    }
}

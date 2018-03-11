using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database_Class.Enum;

namespace Database_Class.Classes
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string DataNascimentoByGrid { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string Profissao { get; set; }
        public string Endereco { get; set; }
        public string Rg { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string Email { get; set; }
        public EnumByCliente.EstadoCivil EstadoCivil { get; set; } 
    }
}

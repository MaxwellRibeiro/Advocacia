using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Class.Classes
{
    public class Processo
    {
        public int Id { get; set; }

        public int IdComarca { get; set; }
        public string NomeComarca { get; set; }

        public string Numero { get; set; }

        public int IdCliente { get; set; }
        public string NomeCliente { get; set; }

        public int IdAdvogado { get; set; }
        public string NomeAdvogado { get; set; }
    }
}

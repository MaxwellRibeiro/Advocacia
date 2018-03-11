using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_Class.Enum
{
    public static class EnumByCliente
    {
        public enum EstadoCivil
        {
            [Description("Não Informar")]
            SemInformacao = 0,
            [Description("Solteiro(a)")]
            Solteiro = 1,
            [Description("Casado(a)")]
            Casado = 2,
            [Description("Viovo(a)")]
            Viovo = 3,
            [Description("Divorciado(a)")]
            Divorciado = 4,
            [Description("União Estavel")]
            UniaoEstavel = 5
        }
    }
}

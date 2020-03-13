using DTO.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNaruto.Models
{
    public class KageViewModel
    {
        public string Nome { get; set; }
        public Cla Cla { get; set; }
        public Vilas Vilas { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }

    }
}

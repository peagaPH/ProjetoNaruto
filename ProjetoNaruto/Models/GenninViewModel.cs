using DTO;
using DTO.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNaruto.Models
{
    public class GenninViewModel
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
        public Cla Cla { get; set; }
        public Vilas Vilas { get; set; }
        public EquipeDTO Equipe { get; set; }
    }
}

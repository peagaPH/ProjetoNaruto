using DTO.Enum;
using System;

namespace DTO
{
    public class GenninDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Idade { get; set; }
        public Cla Cla { get; set; }
        public Vilas Vilas { get; set; }
        public EquipeDTO Equipe { get; set; }
    }
}

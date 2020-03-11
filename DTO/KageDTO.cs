using DTO.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class KageDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public Vilas Vilas { get; set; }
        public Cla Cla { get; set; }
        public string Senha { get; set; }

    }
}

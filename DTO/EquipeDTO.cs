using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class EquipeDTO
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public List<GenninDTO> Gennin { get; set; }
        public JounninDTO Jounnin { get; set; }


        public EquipeDTO()
        {
            Gennin = new List<GenninDTO>();
        }
    }
}

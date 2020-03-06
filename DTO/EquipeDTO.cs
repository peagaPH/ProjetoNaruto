using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class EquipeDTO
    {
        public int ID { get; set; }
        public List<GenninDTO> Gennin { get; set; }
        public List<JounninDTO> Jounnin { get; set; }


        public EquipeDTO()
        {
            Gennin = new List<GenninDTO>();
            Jounnin = new List<JounninDTO>();
        }
    }
}

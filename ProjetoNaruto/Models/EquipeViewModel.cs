using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoNaruto.Models
{
    public class EquipeViewModel
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public List<GenninDTO> Gennin { get; set; }
        public JounninDTO Jounnin{ get; set; }



    }
}

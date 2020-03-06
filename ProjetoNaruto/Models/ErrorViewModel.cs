using System;

namespace ProjetoNaruto.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        //TESTE COMMIT
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

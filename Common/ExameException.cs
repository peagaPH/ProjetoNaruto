using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    [Serializable]
    public class ExameException : Exception
    {
        public List<Error> Errors { get; private set; }

        public ExameException(List<Error> errors)
        {
            this.Errors = errors;
        }

        //Daqui pra baixo é apenas código que o proprio VS gera 
        //pra gente poder utilizar esta exceção 
        public ExameException(string message) : base(message) { }
        public ExameException(string message, Exception inner) : base(message, inner) { }
        protected ExameException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

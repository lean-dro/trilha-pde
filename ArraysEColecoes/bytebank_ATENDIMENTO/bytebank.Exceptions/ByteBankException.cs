using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Exceptions
{

    [Serializable]
    public class ByteBankException : Exception
    {
        public ByteBankException() { }
        public ByteBankException(string message) : base("Aconteceu uma Exceção -> "+ message) { }
        public ByteBankException(string message, Exception inner) : base(message, inner) { }
        protected ByteBankException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

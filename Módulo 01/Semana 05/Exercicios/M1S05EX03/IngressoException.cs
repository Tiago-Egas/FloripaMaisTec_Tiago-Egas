using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M1S05EX03
{
    public class IngressoException : Exception
    {
        public IngressoException(String msg)
            : base(msg) { }

        public IngressoException(String msg, Exception causa)
            : base(msg, causa) { }

        public IngressoException() { }
    }
}

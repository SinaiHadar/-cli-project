using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace sini
{
    public class languagexception : Exception
    {
        public languagexception() :base("Error: --language is required when --createRsp is not specified.") {}
    }
}

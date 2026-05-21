using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haopan.Entity
{
    public class ParamDefineException : Exception
    {
        public string ErrorMessage { get; }

        public ParamDefineException(string errorMsg) : base(errorMsg)
        {
            this.ErrorMessage = errorMsg;
        }
    }
}

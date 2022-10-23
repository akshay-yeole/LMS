using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Exceptions
{
    public class LMSExcep : ApplicationException
    {
        LMSExcep() { }
        LMSExcep(string message) : base(message) { }
    }
}

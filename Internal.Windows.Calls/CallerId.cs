using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls
{
    public enum CallerId : int
    {
        Unavailable = 0,
        Blocked = 1,
        Valid = 2,
        Ambiguous = 3
    }
}

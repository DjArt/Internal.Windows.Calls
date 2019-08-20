using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls
{
    public enum CallActionByExternalDevice : uint
    {
        None = 0,
        Dialed = 1,
        Accepted = 2,
    }
}

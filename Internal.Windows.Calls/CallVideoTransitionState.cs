using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls
{
    public enum CallVideoTransitionState : uint
    {
        Idle = 0,
        IncomingAdd = 1,
        OutgoingAdd = 2,
        OutgoingDrop = 3
    }
}

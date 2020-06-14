using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls
{
    public enum CallVideoFlags : uint
    {
        None = 0,
        Transmit = 1,
        Receive = 2,
        Paused = 4,
        TemporarilyUnavailable = 8
    }
}
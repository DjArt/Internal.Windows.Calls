using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls
{
    public enum CallStateReason : int
    {
        Other = 0,
        Busy = 1,
        Ended = 4,
        NetworkCongestion = 9,
        Dropped = 10,
        CallBarred = 11,
        FDNRestricted = 12,
        ServiceOff = 16,
        RoamRestricted = 24,
        CallUpgradeInitiated = 25,
        VideoCallingOff = 26,
    }
}

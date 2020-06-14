using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls
{
    public enum CallUpgradeState : int
    {
        None = 0,
        NeverPossible = 1,
        QueryingOtherPartyAvailability = 2,
        OtherPartyUnavailable = 3,
        QueryingDataConnectivity = 4,
        DataConnectivityUnavailable = 5,
        OtherPartyAndDataConnectivityAvailable = 6,
        UpgradeAvailable = 7,
        QueryingRemotePartySeamlessCapability = 8,
        NonSeamlessUpgradeWaitingForUser = 9,
        UpgradeInitiated = 10,
        UpgradeComplete = 11,
        AppQueryingRemotePartySeamlessCapability = 12,
    }
}

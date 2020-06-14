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
        NoAnswer = 2,
        BadAddress = 3,
        Ended = 4,
        InvalidSimCard = 5,
        NetworkServiceNotAvailable = 6,
        EmergencyOnly = 7,
        Error = 8,
        NetworkCongestion = 9,
        Dropped = 10,
        CallBarred = 11,
        FDNRestricted = 12,
        TransferComplete = 13,
        SimCallBlocked = 14,
        SimCallModifiedToUssd = 15,
        ServiceOff = 16,
        Rejected = 17,
        DialError = 18,
        CallMerged = 19,
        RemoteHold = 20,
        SimSecurityNeeded = 21,
        Injection = 22,
        Network3GPP2Reorder = 23,
        RoamRestricted = 24,
        CallUpgradeInitiated = 25,
        VideoCallingOff = 26,
        HandoverMerged = 27,
        WifiCallingUpsellNeeded = 28,
        Count = 29
    }
}

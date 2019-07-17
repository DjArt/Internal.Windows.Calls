using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls.PhoneOm
{
    [Flags]
    internal enum PH_CALL_INFO_field_1480 : ulong
    {
        v1                          = 0x1,
        v2                          = 0x2,
        v4                          = 0x4,
        v8                          = 0x8,
        v10                         = 0x10,
        v20                         = 0x20,
        v40                         = 0x40,
        v80                         = 0x80,
        field_98C                   = 0x200,
        field_998                   = 0x400,
        CallStartTime               = 0x800,
        CallEndTime                 = 0x1000,
        LastFlashedTime             = 0x2000,
        CallState                   = 0x4000,
        CallStateReason             = 0x8000,
        CallDirection               = 0x10000,
        field_BD8                   = 0x40000,
        field_BDC                   = 0x80000,
        CallTransport               = 0x100000,
        PhoneLineID                 = 0x200000,
        CallID                      = 0x400000,
        ConferenceID                = 0x800000,
        field_CAC                   = 0x1000000,
        field_C08                   = 0x2000000,
        v4000000                    = 0x4000000,
        field_BF0                   = 0x8000000,
        v10000000                   = 0x10000000,
        v20000000                   = 0x20000000,
        v40000000                   = 0x40000000,
        CallUpgradeState            = 0x100000000,
        AudioQuality                = 0x800000000,
        v1000000000                 = 0x1000000000,
        VideoCallContext            = 0x2000000000,
        VideoFlags1                 = 0x4000000000,
        VideoFlags2                 = 0x8000000000,
        VideoFlags4                 = 0x10000000000,
        VideoTransitionState        = 0x20000000000,
        VideoTransitionError        = 0x40000000000,
        RemotePartyIsVideoCapable   = 0x80000000000,
        VideoConferenceContext      = 0x100000000000,
        VideoConferenceState        = 0x200000000000,
        AudioFlags                  = 0x400000000000,
        VideoFlags8                 = 0x800000000000,
        v2000000000000              = 0x2000000000000,
        field_CB4                   = 0x4000000000000,
        field_1478                  = 0x8000000000000,

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls
{
    public enum CallVerbs : uint
    {
        Dial = 1,
        End = 2,
        DropActiveAcceptHeld = 4,
        Hold = 8,
        Unhold = 16,
        Swap = 32,
        Private = 64,
        Conference = 128,
        Flash = 256,
        RejectIncoming = 512,
        AcceptIncoming = 1024,
        SendDtmf = 2048,
        StartDtmf = 4096,
        StopDtmf = 8192,
        DropFromConference = 16384,
        DisableLocalVideo = 0xffff8000,
        EnableLocalVideo = 0x10000,
        AddVideo = 0x20000,
        DropVideo = 0x40000,
        AcceptIncomingVideo = 0x80000,
        RejectIncomingVideo = 0x100000,
        SetVideoPaused = 0x200000,
        StartRecording = 0x400000,
        PauseRecording = 0x800000,
        StopRecording = 0x1000000,
        ExplicitCallTransfer = 0x2000000,
        None = 0,
        All = 0x1fffff,
        Count = 26,
    }
}

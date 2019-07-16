using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls.PhoneOm
{
    [StructLayout(LayoutKind.Explicit, Size = 0x19c4)]
    internal unsafe struct PH_CALL_INFO
    {
        [FieldOffset(0x0)]
        public long field_0;
        [FieldOffset(0x8)]
        public long field_8;
        /// <summary>
        /// pointer?
        /// </summary>
        [FieldOffset(0x10)]
        public long field_10;
        [FieldOffset(0x18)]
        public byte* gap_18;
        /// <summary>
        /// Probably its number, may be a string
        /// </summary>
        [FieldOffset(0xA0)]
        public char* Number;
        [FieldOffset(0xa8)]
        public byte* gap_A8;
        [FieldOffset(0x120)]
        public char* field_120;
        [FieldOffset(0x520)]
        public long field_520;
        [FieldOffset(0x528)]
        public byte* gap_528;
        [FieldOffset(0x570)]
        public short field_570;
        [FieldOffset(0x572)]
        public byte* gap_572;
        [FieldOffset(0x98c)]
        public long field_98C;
        [FieldOffset(0x994)]
        public int field_994;
        [FieldOffset(0x998)]
        public int field_998;
        [FieldOffset(0x99c)]
        public byte* gap_99C;
        [FieldOffset(0xBA4)]
        public FILETIME CallStartTime;
        [FieldOffset(0xBAC)]
        public FILETIME CallEndTime;
        [FieldOffset(0xBB4)]
        public FILETIME field_BB4;
        [FieldOffset(0xBBC)]
        public FILETIME LastFlashedTime;
        [FieldOffset(0xBC4)]
        public byte* gap_BC4;
        [FieldOffset(0xbc8)]
        public CallState CallState;
        [FieldOffset(0xbcc)]
        public CallStateReason CallStateReason;
        [FieldOffset(0xbd0)]
        public CallDirection CallDirection;
        /// <summary>
        /// Probably enum
        /// </summary>
        [FieldOffset(0xBD4)]
        public int FindStatus;
        [FieldOffset(0xBD8)]
        public int field_bd8;
        /// <summary>
        /// Probably enum
        /// 1 - ?
        /// 2 - CallerIDValid
        /// 3 - ?
        /// </summary>
        [FieldOffset(0xbdc)]
        public int field_BDC;
        [FieldOffset(0xBE0)]
        public CallTransport CallTransport;
        [FieldOffset(0xBE4)]
        public int CallID;
        [FieldOffset(0xBE8)]
        public int ConferenceID;
        [FieldOffset(0xbec)]
        public byte* gap_BEC;
        /// <summary>
        /// enum
        /// 0x4 - BreakthroughCall
        /// 0x20 - ShowKeypadOnCall
        /// 0x80 - ShowAssistedDialUI
        /// 0x200 - CallForwarded
        /// 0x4000 - VoicemailCall
        /// </summary>
        [FieldOffset(0xbf0)]
        public int field_BF0;
        [FieldOffset(0xbf4)]
        public Guid PhoneLineID;
        [FieldOffset(0xc00)]
        public byte* gap_C00;
        [FieldOffset(0xC04)]
        public int field_C04;
        [FieldOffset(0xC08)]
        public byte* gap_C08;
        [FieldOffset(0xc0c)]
        public char* field_C0C;
        /// <summary>
        /// maybe enum
        /// 1 - HasVideo
        /// </summary>
        [FieldOffset(0xCAC)]
        public int field_CAC;
        [FieldOffset(0xCB0)]
        public CallUpgradeState CallUpgradeState;
        /// <summary>
        /// Probably enum
        /// except 0 - VoipCall
        /// </summary>
        [FieldOffset(0xCB4)]
        public int field_CB4;
        [FieldOffset(0xCD8)]
        public char* field_CB8;
        [FieldOffset(0xEC0)]
        public AudioQuality AudioQuality;
        [FieldOffset(0xEC4)]
        public AudioFlags AudioFlags;
        [FieldOffset(0xEC8)]
        public int VideoCallContext;
        [FieldOffset(0xECC)]
        public VideoFlags VideoFlags;
        /// <summary>
        /// 1 or 2 - InVideoCallTransition
        /// </summary>
        [FieldOffset(0xED0)]
        public VideoTransitionState VideoTransitionState;
        [FieldOffset(0xED4)]
        public int VideoTransitionError;
        [FieldOffset(0xED8)]
        public int RemotePartyIsVideoCapable;
        [FieldOffset(0xEDC)]
        public int VideoConferenceContext;
        [FieldOffset(0xEE0)]
        public VideoConferenceState VideoConferenceState;
        [FieldOffset(0xEE4)]
        public long field_EE4;
        [FieldOffset(0xEEC)]
        public byte* gap_EEC;
        [FieldOffset(0xEF4)]
        public long field_EF4;
        [FieldOffset(0xEFC)]
        public byte* gap_EFC;
        [FieldOffset(0x1104)]
        public char* field_1104;
        [FieldOffset(0x11CC)]
        public long field_11CC;
        [FieldOffset(0x11D4)]
        public byte* gap_11D4;
        [FieldOffset(0x126C)]
        public char* field_126C;
        [FieldOffset(0x1370)]
        public long field_1370;
        [FieldOffset(0x1378)]
        public byte* gap_1378;
        [FieldOffset(0x1474)]
        public bool IsHandoverMerged;
        [FieldOffset(0x1478)]
        public int field_1478;
        [FieldOffset(0x147C)]
        public int gap_147C;
        [FieldOffset(0x1480)]
        public int field_1480;
        [FieldOffset(0x1484)]
        public int field_1484;
        [FieldOffset(0x1488)]
        public byte* gap_1488;
        [FieldOffset(0x148C)]
        public int field_148C;
        [FieldOffset(0x1490)]
        public int field_1490;
        [FieldOffset(0x1494)]
        public byte* gap_1494;
        [FieldOffset(0x1498)]
        public int field_1498;
        /// <summary>
        /// CriticalSection element
        /// </summary>
        [FieldOffset(0x149C)]
        public int field_149C;
        [FieldOffset(0x14A0)]
        public byte* gap_14A0;
        [FieldOffset(0x14A4)]
        public int field_14A4;
        [FieldOffset(0x14A8)]
        public byte* gap_14A8;
        [FieldOffset(0x14B0)]
        public int field_14B0;
        [FieldOffset(0x14B4)]
        public byte* gap_14B4;
        [FieldOffset(0x14D0)]
        public bool IsRoaming;
        [FieldOffset(0x14D4)]
        public bool IsBareCall;
        [FieldOffset(0x14D8)]
        public bool UseCallWaiting;
        [FieldOffset(0x14DC)]
        public bool SupportsHold;
        /// <summary>
        /// SendAvailable, field_BC8 must be != 5
        /// probably bool
        /// </summary>
        [FieldOffset(0x14E0)]
        public int field_14E0;
        [FieldOffset(0x14E4)]
        public PH_AVAILABLE_ACTIONS AvailableActions;
        [FieldOffset(0x1564)]
        public byte* gap_1564;
        [FieldOffset(0x189a)]
        public short field_189A;
        [FieldOffset(0x189c)]
        public byte* gap_189C;
        [FieldOffset(0x199c)]
        public short field_199C;
        [FieldOffset(0x199e)]
        public byte* gap_199E;
        [FieldOffset(0x19b0)]
        public int field_19B0;
        [FieldOffset(0x19b4)]
        public int field_19B4;
    }
}

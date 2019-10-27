using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls.PhoneOm
{
    [StructLayout(LayoutKind.Explicit, Size = SIZE, CharSet = CharSet.Unicode)]
    internal unsafe struct PH_CALL_INFO
    {
        public const int SIZE = 0x19c4;

        [FieldOffset(0x0), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x1F)]
        public string Name;
        /// <summary>
        /// Probably its number, may be a string
        /// </summary>
        [FieldOffset(0xA0), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x32)]
        public string Number;
        //[FieldOffset(0x120)]
        //public byte* gap_120;
        [FieldOffset(0x1A0), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x1F)]
        public string CallDetails;
        [FieldOffset(0x2E0), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x1F)]
        public string field_2E0;
        ////[FieldOffset(0x2E4)]
        ////public byte* gap_2E4;
        [FieldOffset(0x360), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x32)]
        public string ForwardNumber;
        ////[FieldOffset(0x364)]
        ////public byte* gap_364;
        [FieldOffset(0x3E0), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x1F)]
        public string field_3E0;
        ////[FieldOffset(0x3E4)]
        ////public byte* gap_3E4;
        [FieldOffset(0x480), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x1F)]
        public string field_480;
        ////[FieldOffset(0x484)]
        ////public byte* gap_484;
        [FieldOffset(0x520), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x1F)]
        public string field_520;
        ////[FieldOffset(0x528)]
        ////public byte* gap_528;
        [FieldOffset(0x570), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x1F)]
        public string ContactPicture;
        ////[FieldOffset(0x572)]
        ////public byte* gap_572;
        [FieldOffset(0x778), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x1F)]
        public string Ringtone;
        ////[FieldOffset(0x77C)]
        ////public byte* gap_77C;
        //[FieldOffset(0x98C)]
        //public long field_98C;
        //[FieldOffset(0x994)]
        //public int field_994;
        //[FieldOffset(0x998)]
        //public int field_998;
        //[FieldOffset(0x99C), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x1F)]
        //public string MeContactPicture;
        //[FieldOffset(0x9A0)]
        //public byte* gap_9A0;
        [FieldOffset(0xBA4)]
        public long CallStartTime;
        [FieldOffset(0xBAC)]
        public long CallEndTime;
        [FieldOffset(0xBB4)]
        public long field_BB4;
        [FieldOffset(0xBBC)]
        public long LastFlashedTime;
        [FieldOffset(0xBC4)]
        public int field_BC4;
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
        [FieldOffset(0xbdc)]
        public PH_CALL_INFO_field_BDC field_BDC;
        [FieldOffset(0xBE0)]
        public CallTransport CallTransport;
        [FieldOffset(0xBE4)]
        public uint CallID;
        [FieldOffset(0xBE8)]
        public uint ConferenceID;
        [FieldOffset(0xbec)]
        public byte* gap_BEC;
        [FieldOffset(0xBF0)]
        public PH_CALL_INFO_field_BF0 field_BF0;
        [FieldOffset(0xbf4)]
        public Guid PhoneLineID;
        //[FieldOffset(0xc00)]
        //public byte* gap_C00;
        [FieldOffset(0xC04)]
        public int field_C04;
        //[FieldOffset(0xC08)]
        //public byte* gap_C08;
        //[FieldOffset(0xc0c)]
        //public char* field_C0C;
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
        public uint OwningApplicationType;
        /// <summary>
        /// AppUserModelID
        /// </summary>
        [FieldOffset(0xCB8), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x104)]
        public string OwningApplicationId;
        [FieldOffset(0xEC0)]
        public CallAudioQuality AudioQuality;
        [FieldOffset(0xEC4)]
        public CallAudioFlags AudioFlags;
        [FieldOffset(0xEC8)]
        public int VideoCallContext;
        [FieldOffset(0xECC)]
        public CallVideoFlags VideoFlags;
        /// <summary>
        /// 1 or 2 - InVideoCallTransition
        /// </summary>
        [FieldOffset(0xED0)]
        public CallVideoTransitionState VideoTransitionState;
        [FieldOffset(0xED4)]
        public int VideoTransitionError;
        [FieldOffset(0xED8)]
        public bool RemotePartyIsVideoCapable;
        [FieldOffset(0xEDC)]
        public int VideoConferenceContext;
        [FieldOffset(0xEE0)]
        public CallVideoConferenceState VideoConferenceState;
        [FieldOffset(0xEE4)]
        public long field_EE4;
        //[FieldOffset(0xEEC)]
        //public byte* gap_EEC;
        [FieldOffset(0xEF4)]
        public long field_EF4;
        //[FieldOffset(0xF04), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x1F)]
        //public string ReminderText;
        //[FieldOffset(0x1104), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x1F)]
        //public string CallerLocation;
        [FieldOffset(0x11CC)]
        public long field_11CC;
        //[FieldOffset(0x11D4)]
        //public byte* gap_11D4;
        //[FieldOffset(0x126C), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x1F)]
        //public string CallerCategoryDescription;
        [FieldOffset(0x136C)]
        public CallActionByExternalDevice ActionByExternalDevice;
        [FieldOffset(0x1370)]
        public long field_1370;
        //[FieldOffset(0x1378)]
        //public byte* gap_1378;
        [FieldOffset(0x1478)]
        public bool IsHandoverMerged;
        [FieldOffset(0x147C)]
        public int gap_147C;
        [FieldOffset(0x1480)]
        public PH_CALL_INFO_field_1480 field_1480;
        [FieldOffset(0x1488)]
        public int field_1488;
        [FieldOffset(0x148C)]
        public OLITEMID field_148C;
        [FieldOffset(0x1498)]
        public int field_1498;
        /// <summary>
        /// CriticalSection element
        /// </summary>
        [FieldOffset(0x149C)]
        public int field_149C;
        //[FieldOffset(0x14A0)]
        //public byte* gap_14A0;
        [FieldOffset(0x14A4)]
        public int field_14A4;
        //[FieldOffset(0x14A8)]
        //public byte* gap_14A8;
        [FieldOffset(0x14B0)]
        public int field_14B0;
        //[FieldOffset(0x14B4), MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x1F)]
        //public string CallIdentifier;
        [FieldOffset(0x14D4)]
        public bool IsRoaming;
        [FieldOffset(0x14D8)]
        public bool IsBareCall;
        [FieldOffset(0x14DC)]
        public bool UseCallWaiting;
        [FieldOffset(0x14E0)]
        public bool SupportsHold;
        [FieldOffset(0x14E4)]
        public bool IsDtmfWaitPending;
        [FieldOffset(0x14E8)]
        public PH_AVAILABLE_ACTIONS AvailableActions;
        //[FieldOffset(0x1568)]
        //public byte* gap_1568;
        //[FieldOffset(0x189a)]
        //public short field_189A;
        ////[FieldOffset(0x189c)]
        ////public byte* gap_189C;
        //[FieldOffset(0x199c)]
        //public short field_199C;
        ////[FieldOffset(0x199e)]
        ////public byte* gap_199E;
        //[FieldOffset(0x19b0)]
        //public int field_19B0;
        //[FieldOffset(0x19b4)]
        //public int field_19B4;
    }
}

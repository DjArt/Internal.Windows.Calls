using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls.PhoneOm
{
    [StructLayout(LayoutKind.Explicit, Size = 0x30)]
    internal struct PH_PHONE_CALL_COUNTS
    {
        [FieldOffset(0x0)]
        public uint ActiveTalkingCalls;
        [FieldOffset(0x4)]
        public uint OnHoldCalls;
        [FieldOffset(0x8)]
        public uint DisconnectedCalls;
        [FieldOffset(0xC)]
        public uint IncomingCalls;
        [FieldOffset(0x10)]
        public uint DialingCalls;
        [FieldOffset(0x14)]
        public uint IndeterminateCalls;
        [FieldOffset(0x18)]
        public uint TransferingCalls;
        /// <summary>
        /// Probably invalid calls
        /// </summary>
        [FieldOffset(0x1C)]
        public uint field_1C;
        [FieldOffset(0x20)]
        public uint ConferenceCalls;
        [FieldOffset(0x24)]
        public uint UpgradingCalls;
        [FieldOffset(0x28)]
        public uint AllCalls;
        /// <summary>
        /// Probably bluetooth calls
        /// </summary>
        [FieldOffset(0x2C)]
        public uint field_2C;
    }
}

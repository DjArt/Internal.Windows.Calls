using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls.PhoneOm
{
    [StructLayout(LayoutKind.Explicit)]
    public struct OLITEMID
    {
        [FieldOffset(0x0)]
        public int field_0;
        [FieldOffset(0x4)]
        public int field_4;
        [FieldOffset(0x8)]
        public int field_8;
    }
}

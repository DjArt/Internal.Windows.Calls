using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls.PhoneOm
{
    [StructLayout(LayoutKind.Explicit, Size = 0x13C)]
    internal struct PH_PROVIDER_LINE_SERVICE_INFO
    {
        [FieldOffset(0x130)]
        PH_PROVIDER_LINE_SERVICE_INFO_field_130 field_130;
    }
}

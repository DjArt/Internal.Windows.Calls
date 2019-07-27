using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Calls;

namespace Internal.Windows.Calls.PhoneOm
{
    [StructLayout(LayoutKind.Explicit, Size = 0x13C)]
    internal struct PH_PROVIDER_LINE_SERVICE_INFO
    {
        /// <summary>
        /// RoamingStatus
        /// Looks like PhoneNetworkState
        /// </summary>
        [FieldOffset(0x8C)]
        public PH_PROVIDER_LINE_SERVICE_INFO_field_8C field_8C;
        [FieldOffset(0x12C)]
        public bool SupportsHold;
        [FieldOffset(0x130)]
        public PH_PROVIDER_LINE_SERVICE_INFO_field_130 field_130;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls.PhoneOm
{
    /// <summary>
    /// Callback function to be used with PhoneAddListener.
    /// </summary>
    [UnmanagedFunctionPointer(CallingConvention.StdCall)]
    internal delegate uint PH_CHANGE_EVENT_NOTIFY_FUNCTION(IntPtr phoneListener, IntPtr userData, ref PhoneNotifyData notifyData);
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls
{
    public enum PhoneOwningAppType : int
    {
        None = 0,
        Legacy = 1,
        LightUp = 2,
        Modern = 3,
        Win32 = 4
    }
}

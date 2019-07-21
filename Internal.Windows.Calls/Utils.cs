using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls
{
    internal static class Utils
    {
        public static unsafe IntPtr AllocateAndClear(int cb, byte fill = 0)
        {
            IntPtr result = Marshal.AllocHGlobal(cb);
            byte* cleaning = (byte*)result.ToPointer();
            for (int i0 = 0; i0 < cb; i0++)
            {
                cleaning[i0] = fill;
            }
            return result;
        }

        public static unsafe string ByteDump(void* ptr, int count, int split = 0)
        {
            StringBuilder result = new StringBuilder();
            byte* dumping = (byte*)ptr;
            for (int i0 = 0; i0 < count; i0++)
            {
                result.Append(dumping[i0]);
                result.Append(' ');
                if (split != 0 && split == i0)
                {
                    result.Append('|');
                }
            }
            return result.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
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

        public static unsafe string ByteDump(void* ptr, int count)
        {
            StringBuilder result = new StringBuilder();
            byte* dumping = (byte*)ptr;
            for (int i0 = 0; i0 < count; i0++)
            {
                result.Append(dumping[i0]);
                result.Append(' ');
            }
            return result.ToString();
        }

        public static Exception HResultToException(int hResult)
        {
            unchecked
            {
                switch (hResult)
                {
                    case 0:
                        return null;
                    case (int)0x80070005:
                        return new UnauthorizedAccessException("General access denied error.");
                    case (int)0x80070057:
                        return new ArgumentException("The parameter is incorrect.");
                    case (int)0x80070424:
                        return new ExternalException("The specified service does not exist as an installed service.", hResult);
                    case (int)0x80070490:
                        return new ExternalException("‭Element not found.", hResult);
                    case (int)0x800710DD:
                        return new InvalidOperationException("The operation identifier is not valid.");
                    default:
                        return new ExternalException("UNKNOWN EXTERNAL EXCEPTION", hResult);
                }
            }
        }

        public static DateTime ToDateTime(this FILETIME @struct)
        {
            return DateTime.FromFileTime((long)@struct.dwHighDateTime << 32 | @struct.dwLowDateTime);
        }
    }
}

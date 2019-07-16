using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;

namespace Internal.Windows.Calls
{
    public static class AsyncExceptionHandler
    {
        public static event TypedEventHandler<string, Exception> ExceptionThrown;

        internal static void Throw(Exception ex, [CallerMemberName]string owner = null)
        {
            ExceptionThrown?.Invoke(owner, ex);
        }
    }
}

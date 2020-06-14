using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls
{
    internal enum CallTransferState : int
    {
        None = 0,
        Transferring = 1,
        Successful = 2,
        Failed = 3
    }
}

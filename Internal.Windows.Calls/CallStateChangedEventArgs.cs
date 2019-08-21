using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls
{
    public sealed class CallStateChangedEventArgs
    {
        public CallState OldState { get; }
        public CallState NewState { get; }
        public CallStateReason StateReason { get; }

        public CallStateChangedEventArgs(CallState old, CallState @new, CallStateReason reason)
        {
            OldState = old;
            NewState = @new;
            StateReason = reason;
        }
    }
}

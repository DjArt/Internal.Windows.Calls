using System;

namespace Internal.Windows.Calls
{
    public sealed class CallTimeChangedEventArgs
    {

        public DateTimeOffset? OldTime { get; }
        public DateTimeOffset? NewTime { get; }

        internal CallTimeChangedEventArgs(DateTimeOffset? old, DateTimeOffset? @new)
        {
            OldTime = old;
            NewTime = @new;
        }
    }
}

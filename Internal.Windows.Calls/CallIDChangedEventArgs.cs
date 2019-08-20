namespace Internal.Windows.Calls
{
    public sealed class CallIDChangedEventArgs
    {
        public uint OldID { get; }
        public uint NewID { get; }

        internal CallIDChangedEventArgs(uint old, uint @new)
        {
            OldID = old;
            NewID = @new;
        }
    }
}

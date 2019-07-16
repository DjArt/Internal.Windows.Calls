using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internal.Windows.Calls.PhoneOm;

namespace Internal.Windows.Calls
{
    public sealed class PhoneCallCounts
    {
        internal PH_PHONE_CALL_COUNTS InternalStruct;

        public uint ActiveTalkingCalls => InternalStruct.ActiveTalkingCalls;
        public uint OnHoldCalls => InternalStruct.OnHoldCalls;
        public uint DisconnectedCalls => InternalStruct.DisconnectedCalls;
        public uint IncomingCalls => InternalStruct.IncomingCalls;
        public uint DialingCalls => InternalStruct.DialingCalls;
        public uint IndeterminateCalls => InternalStruct.IndeterminateCalls;
        public uint TransferingCalls => InternalStruct.TransferingCalls;
        public uint field_1C => InternalStruct.field_1C;
        public uint ConferenceCalls => InternalStruct.ConferenceCalls;
        public uint UpgradingCalls => InternalStruct.UpgradingCalls;
        public uint AllCalls => InternalStruct.AllCalls;
        public uint field_2C => InternalStruct.field_2C;

        internal PhoneCallCounts(PhoneOm.PH_PHONE_CALL_COUNTS @struct)
        {
            InternalStruct = @struct;
        }
    }
}

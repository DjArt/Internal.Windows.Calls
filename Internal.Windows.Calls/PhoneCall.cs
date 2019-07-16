using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Internal.Windows.Calls.PhoneOm;

using static Internal.Windows.Calls.PhoneOm.Exports;

namespace Internal.Windows.Calls
{
    public sealed class PhoneCall
    {
        private PH_CALL_INFO InternalStruct;

        public CallDirection Direction => InternalStruct.CallDirection;
        public CallState State => InternalStruct.CallState;
        public CallStateReason StateReason => InternalStruct.CallStateReason;
        public CallUpgradeState UpgradeState => InternalStruct.CallUpgradeState;
        public AvailableActions AvailableActions { get; private set; }
        public int ID => InternalStruct.CallID;
        public int ConferenceID => InternalStruct.ConferenceID;
        public bool IsBareCall => InternalStruct.IsBareCall;
        public bool IsHandoverMerged => InternalStruct.IsHandoverMerged;
        public bool IsRoaming => InternalStruct.IsRoaming;
        public bool RemotePartyIsVideoCapable
        {
            get
            {
                switch (InternalStruct.RemotePartyIsVideoCapable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(RemotePartyIsVideoCapable)}={InternalStruct.RemotePartyIsVideoCapable}");
                }
            }
        }
        public bool SupportsHold => InternalStruct.SupportsHold;
        public bool UseCallWaiting => InternalStruct.UseCallWaiting;
        public Guid PhoneLineID => InternalStruct.PhoneLineID;
        public DateTimeOffset StartTime { get; private set; }
        public DateTimeOffset EndTime { get; private set; }
        public DateTimeOffset LastFlashedTime { get; private set; }

        internal PhoneCall(PH_CALL_INFO callInfo)
        {
            UpdateState(callInfo);
        }

        private async void UpdateState(PH_CALL_INFO callInfo)
        {
            try
            {
                InternalStruct = callInfo;
                AvailableActions = new AvailableActions(InternalStruct.AvailableActions);
                //PhoneLine = await PhoneLine.FromIdAsync(InternalStruct.PhoneLineID);
                //StartTime = InternalStruct.CallStartTime.ToDateTime();
                //EndTime = InternalStruct.CallEndTime.ToDateTime();
                //LastFlashedTime = InternalStruct.LastFlashedTime.ToDateTime();
            }
            catch (Exception ex)
            {
                AsyncExceptionHandler.Throw(ex);
            }
        }

        public void UpdateState()
        {
            try
            {
                int hResult = PhoneReinitiateCallerIdLookup(ref InternalStruct.CallID);
                Exception ex = new Win32Exception(hResult);
                if (ex != null) throw ex;
                hResult = PhoneGetCallInfo(ref InternalStruct.CallID, out PH_CALL_INFO callInfo);
                ex = new Win32Exception(hResult);
                if (ex != null) throw ex;
                UpdateState(callInfo);
            }
            catch (Exception ex)
            {
                AsyncExceptionHandler.Throw(ex);
            }
        }

        public void AcceptIncomingEx()
        {
            int hResult = PhoneAcceptIncomingEx(ref InternalStruct.CallID);
            Exception ex = new Win32Exception(hResult);
            if (ex != null) throw ex;
            UpdateState();
        }

        public void AcceptVideo()
        {
            int hResult = PhoneAcceptVideo(ref InternalStruct.CallID);
            Exception ex = new Win32Exception(hResult);
            if (ex != null) throw ex;
            UpdateState();
        }

        public void DropVideo()
        {
            int hResult = PhoneDropVideo(ref InternalStruct.CallID);
            Exception ex = new Win32Exception(hResult);
            if (ex != null) throw ex;
            UpdateState();
        }

        public void End()
        {
            int hResult = PhoneEnd(ref InternalStruct.CallID);
            Exception ex = new Win32Exception(hResult);
            if (ex != null) throw ex;
            UpdateState();
        }

        public void RejectIncoming()
        {
            int hResult = PhoneRejectIncoming(ref InternalStruct.CallID);
            Exception ex = new Win32Exception(hResult);
            if (ex != null) throw ex;
            UpdateState();
        }

        public void SetHold(bool state)
        {
            int hResult = PhoneSetHold(ref InternalStruct.CallID, state);
            Exception ex = new Win32Exception(hResult);
            if (ex != null) throw ex;
            UpdateState();
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (FieldInfo info in InternalStruct.GetType().GetTypeInfo().GetFields())
            {
                builder.Append("  ");
                builder.Append(info.Name);
                builder.Append(" = ");
                builder.Append(info.GetValue(InternalStruct).ToString());
                builder.AppendLine();
            }
            return builder.ToString();
        }
    }
}

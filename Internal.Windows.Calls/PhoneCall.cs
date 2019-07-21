using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Internal.Windows.Calls.PhoneOm;
using Windows.ApplicationModel.Calls;
using Windows.Foundation;
using static Internal.Windows.Calls.PhoneOm.Exports;

namespace Internal.Windows.Calls
{
    public sealed class PhoneCall
    {
        private PH_CALL_INFO InternalStruct;

        public event TypedEventHandler<PhoneCall, AvailableActions> AvailableActionsChanged;
        public event TypedEventHandler<PhoneCall, CallState> StateChanged;

        public CallDirection Direction => InternalStruct.CallDirection;
        public CallState State => InternalStruct.CallState;
        public CallStateReason StateReason => InternalStruct.CallStateReason;
        public CallUpgradeState UpgradeState => InternalStruct.CallUpgradeState;
        public AvailableActions AvailableActions { get; private set; }
        public uint ID => InternalStruct.CallID;
        public uint ConferenceID => InternalStruct.ConferenceID;
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
        public string Number => InternalStruct.Number;
        public string Name => InternalStruct.Name;
        public DateTimeOffset StartTime { get; private set; }
        public DateTimeOffset EndTime { get; private set; }
        public DateTimeOffset LastFlashedTime { get; private set; }

        internal PhoneCall(PH_CALL_INFO callInfo)
        {
            UpdateState(callInfo);
        }

        private void UpdateAvailableActions(PH_AVAILABLE_ACTIONS actions)
        {
            bool changed = !InternalStruct.AvailableActions.Equals(actions);
            InternalStruct.AvailableActions = actions;
            AvailableActions = new AvailableActions(InternalStruct.AvailableActions);
            if (changed)
            {
                AvailableActionsChanged?.Invoke(this, AvailableActions);
            }
        }

        private void UpdateState(PH_CALL_INFO callInfo)
        {
            bool stateChanged = State != callInfo.CallState;
            InternalStruct = callInfo;
            UpdateAvailableActions(InternalStruct.AvailableActions);
            try
            {
                StartTime = DateTime.FromFileTime(InternalStruct.CallStartTime);
                EndTime = DateTime.FromFileTime(InternalStruct.CallEndTime);
                LastFlashedTime = DateTime.FromFileTime(InternalStruct.LastFlashedTime);
            }
            catch
            {

            }
            if (stateChanged)
            {
                StateChanged?.Invoke(this, State);
            }
        }

        internal void UpdateAvailableActions()
        {
            PhoneGetAvailableActions(ref InternalStruct.CallID, out PH_AVAILABLE_ACTIONS actions);
            UpdateAvailableActions(actions);
        }

        internal void UpdateID()
        {
            PhoneReinitiateCallerIdLookup(ref InternalStruct.CallID);
        }

        internal void UpdateState()
        {
            PhoneGetCallInfo(ref InternalStruct.CallID, out PH_CALL_INFO callInfo);
            UpdateState(callInfo);
        }

        public void AcceptIncomingEx()
        {
            PhoneAcceptIncomingEx(ref InternalStruct.CallID);
            UpdateState();
        }

        public void AcceptVideo()
        {
            PhoneAcceptVideo(ref InternalStruct.CallID);
            UpdateState();
        }

        public void DropVideo()
        {
            PhoneDropVideo(ref InternalStruct.CallID);
            UpdateState();
        }

        public void End()
        {
            PhoneEnd(ref InternalStruct.CallID);
            UpdateState();
        }

        public void RejectIncoming()
        {
            PhoneRejectIncoming(ref InternalStruct.CallID);
            UpdateState();
        }

        public void SetHold(bool state)
        {
            PhoneSetHold(ref InternalStruct.CallID, state);
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

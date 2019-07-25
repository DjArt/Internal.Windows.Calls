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
    public sealed class Call : INotifyPropertyChanged
    {
        private PH_CALL_INFO InternalStruct;

        public event TypedEventHandler<Call, AvailableActions> AvailableActionsChanged;
        public event TypedEventHandler<Call, CallState> StateChanged;
        public event PropertyChangedEventHandler PropertyChanged;

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
        public PhoneLine Line { get; private set; }
        public string Number => InternalStruct.Number;
        public string Name => InternalStruct.Name;
        public DateTimeOffset StartTime { get; private set; }
        public DateTimeOffset EndTime { get; private set; }
        public DateTimeOffset LastFlashedTime { get; private set; }

        internal Call(PH_CALL_INFO callInfo)
        {
            UpdateState(callInfo);
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void UpdateAvailableActions(PH_AVAILABLE_ACTIONS actions)
        {
            bool changed = !InternalStruct.AvailableActions.Equals(actions);
            InternalStruct.AvailableActions = actions;
            AvailableActions = new AvailableActions(InternalStruct.AvailableActions);
            if (changed)
            {
                AvailableActionsChanged?.Invoke(this, AvailableActions);
                OnPropertyChanged(nameof(AvailableActions));
            }
        }

        private async void UpdateState(PH_CALL_INFO callInfo)
        {
            bool stateChanged = State != callInfo.CallState;
            bool lineChanged = false;
            InternalStruct = callInfo;
            UpdateAvailableActions(InternalStruct.AvailableActions);
            try
            {
                StartTime = DateTime.FromFileTime(InternalStruct.CallStartTime);
                EndTime = DateTime.FromFileTime(InternalStruct.CallEndTime);
                LastFlashedTime = DateTime.FromFileTime(InternalStruct.LastFlashedTime);
                if (lineChanged = Line?.Id != InternalStruct.PhoneLineID)
                {
                    Line = await PhoneLine.FromIdAsync(InternalStruct.PhoneLineID);
                }
            }
            catch
            {

            }
            if (stateChanged)
            {
                StateChanged?.Invoke(this, State);
                OnPropertyChanged(nameof(State));
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
        }

        public void AcceptVideo()
        {
            PhoneAcceptVideo(ref InternalStruct.CallID);
        }

        public void DropVideo()
        {
            PhoneDropVideo(ref InternalStruct.CallID);
        }

        public void End()
        {
            PhoneEnd(ref InternalStruct.CallID);
        }

        public void RejectIncoming()
        {
            PhoneRejectIncoming(ref InternalStruct.CallID);
        }

        public void SetHold(bool state)
        {
            PhoneSetHold(ref InternalStruct.CallID, state);
        }
    }
}

#nullable enable

using Internal.Windows.Calls.PhoneOm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Calls;
using Windows.ApplicationModel.Contacts;
using Windows.Foundation;
using Windows.Foundation.Metadata;
using Windows.System;

using static Internal.Windows.Calls.PhoneOm.Exports;

namespace Internal.Windows.Calls
{
    public sealed class Call
    {
        private readonly CallManager _CallManager;
        private readonly List<Call> _CallsInConference = new List<Call>();
        private Contact? _Contact;
        private ContactPhone? _Phone;
        private Contact? _ForwardContact;
        private ContactPhone? _ForwardPhone;
        private DateTimeOffset? _StartTime;
        private DateTimeOffset? _EndTime;
        private DateTimeOffset? _LastFlashedTime;
        private DateTimeOffset? _field_BB4;
        private CallState _State;
        private CallStateReason _StateReason;
        private CallDirection _Direction;
        private uint _ID;
        private uint _ConferenceID;
        private PhoneLine? _Line;
        private PH_CALL_INFO_field_BF0 _field_BF0;
        private CallUpgradeState _UpgradeState;
        private AppInfo? _OwningApplication;
        private CallAudioQuality _AudioQuality;
        private CallAudioFlags _AudioFlags;
        private CallVideoFlags _VideoFlags;
        private CallVideoTransitionState _VideoTransitionState;
        private bool _RemotePartyIsVideoCapable;
        private CallVideoConferenceState _VideoConferenceState;
        private CallActionByExternalDevice _ActionByExternalDevice;
        private bool _IsHandoverMerged;
        private bool _IsRoaming;
        private bool _IsBareCall;
        private bool _UseCallWaiting;
        private bool _SupportsHold;
        private bool _IsDtmfWaitPending;
        private AvailableActions _AvailableActions;

        [Obsolete]
        public event TypedEventHandler<Call, AvailableActions> AvailableActionsChanged;
        public event TypedEventHandler<Call, CallStateChangedEventArgs> StateChanged;
        public event TypedEventHandler<Call, CallIDChangedEventArgs> IDChanged;
        public event TypedEventHandler<Call, CallIDChangedEventArgs> ConferenceIDChanged;
        public event TypedEventHandler<Call, CallTimeChangedEventArgs> StartTimeChanged;
        public event TypedEventHandler<Call, CallTimeChangedEventArgs> EndTimeChanged;
        public event TypedEventHandler<Call, CallTimeChangedEventArgs> LastFlashedTimeChanged;

        public Contact? Contact
        {
            get => _Contact;
            private set => _Contact = value;
        }
        public ContactPhone? Phone
        {
            get => _Phone;
            private set => _Phone = value;
        }
        public Contact? ForwardContact
        {
            get => _ForwardContact;
            private set => _ForwardContact = value;
        }
        public ContactPhone? ForwardPhone
        {
            get => _ForwardPhone;
            private set => _ForwardPhone = value;
        }
        public DateTimeOffset? StartTime
        {
            get => _StartTime;
            private set
            {
                if (value != _StartTime)
                {
                    DateTimeOffset? old = _StartTime;
                    _StartTime = value;
                    StartTimeChanged?.Invoke(this, new CallTimeChangedEventArgs(old, _StartTime));
                }
            }
        }
        public DateTimeOffset? EndTime
        {
            get => _EndTime;
            private set
            {
                if (value != _EndTime)
                {
                    DateTimeOffset? old = _EndTime;
                    _EndTime = value;
                    EndTimeChanged?.Invoke(this, new CallTimeChangedEventArgs(old, _EndTime));
                }
            }
        }
        public DateTimeOffset? LastFlashedTime
        {
            get => _LastFlashedTime;
            private set
            {
                if (value != _LastFlashedTime)
                {
                    DateTimeOffset? old = _LastFlashedTime;
                    _LastFlashedTime = value;
                    LastFlashedTimeChanged?.Invoke(this, new CallTimeChangedEventArgs(old, _LastFlashedTime));
                }
            }
        }
        public CallState State
        {
            get => _State;
            private set
            {
                if (value != State)
                {
                    CallState state = State;
                    _State = value;
                    StateChanged?.Invoke(this, new CallStateChangedEventArgs(state, State, StateReason));
                }
            }
        }
        public CallStateReason StateReason
        {
            get => _StateReason;
            private set => _StateReason = value;
        }
        public CallDirection Direction
        {
            get => _Direction;
            private set => _Direction = value;
        }
        public uint ID
        {
            get => _ID;
            private set
            {
                if (value != ID)
                {
                    uint id = ID;
                    _ID = value;
                    IDChanged?.Invoke(this, new CallIDChangedEventArgs(id, ID));
                }
            }
        }
        public uint ConferenceID
        {
            get => _ConferenceID;
            private set
            {
                if (value != _ConferenceID)
                {
                    uint id = _ConferenceID;
                    _ConferenceID = value;
                    ConferenceIDChanged?.Invoke(this, new CallIDChangedEventArgs(id, _ConferenceID));
                }
            }
        }
        public PhoneLine? Line
        {
            get => _Line;
            private set => _Line = value;
        }
        public PH_CALL_INFO_field_BF0 field_BF0
        {
            get => _field_BF0;
            private set => _field_BF0 = value;
        }
        public CallUpgradeState UpgradeState
        {
            get => _UpgradeState;
            private set => _UpgradeState = value;
        }
        public AppInfo? OwningApplication
        {
            get => _OwningApplication;
            private set => _OwningApplication = value;
        }
        public CallAudioQuality AudioQuality
        {
            get => _AudioQuality;
            private set => _AudioQuality = value;
        }
        public CallAudioFlags AudioFlags
        {
            get => _AudioFlags;
            private set => _AudioFlags = value;
        }
        public CallVideoFlags VideoFlags
        {
            get => _VideoFlags;
            private set => _VideoFlags = value;
        }
        public CallVideoTransitionState VideoTransitionState
        {
            get => _VideoTransitionState;
            private set => _VideoTransitionState = value;
        }
        public bool RemotePartyIsVideoCapable
        {
            get => _RemotePartyIsVideoCapable;
            private set => _RemotePartyIsVideoCapable = value;
        }
        public CallVideoConferenceState VideoConferenceState
        {
            get => _VideoConferenceState;
            private set => _VideoConferenceState = value;
        }
        public CallActionByExternalDevice ActionByExternalDevice
        {
            get => _ActionByExternalDevice;
            private set => _ActionByExternalDevice = value;
        }
        public bool IsConference => _ConferenceID > 0U;
        public bool IsHandoverMerged
        {
            get => _IsHandoverMerged;
            private set => _IsHandoverMerged = value;
        }
        public bool IsRoaming
        {
            get => _IsRoaming;
            private set => _IsRoaming = value;
        }
        public bool IsBareCall
        {
            get => _IsBareCall;
            private set => _IsBareCall = value;
        }
        public bool UseCallWaiting
        {
            get => _UseCallWaiting;
            private set => _UseCallWaiting = value;
        }
        public bool SupportsHold
        {
            get => _SupportsHold;
            private set => _SupportsHold = value;
        }
        public bool IsDtmfWaitPending
        {
            get => _IsDtmfWaitPending;
            private set => _IsDtmfWaitPending = value;
        }
        public AvailableActions AvailableActions
        {
            get => _AvailableActions;
            private set => _AvailableActions = value;
        }
        public IEnumerable<Call> CallsInConference => _CallsInConference.ToList().AsReadOnly();

#nullable disable
        internal Call(CallManager manager, PH_CALL_INFO callInfo)
        {
            _CallManager = manager;
            UpdateState(callInfo);
        }
#nullable enable

        private async Task<(Contact?, ContactPhone?)> FindInfoByNumber(string number)
        {
            Contact? contact = null;
            ContactPhone? phone = null;
            ContactBatch batch = await _CallManager.ContactStore.GetContactReader(new ContactQueryOptions(number, ContactQuerySearchFields.Phone)).ReadBatchAsync();
            if (batch.Status == ContactBatchStatus.Success && batch.Contacts.Count > 0)
            {
                contact = batch.Contacts.First();
                phone = contact.Phones.First(x => x.Number == number);
            }
            else
            {
                phone = new ContactPhone()
                {
                    Kind = ContactPhoneKind.Other,
                    Number = number
                };
                contact = new Contact()
                {
                    Phones = { phone },
                };
            }
            return (contact, phone);
        }

        private async Task<Contact?> FindInfoByName(string name)
        {
            ContactBatch batch = await _CallManager.ContactStore.GetContactReader(new ContactQueryOptions(name)).ReadBatchAsync();
            if (batch.Status == ContactBatchStatus.Success && batch.Contacts.Count > 0)
            {
                return batch.Contacts.First();
            }
            else
            {
                return null;
            }
        }

        private void UpdateAvailableActions(PH_AVAILABLE_ACTIONS actions)
        {
            AvailableActions = new AvailableActions(actions);
        }

        private async void UpdateState(PH_CALL_INFO callInfo)
        {
            ActionByExternalDevice = callInfo.ActionByExternalDevice;
            AudioFlags = callInfo.AudioFlags;
            AudioQuality = callInfo.AudioQuality;
            try
            {
                StartTime = callInfo.CallStartTime == 0 ? (DateTimeOffset?)null : DateTimeOffset.FromFileTime(callInfo.CallStartTime);
            }
            catch
            {

            }
            try
            {
                EndTime = callInfo.CallEndTime == 0 ? (DateTimeOffset?)null : DateTimeOffset.FromFileTime(callInfo.CallEndTime);
            }
            catch
            {

            }
            try
            {
                LastFlashedTime = callInfo.LastFlashedTime == 0 ? (DateTimeOffset?)null : DateTimeOffset.FromFileTime(callInfo.LastFlashedTime);
            }
            catch
            {

            }
            try
            {
                _field_BB4 = callInfo.field_BB4 == 0 ? (DateTimeOffset?)null : DateTimeOffset.FromFileTime(callInfo.field_BB4);
            }
            catch
            {

            }
            ID = callInfo.CallID;
            ConferenceID = callInfo.ConferenceID;
            IsBareCall = callInfo.IsBareCall;
            IsDtmfWaitPending = callInfo.IsDtmfWaitPending;
            IsHandoverMerged = callInfo.IsHandoverMerged;
            IsRoaming = callInfo.IsRoaming;
            RemotePartyIsVideoCapable = callInfo.RemotePartyIsVideoCapable;
            Direction = callInfo.CallDirection;
            AvailableActions = new AvailableActions(callInfo.AvailableActions);
            try
            {
                if ((Line?.Id ?? Guid.Empty) != callInfo.PhoneLineID)
                {
                    Line = await PhoneLine.FromIdAsync(callInfo.PhoneLineID);
                }
            }
            catch
            {

            }
            if (callInfo.OwningApplicationType > 0)
            {
                OwningApplication = (await AppDiagnosticInfo.RequestInfoForAppAsync(callInfo.OwningApplicationId)).FirstOrDefault().AppInfo;
            }
            if (IsConference)
            {
                _CallsInConference.Clear();
                PhoneGetCallsInConference(ConferenceID, out PH_CALL_INFO[] calls, out uint count);
                _CallsInConference.AddRange(calls.Select(x => _CallManager.GetCallByID(x.CallID)));
            }
            else
            {
                if (!string.IsNullOrEmpty(callInfo.Number))
                {
                    (Contact? Contact, ContactPhone? Phone) info = await FindInfoByNumber(callInfo.Number);
                    Contact = info.Contact;
                    Phone = info.Phone;
                }
                if (Contact == null && !string.IsNullOrEmpty(callInfo.Name))
                {
                    Contact = await FindInfoByName(callInfo.Name);
                }
                if (!string.IsNullOrEmpty(callInfo.ForwardNumber))
                {
                    (Contact? Contact, ContactPhone? Phone) info = await FindInfoByNumber(callInfo.ForwardNumber);
                    ForwardContact = info.Contact;
                    ForwardPhone = info.Phone;
                }
            }
            StateReason = callInfo.CallStateReason;
            State = callInfo.CallState;
        }

        internal void UpdateAvailableActions()
        {
            PhoneGetAvailableActions(ID, out PH_AVAILABLE_ACTIONS availableActions);
            UpdateAvailableActions(availableActions);
        }

        internal void UpdateID()
        {
            uint id = ID;
            PhoneReinitiateCallerIdLookup(ref id);
            ID = id;
        }

        internal void UpdateState()
        {
            PhoneGetCallInfo(ID, out PH_CALL_INFO callInfo);
            UpdateState(callInfo);
        }

        public void AcceptIncomingEx() => PhoneAcceptIncomingEx(ID);

        public void AcceptVideo() => PhoneAcceptVideo(ID);

        public void DropVideo() => PhoneDropVideo(ID);

        public void End() => PhoneEnd(ID);

        public void RejectIncoming() => PhoneRejectIncoming(ID);

        public void SetHold(bool state) => PhoneSetHold(ID, state);
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Internal.Windows.Calls.PhoneOm;
using Windows.ApplicationModel.Contacts;
using Windows.Globalization.PhoneNumberFormatting;
using Windows.Foundation;

using static Internal.Windows.Calls.PhoneOm.Exports;

namespace Internal.Windows.Calls
{
    public sealed class CallManager
    {
        private static readonly PH_CHANGEEVENT[] SubscriptionTypes = new[] { PH_CHANGEEVENT.PhoneStateChanged, PH_CHANGEEVENT.LineConfigurationChanged };

        public static IAsyncOperation<CallManager> GetCallManagerAsync()
        {
            async Task<CallManager> impl()
            {
                CallManager result = new CallManager();
                return result;
            }

            return impl().AsAsyncOperation();
        }

        private readonly IntPtr _PhoneListenerPointer;
        private readonly List<Call> _Calls = new List<Call>();
        private readonly PH_CHANGE_EVENT_NOTIFY_FUNCTION _Callback;

        internal ContactStore ContactStore { get; private set; }
        internal PhoneNumberFormatter NumberFormatter { get; } = new PhoneNumberFormatter();

        public event TypedEventHandler<CallManager, Call> CallAppeared;
        /// <summary>
        /// Fires when <see cref="CurrentCalls"/> obtains or lost calls.
        /// </summary>
        public event TypedEventHandler<CallManager, CallCounts> CurrentCallsChanged;

        public IEnumerable<Call> CurrentCalls => _Calls.ToList().AsReadOnly();
        public CallCounts CallCounts { get; private set; }

        public bool WiredHeadsetIsConnected
        {
            get
            {
                PhoneGetWiredHeadsetState(out bool state);
                return state;
            }
        }

        private CallManager()
        {
            Task<ContactStore> store = Task.Run(() => ContactManager.RequestStoreAsync(ContactStoreAccessType.AllContactsReadOnly).AsTask());
            PhoneAPIInitialize();
            PhoneWaitForAPIReady(0x7530);
            store.Wait();
            ContactStore = store.Result;
            UpdateState();
            _Callback = NotificationCallback;
            PhoneAddListener(_Callback, SubscriptionTypes, (uint)SubscriptionTypes.Length, IntPtr.Zero, out _PhoneListenerPointer);
        }

        ~CallManager()
        {
            PhoneRemoveListener(_PhoneListenerPointer);
            PhoneAPIUninitialize();
        }

        private unsafe uint NotificationCallback(IntPtr phoneListener, IntPtr userData, ref PH_CHANGEEVENT eventType)
        {
            switch (eventType)
            {
                case PH_CHANGEEVENT.PhoneStateChanged:
                    UpdateState();
                    break;
            }
            return 0;
        }

        private unsafe void UpdateState()
        {
            List<Call> invalidCalls = new List<Call>();
            bool currentCallsChanged = false;
            PhoneGetState(out PH_CALL_INFO[] callInfos, out uint count, out PH_PHONE_CALL_COUNTS callCounts);
            CallCounts = new CallCounts(callCounts);
            foreach (Call call in _Calls)
            {
                try
                {
                    call.UpdateID();
                    Task.Run(call.UpdateState).Wait();
                }
                catch
                {
                    invalidCalls.Add(call);
                }
            }
            foreach (Call call in invalidCalls)
            {
                _Calls.Remove(call);
            }
            if (invalidCalls.Count > 0)
            {
                PhoneClearIdleCallsFromController();
                currentCallsChanged = true;
            }
            Array.Sort(callInfos, (x, y) => x.ConferenceID.CompareTo(y.ConferenceID));
            foreach (PH_CALL_INFO callInfo in callInfos)
            {
                if (!_Calls.Exists(x => x.ID == callInfo.CallID))
                {
                    Call call = new Call(this, callInfo);
                    _Calls.Add(call);
                    CallAppeared?.Invoke(this, call);
                    currentCallsChanged = true;
                }
            }
            if (currentCallsChanged)
            {
                CurrentCallsChanged?.Invoke(this, new CallCounts(callCounts));
            }
            if (CallCounts.DisconnectedCalls > 0 || CallCounts.IndeterminateCalls > 0 || CallCounts.UpgradingCalls > 0)
            {
                PhoneClearIdleCallsFromController();
            }
        }

        public Call GetCallByID(uint id) => CurrentCalls.FirstOrDefault(x => x.ID == id);

        public bool IsAbleToCreateConference(Call call0, Call call1)
        {
            return false;
        }

        public void SetSpeaker(bool state) => PhoneSetSpeaker(state);
    }
}

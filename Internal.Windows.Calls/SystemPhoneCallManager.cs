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
using Windows.Foundation;

using static Internal.Windows.Calls.PhoneOm.Exports;

namespace Internal.Windows.Calls
{
    public sealed class SystemPhoneCallManager
    {
        private static readonly PH_CHANGEEVENT[] SubscriptionTypes = new[] { PH_CHANGEEVENT.PhoneStateChanged };

        public static IAsyncOperation<SystemPhoneCallManager> GetSystemPhoneCallManagerAsync()
        {
            async Task<SystemPhoneCallManager> impl()
            {
                await Task.Yield();
                return new SystemPhoneCallManager();
            }

            return impl().AsAsyncOperation();
        }

        private readonly IntPtr _PhoneListenerPointer;
        private readonly List<PhoneCall> _Calls = new List<PhoneCall>();

        public event TypedEventHandler<SystemPhoneCallManager, PhoneCall> CallAppeared;

        public IEnumerable<PhoneCall> CurrentCalls => _Calls.AsReadOnly();
        public bool WiredHeadsetIsConnected
        {
            get
            {
                PhoneGetWiredHeadsetState(out bool state);
                return state;
            }
        }

        private SystemPhoneCallManager()
        {
            PhoneAPIInitialize();
            PhoneWaitForAPIReady(0x7530);
            PhoneAddListener(NotificationCallback, SubscriptionTypes, (uint)SubscriptionTypes.Length, IntPtr.Zero, out _PhoneListenerPointer);
        }

        ~SystemPhoneCallManager()
        {
            PhoneRemoveListener(_PhoneListenerPointer);
            PhoneAPIUninitialize();
        }

        private unsafe uint NotificationCallback(IntPtr phoneListener, IntPtr userData, ref PH_CHANGEEVENT eventType)
        {
            switch (eventType)
            {
                case PH_CHANGEEVENT.PhoneStateChanged:
                    PhoneGetState(out PH_CALL_INFO[] callInfos, out uint count, out PH_PHONE_CALL_COUNTS callCounts);
                    //PhoneGetState(out IntPtr callInfosPtr, out uint count, out PH_PHONE_CALL_COUNTS callCounts);
                    //PH_CALL_INFO[] callInfos = new PH_CALL_INFO[count];
                    //for (int i0 = 0; i0 < count; i0++)
                    //{
                    //    callInfos[i0] = Marshal.PtrToStructure<PH_CALL_INFO>(IntPtr.Add(callInfosPtr, PH_CALL_INFO.SIZE * i0));
                    //}
                    //PhoneFreeCallInfo(callInfosPtr);
                    List<PhoneCall> invalidCalls = new List<PhoneCall>();
                    foreach (PhoneCall call in _Calls)
                    {
                        try
                        {
                            call.UpdateID();
                            call.UpdateState();
                        }
                        catch
                        {
                            invalidCalls.Add(call);
                        }
                    }
                    foreach (PhoneCall call in invalidCalls)
                    {
                        _Calls.Remove(call);
                    }
                    if (invalidCalls.Count > 0)
                    {
                        PhoneClearIdleCallsFromController();
                    }
                    foreach (PH_CALL_INFO callInfo in callInfos)
                    {
                        if (!_Calls.Exists(x => x.ID == callInfo.CallID))
                        {
                            PhoneCall call = new PhoneCall(callInfo);
                            _Calls.Add(call);
                            CallAppeared?.Invoke(this, call);
                        }
                    }
                    break;
            }
            return 0;
        }

        public unsafe void GetCallCounts()
        {
            PhoneGetCallCounts(out PH_PHONE_CALL_COUNTS count);
        }

        public void SetSpeaker(bool state) => PhoneSetSpeaker(state);
    }
}

using System;
using System.Collections.Generic;
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
        public static IAsyncOperation<SystemPhoneCallManager> GetSystemPhoneCallManagerAsync()
        {
            async Task<SystemPhoneCallManager> impl()
            {
                await Task.Yield();
                Exception ex = Utils.HResultToException(PhoneAPIInitialize());
                if (ex != null) throw ex;
                ex = Utils.HResultToException(PhoneWaitForAPIReady(0x7530));
                //if (hResult + 2147483648 < 0 || hResult == -2147023836)
                if (ex != null) throw ex;
                return new SystemPhoneCallManager();
            }

            return impl().AsAsyncOperation();
        }

        public bool WiredHeadsetIsConnected
        {
            get
            {
                int hResult = PhoneGetWiredHeadsetState(out int state);
                Exception ex = Utils.HResultToException(hResult);
                if (ex != null) throw ex;
                switch (state)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(PhoneGetWiredHeadsetState)}={state}");
                }
            }
        }

        private SystemPhoneCallManager()
        {

        }

        ~SystemPhoneCallManager()
        {
            PhoneAPIUninitialize();
        }

        public unsafe void GetCallCounts()
        {
            int hResult = PhoneGetCallCounts(out PH_PHONE_CALL_COUNTS count);
            Exception ex = Utils.HResultToException(hResult);
            if (ex != null) throw ex;
        }

        public unsafe IEnumerable<PhoneCall> GetCurrentCalls()
        {
            int hResult = PhoneGetState(out PH_CALL_INFO* callInfos, out uint count, out PH_PHONE_CALL_COUNTS callCounts);
            Exception ex = Utils.HResultToException(hResult);
            if (ex != null) throw ex;
            List<PhoneCall> result = new List<PhoneCall>();
            for (int i0 = 0; i0 < count; i0++)
            {
                result.Add(new PhoneCall(callInfos[i0]));
            }
            return result.AsReadOnly();
        }

        public int SetSpeaker(bool state) => PhoneSetSpeaker(state ? 1 : 0);
    }
}

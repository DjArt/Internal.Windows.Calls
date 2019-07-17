using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls.PhoneOm
{
    public enum PhoneListenerEventType : int
    {
        PhoneStateChanged = 1,
        ActionAvailabilityChanged = 2,
        RecordingStateChanged = 2,
        AudioStateChanged4 = 2,
        AudioStateChanged = 3,
        AudioStateChanged2 = 4,
        AudioStateChanged3 = 5,
        LineRegistrationInfoChanged = 7,
        LineConfigurationChanged = 8,
        LineVoicemailCountChanged = 8,
        LineSignalStrengthChanged = 9,
        LineVoicemailConnectivityChanged = 10,
        Error = 11,
        AlertMessage = 12,
        ModifyLineSettingComplete = 13,
        ModifyLineSettingComplete2 = 14,
        ModifyLineSettingComplete3 = 15,
        LineComponentsChanged = 16,
        LineLockInfoChanged = 17,
        NewLineCreated3 = 22,
        LineConfigurationChanged2 = 22,
        LineRegistrationInfoChanged2 = 22,
        ModifyLineSettingComplete4 = 23,
        NewLineCreated = 24,
        ReleaseLine = 25,
        WifiCallDropWarning = 27,
        LineBluetoothHandsFreeDeviceStateChanged = 28,
        EmergencyCallDialerRequired = 34,
        NewLineCreated2 = -1, //!!!!!!!
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Internal.Windows.Calls.PhoneOm;

namespace Internal.Windows.Calls
{
    public sealed class AvailableActions
    {
        internal PH_AVAILABLE_ACTIONS InternalStruct;

        public bool MakeCallAvailable => InternalStruct.MakeCallAvailable;
        public bool AnswerAvailable => InternalStruct.AnswerAvailable;
        public bool IgnoreAvailable => InternalStruct.IgnoreAvailable;
        public bool DropAcceptAvailable => InternalStruct.DropAcceptAvailable;
        public bool EndCallAvailable => InternalStruct.EndCallAvailable;
        public bool SpeakerPhoneOnAvailable => InternalStruct.SpeakerPhoneOnAvailable;
        public bool SpeakerPhoneOffAvailable => InternalStruct.SpeakerPhoneOffAvailable;
        public bool MuteAvailable => InternalStruct.MuteAvailable;
        public bool UnmuteAvailable => InternalStruct.UnmuteAvailable;
        public bool HoldAvailable => InternalStruct.HoldAvailable;
        public bool UnholdAvailable => InternalStruct.UnholdAvailable;
        public bool ConferenceAvailable => InternalStruct.ConferenceAvailable;
        public bool FlashAvailable => InternalStruct.FlashAvailable;
        public bool SwapAvailable => InternalStruct.SwapAvailable;
        public bool PrivateAvailable => InternalStruct.PrivateAvailable;
        public bool DropFromConferenceAvailable => InternalStruct.DropFromConferenceAvailable;
        public bool BluetoothHandsFreeStateOnAvailable => InternalStruct.BluetoothHandsFreeStateOnAvailable;
        public bool BluetoothHandsFreeStateOffAvailable => InternalStruct.BluetoothHandsFreeStateOffAvailable;
        public bool WiredHeadsetInUse => InternalStruct.WiredHeadsetInUse;
        public bool UserInitiatedEnd => InternalStruct.UserInitiatedEnd;
        public bool KeypadDeployedForCall => InternalStruct.KeypadDeployedForCall;
        public bool field_1538 => InternalStruct.field_1538;
        public bool field_153C => InternalStruct.field_153C;
        public bool DisableLocalVideoAvailable => InternalStruct.DisableLocalVideoAvailable;
        public bool EnableLocalVideoAvailable => InternalStruct.EnableLocalVideoAvailable;
        public bool AddVideoAvailable => InternalStruct.AddVideoAvailable;
        public bool DropVideoAvailable => InternalStruct.DropVideoAvailable;
        public bool AcceptVideoAvailable => InternalStruct.AcceptVideoAvailable;
        public bool RejectVideoAvailable => InternalStruct.RejectVideoAvailable;
        public bool SetVideoPausedAvailable => InternalStruct.SetVideoPausedAvailable;
        public bool StartRecordingAvailable => InternalStruct.StartRecordingAvailable;
        public bool PauseRecordingAvailable => InternalStruct.PauseRecordingAvailable;

        internal AvailableActions(PH_AVAILABLE_ACTIONS @struct)
        {
            InternalStruct = @struct;
        }
    }
}

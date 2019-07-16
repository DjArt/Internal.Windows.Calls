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

        public bool MakeCallAvailable
        {
            get
            {
                switch (InternalStruct.MakeCallAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(MakeCallAvailable)}={InternalStruct.MakeCallAvailable}");
                }
            }
        }
        public bool AnswerAvailable
        {
            get
            {
                switch (InternalStruct.AnswerAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(AnswerAvailable)}={InternalStruct.AnswerAvailable}");
                }
            }
        }
        public bool IgnoreAvailable
        {
            get
            {
                switch (InternalStruct.IgnoreAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(IgnoreAvailable)}={InternalStruct.IgnoreAvailable}");
                }
            }
        }
        public bool DropAcceptAvailable
        {
            get
            {
                switch (InternalStruct.DropAcceptAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(DropAcceptAvailable)}={InternalStruct.DropAcceptAvailable}");
                }
            }
        }
        public bool EndCallAvailable
        {
            get
            {
                switch (InternalStruct.EndCallAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(EndCallAvailable)}={InternalStruct.EndCallAvailable}");
                }
            }
        }
        public bool SpeakerPhoneOnAvailable
        {
            get
            {
                switch (InternalStruct.SpeakerPhoneOnAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(SpeakerPhoneOnAvailable)}={InternalStruct.SpeakerPhoneOnAvailable}");
                }
            }
        }
        public bool SpeakerPhoneOffAvailable
        {
            get
            {
                switch (InternalStruct.SpeakerPhoneOffAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(SpeakerPhoneOffAvailable)}={InternalStruct.SpeakerPhoneOffAvailable}");
                }
            }
        }
        public bool MuteAvailable
        {
            get
            {
                switch (InternalStruct.MuteAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(MuteAvailable)}={InternalStruct.MuteAvailable}");
                }
            }
        }
        public bool UnmuteAvailable
        {
            get
            {
                switch (InternalStruct.UnmuteAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(UnmuteAvailable)}={InternalStruct.UnmuteAvailable}");
                }
            }
        }
        public bool HoldAvailable
        {
            get
            {
                switch (InternalStruct.HoldAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(HoldAvailable)}={InternalStruct.HoldAvailable}");
                }
            }
        }
        public bool UnholdAvailable
        {
            get
            {
                switch (InternalStruct.UnholdAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(UnholdAvailable)}={InternalStruct.UnholdAvailable}");
                }
            }
        }
        public bool ConferenceAvailable
        {
            get
            {
                switch (InternalStruct.ConferenceAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(ConferenceAvailable)}={InternalStruct.ConferenceAvailable}");
                }
            }
        }
        public bool FlashAvailable
        {
            get
            {
                switch (InternalStruct.FlashAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(FlashAvailable)}={InternalStruct.FlashAvailable}");
                }
            }
        }
        public bool SwapAvailable
        {
            get
            {
                switch (InternalStruct.SwapAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(SwapAvailable)}={InternalStruct.SwapAvailable}");
                }
            }
        }
        public bool PrivateAvailable
        {
            get
            {
                switch (InternalStruct.PrivateAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(PrivateAvailable)}={InternalStruct.PrivateAvailable}");
                }
            }
        }
        public bool DropFromConferenceAvailable
        {
            get
            {
                switch (InternalStruct.DropFromConferenceAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(DropFromConferenceAvailable)}={InternalStruct.DropFromConferenceAvailable}");
                }
            }
        }
        public bool BluetoothHandsFreeStateOnAvailable
        {
            get
            {
                switch (InternalStruct.BluetoothHandsFreeStateOnAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(BluetoothHandsFreeStateOnAvailable)}={InternalStruct.BluetoothHandsFreeStateOnAvailable}");
                }
            }
        }
        public bool BluetoothHandsFreeStateOffAvailable
        {
            get
            {
                switch (InternalStruct.BluetoothHandsFreeStateOffAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(BluetoothHandsFreeStateOffAvailable)}={InternalStruct.BluetoothHandsFreeStateOffAvailable}");
                }
            }
        }
        public bool WiredHeadsetInUse
        {
            get
            {
                switch (InternalStruct.WiredHeadsetInUse)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(WiredHeadsetInUse)}={InternalStruct.WiredHeadsetInUse}");
                }
            }
        }
        public bool UserInitiatedEnd
        {
            get
            {
                switch (InternalStruct.UserInitiatedEnd)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(UserInitiatedEnd)}={InternalStruct.UserInitiatedEnd}");
                }
            }
        }
        public bool KeypadDeployedForCall
        {
            get
            {
                switch (InternalStruct.KeypadDeployedForCall)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(KeypadDeployedForCall)}={InternalStruct.KeypadDeployedForCall}");
                }
            }
        }
        public bool field_1538
        {
            get
            {
                switch (InternalStruct.field_1538)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(field_1538)}={InternalStruct.field_1538}");
                }
            }
        }
        public bool field_153C
        {
            get
            {
                switch (InternalStruct.field_153C)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(field_153C)}={InternalStruct.field_153C}");
                }
            }
        }
        public bool DisableLocalVideoAvailable
        {
            get
            {
                switch (InternalStruct.DisableLocalVideoAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(DisableLocalVideoAvailable)}={InternalStruct.DisableLocalVideoAvailable}");
                }
            }
        }
        public bool EnableLocalVideoAvailable
        {
            get
            {
                switch (InternalStruct.EnableLocalVideoAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(EnableLocalVideoAvailable)}={InternalStruct.EnableLocalVideoAvailable}");
                }
            }
        }
        public bool AddVideoAvailable
        {
            get
            {
                switch (InternalStruct.AddVideoAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(AddVideoAvailable)}={InternalStruct.AddVideoAvailable}");
                }
            }
        }
        public bool DropVideoAvailable
        {
            get
            {
                switch (InternalStruct.DropVideoAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(DropVideoAvailable)}={InternalStruct.DropVideoAvailable}");
                }
            }
        }
        public bool AcceptVideoAvailable
        {
            get
            {
                switch (InternalStruct.AcceptVideoAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(AcceptVideoAvailable)}={InternalStruct.AcceptVideoAvailable}");
                }
            }
        }
        public bool RejectVideoAvailable
        {
            get
            {
                switch (InternalStruct.RejectVideoAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(RejectVideoAvailable)}={InternalStruct.RejectVideoAvailable}");
                }
            }
        }
        public bool SetVideoPausedAvailable
        {
            get
            {
                switch (InternalStruct.SetVideoPausedAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(SetVideoPausedAvailable)}={InternalStruct.SetVideoPausedAvailable}");
                }
            }
        }
        public bool StartRecordingAvailable
        {
            get
            {
                switch (InternalStruct.StartRecordingAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(StartRecordingAvailable)}={InternalStruct.StartRecordingAvailable}");
                }
            }
        }
        public bool PauseRecordingAvailable
        {
            get
            {
                switch (InternalStruct.PauseRecordingAvailable)
                {
                    case 0:
                        return false;
                    case 1:
                        return true;
                    default:
                        throw new Exception($"API prediction error: {nameof(PauseRecordingAvailable)}={InternalStruct.PauseRecordingAvailable}");
                }
            }
        }

        internal AvailableActions(PH_AVAILABLE_ACTIONS @struct)
        {
            InternalStruct = @struct;
        }
    }
}

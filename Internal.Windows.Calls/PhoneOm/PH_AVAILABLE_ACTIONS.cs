using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls.PhoneOm
{
    [StructLayout(LayoutKind.Explicit, Size = 0x80)]
    internal struct PH_AVAILABLE_ACTIONS
    {
        [FieldOffset(0x0)]
        public bool MakeCallAvailable;
        [FieldOffset(0x4)]
        public bool AnswerAvailable;
        [FieldOffset(0x8)]
        public bool IgnoreAvailable;
        [FieldOffset(0xC)]
        public bool DropAcceptAvailable;
        [FieldOffset(0x10)]
        public bool EndCallAvailable;
        [FieldOffset(0x14)]
        public bool SpeakerPhoneOnAvailable;
        [FieldOffset(0x18)]
        public bool SpeakerPhoneOffAvailable;
        [FieldOffset(0x1C)]
        public bool MuteAvailable;
        [FieldOffset(0x20)]
        public bool UnmuteAvailable;
        [FieldOffset(0x24)]
        public bool HoldAvailable;
        [FieldOffset(0x28)]
        public bool UnholdAvailable;
        [FieldOffset(0x2C)]
        public bool ConferenceAvailable;
        [FieldOffset(0x30)]
        public bool FlashAvailable;
        [FieldOffset(0x34)]
        public bool SwapAvailable;
        [FieldOffset(0x38)]
        public bool PrivateAvailable;
        [FieldOffset(0x3C)]
        public bool DropFromConferenceAvailable;
        [FieldOffset(0x40)]
        public bool BluetoothHandsFreeStateOnAvailable;
        [FieldOffset(0x44)]
        public bool BluetoothHandsFreeStateOffAvailable;
        [FieldOffset(0x48)]
        public bool WiredHeadsetInUse;
        [FieldOffset(0x4C)]
        public bool UserInitiatedEnd;
        [FieldOffset(0x50)]
        public bool KeypadDeployedForCall;
        [FieldOffset(0x54)]
        public bool field_1538;
        [FieldOffset(0x58)]
        public bool field_153C;
        [FieldOffset(0x5C)]
        public bool DisableLocalVideoAvailable;
        [FieldOffset(0x60)]
        public bool EnableLocalVideoAvailable;
        [FieldOffset(0x64)]
        public bool AddVideoAvailable;
        [FieldOffset(0x68)]
        public bool DropVideoAvailable;
        [FieldOffset(0x6C)]
        public bool AcceptVideoAvailable;
        [FieldOffset(0x70)]
        public bool RejectVideoAvailable;
        [FieldOffset(0x74)]
        public bool SetVideoPausedAvailable;
        [FieldOffset(0x78)]
        public bool StartRecordingAvailable;
        [FieldOffset(0x7C)]
        public bool PauseRecordingAvailable;
    }
}

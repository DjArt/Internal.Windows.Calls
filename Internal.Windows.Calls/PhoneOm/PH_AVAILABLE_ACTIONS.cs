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
        public int MakeCallAvailable;
        [FieldOffset(0x4)]
        public int AnswerAvailable;
        [FieldOffset(0x8)]
        public int IgnoreAvailable;
        [FieldOffset(0xC)]
        public int DropAcceptAvailable;
        [FieldOffset(0x10)]
        public int EndCallAvailable;
        [FieldOffset(0x14)]
        public int SpeakerPhoneOnAvailable;
        [FieldOffset(0x18)]
        public int SpeakerPhoneOffAvailable;
        [FieldOffset(0x1C)]
        public int MuteAvailable;
        [FieldOffset(0x20)]
        public int UnmuteAvailable;
        [FieldOffset(0x24)]
        public int HoldAvailable;
        [FieldOffset(0x28)]
        public int UnholdAvailable;
        [FieldOffset(0x2C)]
        public int ConferenceAvailable;
        [FieldOffset(0x30)]
        public int FlashAvailable;
        [FieldOffset(0x34)]
        public int SwapAvailable;
        [FieldOffset(0x38)]
        public int PrivateAvailable;
        [FieldOffset(0x3C)]
        public int DropFromConferenceAvailable;
        [FieldOffset(0x40)]
        public int BluetoothHandsFreeStateOnAvailable;
        [FieldOffset(0x44)]
        public int BluetoothHandsFreeStateOffAvailable;
        [FieldOffset(0x48)]
        public int WiredHeadsetInUse;
        [FieldOffset(0x4C)]
        public int UserInitiatedEnd;
        [FieldOffset(0x50)]
        public int KeypadDeployedForCall;
        [FieldOffset(0x54)]
        public int field_1538;
        [FieldOffset(0x58)]
        public int field_153C;
        [FieldOffset(0x5C)]
        public int DisableLocalVideoAvailable;
        [FieldOffset(0x60)]
        public int EnableLocalVideoAvailable;
        [FieldOffset(0x64)]
        public int AddVideoAvailable;
        [FieldOffset(0x68)]
        public int DropVideoAvailable;
        [FieldOffset(0x6C)]
        public int AcceptVideoAvailable;
        [FieldOffset(0x70)]
        public int RejectVideoAvailable;
        [FieldOffset(0x74)]
        public int SetVideoPausedAvailable;
        [FieldOffset(0x78)]
        public int StartRecordingAvailable;
        [FieldOffset(0x7C)]
        public int PauseRecordingAvailable;
    }
}

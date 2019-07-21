using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace Internal.Windows.Calls.PhoneOm
{
    internal unsafe static partial class Exports
    {
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void CreatePhoneRpcClient();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void DTMFModeListener_CreateInstance();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void GetBluetoothHandsFreeLineInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void IsCallOriginManagerSupported();
        /// <summary>
        /// Initialize the Phone API set. Clients of the Phone Call Control APIs must call this API before calling any of the other Phone Call Control APIs.
        /// </summary>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneAPIInitialize();
        /// <summary>
        /// Uninitialize the Phone API set. Clients of the Phone Call Control APIs should call this to clean up.
        /// </summary>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneAPIUninitialize();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneAcceptIncoming();
        /// <summary>
        /// Accept an incoming call, with additional parameters to control aspects of the call being
        /// accepted.
        /// </summary>
        /// <param name="parameters">
        /// Parameters that dictate which call is accepted, and additional aspects of the call
        /// being accepted.
        /// </param>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneAcceptIncomingEx(ref uint callID);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneAcceptUpgradingRealTimeTextCall();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneAcceptVideo(ref uint callID);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneActivateVisualVoicemail();
        /// <summary>
        /// Allows the caller to specify a callback function ptr that
        /// will get called when the state of phone data changes or
        /// when an error occurs.
        /// </summary>
        /// <param name="changeEventNotify">Callback function pointer</param>
        /// <param name="eventTypes">Pointer to an array of PH_EVENTs</param>
        /// <param name="typesCount">Number of elements in <paramref name="eventTypes" />
        /// array.</param>
        /// <param name="userData">Any caller specific data that is sent to the callback notification function.</param>
        /// <param name="phoneListener">Pointer to the listener handle</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneAddListener([MarshalAs(UnmanagedType.FunctionPtr)]PH_CHANGE_EVENT_NOTIFY_FUNCTION changeEventNotify, [MarshalAs(UnmanagedType.LPArray)]PH_CHANGEEVENT[] eventTypes, uint typesCount, IntPtr userData, out IntPtr phoneListener);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneAddVideo();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneCallCapabilityAccessCheck();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneCallVoicemail();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneCancelNonSeamlessUpgrade();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneClearIdleCallsFromController();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneConference();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneConfirmNonSeamlessUpgrade();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneDeactivateVisualVoicemail();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneDial();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneDowngradeFromRealTimeTextCall();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneDropAccept();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneDropAcceptEx(ref uint callID);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneDropVideo(ref uint callID);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneEnableBluetoothHandsFree();
        /// <summary>
        /// End a given call in the system.
        /// </summary>
        /// <param name="callID">ID of the phone call.</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneEnd(ref uint callID);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneExecutePendingDtmfWait();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneExitEmergencyMode();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneExplicitCallTransfer();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneFinishRecording();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneFlash();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneFormatPhoneNumber();
        /// <summary>
        /// Releases memory allocated for PH_CALL_INFO array
        /// </summary>
        /// <param name="callInfos">Pointer to PH_CALL_INFO</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneFreeCallInfo(IntPtr callInfos);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneFreeRecordingApplicationList();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetActiveAppByType();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetActiveSpamFilterApp();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetAggregateBranding();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetAppListByType();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetAssistedDialNumber();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetAssistedDialSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetAvailableActions(ref uint callID, out PH_AVAILABLE_ACTIONS availableActions);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetBlockPrivateNumbersSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetBlockUnknownNumbersSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetBluetoothHandsFreeState();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetBrandingText();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetCallCounts(out PH_PHONE_CALL_COUNTS callCounts);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetCallInfo(ref uint callID, out PH_CALL_INFO callInfo);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetCallState();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetCallsInConference(ref uint conferenceID, out PH_CALL_INFO[] calls, out uint count);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetCellularApiComponentInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetContactPictureHandle();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetDefaultOutgoingLine();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetDeviceRealTimeTextAutomaticEnabled();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetDeviceRealTimeTextEnabled();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetDeviceSupportsVideoCalling();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetElapsedTime();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetLinePublicInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetLinePublicSettings();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ids">Must be cleared like <see cref="PhoneGetState"/></param>
        /// <param name="count"></param>
        /// <returns></returns>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetLines(out Guid* ids, out uint count);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetLinesEx();
        /// <summary>
        /// Returns the current mute state of the system.
        /// </summary>
        /// <param name="state">Mute state</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetMute(out bool state);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetNetworkAlert();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetPreferredCallUpgradeLine();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetProviderLineInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetProviderLineLockInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetProviderLineServiceInfo(ref Guid id, out PH_PROVIDER_LINE_SERVICE_INFO lineServiceInfo);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetProviderLineVvmConnectivityState();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetRecordingApplications();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetShouldMuteKeypad();
        /// <summary>
        /// Returns the speakerphone state of the system.
        /// </summary>
        /// <param name="state">SpeakerPhone state.</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetSpeaker(out bool state);
        /// <summary>
        /// Returns the state of all phone calls.
        /// </summary>
        /// <param name="callInfos">
        /// Returns a pointer to an array of PH_CALL_INFO, which must be freed with LocalFree
        /// when the caller is finished. This array is allocated and returned even if there are
        /// no calls (the value returned in <paramref name="count"/> is 0).
        /// Conference calls are treated as a single entity, and calls within conferences
        /// are not returned by this API. Use <see cref="PhoneGetCallsInConference" /> to get
        /// a conference's member calls.
        /// </param>
        /// <param name="count">
        /// Returns the number of calls in <paramref name="callInfos" />.
        /// </param>
        /// <param name="callCounts">If supplied, returns PH_PHONE_CALL_COUNTS.</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetState([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)]out PH_CALL_INFO[] callInfos, out uint count, out PH_PHONE_CALL_COUNTS callCounts);
        //public static extern void PhoneGetState(out IntPtr callInfos, out uint count, out PH_PHONE_CALL_COUNTS callCounts);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetVideoCapabilities();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetVideoCapabilitySharingSettings();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetVisualVoicemailAccessor();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetVisualVoicemailBranding();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetVoicemailNumberAndOverrideInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneGetWiredHeadsetState(out bool state);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneHandleAppUninstallByType();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneInitiateCallUpgrade();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneInitiateRetrievalOfCIDRestrictionSupport();
        /// <summary>
        /// Returns whether an action is available or not
        /// based on the current phone system state.
        /// E.g. PH_ACTION_SWAP is an available action if
        /// there are two calls in the phone system.
        /// </summary>
        /// <param name="callID">ID of the phone call.</param>
        /// <param name="action">One of PH_ACTION values</param>
        /// <remarks>
        /// If <paramref name="callID"/> is nullptr, then
        /// this API returns TRUE, if <paramref name="action"/> is available 
        /// on the phone system.
        /// Otherwise this API returns TRUE if <paramref name="action"/> can be
        /// performed on <paramref name="callID"/> or on the phone system.
        /// </remarks>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern bool PhoneIsActionAvailable(ref uint callID, int action);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneIsDtmfWaitPending();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneIsEmergencyNumber();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneIsImmediateDialString();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneIsPhoneNumberInBlockList();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneIsVideoCallingEnabled();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneIsVideoCallingSwitchActionable();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneIsVoiceRoamingRestrictionActive();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneIsVvmSetupComplete();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneLineAddCapabilities();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneLineRemoveCapabilities();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneMapIddPrefixToPlus();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneMapPlusToDialingPrefix();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneMarkDataAffinityNotificationSeen();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneMarkVvmSetupComplete();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneModifyCallForwarding();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneModifyCallerIdSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneModifyVideoCallingSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneModifyVoicemailAddress();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneNotificationHelper_CreateInstance();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhonePauseRecording(ref uint callID);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhonePrivate();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhonePublicDial();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneRefreshCallForwardingState();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneRefreshEcbmState();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneRefreshVideoCallingSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneReinitiateCallerIdLookup(ref uint callID);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneRejectIncoming(ref uint callID);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneRejectIncomingForTextReply();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneRejectVideo();
        /// <summary>
        /// Removes a given listener.
        /// </summary>
        /// <param name="phoneListener">The HPHONELISTENER returned by PhoneAddListener in phoneListener.</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneRemoveListener(IntPtr phoneListener);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSaveVvmPassword();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSendDTMF();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSendDTMFStart();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSendDTMFStop();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSendRealTimeTextData();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetActiveAppByType();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetActiveSpamFilterApp();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetBlockPrivateNumbersSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetBlockUnknownNumbersSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetBluetoothHfpCallAudioTransfer();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetCallOriginInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetCallerAsActiveAppByType();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetFilterAppBlockList();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetForegroundLine(ref Guid lineID);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetHold(ref uint callID, bool state);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetLocalVideo();
        /// <summary>
        /// Mute phone system.
        /// </summary>
        /// <param name="state">Whether to mute or unmute</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetMute(bool state);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetPreferredCallUpgradeLine();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetRecordingApplication();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetReminderInfo();
        /// <summary>
        /// Turn on/off speakerphone.
        /// </summary>
        /// <param name="state">Whether to turn on/off the speakerphone.</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetSpeaker(bool state);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetVideoCapabilitySharingSettings();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSetVideoPaused();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSpamFilteringEnabled();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneStartRecording();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneStartVisualVoicemailSync();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSupportsLocalVvmConfig();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneSwap();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneUpgradeToRealTimeTextCall();
        /// <summary>
        /// Blocks until the phone service is loaded and ready for Phone API requests.
        /// </summary>
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void PhoneWaitForAPIReady(int wait);
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void RetrieveSystemNotificationCallbackPayload();
        [DllImport("PhoneOm.dll", ExactSpelling = true, PreserveSig = false)]
        public static extern void ShouldPlayCallWaitingTone();
    }
}

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
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int CreatePhoneRpcClient();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int DTMFModeListener_CreateInstance();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int GetBluetoothHandsFreeLineInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int IsCallOriginManagerSupported();
        /// <summary>
        /// Initialize the Phone API set. Clients of the Phone Call Control APIs must call this API before calling any of the other Phone Call Control APIs.
        /// </summary>
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneAPIInitialize();
        /// <summary>
        /// Uninitialize the Phone API set. Clients of the Phone Call Control APIs should call this to clean up.
        /// </summary>
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneAPIUninitialize();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneAcceptIncoming();
        /// <summary>
        /// Accept an incoming call, with additional parameters to control aspects of the call being
        /// accepted.
        /// </summary>
        /// <param name="parameters">
        /// Parameters that dictate which call is accepted, and additional aspects of the call
        /// being accepted.
        /// </param>
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneAcceptIncomingEx(ref int callID);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneAcceptUpgradingRealTimeTextCall();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneAcceptVideo(ref int callID);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneActivateVisualVoicemail();
        /// <summary>
        /// Allows the caller to specify a callback function ptr that
        /// will get called when the state of phone data changes or
        /// when an error occurs.
        /// </summary>
        /// <param name="changeEventNotify">Callback function pointer</param>
        /// <param name="changeEvents">Pointer to an array of PH_EVENTs</param>
        /// <param name="eventsCount">Number of elements in <paramref name="changeEvents" />
        /// array.</param>
        /// <param name="userData">Any caller specific data that is sent to the callback notification function.</param>
        /// <param name="phoneListener">Pointer to the listener handle</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneAddListener([MarshalAs(UnmanagedType.FunctionPtr)]PH_CHANGE_EVENT_NOTIFY_FUNCTION changeEventNotify, int[] changeEvents, uint eventsCount, IntPtr userData, out IntPtr phoneListener);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneAddVideo();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneCallCapabilityAccessCheck();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneCallVoicemail();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneCancelNonSeamlessUpgrade();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneClearIdleCallsFromController();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneConference();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneConfirmNonSeamlessUpgrade();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneDeactivateVisualVoicemail();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneDial();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneDowngradeFromRealTimeTextCall();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneDropAccept();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneDropAcceptEx();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneDropVideo(ref int callID);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneEnableBluetoothHandsFree();
        /// <summary>
        /// End a given call in the system.
        /// </summary>
        /// <param name="callID">ID of the phone call.</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneEnd(ref int callID);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneExecutePendingDtmfWait();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneExitEmergencyMode();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneExplicitCallTransfer();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneFinishRecording();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneFlash();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneFormatPhoneNumber();
        /// <summary>
        /// Releases memory allocated for PH_CALL_INFO array
        /// </summary>
        /// <param name="callInfos">Pointer to PH_CALL_INFO</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneFreeCallInfo(ref PH_CALL_INFO* callInfoss);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneFreeRecordingApplicationList();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetActiveAppByType();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetActiveSpamFilterApp();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetAggregateBranding();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetAppListByType();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetAssistedDialNumber();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetAssistedDialSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetAvailableActions(ref int callID, out PH_AVAILABLE_ACTIONS availableActions);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetBlockPrivateNumbersSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetBlockUnknownNumbersSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetBluetoothHandsFreeState();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetBrandingText();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetCallCounts(out PH_PHONE_CALL_COUNTS callCounts);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetCallInfo(ref int callID, out PH_CALL_INFO callInfo);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetCallState();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetCallsInConference(ref int conferenceID, out PH_CALL_INFO* calls, out uint count);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetCellularApiComponentInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetContactPictureHandle();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetDefaultOutgoingLine();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetDeviceRealTimeTextAutomaticEnabled();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetDeviceRealTimeTextEnabled();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetDeviceSupportsVideoCalling();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetElapsedTime();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetLinePublicInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetLinePublicSettings();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetLines();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetLinesEx();
        /// <summary>
        /// Returns the current mute state of the system.
        /// </summary>
        /// <param name="state">Mute state</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetMute(out bool state);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetNetworkAlert();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetPreferredCallUpgradeLine();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetProviderLineInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetProviderLineLockInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetProviderLineServiceInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetProviderLineVvmConnectivityState();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetRecordingApplications();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetShouldMuteKeypad();
        /// <summary>
        /// Returns the speakerphone state of the system.
        /// </summary>
        /// <param name="state">SpeakerPhone state.</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetSpeaker(out bool state);
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
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetState(out PH_CALL_INFO* callInfos, out uint count, out PH_PHONE_CALL_COUNTS callCounts);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetVideoCapabilities();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetVideoCapabilitySharingSettings();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetVisualVoicemailAccessor();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetVisualVoicemailBranding();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetVoicemailNumberAndOverrideInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneGetWiredHeadsetState(out bool inUse);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneHandleAppUninstallByType();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneInitiateCallUpgrade();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneInitiateRetrievalOfCIDRestrictionSupport();
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
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern bool PhoneIsActionAvailable(ref int callID, int action);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneIsDtmfWaitPending();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneIsEmergencyNumber();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneIsImmediateDialString();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneIsPhoneNumberInBlockList();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneIsVideoCallingEnabled();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneIsVideoCallingSwitchActionable();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneIsVoiceRoamingRestrictionActive();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneIsVvmSetupComplete();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneLineAddCapabilities();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneLineRemoveCapabilities();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneMapIddPrefixToPlus();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneMapPlusToDialingPrefix();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneMarkDataAffinityNotificationSeen();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneMarkVvmSetupComplete();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneModifyCallForwarding();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneModifyCallerIdSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneModifyVideoCallingSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneModifyVoicemailAddress();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneNotificationHelper_CreateInstance();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhonePauseRecording();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhonePrivate();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhonePublicDial();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneRefreshCallForwardingState();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneRefreshEcbmState();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneRefreshVideoCallingSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneReinitiateCallerIdLookup(ref int callID);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneRejectIncoming(ref int callID);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneRejectIncomingForTextReply();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneRejectVideo();
        /// <summary>
        /// Removes a given listener.
        /// </summary>
        /// <param name="phoneListener">[In] The HPHONELISTENER returned by PhoneAddListener in phoneListener.</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneRemoveListener(IntPtr phoneListener);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSaveVvmPassword();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSendDTMF();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSendDTMFStart();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSendDTMFStop();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSendRealTimeTextData();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetActiveAppByType();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetActiveSpamFilterApp();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetBlockPrivateNumbersSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetBlockUnknownNumbersSetting();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetBluetoothHfpCallAudioTransfer();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetCallOriginInfo();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetCallerAsActiveAppByType();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetFilterAppBlockList();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetForegroundLine();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetHold(ref int callID, bool state);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetLocalVideo();
        /// <summary>
        /// Mute phone system.
        /// </summary>
        /// <param name="state">Whether to mute or unmute</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetMute(bool state);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetPreferredCallUpgradeLine();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetRecordingApplication();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetReminderInfo();
        /// <summary>
        /// Turn on/off speakerphone.
        /// </summary>
        /// <param name="state">Whether to turn on/off the speakerphone.</param>
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetSpeaker(bool state);
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetVideoCapabilitySharingSettings();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSetVideoPaused();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSpamFilteringEnabled();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneStartRecording();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneStartVisualVoicemailSync();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSupportsLocalVvmConfig();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneSwap();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneUpgradeToRealTimeTextCall();
        /// <summary>
        /// Blocks until the phone service is loaded and ready for Phone API requests.
        /// </summary>
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int PhoneWaitForAPIReady();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int RetrieveSystemNotificationCallbackPayload();
        [DllImport("PhoneOm.dll", ExactSpelling = true)]
        public static extern int ShouldPlayCallWaitingTone();
    }
}

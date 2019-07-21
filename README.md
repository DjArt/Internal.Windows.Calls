# Internal.Windows.Calls
Exposes internal Windows API to WinRT. Allowing to manipulate all calls, that use `Windows.ApplicationModel.Calls` API(ex. Skype or phone calls with supported MBB modem).

# How to use
UWP applications must declare `<rescap:Capability Name="phoneCallSystem" />` capability for using this API.

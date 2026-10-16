namespace Steamworks;

[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
public sealed class SteamAPIWarningMessageHook_t : MulticastDelegate
{

	public SteamAPIWarningMessageHook_t(object object, IntPtr method) { }

	public override void Invoke(int nSeverity, StringBuilder pchDebugText) { }

}


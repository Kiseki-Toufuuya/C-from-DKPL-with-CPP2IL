namespace System.Runtime.Interop;

internal sealed class SafeEventLogWriteHandle : SafeHandleZeroOrMinusOneIsInvalid
{

	private SafeEventLogWriteHandle() { }

	private static bool DeregisterEventSource(IntPtr hEventLog) { }

	public static SafeEventLogWriteHandle RegisterEventSource(string uncServerName, string sourceName) { }

	protected virtual bool ReleaseHandle() { }

}


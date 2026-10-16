namespace System.Runtime.Interop;

internal static class UnsafeNativeMethods
{
	public sealed class EtwEnableCallback : MulticastDelegate
	{

		public EtwEnableCallback(object object, IntPtr method) { }

		public override void Invoke(in Guid sourceId, in int isEnabled, in byte level, in long matchAnyKeywords, in long matchAllKeywords, in Void* filterData, in Void* callbackContext) { }

	}

	internal struct EventData
	{
		internal ulong DataPointer; //Field offset: 0x0
		internal uint Size; //Field offset: 0x8
		internal int Reserved; //Field offset: 0xC

	}


	internal static uint EventActivityIdControl(in int ControlCode, out Guid ActivityId) { }

	internal static bool EventEnabled(in long registrationHandle, in EventDescriptor eventDescriptor) { }

	internal static uint EventRegister(in Guid providerId, in EtwEnableCallback enableCallback, in Void* callbackContext, out long registrationHandle) { }

	internal static uint EventUnregister(in long registrationHandle) { }

	internal static uint EventWrite(in long registrationHandle, in EventDescriptor eventDescriptor, in uint userDataCount, in EventData* userData) { }

	internal static SafeEventLogWriteHandle RegisterEventSource(string uncServerName, string sourceName) { }

	internal static bool ReportEvent(SafeHandle hEventLog, ushort type, ushort category, uint eventID, Byte[] userSID, ushort numStrings, uint dataLen, HandleRef strings, Byte[] rawData) { }

}


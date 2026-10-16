namespace System.Runtime.Diagnostics;

internal abstract class DiagnosticsEventProvider : IDisposable
{
	internal enum WriteEventErrorCode
	{
		NoError = 0,
		NoFreeBuffers = 1,
		EventTooBig = 2,
	}

	[ThreadStatic]
	private static WriteEventErrorCode errorCode; //Field offset: 0x80000000
	private EtwEnableCallback etwCallback; //Field offset: 0x8
	private long traceRegistrationHandle; //Field offset: 0x10
	private byte currentTraceLevel; //Field offset: 0x18
	private long anyKeywordMask; //Field offset: 0x20
	private long allKeywordMask; //Field offset: 0x28
	private bool isProviderEnabled; //Field offset: 0x30
	private Guid providerId; //Field offset: 0x34
	private int isDisposed; //Field offset: 0x44

	protected DiagnosticsEventProvider(Guid providerGuid) { }

	private void Deregister() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	private void EtwEnableCallBack(in Guid sourceId, in int isEnabled, in byte setLevel, in long anyKeyword, in long allKeyword, in Void* filterData, in Void* callbackContext) { }

	private void EtwRegister() { }

	protected virtual void Finalize() { }

	public bool IsEnabled() { }

	public bool IsEnabled(byte level, long keywords) { }

	public bool IsEventEnabled(ref EventDescriptor eventDescriptor) { }

	protected abstract void OnControllerCommand() { }

	public static void SetActivityId(ref Guid id) { }

	private static void SetLastError(int error) { }

	public bool WriteEvent(ref EventDescriptor eventDescriptor, EventTraceActivity eventTraceActivity, string data) { }

	protected private bool WriteEvent(ref EventDescriptor eventDescriptor, EventTraceActivity eventTraceActivity, int dataCount, IntPtr data) { }

}


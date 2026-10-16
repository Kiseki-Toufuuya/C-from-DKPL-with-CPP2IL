namespace System;

[ComVisible(True)]
public class Exception : ISerializable
{
	public enum ExceptionMessageKind
	{
		ThreadAbort = 1,
		ThreadInterrupted = 2,
		OutOfMemory = 3,
	}

	[OptionalField]
	private static object s_EDILock; //Field offset: 0x0
	private const int _COMPlusExceptionCode = -532462766; //Field offset: 0x0
	private string _className; //Field offset: 0x8
	internal string _message; //Field offset: 0xC
	private IDictionary _data; //Field offset: 0x10
	private Exception _innerException; //Field offset: 0x14
	private string _helpURL; //Field offset: 0x18
	private object _stackTrace; //Field offset: 0x1C
	private string _stackTraceString; //Field offset: 0x20
	private string _remoteStackTraceString; //Field offset: 0x24
	private int _remoteStackIndex; //Field offset: 0x28
	private object _dynamicMethods; //Field offset: 0x2C
	internal int _HResult; //Field offset: 0x30
	private string _source; //Field offset: 0x34
	[OptionalField(VersionAdded = 4)]
	private SafeSerializationManager _safeSerializationManager; //Field offset: 0x38
	internal StackTrace[] captured_traces; //Field offset: 0x3C
	private IntPtr[] native_trace_ips; //Field offset: 0x40
	private int caught_in_unmanaged; //Field offset: 0x44

	public override IDictionary Data
	{
		 get { } //Length: 87
	}

	public int HResult
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public override Exception InnerException
	{
		 get { } //Length: 11
	}

	public override string Message
	{
		 get { } //Length: 200
	}

	public override string Source
	{
		 get { } //Length: 289
	}

	public override string StackTrace
	{
		 get { } //Length: 66
	}

	public override MethodBase TargetSite
	{
		 get { } //Length: 149
	}

	private static Exception() { }

	public Exception() { }

	public Exception(string message) { }

	public Exception(string message, Exception innerException) { }

	protected Exception(SerializationInfo info, StreamingContext context) { }

	internal Exception FixRemotingException() { }

	public override IDictionary get_Data() { }

	public int get_HResult() { }

	public override Exception get_InnerException() { }

	public override string get_Message() { }

	public override string get_Source() { }

	public override string get_StackTrace() { }

	public override MethodBase get_TargetSite() { }

	private string GetClassName() { }

	internal static string GetMessageFromNativeResources(ExceptionMessageKind kind) { }

	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	private string GetStackTrace(bool needFileInfo) { }

	public override Type GetType() { }

	private void Init() { }

	[OnDeserialized]
	private void OnDeserialized(StreamingContext context) { }

	internal static void ReportUnhandledException(Exception exception) { }

	internal void RestoreExceptionDispatchInfo(ExceptionDispatchInfo exceptionDispatchInfo) { }

	protected void set_HResult(int value) { }

	internal void SetErrorCode(int hr) { }

	private string StripFileInfo(string stackTrace, bool isRemoteStackTrace) { }

	public virtual string ToString() { }

	private string ToString(bool needFileLineInfo, bool needMessage) { }

}


namespace System.Runtime.Diagnostics;

internal sealed class EventLogger
{
	private static int logCountForPT; //Field offset: 0x0
	private static bool canLogEvent; //Field offset: 0x4
	private DiagnosticTraceBase diagnosticTrace; //Field offset: 0x8
	private string eventLogSourceName; //Field offset: 0xC
	private bool isInPartialTrust; //Field offset: 0x10

	private static EventLogger() { }

	private EventLogger() { }

	[Obsolete("For System.Runtime.dll use only. Call FxTrace.EventLog instead")]
	public EventLogger(string eventLogSourceName, DiagnosticTraceBase diagnosticTrace) { }

	private static EventLogEntryType EventLogEntryTypeFromEventType(TraceEventType type) { }

	private bool IsInPartialTrust() { }

	public void LogEvent(TraceEventType type, ushort eventLogCategory, uint eventId, bool shouldTrace, String[] values) { }

	internal static string NormalizeEventLogParameter(string eventLogParameter) { }

	private void SafeLogEvent(TraceEventType type, ushort eventLogCategory, uint eventId, bool shouldTrace, String[] values) { }

	private void SafeSetLogSourceName(string eventLogSourceName) { }

	private void SetLogSourceName(string eventLogSourceName, DiagnosticTraceBase diagnosticTrace) { }

	public static EventLogger UnsafeCreateEventLogger(string eventLogSourceName, DiagnosticTraceBase diagnosticTrace) { }

	private int UnsafeGetProcessId() { }

	private string UnsafeGetProcessName() { }

	public void UnsafeLogEvent(TraceEventType type, ushort eventLogCategory, uint eventId, bool shouldTrace, String[] values) { }

	private void UnsafeWriteEventLog(TraceEventType type, ushort eventLogCategory, uint eventId, String[] logValues, Byte[] sidBA, GCHandle stringsRootHandle) { }

}


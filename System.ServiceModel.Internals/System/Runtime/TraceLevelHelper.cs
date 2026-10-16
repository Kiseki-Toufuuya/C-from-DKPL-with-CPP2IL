namespace System.Runtime;

internal class TraceLevelHelper
{
	private static TraceEventType[] EtwLevelToTraceEventType; //Field offset: 0x0

	private static TraceLevelHelper() { }

	internal static TraceEventType GetTraceEventType(TraceEventLevel level) { }

	internal static string LookupSeverity(TraceEventLevel level, TraceEventOpcode opcode) { }

}


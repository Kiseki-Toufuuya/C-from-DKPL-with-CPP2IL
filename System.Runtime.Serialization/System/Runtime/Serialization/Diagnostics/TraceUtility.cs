namespace System.Runtime.Serialization.Diagnostics;

internal static class TraceUtility
{
	private static Dictionary<Int32, String> traceCodes; //Field offset: 0x0

	private static TraceUtility() { }

	internal static void Trace(TraceEventType severity, int traceCode, string traceDescription) { }

	internal static void Trace(TraceEventType severity, int traceCode, string traceDescription, TraceRecord record) { }

	internal static void Trace(TraceEventType severity, int traceCode, string traceDescription, TraceRecord record, Exception exception) { }

}


namespace System.Runtime.Serialization;

internal static class DiagnosticUtility
{
	public static class DiagnosticTrace
	{

		internal static void TraceEvent(Object[] args) { }

	}

	public static class ExceptionUtility
	{

		internal static Exception ThrowHelper(Exception e, TraceEventType type) { }

		internal static Exception ThrowHelperArgument(string arg) { }

		internal static Exception ThrowHelperArgument(string arg, string message) { }

		internal static Exception ThrowHelperArgumentNull(string arg) { }

		internal static Exception ThrowHelperCallback(string msg, Exception e) { }

		internal static Exception ThrowHelperCallback(Exception e) { }

		internal static Exception ThrowHelperError(Exception e) { }

		internal static Exception ThrowHelperFatal(string msg, Exception e) { }

	}

	internal static bool ShouldTraceError; //Field offset: 0x0
	internal static readonly bool ShouldTraceWarning; //Field offset: 0x1
	internal static readonly bool ShouldTraceInformation; //Field offset: 0x2
	internal static bool ShouldTraceVerbose; //Field offset: 0x3

	private static DiagnosticUtility() { }

	internal static bool IsFatal(Exception exception) { }

}


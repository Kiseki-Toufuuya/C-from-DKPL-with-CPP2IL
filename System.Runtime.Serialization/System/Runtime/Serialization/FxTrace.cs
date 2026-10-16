namespace System.Runtime.Serialization;

internal static class FxTrace
{
	public static bool ShouldTraceError; //Field offset: 0x0
	public static bool ShouldTraceVerbose; //Field offset: 0x1

	public static ExceptionTrace Exception
	{
		 get { } //Length: 116
	}

	public static EtwDiagnosticTrace Trace
	{
		 get { } //Length: 11
	}

	private static FxTrace() { }

	public static ExceptionTrace get_Exception() { }

	public static EtwDiagnosticTrace get_Trace() { }

	public static bool IsEventEnabled(int index) { }

	public static void UpdateEventDefinitions(EventDescriptor[] ed, UInt16[] events) { }

}


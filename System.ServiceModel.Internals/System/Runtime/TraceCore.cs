namespace System.Runtime;

internal class TraceCore
{
	private static ResourceManager resourceManager; //Field offset: 0x0
	private static CultureInfo resourceCulture; //Field offset: 0x4
	private static EventDescriptor[] eventDescriptors; //Field offset: 0x8
	private static object syncLock; //Field offset: 0xC
	private static bool eventDescriptorsCreated; //Field offset: 0x10

	internal static CultureInfo Culture
	{
		internal get { } //Length: 61
	}

	private static ResourceManager ResourceManager
	{
		private get { } //Length: 282
	}

	private static TraceCore() { }

	internal static void ActionItemCallbackInvoked(EtwDiagnosticTrace trace, EventTraceActivity eventTraceActivity) { }

	internal static bool ActionItemCallbackInvokedIsEnabled(EtwDiagnosticTrace trace) { }

	internal static void ActionItemScheduled(EtwDiagnosticTrace trace, EventTraceActivity eventTraceActivity) { }

	internal static bool ActionItemScheduledIsEnabled(EtwDiagnosticTrace trace) { }

	internal static void AppDomainUnload(EtwDiagnosticTrace trace, string appdomainName, string processName, string processId) { }

	internal static bool AppDomainUnloadIsEnabled(EtwDiagnosticTrace trace) { }

	private static void CreateEventDescriptors() { }

	private static void EnsureEventDescriptors() { }

	internal static CultureInfo get_Culture() { }

	private static ResourceManager get_ResourceManager() { }

	internal static void HandledException(EtwDiagnosticTrace trace, string param0, Exception exception) { }

	internal static void HandledExceptionError(EtwDiagnosticTrace trace, string param0, Exception exception) { }

	internal static bool HandledExceptionErrorIsEnabled(EtwDiagnosticTrace trace) { }

	internal static bool HandledExceptionIsEnabled(EtwDiagnosticTrace trace) { }

	internal static void HandledExceptionVerbose(EtwDiagnosticTrace trace, string param0, Exception exception) { }

	internal static bool HandledExceptionVerboseIsEnabled(EtwDiagnosticTrace trace) { }

	internal static void HandledExceptionWarning(EtwDiagnosticTrace trace, string param0, Exception exception) { }

	internal static bool HandledExceptionWarningIsEnabled(EtwDiagnosticTrace trace) { }

	private static bool IsEtwEventEnabled(EtwDiagnosticTrace trace, int eventIndex) { }

	internal static void ShipAssertExceptionMessage(EtwDiagnosticTrace trace, string param0) { }

	internal static void ThrowingException(EtwDiagnosticTrace trace, string param0, string param1, Exception exception) { }

	internal static bool ThrowingExceptionIsEnabled(EtwDiagnosticTrace trace) { }

	internal static void TraceCodeEventLogCritical(EtwDiagnosticTrace trace, TraceRecord traceRecord) { }

	internal static bool TraceCodeEventLogCriticalIsEnabled(EtwDiagnosticTrace trace) { }

	internal static void TraceCodeEventLogError(EtwDiagnosticTrace trace, TraceRecord traceRecord) { }

	internal static bool TraceCodeEventLogErrorIsEnabled(EtwDiagnosticTrace trace) { }

	internal static void TraceCodeEventLogInfo(EtwDiagnosticTrace trace, TraceRecord traceRecord) { }

	internal static bool TraceCodeEventLogInfoIsEnabled(EtwDiagnosticTrace trace) { }

	internal static void TraceCodeEventLogVerbose(EtwDiagnosticTrace trace, TraceRecord traceRecord) { }

	internal static bool TraceCodeEventLogVerboseIsEnabled(EtwDiagnosticTrace trace) { }

	internal static void TraceCodeEventLogWarning(EtwDiagnosticTrace trace, TraceRecord traceRecord) { }

	internal static bool TraceCodeEventLogWarningIsEnabled(EtwDiagnosticTrace trace) { }

	internal static void UnhandledException(EtwDiagnosticTrace trace, string param0, Exception exception) { }

	internal static bool UnhandledExceptionIsEnabled(EtwDiagnosticTrace trace) { }

	private static bool WriteEtwEvent(EtwDiagnosticTrace trace, int eventIndex, EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3, string eventParam4) { }

	private static bool WriteEtwEvent(EtwDiagnosticTrace trace, int eventIndex, EventTraceActivity eventParam0, string eventParam1, string eventParam2, string eventParam3) { }

	private static bool WriteEtwEvent(EtwDiagnosticTrace trace, int eventIndex, EventTraceActivity eventParam0, string eventParam1, string eventParam2) { }

	private static bool WriteEtwEvent(EtwDiagnosticTrace trace, int eventIndex, EventTraceActivity eventParam0, string eventParam1) { }

	private static void WriteTraceSource(EtwDiagnosticTrace trace, int eventIndex, string description, TracePayload payload) { }

}


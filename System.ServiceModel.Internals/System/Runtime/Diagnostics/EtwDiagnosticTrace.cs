namespace System.Runtime.Diagnostics;

internal sealed class EtwDiagnosticTrace : DiagnosticTraceBase
{
	private static class StringBuilderPool
	{
		private static readonly ConcurrentQueue<StringBuilder> freeStringBuilders; //Field offset: 0x0

		private static StringBuilderPool() { }

		public static void Return(StringBuilder sb) { }

		public static StringBuilder Take() { }

	}

	public static readonly Guid ImmutableDefaultEtwProviderId; //Field offset: 0x0
	private static Guid defaultEtwProviderId; //Field offset: 0x10
	private static Hashtable etwProviderCache; //Field offset: 0x20
	private static bool isVistaOrGreater; //Field offset: 0x24
	private static Func<String> traceAnnotation; //Field offset: 0x28
	private static EventDescriptor transferEventDescriptor; //Field offset: 0x2C
	private EtwProvider etwProvider; //Field offset: 0x28
	private Guid etwProviderId; //Field offset: 0x2C

	public static Guid DefaultEtwProviderId
	{
		 get { } //Length: 72
	}

	public EtwProvider EtwProvider
	{
		 get { } //Length: 11
	}

	private bool EtwTracingEnabled
	{
		private get { } //Length: 15
	}

	public bool IsEnd2EndActivityTracingEnabled
	{
		 get { } //Length: 34
	}

	public bool IsEtwProviderEnabled
	{
		 get { } //Length: 24
	}

	public Action RefreshState
	{
		 get { } //Length: 23
		 set { } //Length: 39
	}

	private static EtwDiagnosticTrace() { }

	public EtwDiagnosticTrace(string traceSourceName, Guid etwProviderId) { }

	private static string BuildTrace(ref EventDescriptor eventDescriptor, string description, TracePayload payload, string msdnTraceCode) { }

	private void CreateEtwProvider(Guid etwProviderId) { }

	private void CreateTraceSource() { }

	internal static string ExceptionToTraceString(Exception exception, int maxTraceStringLength) { }

	private static void GenerateLegacyTraceCode(ref EventDescriptor eventDescriptor, out string msdnTraceCode, out int legacyEventId) { }

	private static string GenerateMsdnTraceCode(string traceSource, string traceCodeString) { }

	public static Guid get_DefaultEtwProviderId() { }

	public EtwProvider get_EtwProvider() { }

	private bool get_EtwTracingEnabled() { }

	public bool get_IsEnd2EndActivityTracingEnabled() { }

	public bool get_IsEtwProviderEnabled() { }

	public Action get_RefreshState() { }

	private static string GetExceptionData(Exception exception) { }

	private static string GetInnerException(Exception exception, int remainingLength, int remainingAllowedRecursionDepth) { }

	public TracePayload GetSerializedPayload(object source, TraceRecord traceRecord, Exception exception, bool getServiceReference) { }

	public TracePayload GetSerializedPayload(object source, TraceRecord traceRecord, Exception exception) { }

	public virtual bool IsEnabled() { }

	public bool IsEtwEventEnabled(ref EventDescriptor eventDescriptor, bool fullCheck) { }

	private static string LookupChannel(TraceChannel traceChannel) { }

	protected virtual void OnShutdownTracing() { }

	protected virtual void OnUnhandledException(Exception exception) { }

	public void set_RefreshState(Action value) { }

	public void SetEnd2EndActivityTracingEnabled(bool isEnd2EndTracingEnabled) { }

	public virtual bool ShouldTrace(TraceEventLevel level) { }

	public bool ShouldTraceToEtw(TraceEventLevel level) { }

	private void ShutdownEtwProvider() { }

	private void ShutdownTraceSource() { }

	public virtual void TraceEventLogEvent(TraceEventType type, TraceRecord traceRecord) { }

	private static void WriteExceptionToTraceString(XmlTextWriter xml, Exception exception, int remainingLength, int remainingAllowedRecursionDepth) { }

	private static bool WriteStartElement(XmlTextWriter xml, string localName, ref int remainingLength) { }

	public void WriteTraceSource(ref EventDescriptor eventDescriptor, string description, TracePayload payload) { }

	private static bool WriteXmlElementString(XmlTextWriter xml, string localName, string value, ref int remainingLength) { }

}


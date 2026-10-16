namespace System.Runtime.Diagnostics;

internal abstract class DiagnosticTraceBase
{
	protected static string AppDomainFriendlyName; //Field offset: 0x0
	private object thisLock; //Field offset: 0x8
	private bool tracingEnabled; //Field offset: 0xC
	private bool calledShutdown; //Field offset: 0xD
	private bool haveListeners; //Field offset: 0xE
	private SourceLevels level; //Field offset: 0x10
	protected string TraceSourceName; //Field offset: 0x14
	private TraceSource traceSource; //Field offset: 0x18
	private string eventSourceName; //Field offset: 0x1C
	[CompilerGenerated]
	private DateTime <LastFailure>k__BackingField; //Field offset: 0x20

	public static Guid ActivityId
	{
		 get { } //Length: 163
		 set { } //Length: 47
	}

	protected bool CalledShutdown
	{
		 get { } //Length: 11
	}

	protected string EventSourceName
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public bool HaveListeners
	{
		 get { } //Length: 11
	}

	protected DateTime LastFailure
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 20
	}

	public SourceLevels Level
	{
		 get { } //Length: 93
	}

	protected static int ProcessId
	{
		 get { } //Length: 248
	}

	protected static string ProcessName
	{
		 get { } //Length: 248
	}

	public TraceSource TraceSource
	{
		 get { } //Length: 11
	}

	public bool TracingEnabled
	{
		 get { } //Length: 25
	}

	private static DiagnosticTraceBase() { }

	public DiagnosticTraceBase(string traceSourceName) { }

	protected void AddDomainEventHandlersForCleanup() { }

	internal static string CreateDefaultSourceString(object source) { }

	protected static string CreateSourceString(object source) { }

	private void ExitOrUnloadEventHandler(object sender, EventArgs e) { }

	private SourceLevels FixLevel(SourceLevels level) { }

	public static Guid get_ActivityId() { }

	protected bool get_CalledShutdown() { }

	protected string get_EventSourceName() { }

	public bool get_HaveListeners() { }

	[CompilerGenerated]
	protected DateTime get_LastFailure() { }

	public SourceLevels get_Level() { }

	protected static int get_ProcessId() { }

	protected static string get_ProcessName() { }

	public TraceSource get_TraceSource() { }

	public bool get_TracingEnabled() { }

	public abstract bool IsEnabled() { }

	protected void LogTraceFailure(string traceString, Exception exception) { }

	protected override void OnSetLevel(SourceLevels level) { }

	protected abstract void OnShutdownTracing() { }

	protected abstract void OnUnhandledException(Exception exception) { }

	public static void set_ActivityId(Guid value) { }

	protected void set_EventSourceName(string value) { }

	[CompilerGenerated]
	protected void set_LastFailure(DateTime value) { }

	private void SetLevel(SourceLevels level) { }

	protected void SetTraceSource(TraceSource traceSource) { }

	public bool ShouldTrace(TraceEventType type) { }

	public override bool ShouldTrace(TraceEventLevel level) { }

	public bool ShouldTraceToTraceSource(TraceEventLevel level) { }

	private void ShutdownTracing() { }

	protected static string StackTraceString(Exception exception) { }

	public abstract void TraceEventLogEvent(TraceEventType type, TraceRecord traceRecord) { }

	protected void UnhandledExceptionHandler(object sender, UnhandledExceptionEventArgs args) { }

	private static void UnsafeRemoveDefaultTraceListener(TraceSource traceSource) { }

	public static string XmlEncode(string text) { }

}


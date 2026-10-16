namespace System.Runtime;

internal class ExceptionTrace
{
	private string eventSourceName; //Field offset: 0x8
	private readonly EtwDiagnosticTrace diagnosticTrace; //Field offset: 0xC

	public ExceptionTrace(string eventSourceName, EtwDiagnosticTrace diagnosticTrace) { }

	public ArgumentException Argument(string paramName, string message) { }

	public ArgumentNullException ArgumentNull(string paramName) { }

	public ArgumentOutOfRangeException ArgumentOutOfRange(string paramName, object actualValue, string message) { }

	public Exception AsError(Exception exception) { }

	public Exception AsError(AggregateException aggregateException) { }

	public Exception AsError(AggregateException aggregateException, string eventSource) { }

	private void BreakOnException(Exception exception) { }

	private TException TraceException(TException exception) { }

	private TException TraceException(TException exception, string eventSource) { }

	public void TraceHandledException(Exception exception, TraceEventType traceEventType) { }

	public void TraceUnhandledException(Exception exception) { }

}


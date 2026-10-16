namespace System.Runtime;

internal static class Fx
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__8_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <InitializeTracing>b__8_0() { }

	}

	private sealed class AsyncThunk : Thunk<AsyncCallback>
	{

		public AsyncCallback ThunkFrame
		{
			 get { } //Length: 81
		}

		public AsyncThunk(AsyncCallback callback) { }

		public AsyncCallback get_ThunkFrame() { }

		private void UnhandledExceptionFrame(IAsyncResult result) { }

	}

	internal abstract class ExceptionHandler
	{

		public abstract bool HandleException(Exception exception) { }

	}

	private class FatalInternalException : InternalException
	{

		public FatalInternalException(string description) { }

		protected FatalInternalException(SerializationInfo info, StreamingContext context) { }

	}

	private class InternalException : SystemException
	{

		public InternalException(string description) { }

		protected InternalException(SerializationInfo info, StreamingContext context) { }

	}

	private sealed class IOCompletionThunk
	{
		private IOCompletionCallback callback; //Field offset: 0x8

		public IOCompletionCallback ThunkFrame
		{
			 get { } //Length: 81
		}

		public IOCompletionThunk(IOCompletionCallback callback) { }

		public IOCompletionCallback get_ThunkFrame() { }

		private void UnhandledExceptionFrame(uint error, uint bytesRead, NativeOverlapped* nativeOverlapped) { }

	}

	private abstract class Thunk
	{
		private T callback; //Field offset: 0x0

		internal T Callback
		{
			internal get { } //Length: 11
		}

		protected Thunk`1(T callback) { }

		internal T get_Callback() { }

	}

	private static ExceptionTrace exceptionTrace; //Field offset: 0x0
	private static EtwDiagnosticTrace diagnosticTrace; //Field offset: 0x4
	private static ExceptionHandler asynchronousThreadExceptionHandler; //Field offset: 0x8

	public static ExceptionHandler AsynchronousThreadExceptionHandler
	{
		[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
		 get { } //Length: 41
	}

	public static ExceptionTrace Exception
	{
		 get { } //Length: 169
	}

	public static EtwDiagnosticTrace Trace
	{
		 get { } //Length: 96
	}

	public static Exception AssertAndThrow(string description) { }

	public static Exception AssertAndThrowFatal(string description) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	public static ExceptionHandler get_AsynchronousThreadExceptionHandler() { }

	public static ExceptionTrace get_Exception() { }

	public static EtwDiagnosticTrace get_Trace() { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	private static bool HandleAtThreadBase(Exception exception) { }

	private static EtwDiagnosticTrace InitializeTracing() { }

	public static bool IsFatal(Exception exception) { }

	public static AsyncCallback ThunkCallback(AsyncCallback callback) { }

	public static IOCompletionCallback ThunkCallback(IOCompletionCallback callback) { }

	[ReliabilityContract(Consistency::WillNotCorruptState (3), Cer::Success (2))]
	private static void TraceExceptionNoThrow(Exception exception) { }

	private static void UpdateLevel(EtwDiagnosticTrace trace) { }

	private static void UpdateLevel() { }

}


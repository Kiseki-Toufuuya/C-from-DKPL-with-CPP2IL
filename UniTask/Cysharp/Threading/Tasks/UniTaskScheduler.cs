namespace Cysharp.Threading.Tasks;

public static class UniTaskScheduler
{
	[CompilerGenerated]
	private static Action<Exception> UnobservedTaskException; //Field offset: 0x0
	public static bool PropagateOperationCanceledException; //Field offset: 0x4
	public static LogType UnobservedExceptionWriteLogType; //Field offset: 0x8
	public static bool DispatchUnityMainThread; //Field offset: 0xC
	private static readonly SendOrPostCallback handleExceptionInvoke; //Field offset: 0x10

	private static UniTaskScheduler() { }

	private static void InvokeUnobservedTaskException(object state) { }

	internal static void PublishUnobservedTaskException(Exception ex) { }

}


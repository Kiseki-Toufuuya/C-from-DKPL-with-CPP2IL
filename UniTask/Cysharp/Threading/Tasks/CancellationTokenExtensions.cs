namespace Cysharp.Threading.Tasks;

[Extension]
public static class CancellationTokenExtensions
{
	private static readonly Action<Object> cancellationTokenCallback; //Field offset: 0x0
	private static readonly Action<Object> disposeCallback; //Field offset: 0x4

	private static CancellationTokenExtensions() { }

	private static void Callback(object state) { }

	private static void DisposeCallback(object state) { }

	[Extension]
	public static CancellationTokenRegistration RegisterWithoutCaptureExecutionContext(CancellationToken cancellationToken, Action<Object> callback, object state) { }

}


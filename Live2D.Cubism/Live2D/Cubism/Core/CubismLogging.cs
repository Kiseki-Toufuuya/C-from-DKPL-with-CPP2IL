namespace Live2D.Cubism.Core;

public class CubismLogging
{
	internal sealed class UnmanagedLogDelegate : MulticastDelegate
	{

		public UnmanagedLogDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Char* message, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(Char* message) { }

	}

	[CompilerGenerated]
	private static UnmanagedLogDelegate <LogDelegate>k__BackingField; //Field offset: 0x0

	public static UnmanagedLogDelegate LogDelegate
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		 set { } //Length: 64
	}

	public CubismLogging() { }

	[CompilerGenerated]
	public static UnmanagedLogDelegate get_LogDelegate() { }

	public static void Initialize(UnmanagedLogDelegate logFunctionDelegate) { }

	public static void InvokeLog(string message) { }

	[MonoPInvokeCallback(typeof(UnmanagedLogDelegate))]
	public static void LogUnmanaged(Char* message) { }

	[CompilerGenerated]
	public static void set_LogDelegate(UnmanagedLogDelegate value) { }

}


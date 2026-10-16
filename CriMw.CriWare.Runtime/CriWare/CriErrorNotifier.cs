namespace CriWare;

public static class CriErrorNotifier
{
	internal sealed class Callback : MulticastDelegate
	{

		public Callback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string message) { }

	}

	[UnmanagedFunctionPointer(CallingConvention::Cdecl (2))]
	public sealed class ErrorCallbackFunc : MulticastDelegate
	{

		public ErrorCallbackFunc(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray) { }

	}

	private static class NativeMethod
	{

		internal static IntPtr criErr_ConvertIdToMessage(IntPtr errmsgPtr, uint p1, uint p2) { }

		internal static void criErr_SetCallback(IntPtr callback) { }

		internal static void criErr_SetCallback(ErrorCallbackFunc callback) { }

	}

	[CompilerGenerated]
	private static Callback _onCallbackThreadUnsafe; //Field offset: 0x0
	private static object objectLock; //Field offset: 0x4

	private static event Callback _onCallbackThreadUnsafe
	{
		[CompilerGenerated]
		private add { } //Length: 173
		[CompilerGenerated]
		private remove { } //Length: 173
	}

	public static event Callback OnCallbackThreadUnsafe
	{
		 add { } //Length: 724
		 remove { } //Length: 542
	}

	private static CriErrorNotifier() { }

	[CompilerGenerated]
	private static void add__onCallbackThreadUnsafe(Callback value) { }

	public static void add_OnCallbackThreadUnsafe(Callback value) { }

	public static void CallEvent(string message) { }

	[MonoPInvokeCallback(typeof(ErrorCallbackFunc))]
	private static void ErrorCallbackFromNative(IntPtr errmsgPtr, uint p1, uint p2, IntPtr parray) { }

	internal static ErrorCallbackFunc GetManagedPluginFunc() { }

	public static bool IsRegistered(Callback target) { }

	[CompilerGenerated]
	private static void remove__onCallbackThreadUnsafe(Callback value) { }

	public static void remove_OnCallbackThreadUnsafe(Callback value) { }

	public static void SetCallbackNative(IntPtr errorCallback) { }

	internal static void SetCallbackNative(ErrorCallbackFunc errorCallback) { }

}


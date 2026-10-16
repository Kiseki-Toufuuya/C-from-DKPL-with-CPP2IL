namespace CriWare;

[AddComponentMenu("CRIWARE/Error Handler")]
public class CriWareErrorHandler : CriMonoBehaviour
{
	internal sealed class Callback : MulticastDelegate
	{

		public Callback(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(string message, AsyncCallback callback, object object) { }

		public override void EndInvoke(IAsyncResult result) { }

		public override void Invoke(string message) { }

	}

	private static class NativeMethod
	{

		internal static IntPtr CRIWARE19B58EBB() { }

	}

	[CompilerGenerated]
	private static string <errorMessage>k__BackingField; //Field offset: 0x0
	public static readonly string logPrefix; //Field offset: 0x4
	[CompilerGenerated]
	private static Callback _onCallback; //Field offset: 0x8
	[Obsolete("CriWareErrorHandler.callback is deprecated. Use CriWareErrorHandler.OnCallback event", False)]
	public static Callback callback; //Field offset: 0xC
	private static bool _enableDebugPrintOnTerminal; //Field offset: 0x10
	private static int initializationCount; //Field offset: 0x14
	public bool enableDebugPrintOnTerminal; //Field offset: 0x20
	public bool enableForceCrashOnError; //Field offset: 0x21
	public bool dontDestroyOnLoad; //Field offset: 0x22
	public uint messageBufferCounts; //Field offset: 0x24
	private ConcurrentQueue<String> unThreadSafeMessages; //Field offset: 0x28

	private static event Callback _onCallback
	{
		[CompilerGenerated]
		private add { } //Length: 177
		[CompilerGenerated]
		private remove { } //Length: 177
	}

	public static event Callback OnCallback
	{
		 add { } //Length: 313
		 remove { } //Length: 235
	}

	public static string errorMessage
	{
		[CompilerGenerated]
		 get { } //Length: 60
		[CompilerGenerated]
		 set { } //Length: 84
	}

	private static CriWareErrorHandler() { }

	public CriWareErrorHandler() { }

	[CompilerGenerated]
	private static void add__onCallback(Callback value) { }

	public static void add_OnCallback(Callback value) { }

	private void Awake() { }

	public virtual void CriInternalLateUpdate() { }

	public virtual void CriInternalUpdate() { }

	private void DequeueErrorMessages() { }

	[CompilerGenerated]
	public static string get_errorMessage() { }

	private void HandleMessage(string errmsg) { }

	private static bool IsEnableNativePrintMessageFunc() { }

	private void OnDestroy() { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	private static void OutputDefaultLog(string errmsg) { }

	private static void RegisterErrorCallback() { }

	[CompilerGenerated]
	private static void remove__onCallback(Callback value) { }

	public static void remove_OnCallback(Callback value) { }

	[CompilerGenerated]
	public static void set_errorMessage(string value) { }

}


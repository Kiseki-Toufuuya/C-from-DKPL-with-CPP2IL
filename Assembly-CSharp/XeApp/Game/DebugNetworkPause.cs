namespace XeApp.Game;

public class DebugNetworkPause : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass19_0
	{
		public bool done; //Field offset: 0x8

		public <>c__DisplayClass19_0() { }

		internal void <OpenWindow>b__0(object _) { }

	}

	[CompilerGenerated]
	private struct <OpenWindow>d__19 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncTaskMethodBuilder<DebugNetworkPause> <>t__builder; //Field offset: 0x4
		private <>c__DisplayClass19_0 <>8__1; //Field offset: 0x10
		private TaskAwaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private static DebugNetworkPause <Instance>k__BackingField; //Field offset: 0x0
	[SerializeField]
	private Button buttonNext; //Field offset: 0x10
	[SerializeField]
	private Button buttonTimeout; //Field offset: 0x14
	[SerializeField]
	private Button buttonError; //Field offset: 0x18
	[SerializeField]
	private Text actionName; //Field offset: 0x1C
	[SerializeField]
	private Dropdown dropdownErrorList; //Field offset: 0x20
	[SerializeField]
	private InputField inputErrorCode; //Field offset: 0x24
	[SerializeField]
	private Toggle toggleDoAction; //Field offset: 0x28
	public int selectedErrorId; //Field offset: 0x2C
	public bool doErrorEmulation; //Field offset: 0x30
	public bool isOpened; //Field offset: 0x31
	public bool doTimeoutEmulaton; //Field offset: 0x32
	public bool emulateDoAction; //Field offset: 0x33

	public private static DebugNetworkPause Instance
	{
		[CompilerGenerated]
		 get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public DebugNetworkPause() { }

	private void Awake() { }

	public static void Create() { }

	[CompilerGenerated]
	public static DebugNetworkPause get_Instance() { }

	[AsyncStateMachine(typeof(<OpenWindow>d__19))]
	public static Task<DebugNetworkPause> OpenWindow(string name) { }

	[CompilerGenerated]
	private static void set_Instance(DebugNetworkPause value) { }

	public void Start() { }

	public void ThrowSimulatedError() { }

}


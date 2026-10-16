namespace Heqet;

public class RebindUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<InputDevice> <>9__50_0; //Field offset: 0x4
		public static Predicate<InputDevice> <>9__50_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal bool <CheckConnectDevice>b__50_0(InputDevice x) { }

		internal bool <CheckConnectDevice>b__50_1(InputDevice x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__49
	{
		public static readonly <>c__49<TDevice> <>9; //Field offset: 0x0
		public static Predicate<InputControl> <>9__49_2; //Field offset: 0x0

		private static <>c__49`1() { }

		public <>c__49`1() { }

		internal bool <StartRebindingAsync>b__49_2(InputControl x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass49_0
	{
		public InputControl ctrl; //Field offset: 0x0

		public <>c__DisplayClass49_0`1() { }

		internal bool <StartRebindingAsync>b__3(string x) { }

	}

	[CompilerGenerated]
	private struct <StartRebindingAsync>d__49 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x0
		public RebindUI <>4__this; //Field offset: 0x0
		public CancellationToken _token; //Field offset: 0x0
		private Awaiter <>u__1; //Field offset: 0x0

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum DeviceType
	{
		Keyboard = 0,
		Gamepad = 1,
	}

	private readonly string backquote; //Field offset: 0x10
	[SerializeField]
	private InputBindingReference _bindingRef; //Field offset: 0x14
	[SerializeField]
	private TMP_Text _pathText; //Field offset: 0x18
	[SerializeField]
	private GameObject _mask; //Field offset: 0x1C
	[InputControl]
	[SerializeField]
	private string _cancelControlPath; //Field offset: 0x20
	[InputControl]
	[SerializeField]
	private List<String> _ignoreControlPath; //Field offset: 0x24
	private InputAction _action; //Field offset: 0x28
	private RebindingOperation _rebindOperation; //Field offset: 0x2C
	private List<InputControl> m_control_list; //Field offset: 0x30
	private InputControl m_esapekey; //Field offset: 0x34
	private bool OnEsapekey; //Field offset: 0x38
	private List<InputBinding> m_bind_list; //Field offset: 0x3C
	private StringBuilder m_sb; //Field offset: 0x40
	private List<InputBinding> m_backup_bind_list; //Field offset: 0x44
	private int m_max_key; //Field offset: 0x48
	private bool m_dirty; //Field offset: 0x4C
	private bool m_is_cancel; //Field offset: 0x4D
	private IDisposable m_keyChekingDisposable; //Field offset: 0x50
	private IDisposable m_keyCancelDisposable; //Field offset: 0x54
	private CancellationTokenSource m_Cts; //Field offset: 0x58
	[CompilerGenerated]
	private Action <StartBindingCallback>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private Action <EndBindingCallback>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Action<String, String, DeviceType> <ButtonPressesCallback>k__BackingField; //Field offset: 0x64
	public DeviceType deviceType; //Field offset: 0x68

	public string ActionName
	{
		 get { } //Length: 32
	}

	public string BindingRefName
	{
		 get { } //Length: 65
	}

	public private Action<String, String, DeviceType> ButtonPressesCallback
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private Action EndBindingCallback
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string ID
	{
		 get { } //Length: 23
		 set { } //Length: 39
	}

	public GameObject MaskObject
	{
		 set { } //Length: 27
	}

	public private Action StartBindingCallback
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public RebindUI() { }

	[CompilerGenerated]
	private void <StartRebindingAsync>b__49_0(InputEventPtr eventPtr) { }

	[CompilerGenerated]
	private void <StartRebindingAsync>b__49_1(InputEventPtr eventPtr) { }

	public void ApplyOverideBinding() { }

	private void Awake() { }

	public void BackBinding() { }

	public string BindingName(int _id) { }

	public void CancelRebinding() { }

	private bool CheckConnectDevice() { }

	public void ClearOverideBinding() { }

	public string get_ActionName() { }

	public string get_BindingRefName() { }

	[CompilerGenerated]
	private Action<String, String, DeviceType> get_ButtonPressesCallback() { }

	[CompilerGenerated]
	private Action get_EndBindingCallback() { }

	public string get_ID() { }

	[CompilerGenerated]
	private Action get_StartBindingCallback() { }

	public int GetBindingCount() { }

	private void LoadInitialBinding() { }

	public void OnCancell() { }

	private void OnDestroy() { }

	public void OverrideCancelControlPath(string _value) { }

	public void OverrideIgnoreControlPath(List<String> _value) { }

	private void RefreshDisplay() { }

	public void ReloadOverrideBinding() { }

	public void ResetOverrideBinding() { }

	[CompilerGenerated]
	public void set_ButtonPressesCallback(Action<String, String, DeviceType> value) { }

	[CompilerGenerated]
	public void set_EndBindingCallback(Action value) { }

	public void set_ID(string value) { }

	public void set_MaskObject(GameObject value) { }

	[CompilerGenerated]
	public void set_StartBindingCallback(Action value) { }

	public void SetIdForBindingIndex(int _index) { }

	public void StartRebinding() { }

	[AsyncStateMachine(typeof(<StartRebindingAsync>d__49`1))]
	private UniTask StartRebindingAsync(CancellationToken _token) { }

}


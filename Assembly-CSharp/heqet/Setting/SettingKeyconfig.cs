namespace Heqet.Setting;

public class SettingKeyconfig : SettingBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__34_1; //Field offset: 0x4
		public static Action <>9__34_2; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ExcuteNullDialog>b__34_1() { }

		internal void <ExcuteNullDialog>b__34_2() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public SettingKeyconfig <>4__this; //Field offset: 0x8
		public bool end; //Field offset: 0xC

		public <>c__DisplayClass34_0() { }

		internal void <ExcuteNullDialog>b__0(ButtonType btnId) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass35_0
	{
		public bool end; //Field offset: 0x8

		public <>c__DisplayClass35_0() { }

		internal bool <OpenCheckNullKeyDialog>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <ExcuteNullDialog>d__34 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SettingKeyconfig <>4__this; //Field offset: 0x10
		private <>c__DisplayClass34_0 <>8__1; //Field offset: 0x14

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <ExcuteNullDialog>d__34(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <ExcuteStateIdle>d__32 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SettingKeyconfig <>4__this; //Field offset: 0x10

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <ExcuteStateIdle>d__32(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <ExcuteStatePreview>d__33 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public SettingKeyconfig <>4__this; //Field offset: 0x10
		private float <timer>5__2; //Field offset: 0x14

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <ExcuteStatePreview>d__33(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private struct <OpenCheckNullKeyDialog>d__35 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingKeyconfig <>4__this; //Field offset: 0xC
		private <>c__DisplayClass35_0 <>8__1; //Field offset: 0x10
		private IEnumerator <excute>5__2; //Field offset: 0x14
		private Awaiter <>u__1; //Field offset: 0x18
		private Awaiter <>u__2; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eState
	{
		None = 0,
		Entry = 1,
		Idle = 2,
		Preview = 3,
		Decide = 4,
		NullDialog = 5,
		Wait = 6,
		End = 7,
	}

	private const string ROOT_HEARDER_KEYCONFIG = "root/header/btn_keyconfig"; //Field offset: 0x0
	private readonly float PRESS_CLOSE_TIME; //Field offset: 0x20
	private readonly float BACK_CLOSE_TIME_RATE; //Field offset: 0x24
	private readonly string NULL_KEYCONFIG_DIALOG_TAG; //Field offset: 0x28
	private ExcuteStateCooutine<eState> m_StateLoop; //Field offset: 0x2C
	private SettingKeyConfigDisp m_Disp; //Field offset: 0x30
	private SettingKeyconfigPreviewDisp m_PreviewDisp; //Field offset: 0x34
	private SettingHeaderDisp m_HeaderDisp; //Field offset: 0x38
	private InputActionReference m_InputActionPreview; //Field offset: 0x3C
	private ePresetType m_PresetType; //Field offset: 0x40
	private string m_InputActionJson; //Field offset: 0x44
	private GameObject m_SelectedBuf; //Field offset: 0x48
	[CompilerGenerated]
	private Action<Boolean> <DispKeyconfigPrevewCallback>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private bool <IsContinue>k__BackingField; //Field offset: 0x50

	public Action<Boolean> DispKeyconfigPrevewCallback
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public private bool IsContinue
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public bool IsPreView
	{
		 get { } //Length: 56
	}

	public SettingKeyconfig(SettingKeyConfigDisp _keyconfig, SettingHeaderDisp _header, SettingKeyconfigPreviewDisp _preview) { }

	private void ChangeValuePresetDropdown(ePresetType _type) { }

	private bool CheckBindingNullKey() { }

	[IteratorStateMachine(typeof(<ExcuteNullDialog>d__34))]
	private IEnumerator ExcuteNullDialog() { }

	[IteratorStateMachine(typeof(<ExcuteStateIdle>d__32))]
	private IEnumerator ExcuteStateIdle() { }

	[IteratorStateMachine(typeof(<ExcuteStatePreview>d__33))]
	private IEnumerator ExcuteStatePreview() { }

	[CompilerGenerated]
	public Action<Boolean> get_DispKeyconfigPrevewCallback() { }

	[CompilerGenerated]
	public bool get_IsContinue() { }

	public bool get_IsPreView() { }

	public virtual void ImmediateOpen() { }

	public void InitUpdateBefore() { }

	public bool IsChangeData() { }

	private void OnClickPreviewClose() { }

	private void OnPressButton(int _id) { }

	[AsyncStateMachine(typeof(<OpenCheckNullKeyDialog>d__35))]
	public UniTask OpenCheckNullKeyDialog() { }

	public virtual void Reset(int _tab) { }

	public void ResetCursor() { }

	public void Save() { }

	[CompilerGenerated]
	public void set_DispKeyconfigPrevewCallback(Action<Boolean> value) { }

	[CompilerGenerated]
	private void set_IsContinue(bool value) { }

	public virtual void SetupDisp() { }

	public virtual void Update() { }

}


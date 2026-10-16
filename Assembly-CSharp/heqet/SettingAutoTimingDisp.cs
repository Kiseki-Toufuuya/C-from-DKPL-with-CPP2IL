namespace Heqet;

public class SettingAutoTimingDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<ButtonType> <>9__63_0; //Field offset: 0x4
		public static Action <>9__63_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal void <ShowResultDialog>b__63_0(ButtonType btn) { }

		internal void <ShowResultDialog>b__63_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public SettingAutoTimingDisp <>4__this; //Field offset: 0x8
		public bool enable; //Field offset: 0xC

		public <>c__DisplayClass44_0() { }

		internal void <SetHide>b__0() { }

		internal void <SetHide>b__1() { }

	}

	[CompilerGenerated]
	private struct <HideDisplay>d__46 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingAutoTimingDisp <>4__this; //Field offset: 0xC
		public Action Callback; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowDisplay>d__45 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingAutoTimingDisp <>4__this; //Field offset: 0xC
		public Action Callback; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <ShowResultDialog>d__63 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingAutoTimingDisp <>4__this; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <WaitTimeToStart>d__47 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingAutoTimingDisp <>4__this; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x10

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eButtonId
	{
		Cancel = 0,
		Click = 1,
		Max = 2,
	}

	private const int MAX_NOTE = 3; //Field offset: 0x0
	private const float LIGHT_SPEED = 3; //Field offset: 0x0
	private const float WAIT_TIME = 1; //Field offset: 0x0
	private const float BEAT_TIME = 0.5; //Field offset: 0x0
	private const float JUDGE_TIME = 0.5; //Field offset: 0x0
	private const int INPUT_MAX_COUNT = 10; //Field offset: 0x0
	private const int BPM = 120; //Field offset: 0x0
	private const int INTERVAL_BEATS = 4; //Field offset: 0x0
	private readonly string LIGHT_SPRITE; //Field offset: 0x114
	private readonly string COUNT_TEXT; //Field offset: 0x118
	private readonly string NOTE_PREFAB; //Field offset: 0x11C
	private readonly string START_POINT; //Field offset: 0x120
	private readonly string END_POINT; //Field offset: 0x124
	private readonly string NOTE_POINT; //Field offset: 0x128
	private Image m_LightImage; //Field offset: 0x12C
	private TextMeshProUGUI m_InputCountText; //Field offset: 0x130
	private Animator m_RootAnimator; //Field offset: 0x134
	private GameObject m_NotePrefab; //Field offset: 0x138
	private Transform m_StartPoint; //Field offset: 0x13C
	private Transform m_EndPoint; //Field offset: 0x140
	private Transform m_NotePoint; //Field offset: 0x144
	private InputActionReference m_InputActionCancel; //Field offset: 0x148
	private InputActionReference keyLaneInput; //Field offset: 0x14C
	private float m_ElapsedTime; //Field offset: 0x150
	private float m_BPMTimer; //Field offset: 0x154
	private int m_BeatCount; //Field offset: 0x158
	private int m_InputNoteCount; //Field offset: 0x15C
	private bool m_Inited; //Field offset: 0x160
	private bool m_IsCheckTiming; //Field offset: 0x161
	private bool m_PrePressed; //Field offset: 0x162
	[CompilerGenerated]
	private Action<Single> <TimingAutoCallback>k__BackingField; //Field offset: 0x164
	private UIWrapperButton[] m_ButtonObjs; //Field offset: 0x168
	private Stack<TimingNote> m_NotePool; //Field offset: 0x16C
	private List<TimingNote> m_OpenNoteList; //Field offset: 0x170
	private List<Single> m_ResultOffsettList; //Field offset: 0x174
	private readonly String[] m_ButtonDataList; //Field offset: 0x178

	public private Action<Single> TimingAutoCallback
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public SettingAutoTimingDisp() { }

	[CompilerGenerated]
	private bool <HideDisplay>b__46_0() { }

	[CompilerGenerated]
	private bool <ShowDisplay>b__45_0() { }

	[CompilerGenerated]
	private void <ShowResultDialog>b__63_2() { }

	private void BeatDetection() { }

	private void CheckNoteInput() { }

	private void CheckResult() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void CreateNodeByBPM() { }

	private void CreateNodeByStart() { }

	private void CreateNodeToOpenNoteList() { }

	[CompilerGenerated]
	private Action<Single> get_TimingAutoCallback() { }

	private float GetNoteSpeed() { }

	private float GetPerfectTiming() { }

	[AsyncStateMachine(typeof(<HideDisplay>d__46))]
	private UniTask HideDisplay(Action Callback) { }

	private void InitLayout() { }

	protected virtual void LateUpdate() { }

	private void LightAnimation() { }

	private void MoveNotes() { }

	private void OnClickButton(int _id) { }

	public void Open(bool visible) { }

	private void PlayBeatSE() { }

	public virtual void ReleaseAll() { }

	private void ResetNotePosition() { }

	private void ResetPlayState() { }

	[CompilerGenerated]
	public void set_TimingAutoCallback(Action<Single> value) { }

	public virtual void SetHide(bool enable) { }

	[AsyncStateMachine(typeof(<ShowDisplay>d__45))]
	private UniTask ShowDisplay(Action Callback) { }

	private void ShowLight() { }

	[AsyncStateMachine(typeof(<ShowResultDialog>d__63))]
	private UniTask ShowResultDialog() { }

	protected virtual void UpdateDispMain() { }

	[AsyncStateMachine(typeof(<WaitTimeToStart>d__47))]
	private UniTask WaitTimeToStart() { }

}


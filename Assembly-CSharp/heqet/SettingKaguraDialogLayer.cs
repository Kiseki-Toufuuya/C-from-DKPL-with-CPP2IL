namespace Heqet;

public class SettingKaguraDialogLayer : LayerBase
{
	[CompilerGenerated]
	private struct <<ExcuteStateClose>b__37_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingKaguraDialogLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<ExcuteStateOpen>b__36_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SettingKaguraDialogLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eMainStep
	{
		NONE = 0,
		OPEN = 1,
		OPENING = 2,
		MAIN = 3,
		SAVING = 4,
		CLOSE = 5,
		CLOSEING = 6,
		TimingInit = 7,
		Timing = 8,
		WAIT = 9,
	}

	internal class SetupParam
	{
		public int MusicId; //Field offset: 0x8
		public HeqetGameMode GameMode; //Field offset: 0xC
		public MusicDifficulty Difficulty; //Field offset: 0x10
		public LaneMode LaneMode; //Field offset: 0x14
		public float NotesSpeed; //Field offset: 0x18

		public SetupParam() { }

	}

	[CompilerGenerated]
	private Action<Int32> <OnPressButtonCallback>k__BackingField; //Field offset: 0x58
	private SettingKaguraDanmakuDialogDisp m_daialogDisp; //Field offset: 0x5C
	private SettingPreviewDisp m_SettingPreviewDisp; //Field offset: 0x60
	private int m_MusicId; //Field offset: 0x64
	private MusicDifficulty m_Difficulty; //Field offset: 0x68
	private LaneMode m_LaneMode; //Field offset: 0x6C
	private HeqetGameMode m_HeqetGameMode; //Field offset: 0x70
	private float m_GimmickNotesSpeed; //Field offset: 0x74
	private SettingAutoTimingDisp m_SettingAutoTimingDisp; //Field offset: 0x78
	private GameObject m_SettingAutoTimingBtn; //Field offset: 0x7C
	private float m_sudden_buf; //Field offset: 0x80
	private float m_hidden_buf; //Field offset: 0x84
	private bool isRandom; //Field offset: 0x88
	private eMainStep m_MainStep; //Field offset: 0x8C

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public bool IsRandom
	{
		 set { } //Length: 17
	}

	public private Action<Int32> OnPressButtonCallback
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public SettingKaguraDialogLayer() { }

	[AsyncStateMachine(typeof(<<ExcuteStateClose>b__37_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <ExcuteStateClose>b__37_0() { }

	[AsyncStateMachine(typeof(<<ExcuteStateOpen>b__36_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <ExcuteStateOpen>b__36_0() { }

	[CompilerGenerated]
	private void <InitUpdateBefore>b__31_0() { }

	private void ApplySettingData(Param param, SettingData value) { }

	public void Close() { }

	protected virtual bool EndUpdateAfter() { }

	private void ExcuteInitTiming() { }

	private void ExcuteStateClose() { }

	private void ExcuteStateOpen() { }

	private void ExcuteStateSaving() { }

	private void ExcuteTiming() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	private Action<Int32> get_OnPressButtonCallback() { }

	private void IndividualResetParam(eResetCategory category) { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	private bool IsIndividualParam(eResetCategory category) { }

	protected virtual void LateUpdate(bool is_active) { }

	private void OnCangeSliderValue(int _id, float _value) { }

	private void OnPressButton(int _id) { }

	public void Open() { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	private void ResetParam() { }

	private void ResetParamSelectCategory(GameObject targetObject) { }

	public void set_IsRandom(bool value) { }

	[CompilerGenerated]
	public void set_OnPressButtonCallback(Action<Int32> value) { }

	private void SetTimingAutoValue(float _value) { }

	public void Setup(SetupParam _param) { }

	protected virtual void Update(bool is_active) { }

	private void UpdateInvididualButtonState() { }

}


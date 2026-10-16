namespace Heqet;

public class MusicInfoLayer : UiScrollListLayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__59_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public MusicInfoLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__59_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public MusicInfoLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eContStep
	{
		MAIN = 0,
		NONE = 1,
	}

	private enum eMainStep
	{
		OPEN = 0,
		OPENING = 1,
		MAIN = 2,
		CLOSE = 3,
		CLOSEING = 4,
		OTHER_LAYER = 5,
		NONE = 6,
	}

	internal enum eModeType
	{
		StoryMode = 0,
		FreeMode = 1,
	}

	private MusicRecordInfoDisp m_MusicInfoDisp; //Field offset: 0x7C
	[CompilerGenerated]
	private Action<Int32> <OnSubmitStage>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private SpotManager <SpotManager>k__BackingField; //Field offset: 0x84
	private InputActionReference m_InputActionCancel; //Field offset: 0x88
	[CompilerGenerated]
	private RythmGameType <RythmGameType>k__BackingField; //Field offset: 0x8C
	[CompilerGenerated]
	private eModeType <ModeType>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private int <MusicId>k__BackingField; //Field offset: 0x94
	[CompilerGenerated]
	private int <StageId>k__BackingField; //Field offset: 0x98
	[CompilerGenerated]
	private int <Difficulty>k__BackingField; //Field offset: 0x9C
	[CompilerGenerated]
	private bool <IsDisplayScore>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private LaneMode <LaneMode>k__BackingField; //Field offset: 0xA4
	private GameObject m_prevSelectObject; //Field offset: 0xA8
	private eMainStep m_MainStep; //Field offset: 0xAC
	private eContStep m_ContStep; //Field offset: 0xB0

	public private int Difficulty
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

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

	public private bool IsDisplayScore
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public private LaneMode LaneMode
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public private eModeType ModeType
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public private int MusicId
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public Action<Int32> OnSubmitStage
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private RythmGameType RythmGameType
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public private SpotManager SpotManager
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public private int StageId
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public MusicInfoLayer() { }

	[CompilerGenerated]
	private void <InitAll>b__53_0(int btn_id) { }

	[AsyncStateMachine(typeof(<<Update>b__59_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__59_0() { }

	[AsyncStateMachine(typeof(<<Update>b__59_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__59_1() { }

	private void ChangeDifficulty(int offset) { }

	private void ContMain() { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected virtual UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	protected virtual bool EndUpdateAfter() { }

	[CompilerGenerated]
	private int get_Difficulty() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	private bool get_IsDisplayScore() { }

	[CompilerGenerated]
	private LaneMode get_LaneMode() { }

	[CompilerGenerated]
	private eModeType get_ModeType() { }

	[CompilerGenerated]
	private int get_MusicId() { }

	[CompilerGenerated]
	public Action<Int32> get_OnSubmitStage() { }

	[CompilerGenerated]
	private RythmGameType get_RythmGameType() { }

	[CompilerGenerated]
	private SpotManager get_SpotManager() { }

	[CompilerGenerated]
	private int get_StageId() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	public bool IsDispMusicInfo() { }

	private bool IsEnableDifficulty(int difficulty) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	public void set_Difficulty(int value) { }

	[CompilerGenerated]
	public void set_IsDisplayScore(bool value) { }

	[CompilerGenerated]
	public void set_LaneMode(LaneMode value) { }

	[CompilerGenerated]
	public void set_ModeType(eModeType value) { }

	[CompilerGenerated]
	public void set_MusicId(int value) { }

	[CompilerGenerated]
	public void set_OnSubmitStage(Action<Int32> value) { }

	[CompilerGenerated]
	public void set_RythmGameType(RythmGameType value) { }

	[CompilerGenerated]
	public void set_SpotManager(SpotManager value) { }

	[CompilerGenerated]
	public void set_StageId(int value) { }

	protected virtual void Update(bool is_active) { }

}


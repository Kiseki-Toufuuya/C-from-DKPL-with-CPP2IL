namespace Heqet;

public class ConfirmationLayer : LayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__26_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public ConfirmationLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__26_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public ConfirmationLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<BoosterSelectLayer, Int32> <>9__29_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <OpenBoostDialog>b__29_0(BoosterSelectLayer layer, int booster_id) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public int id; //Field offset: 0x8

		public <>c__DisplayClass34_0() { }

		internal bool <CheckStageGimmickNotesSpeed>b__0(int x) { }

	}

	private enum eContStep
	{
		FIRST_HELP = 0,
		MAIN = 1,
		NONE = 2,
	}

	private enum eMainStep
	{
		OPEN = 0,
		OPENING = 1,
		MAIN = 2,
		CLOSE = 3,
		CLOSEING = 4,
		OTHER_LAYER = 5,
		WAIT_SETTING_DIALOG = 6,
		WAIT_BOOST_DIALOG = 7,
		WAIT_HELP = 8,
		WAIT_MUSIC_INFO = 9,
		WAIT_RECOMMEND = 10,
		WAIT_REWARD = 11,
		NONE = 12,
	}

	private WorldMapHeaderDisp m_HeaderDisp; //Field offset: 0x58
	private ConfirmationDisp m_ConfirmationDisp; //Field offset: 0x5C
	private ConfirmationBgDisp m_ConfirmationBgDisp; //Field offset: 0x60
	private TransitionInfo m_transitionInfo; //Field offset: 0x64
	public Action OnGotoPlay; //Field offset: 0x68
	public Action<Int32> OnUpdateDifficulty; //Field offset: 0x6C
	public Action<Int32> OnUpdateLaneMode; //Field offset: 0x70
	private eMainStep m_MainStep; //Field offset: 0x74
	private eContStep m_ContStep; //Field offset: 0x78
	private WorldStageModel m_stageModel; //Field offset: 0x7C

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

	public ConfirmationLayer() { }

	[CompilerGenerated]
	private void <ContMain>b__27_0(LayerBase _layer) { }

	[CompilerGenerated]
	private void <InitAll>b__22_0(int btn_id) { }

	[CompilerGenerated]
	private void <InitAll>b__22_1(LayerBase _layer) { }

	[CompilerGenerated]
	private void <OpenSettingDialog>b__30_0(int _id) { }

	[CompilerGenerated]
	private void <OpenSettingDialog>b__30_1(int _id) { }

	[CompilerGenerated]
	private void <PressButtonActon>b__33_0(int _id) { }

	[AsyncStateMachine(typeof(<<Update>b__26_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__26_0() { }

	[AsyncStateMachine(typeof(<<Update>b__26_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__26_1() { }

	private float CheckStageGimmickNotesSpeed() { }

	private void ContMain() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	private void GotoGame() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	public bool isLoadedImages() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void Open(bool visible) { }

	private void OpenBoostDialog() { }

	private void OpenSettingDialog() { }

	public virtual void OverDeleteLayer() { }

	private void PaymentBoosterItem() { }

	public void PressButtonActon(int btn_id) { }

	protected virtual bool ReleaseLayer() { }

	protected virtual void Update(bool is_active) { }

	public int UpdateDisp(WorldStageModel stageModel, int difficulty, LaneMode laneMode) { }

}


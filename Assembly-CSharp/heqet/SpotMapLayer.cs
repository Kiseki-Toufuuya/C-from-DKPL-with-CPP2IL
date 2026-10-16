namespace Heqet;

public class SpotMapLayer : LayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__37_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SpotMapLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__37_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public SpotMapLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eContStep
	{
		MAIN = 0,
		OTHER_LAYER = 1,
		NONE = 2,
	}

	private enum eMainStep
	{
		OPEN = 0,
		OPENING = 1,
		MAIN = 2,
		CLOSE = 3,
		CLOSEING = 4,
		GO_TO_GALLERY = 5,
		WAIT_SYSTEM_ERROR_DIALOG = 6,
		NONE = 7,
	}

	private SpotMapDisp m_SpotMapDisp; //Field offset: 0x58
	[CompilerGenerated]
	private Action<SpotMapLayer> <OnPressBackToTitle>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private Action<SpotMapLayer> <OnPressGoToFreePlay>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private Action <OnStartChildLayer>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private Action <OnEndChildLayer>k__BackingField; //Field offset: 0x68
	private TransitionInfo m_transitionInfo; //Field offset: 0x6C
	private GameObject m_lastSelected; //Field offset: 0x70
	private eMainStep m_MainStep; //Field offset: 0x74
	private eContStep m_ContStep; //Field offset: 0x78
	private eContStep m_PrevContStep; //Field offset: 0x7C

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

	public Action OnEndChildLayer
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Action<SpotMapLayer> OnPressBackToTitle
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Action<SpotMapLayer> OnPressGoToFreePlay
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public Action OnStartChildLayer
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public SpotMapLayer() { }

	[CompilerGenerated]
	private void <InitAll>b__32_0(int btn_id) { }

	[CompilerGenerated]
	private void <TransitonOtherLayer>b__33_0() { }

	[CompilerGenerated]
	private void <TransitonOtherLayer>b__33_1() { }

	[AsyncStateMachine(typeof(<<Update>b__37_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__37_0() { }

	[AsyncStateMachine(typeof(<<Update>b__37_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__37_1() { }

	private void ContMain() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	public Action get_OnEndChildLayer() { }

	[CompilerGenerated]
	public Action<SpotMapLayer> get_OnPressBackToTitle() { }

	[CompilerGenerated]
	public Action<SpotMapLayer> get_OnPressGoToFreePlay() { }

	[CompilerGenerated]
	public Action get_OnStartChildLayer() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void Open(bool visible) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	public void set_OnEndChildLayer(Action value) { }

	[CompilerGenerated]
	public void set_OnPressBackToTitle(Action<SpotMapLayer> value) { }

	[CompilerGenerated]
	public void set_OnPressGoToFreePlay(Action<SpotMapLayer> value) { }

	[CompilerGenerated]
	public void set_OnStartChildLayer(Action value) { }

	public void SetAllButtonHit(bool enable) { }

	private void TransitonOtherLayer(TransitionID transitionID) { }

	protected virtual void Update(bool is_active) { }

}


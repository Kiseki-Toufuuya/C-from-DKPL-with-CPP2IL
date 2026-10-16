namespace Heqet;

public class GalleryPlayRecordLayer : LayerBase, IGalleryLayer
{
	[CompilerGenerated]
	private struct <<ContMain>b__32_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public GalleryPlayRecordLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__30_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <OpenHelpDialog>b__30_0(LayerBase _layer) { }

	}

	[CompilerGenerated]
	private struct <Open>d__37 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public GalleryPlayRecordLayer <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eContStep
	{
		INIT = 0,
		INIT_WAIT = 1,
		INIT_FINISH = 2,
		FIRST_HELP = 3,
		MAIN = 4,
		NONE = 5,
	}

	private enum eMainStep
	{
		OPENING = 0,
		MAIN = 1,
		CLOSEING = 2,
		SKIN_SELECT = 3,
		HELP_DIALOG = 4,
		NONE = 5,
	}

	private GalleryPlayRecordDisp m_ProfileDisp; //Field offset: 0x58
	private eMainStep m_MainStep; //Field offset: 0x5C
	private eContStep m_ContStep; //Field offset: 0x60
	private GalleryTopLayer m_topLayer; //Field offset: 0x64
	private InputActionReference m_inputAction; //Field offset: 0x68
	private bool m_lastPressed; //Field offset: 0x6C
	private bool m_isStoryMode; //Field offset: 0x6D
	private int m_selectSkinId; //Field offset: 0x70
	private int m_FavoritViewMode; //Field offset: 0x74
	private int m_PreviweFavoritViewMode; //Field offset: 0x78
	private LaneMode[] LaneDispMode; //Field offset: 0x7C
	private int m_currentLaneDispIndex; //Field offset: 0x80

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

	public GalleryPlayRecordLayer() { }

	[AsyncStateMachine(typeof(<<ContMain>b__32_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <ContMain>b__32_0() { }

	[CompilerGenerated]
	private bool <Open>b__37_0() { }

	[CompilerGenerated]
	private bool <Open>b__37_1() { }

	private void ChangeSkin(int skin_id) { }

	private void ContMain() { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	private KeyType GetCurrentKeyType() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	private bool IsVisibleCollaboImage(int skin_id) { }

	protected virtual void LateUpdate(bool is_active) { }

	private void OnChangeSkin(int skin_id) { }

	[AsyncStateMachine(typeof(<Open>d__37))]
	public override UniTask Open(bool visible) { }

	public void OpenHelpDialog() { }

	public void OpenSkinSelectDialog() { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	protected virtual bool ReleaseLayer() { }

	private void SetFavaritHeroineMode(int favoritViewMode) { }

	public override void SetTopLayer(GalleryTopLayer topLayer) { }

	protected virtual void Update(bool is_active) { }

	private int UpdateViewMode(int viewMode) { }

}


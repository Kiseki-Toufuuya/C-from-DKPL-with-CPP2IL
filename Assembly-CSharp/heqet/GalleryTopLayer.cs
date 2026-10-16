namespace Heqet;

public class GalleryTopLayer : LayerBase, IGalleryLayer
{
	[CompilerGenerated]
	private struct <<ChangeLayer>b__24_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public GalleryTopLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__31_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public GalleryTopLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__31_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public GalleryTopLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__32_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <OpenHelpDialog>b__32_0(LayerBase _layer) { }

	}

	[CompilerGenerated]
	private struct <Open>d__34 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public GalleryTopLayer <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eContStep
	{
		MAIN = 0,
		FIRST_HELP = 1,
		NONE = 2,
	}

	internal enum eLayerType
	{
		Top = 0,
		PlayRecord = 1,
		Story = 2,
		Mitama = 3,
		Heroine = 4,
		Jacket = 5,
		Achievement = 6,
		Help = 7,
		Max = 8,
	}

	private enum eMainStep
	{
		OPEN = 0,
		OPENING = 1,
		MAIN = 2,
		CLOSE = 3,
		CLOSEING = 4,
		START_CHANGE_DISP = 5,
		OTHER_LAYER = 6,
		HELP_DIALOG = 7,
		DO_SAVE = 8,
		WAIT_SYSTEM_DIALOG = 9,
		NONE = 10,
	}

	private GalleryTopDisp m_TopDisp; //Field offset: 0x58
	private eMainStep m_MainStep; //Field offset: 0x5C
	private eContStep m_ContStep; //Field offset: 0x60
	private IGalleryLayer[] m_layer_list; //Field offset: 0x64
	private IGalleryLayer m_currentLayer; //Field offset: 0x68
	private IGalleryLayer m_prevLayer; //Field offset: 0x6C
	private eLayerType m_currentLayerType; //Field offset: 0x70
	private eLayerType m_prevLayerType; //Field offset: 0x74
	private int m_story_category_index; //Field offset: 0x78
	private GameObject m_LastSelectedGameObject; //Field offset: 0x7C

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

	public eLayerType PrevLayerType
	{
		 get { } //Length: 11
	}

	public int StoryCategoryIndex
	{
		 get { } //Length: 11
	}

	public GalleryTopLayer() { }

	[AsyncStateMachine(typeof(<<ChangeLayer>b__24_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <ChangeLayer>b__24_0() { }

	[CompilerGenerated]
	private void <CreateLayer>b__23_0(LayerBase layerBase) { }

	[AsyncStateMachine(typeof(<<Update>b__31_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__31_0() { }

	[AsyncStateMachine(typeof(<<Update>b__31_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__31_1() { }

	public void ChangeLayer(eLayerType nextType) { }

	public void CloseTopLayer() { }

	private void ContMain() { }

	private LayerBase CreateLayer(string layerTag) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public eLayerType get_PrevLayerType() { }

	public int get_StoryCategoryIndex() { }

	protected virtual void InitAll() { }

	protected virtual bool InitUpdateBefore() { }

	public bool IsPlayRecordLayerActive() { }

	protected virtual void LateUpdate(bool is_active) { }

	[AsyncStateMachine(typeof(<Open>d__34))]
	public override UniTask Open(bool visible) { }

	public void OpenHelpDialog() { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	public void SaveStorySort(int categoryId) { }

	public override void SetTopLayer(GalleryTopLayer topLayer) { }

	protected virtual void Update(bool is_active) { }

}


namespace Heqet;

public class RecommendCardLayer : LayerBase
{
	[CompilerGenerated]
	private struct <<Update>b__27_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public RecommendCardLayer <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Update>b__27_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public RecommendCardLayer <>4__this; //Field offset: 0x8
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
		NONE = 5,
	}

	internal class ItemData
	{
		internal enum Type
		{
			Mission = 0,
			Gimmick = 1,
			StageClear = 2,
		}

		public Type type; //Field offset: 0x8
		public HeqetCardModel model; //Field offset: 0xC
		public string category; //Field offset: 0x10
		public string title; //Field offset: 0x14

		public ItemData() { }

	}

	[CompilerGenerated]
	private int <StageId>k__BackingField; //Field offset: 0x58
	private RecommendCardDisp m_RecommendCardDisp; //Field offset: 0x5C
	private List<ItemData> m_itemList; //Field offset: 0x60
	private int m_dispIndex; //Field offset: 0x64
	public Action<Int32> OnPressButton; //Field offset: 0x68
	private eMainStep m_MainStep; //Field offset: 0x6C
	private eContStep m_ContStep; //Field offset: 0x70

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

	public int StageId
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public RecommendCardLayer() { }

	[AsyncStateMachine(typeof(<<Update>b__27_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__27_0() { }

	[AsyncStateMachine(typeof(<<Update>b__27_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Update>b__27_1() { }

	private void AddItemData(Int32[] itemList, Type type, int typeIndex) { }

	private void ContMain() { }

	private void DispItem(int dispIndex) { }

	protected virtual bool EndUpdateAfter() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	public int get_StageId() { }

	protected virtual void InitAll() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void Open(bool visible) { }

	public virtual void OverDeleteLayer() { }

	public void PressButtonActon(int btn_id) { }

	protected virtual bool ReleaseLayer() { }

	private void SequentialDisp(int offset) { }

	[CompilerGenerated]
	public void set_StageId(int value) { }

	protected virtual void Update(bool is_active) { }

}


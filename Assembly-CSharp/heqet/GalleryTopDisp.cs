namespace Heqet;

public class GalleryTopDisp : DispBase, IGalleryDisp
{
	[CompilerGenerated]
	private struct <Open>d__18 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public GalleryTopDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal enum eButtonId
	{
		PlayRecord = 0,
		Story = 1,
		Mitama = 2,
		Heroine = 3,
		Jacket = 4,
		Achievement = 5,
		Help = 6,
		HelpTab = 7,
		Back = 8,
		Select = 9,
		Max = 10,
	}

	private enum eCommonLayerId
	{
		PlayRecordArrow = 0,
		StoryArrow = 1,
		MitamaArrow = 2,
		HeroineArrow = 3,
		JacketArrow = 4,
		AchievementArrow = 5,
		HelpArrow = 6,
		Max = 7,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private GalleryTopLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private InputActionReference m_InputActionNavigate; //Field offset: 0x120
	private int m_select_index; //Field offset: 0x124
	private Vector2 m_InputValue; //Field offset: 0x128

	public int SelectIndex
	{
		 get { } //Length: 14
	}

	private static GalleryTopDisp() { }

	public GalleryTopDisp() { }

	[CompilerGenerated]
	private bool <Open>b__18_0() { }

	private void AchievementResetSortFilter() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	private void CursolSelectIndex(int value) { }

	public int get_SelectIndex() { }

	private void HeroineResetSortFilter() { }

	protected virtual void InitUguiOther() { }

	private void JacketResetSortFilter() { }

	protected virtual void LateUpdate() { }

	private void MitamaResetSortFilter() { }

	[AsyncStateMachine(typeof(<Open>d__18))]
	public override UniTask Open(bool visible) { }

	public virtual void ReleaseAll() { }

	private void ResetSortFilter() { }

	private void SelectButtonIndex(float value) { }

	public void SelectFirstButton() { }

	public void UpdateDisp(WorldStageModel stageModel) { }

	protected virtual void UpdateDispMain() { }

}


namespace Heqet;

public class StageInfoDisp : DispBase
{
	[CompilerGenerated]
	private struct <<Open>b__36_0>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public StageInfoDisp <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	[CompilerGenerated]
	private struct <<Open>b__36_1>d : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public StageInfoDisp <>4__this; //Field offset: 0x8
		private Awaiter <>u__1; //Field offset: 0xC

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eCommonLayerId
	{
		kindKagura = 0,
		KindDanmaku = 1,
		Max = 2,
	}

	private enum eImageId
	{
		JacketImage = 0,
		reward_icon_1 = 1,
		reward_icon_2 = 2,
		reward_icon_3 = 3,
		Max = 4,
	}

	private enum eTextId
	{
		StageName = 0,
		MusicName = 1,
		StageDifficulty = 2,
		Max = 3,
	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private const string REARD_ON_ICON_SPRITE_NAME = "reward_icon_on"; //Field offset: 0x0
	private const string REARD_OFF_ICON_SPRITE_NAME = "reward_icon_off"; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x4
	private WorldMapLayer m_Layer; //Field offset: 0x114
	private String[] m_ImageList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private TextMeshProUGUI m_StageName; //Field offset: 0x120
	private TextMeshProUGUI m_MusicName; //Field offset: 0x124
	private TextMeshProUGUI m_StageDifficulty; //Field offset: 0x128
	private AtlasImage[] m_RewardIcons; //Field offset: 0x12C
	private int m_JacketId; //Field offset: 0x130
	private RawImageEx m_JacketImage; //Field offset: 0x134
	[CompilerGenerated]
	private StagePoint <TargetStage>k__BackingField; //Field offset: 0x138
	private Transform trackTransform; //Field offset: 0x13C
	[CompilerGenerated]
	private Camera <SceneCamera>k__BackingField; //Field offset: 0x140
	private JacketAssetBunleLoader m_jacketLoader; //Field offset: 0x144
	private bool m_IsClosing; //Field offset: 0x148
	private int m_OpenSpotDataId; //Field offset: 0x14C

	public Camera SceneCamera
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public StagePoint TargetStage
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	private static StageInfoDisp() { }

	public StageInfoDisp() { }

	[AsyncStateMachine(typeof(<<Open>b__36_0>d))]
	[CompilerGenerated]
	private UniTaskVoid <Open>b__36_0() { }

	[AsyncStateMachine(typeof(<<Open>b__36_1>d))]
	[CompilerGenerated]
	private UniTaskVoid <Open>b__36_1() { }

	[CompilerGenerated]
	private bool <Open>b__36_2() { }

	[CompilerGenerated]
	private bool <Open>b__36_3() { }

	[CompilerGenerated]
	private void <UpdateDisp>b__29_0(AssetBundleLoadAssetOperation ope) { }

	public void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	[CompilerGenerated]
	public Camera get_SceneCamera() { }

	[CompilerGenerated]
	public StagePoint get_TargetStage() { }

	protected virtual void InitUguiOther() { }

	public bool isDisplay() { }

	protected virtual void LateUpdate() { }

	public void Open(bool visible) { }

	public virtual void ReleaseAll() { }

	[CompilerGenerated]
	public void set_SceneCamera(Camera value) { }

	[CompilerGenerated]
	public void set_TargetStage(StagePoint value) { }

	public bool UpdateDisp() { }

	protected virtual void UpdateDispMain() { }

}


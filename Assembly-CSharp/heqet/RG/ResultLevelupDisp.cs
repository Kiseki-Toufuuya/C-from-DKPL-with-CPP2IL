namespace Heqet.RG;

public class ResultLevelupDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass34_0
	{
		public RawImageEx img; //Field offset: 0x8

		public <>c__DisplayClass34_0() { }

		internal void <Setup>b__0(AssetBundleLoadAssetOperation ope) { }

	}

	[CompilerGenerated]
	private struct <InitEffect>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public ResultLevelupDisp <>4__this; //Field offset: 0x8
		private Vector3 <pos>5__2; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eLayerId
	{
		LEVELUP = 0,
		IMAGE_CARD_ICON = 1,
		IMAGE_EXP_GAUGE = 2,
		EXP_RATE = 3,
	}

	private enum eTextId
	{
		TEXT_SPLIT_EXP = 0,
		TEXT_ACQUISITION_VALUE = 1,
		TEXT_REWARD_RATE = 2,
		TEXT_LEVEL = 3,
		TEXT_BASE_LEVEL = 4,
		TEXT_RATE = 5,
		TEXT_EXP = 6,
		TEXT_NEXT_EXP = 7,
	}

	internal class Param
	{
		public CardData CardData; //Field offset: 0x8
		public int Exp; //Field offset: 0xC
		public int AddExp; //Field offset: 0x10
		public int ExpRate; //Field offset: 0x14

		public Param() { }

	}

	internal enum UiState
	{
		Wait = 0,
		Open = 1,
		OpenWait = 2,
		CloseWait = 3,
		Close = 4,
	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private static readonly String[] m_TextIdList; //Field offset: 0x4
	private readonly string GAME_CAMERA; //Field offset: 0x114
	private readonly string BEFORE_LEVEL_TEXT_BASE; //Field offset: 0x118
	private readonly string LEVEL_TEXT_BASE; //Field offset: 0x11C
	private string EXP_TEXT_BASE; //Field offset: 0x120
	private string NEXT_EXP_TEXT_BASE; //Field offset: 0x124
	private readonly string NEXT_EXP_TEXT_MAX; //Field offset: 0x128
	private readonly string LEVELUP_ANIM_NAME; //Field offset: 0x12C
	private Animator RootAnimator; //Field offset: 0x130
	private Animator m_LevelupAnimator; //Field offset: 0x134
	private UiState WindowState; //Field offset: 0x138
	private EffectObjectBase m_LevelupEffect; //Field offset: 0x13C
	private ShearProgressBarSprite m_ExpGauge; //Field offset: 0x140
	private int m_DispLevel; //Field offset: 0x144
	private int m_MaxLevel; //Field offset: 0x148
	private int m_AddExp; //Field offset: 0x14C
	private int m_BaseExp; //Field offset: 0x150
	private int m_CardId; //Field offset: 0x154
	private CharacterAssetBunleLoader m_CharacterIconLoder; //Field offset: 0x158

	private static ResultLevelupDisp() { }

	public ResultLevelupDisp() { }

	[CompilerGenerated]
	private bool <InitEffect>b__38_0() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void DispMaxLevel() { }

	[AsyncStateMachine(typeof(<InitEffect>d__38))]
	public UniTaskVoid InitEffect() { }

	protected virtual void InitUguiOther() { }

	public virtual bool IsPlaying() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	private void PresentLevelup(bool isSkip) { }

	public virtual void ReleaseAll() { }

	public void Setup(Param _param) { }

	public void StartCloseAnimation() { }

	public void StartOpenAnimation(float _timer = 0) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateLevelup(float _rate, bool IsSkip = false) { }

}


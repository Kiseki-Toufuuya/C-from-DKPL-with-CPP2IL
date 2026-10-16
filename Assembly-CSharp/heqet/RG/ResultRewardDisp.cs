namespace Heqet.RG;

public class ResultRewardDisp : DispBase
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass31_0
	{
		public ResultRewardDisp <>4__this; //Field offset: 0x8
		public eLayerId layerId; //Field offset: 0xC

		public <>c__DisplayClass31_0() { }

		internal void <LoadItemIconCard>b__0(AssetBundleLoadAssetOperation ope) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass32_0
	{
		public RawImageEx img; //Field offset: 0x8
		public ResultRewardDisp <>4__this; //Field offset: 0xC
		public eLayerId layerId; //Field offset: 0x10

		public <>c__DisplayClass32_0() { }

		internal void <LoadItemIconHeroine>b__0(AssetBundleLoadAssetOperation ope) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass33_0
	{
		public RawImageEx img; //Field offset: 0x8
		public ResultRewardDisp <>4__this; //Field offset: 0xC
		public eLayerId layerId; //Field offset: 0x10

		public <>c__DisplayClass33_0() { }

		internal void <LoadItemIconEmblem>b__0(AssetBundleLoadAssetOperation ope) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass38_0
	{
		public ResultRewardDisp <>4__this; //Field offset: 0x8
		public Func<Boolean> IsLosdingEffect; //Field offset: 0xC

		public <>c__DisplayClass38_0() { }

		internal bool <InitEffect>b__0() { }

		internal bool <InitEffect>b__1() { }

	}

	[CompilerGenerated]
	private struct <InitEffect>d__38 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public ResultRewardDisp <>4__this; //Field offset: 0x8
		private Vector3 <offset>5__2; //Field offset: 0xC
		private Camera <cameraObj>5__3; //Field offset: 0x18
		private Awaiter <>u__1; //Field offset: 0x1C

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private enum eLayerId
	{
		BOX_1 = 0,
		BOX_2 = 1,
		BOX_3 = 2,
		BOX_CHECK_1 = 3,
		BOX_CHECK_2 = 4,
		BOX_CHECK_3 = 5,
		BOX_IMAGE_CARD_1 = 6,
		BOX_IMAGE_CARD_2 = 7,
		BOX_IMAGE_CARD_3 = 8,
		BOX_IMAGE_HEROINE_1 = 9,
		BOX_IMAGE_HEROINE_2 = 10,
		BOX_IMAGE_HEROINE_3 = 11,
		BOX_IMAGE_EMBLEM_1 = 12,
		BOX_IMAGE_EMBLEM_2 = 13,
		BOX_IMAGE_EMBLEM_3 = 14,
		BOX_IMAGE_MONEY_1 = 15,
		BOX_IMAGE_MONEY_2 = 16,
		BOX_IMAGE_MONEY_3 = 17,
		BOX_TEXT_MONEY_1 = 18,
		BOX_TEXT_MONEY_2 = 19,
		BOX_TEXT_MONEY_3 = 20,
		BOX_IMAGE_EMPTY_1 = 21,
		BOX_IMAGE_EMPTY_2 = 22,
		BOX_IMAGE_EMPTY_3 = 23,
		BOX_TEXT_EMPTY_1 = 24,
		BOX_TEXT_EMPTY_2 = 25,
		BOX_TEXT_EMPTY_3 = 26,
	}

	private enum eTextId
	{
		TEXT_STAGE_REWARD = 0,
		BASE_MONEY_TEXT = 1,
		MONEY_TEXT = 2,
		REWARD_MONEY_CNT_1 = 3,
		REWARD_MONEY_CNT_2 = 4,
		REWARD_MONEY_CNT_3 = 5,
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
	private Animator RootAnimator; //Field offset: 0x118
	private UiState WindowState; //Field offset: 0x11C
	private List<EffectObjectBase> m_Effects; //Field offset: 0x120
	private RawImageEx[] m_RawImageArray; //Field offset: 0x124
	private Single[] m_EffectPlayStartTime; //Field offset: 0x128
	private CharacterAssetBunleLoader m_Box1HeroineIconLoder; //Field offset: 0x12C
	private CharacterAssetBunleLoader m_Box1CardIconLoder; //Field offset: 0x130
	private EmblemAssetBundleLoader m_Box1EmblemIconLoder; //Field offset: 0x134
	private CharacterAssetBunleLoader m_Box2HeroineIconLoder; //Field offset: 0x138
	private CharacterAssetBunleLoader m_Box2CardIconLoder; //Field offset: 0x13C
	private EmblemAssetBundleLoader m_Box2EmblemIconLoder; //Field offset: 0x140
	private CharacterAssetBunleLoader m_Box3HeroineIconLoder; //Field offset: 0x144
	private CharacterAssetBunleLoader m_Box3CardIconLoder; //Field offset: 0x148
	private EmblemAssetBundleLoader m_Box3EmblemIconLoder; //Field offset: 0x14C

	private static ResultRewardDisp() { }

	public ResultRewardDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void DispBox(int _index, bool isNew = false) { }

	public void DispItemIcon(int _index, bool _enable) { }

	[AsyncStateMachine(typeof(<InitEffect>d__38))]
	public UniTaskVoid InitEffect() { }

	protected virtual void InitUguiOther() { }

	public virtual bool IsPlaying() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	private void LoadItemIconCard(int _index, int _rewardId) { }

	private void LoadItemIconEmblem(int _index, int _rewardId) { }

	private void LoadItemIconHeroine(int _index, int _rewardId) { }

	private void LoadItemIconRewardMoney(int _index, int _rewardId) { }

	public virtual void ReleaseAll() { }

	public void ResumeEffects() { }

	public void SetMoneyCount(int cnt) { }

	public void SetMoneyRate(float _rate, int _money) { }

	public void StartCloseAnimation() { }

	public void StartOpenAnimation(float _timer = 0) { }

	public void StopEffect() { }

	public void UpdateCheckBox(int _index, bool _value) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateItemIcon(int _index, int type, int _rewardId) { }

}


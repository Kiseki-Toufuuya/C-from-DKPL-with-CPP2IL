namespace Heqet;

public class GalleryPlayRecordDisp : DispBase, IGalleryDisp
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass27_0
	{
		public GalleryPlayRecordDisp <>4__this; //Field offset: 0x8
		public int heroineViewId; //Field offset: 0xC

		public <>c__DisplayClass27_0() { }

		internal void <UpdateDispLeftPane>b__0(AssetBundleLoadAssetOperation ope) { }

		internal void <UpdateDispLeftPane>b__1() { }

	}

	[CompilerGenerated]
	private struct <Open>d__40 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskMethodBuilder <>t__builder; //Field offset: 0x4
		public bool visible; //Field offset: 0xC
		public GalleryPlayRecordDisp <>4__this; //Field offset: 0x10
		private Awaiter <>u__1; //Field offset: 0x14

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	internal struct ClearCountPanel
	{
		public TextMeshProUGUI stageClear; //Field offset: 0x0
		public TextMeshProUGUI fullCombo; //Field offset: 0x4
		public TextMeshProUGUI allBrilliant; //Field offset: 0x8
		public TextMeshProUGUI framePerfect; //Field offset: 0xC

		public void Setup(Transform parent) { }

	}

	internal enum eButtonId
	{
		FreeMode = 0,
		StoryMode = 1,
		Help = 2,
		DisplaySwitch = 3,
		GotoHeroine = 4,
		GotoMitama = 5,
		PrevKeyType = 6,
		NextKeyType = 7,
		PrevKeyTypeBlank = 8,
		NextKeyTypeBlank = 9,
		Back = 10,
		SelectSkin = 11,
		Max = 12,
	}

	private enum eCommonLayerId
	{
		CardIllust = 0,
		FreePlayRankingTop = 1,
		FreePlayCountEasy = 2,
		FreePlayCountNormal = 3,
		FreePlayCountHard = 4,
		FreePlayCountLunatic = 5,
		FreePlayAllBrilliantIcon = 6,
		FreePlayFrameParfectIcon = 7,
		SwitchSelect = 8,
		FreeModePanelTop = 9,
		StoryModePanelTop = 10,
		MitamaPreviewRoot = 11,
		HironePreviewRoot = 12,
		ColaboPreviewRoot = 13,
		Score6KeyRoot = 14,
		Score4KeyRoot = 15,
		ScoreAllRoot = 16,
		Max = 17,
	}

	private enum eImageId
	{
		HeroinPreview = 0,
		Max = 1,
	}

	private enum eTextId
	{
		PreviewHeroineName = 0,
		PreviewHeroineSecondName = 1,
		PreviewHeroineIllustrator = 2,
		PreviewMitamaHironeName = 3,
		PreviewMitamaName = 4,
		PreviewMitamaIllustrator = 5,
		StageClearCount = 6,
		MissonClearCount = 7,
		MoneyCount = 8,
		KaguraClearCount = 9,
		DanmakuClearCount = 10,
		BossDestroyCount = 11,
		NormalDestroyCount = 12,
		EpisodeRate = 13,
		HeroineRate = 14,
		MitamaRate = 15,
		JaketRate = 16,
		AchievementRate = 17,
		PlayerId = 18,
		RatingScore = 19,
		TotalPlayCount = 20,
		Max = 21,
	}

	internal enum KeyType
	{
		All = 0,
		Key4 = 1,
		Key6 = 2,
		Max = 3,
	}

	internal enum PreviewMode
	{
		Heroine = 0,
		Mitama = 1,
		Colabo = 2,
		Max = 3,
	}

	internal struct RankingPanel
	{
		public GameObject obj; //Field offset: 0x0
		public TextMeshProUGUI title; //Field offset: 0x4
		public TextMeshProUGUI countLabel; //Field offset: 0x8
		public TextMeshProUGUI levelLabel; //Field offset: 0xC
		public Transform[] difficultyFrame; //Field offset: 0x10

		public void Setup(Transform parent) { }

		public void Update(HeqetMusicModel model, RankingData data) { }

	}

	private static readonly String[] m_TextList; //Field offset: 0x0
	private static readonly String[] m_ImageList; //Field offset: 0x4
	private static readonly String[] m_LayerIdList; //Field offset: 0x8
	private GalleryPlayRecordLayer m_Layer; //Field offset: 0x114
	private String[] m_ButtonDataList; //Field offset: 0x118
	private Animator RootAnimator; //Field offset: 0x11C
	private RawImageEx m_HeroineIconImage; //Field offset: 0x120
	private CharacterAssetBunleLoader m_HeroineImageLoader; //Field offset: 0x124
	private CardIllust m_CardIllust; //Field offset: 0x128
	private KeyType m_laneType; //Field offset: 0x12C
	private SkinSpriteSwitcher m_skinSpriteSwitcher; //Field offset: 0x130
	private RankingPanel[] m_FreeRankingPanel; //Field offset: 0x134
	private ClearCountPanel[] m_ClearCountPanel; //Field offset: 0x138

	private static GalleryPlayRecordDisp() { }

	public GalleryPlayRecordDisp() { }

	[CompilerGenerated]
	private bool <Open>b__40_0() { }

	public void CallbackButton(int button_id) { }

	public void CallbackInitLayout() { }

	private void ChangePreviewActive(PreviewMode mode) { }

	public virtual void Create(LayerBase parent_layer) { }

	public void DisableSwitchFavarit() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	[AsyncStateMachine(typeof(<Open>d__40))]
	public override UniTask Open(bool visible) { }

	private string PercentStr(float rate) { }

	public virtual void ReleaseAll() { }

	public void RestoreSkin() { }

	public void SetFavaritHeroineMode(PreviewMode mode) { }

	public void SetFrameParfectMode(bool visible) { }

	public void SwitchSelectStoryMode(bool isSelectMode) { }

	public void UpdateDispLeftPane(int heroineId, int mitamaCardId, int heroineViewId) { }

	protected virtual void UpdateDispMain() { }

	public void UpdateDispRightPane(KeyType laneType) { }

	private void UpdatePlayCount() { }

	private void UpdateRaning() { }

	public void UpdateSkin(string theme) { }

	private void UpdateStoryMode() { }

}


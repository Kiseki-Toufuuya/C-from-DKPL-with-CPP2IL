namespace Heqet.Danmaku;

public class DanmakuLayer : LayerBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__32_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <InitAll>b__32_0(LayerBase layer) { }

	}

	internal enum DanmakuDispEnum
	{
		Score = 0,
		Life = 1,
		Bomb = 2,
		Power = 3,
		MitamaCard = 4,
		SeekBar = 5,
		Status = 6,
		Item = 7,
		MusicInfo = 8,
		Bar = 9,
		ALL = 10,
	}

	private StageBackgroundDisp m_StageBackgroundDisp; //Field offset: 0x58
	private ViewMusicInfoLayer m_ViewMusicInfoLayer; //Field offset: 0x5C
	private ScoreBoardDisp m_ScoreBoardDisp; //Field offset: 0x60
	private LifeGaugeDisp m_LifeGaugeDisp; //Field offset: 0x64
	private BombGaugeDisp m_BombGaugeDisp; //Field offset: 0x68
	private PowerGaugeDisp m_PowerGaugeDisp; //Field offset: 0x6C
	private StatusIconsDisp m_StatusIconsDisp; //Field offset: 0x70
	private SupportItemsDisp m_SupportItemsDisp; //Field offset: 0x74
	private MitamaCardDisp m_MitamaCardDisp; //Field offset: 0x78
	private SeekBarDisp m_SeekBarDisp; //Field offset: 0x7C
	private BossLifeGaugeDisp m_BossLifeGaugeDisp; //Field offset: 0x80
	private CharacterBarDisp m_CharacterBarDisp; //Field offset: 0x84
	private BlindDisp m_BlindDisp; //Field offset: 0x88
	private FramePerfectUIDisp m_FramePerfectUIDisp; //Field offset: 0x8C
	private AllBrilliantUIDisp m_AllBrilliantUIDisp; //Field offset: 0x90
	private FullComboUIDisp m_FullComboUIDisp; //Field offset: 0x94
	private StageClearUIDisp m_StageClearUIDisp; //Field offset: 0x98
	private GameOverUIDisp m_GameOverUIDisp; //Field offset: 0x9C
	private DanmakuStartInfoDisp m_DanmakuStartInfoDisp; //Field offset: 0xA0
	private MoneyCountDisp m_MoneyCountDisp; //Field offset: 0xA4
	private TenCountDisp m_TenCountDisp; //Field offset: 0xA8
	private UnionAssetBundleLoadOperation m_ScoreFont; //Field offset: 0xAC

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

	public virtual eLayerType LAYER_TYPE
	{
		 get { } //Length: 6
	}

	public DanmakuLayer() { }

	protected virtual bool EndUpdateAfter() { }

	public void GamePause(bool enable) { }

	public void GameStart() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public virtual eLayerType get_LAYER_TYPE() { }

	public GameObject GetJudgeMessagePintOfLowerBlind() { }

	public GameObject GetJudgeMessagePintOfUpperBlind() { }

	public void HideBossLifeGauge() { }

	protected virtual void InitAll() { }

	public void Initialize() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	public bool IsGameFinishAnimation() { }

	public bool IsJacketLording() { }

	public bool IsOpenMusicInfo() { }

	public bool IsReadyStageBackground() { }

	protected virtual void LateUpdate(bool is_active) { }

	private void OnLaneJudge(NoteData noteData, int judge) { }

	public virtual void OverDeleteLayer() { }

	public void PlayNameAnimation() { }

	public void PlayStartInfoAnimation() { }

	protected virtual bool ReleaseLayer() { }

	public void SetDispHide(DanmakuDispEnum disp, bool hide) { }

	public void SetSeekPosition(float time) { }

	public void SetupParam(HeqetMusicModel _musicModel, SettingData _musicSettingData, StageController stageController) { }

	public void ShowBossLifeGauge() { }

	public void StartGameFinishAnimation() { }

	public void StartRhythmGameResult() { }

	protected virtual void Update(bool is_active) { }

}


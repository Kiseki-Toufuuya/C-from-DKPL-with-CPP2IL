namespace Heqet.Kagura;

public class KaguraLayer : LayerBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__41_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <InitAll>b__41_0(LayerBase layer) { }

	}

	private enum FullComboEffectType
	{
		FullCombo = 0,
		AllBrilliant = 1,
		FramePerfect = 2,
		FullCombo_Touch = 3,
		AllBrilliant_Touch = 4,
		FramePerfect_Touch = 5,
		Count = 6,
	}

	internal enum KaguraDispEnum
	{
		MusicInfo = 0,
		BG = 1,
		GrooveGauge = 2,
		Live2D = 3,
		MitamaCard = 4,
		Score = 5,
		SeekBar = 6,
		ALL = 7,
	}

	private ViewMusicInfoLayer m_ViewMusicInfoLayer; //Field offset: 0x58
	private MusicInfoTouchUIDisp m_MusicInfoTouchUI; //Field offset: 0x5C
	private KaguraBackgroundDisp m_KaguraBackgroundDisp; //Field offset: 0x60
	private GrooveGaugeDisp m_GrooveGaugeDisp; //Field offset: 0x64
	private KaguraLive2DDisp m_KaguraLive2DDisp; //Field offset: 0x68
	private MitamaCardDisp m_MitamaCardDisp; //Field offset: 0x6C
	private ScoreBoardDisp m_ScoreBoardDisp; //Field offset: 0x70
	private BlindDisp m_BlindDisp; //Field offset: 0x74
	private SeekBarDisp m_SeekBarDisp; //Field offset: 0x78
	private AutoPlayDisp m_AutoPlayDisp; //Field offset: 0x7C
	private FramePerfectUIDisp m_FramePerfectUIDisp; //Field offset: 0x80
	private AllBrilliantUIDisp m_AllBrilliantUIDisp; //Field offset: 0x84
	private FullComboUIDisp m_FullComboUIDisp; //Field offset: 0x88
	private StageClearUIDisp m_StageClearUIDisp; //Field offset: 0x8C
	private GameOverUIDisp m_GameOverUIDisp; //Field offset: 0x90
	private KaguraStartInfoDisp m_KaguraStartInfoDisp; //Field offset: 0x94
	private UnionAssetBundleLoadOperation m_ScoreFont; //Field offset: 0x98
	private bool isPlayFullComboEffect; //Field offset: 0x9C
	[CompilerGenerated]
	private bool <IsPlayingFullComboEffect>k__BackingField; //Field offset: 0x9D
	private GameObject fullComboEffectRoot; //Field offset: 0xA0
	private List<EffectObjectBase> fullComboEffectList; //Field offset: 0xA4
	private EffectObjectBase playingFullComboEffect; //Field offset: 0xA8
	private float fullComboEffectTimer; //Field offset: 0xAC
	private bool isGameStart; //Field offset: 0xB0

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

	public private bool IsPlayingFullComboEffect
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 17
	}

	public virtual eLayerType LAYER_TYPE
	{
		 get { } //Length: 6
	}

	public KaguraLayer() { }

	protected virtual bool EndUpdateAfter() { }

	public void GamePause(bool enable) { }

	public void GameStart() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	[CompilerGenerated]
	public bool get_IsPlayingFullComboEffect() { }

	public virtual eLayerType get_LAYER_TYPE() { }

	public GameObject GetJudgeMessagePintOfLowerBlind() { }

	public GameObject GetJudgeMessagePintOfUpperBlind() { }

	protected virtual void InitAll() { }

	public void Initialize() { }

	protected virtual bool InitResourceWait() { }

	protected virtual bool InitUpdateBefore() { }

	public bool IsGameFinishAnimation() { }

	public bool IsJacketLording() { }

	public bool IsOpenMusicInfo() { }

	public bool IsReadyBackground() { }

	protected virtual void LateUpdate(bool is_active) { }

	private void OnLaneJudge(NoteData noteData, int judge) { }

	public virtual void OverDeleteLayer() { }

	public void PlayNameAnimation() { }

	public void PlayStartInfoAnimation() { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	private void set_IsPlayingFullComboEffect(bool value) { }

	public void SetDispHide(KaguraDispEnum disp, bool hide) { }

	public void SetupParam(HeqetMusicModel _data, SettingData _musicSettingData) { }

	public void StartGameFinishAnimation() { }

	public void StartRhythmGameResult() { }

	public bool StopMovie() { }

	protected virtual void Update(bool is_active) { }

}


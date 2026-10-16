namespace Heqet.RG;

public class ResultScoreDisp : DispBase
{
	private enum eLayerId
	{
		ICON_NEW_RECORD = 0,
		ICON_GRADE = 1,
		ANIM_GRADE = 2,
		GAUGE_C = 3,
		GAUGE_B = 4,
		GAUGE_A = 5,
		GAUGE_S = 6,
		GAUGE_SS = 7,
		SCORE_COMMA_1 = 8,
		SCORE_COMMA_2 = 9,
		SCORE_COMMA_3 = 10,
	}

	internal enum eScoreAtlasImage
	{
		SUJI_0 = 0,
		SUJI_1 = 1,
		SUJI_2 = 2,
		SUJI_3 = 3,
		SUJI_4 = 4,
		SUJI_5 = 5,
		SUJI_6 = 6,
		SUJI_7 = 7,
		SUJI_8 = 8,
		SUJI_9 = 9,
		SUJI_10 = 10,
	}

	private enum eTxtLayerId
	{
		TEXT_HIGH_SCORE = 0,
	}

	private class ScoreGaugeWork
	{
		public int LayerId; //Field offset: 0x8
		public AtlasImage Img; //Field offset: 0xC
		public ScoreGaugeWork Next; //Field offset: 0x10
		public float StartRate; //Field offset: 0x14
		public float EndRate; //Field offset: 0x18
		public ShearProgressBarSprite Sprite; //Field offset: 0x1C

		public ScoreGaugeWork() { }

		public ScoreGaugeWork GetScoreGsugeWorkByRate(float _rate) { }

		public void UpdateGauge(float _rate) { }

	}

	internal class SetupParam
	{
		public int Score; //Field offset: 0x8
		public int HighScore; //Field offset: 0xC
		public int MaxScore; //Field offset: 0x10
		public HeqetGameMode Mode; //Field offset: 0x14
		public ScoreRankID Grade; //Field offset: 0x18

		public SetupParam() { }

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
	private static readonly String[] m_GreadSpriteList; //Field offset: 0x4
	private String[] TxtLayerList; //Field offset: 0x114
	private readonly string SCORE_SPRITE; //Field offset: 0x118
	private readonly string SCORE_PATH; //Field offset: 0x11C
	private UiState WindowState; //Field offset: 0x120
	private Camera Camera3d; //Field offset: 0x124
	private EffectObjectBase NewEffect; //Field offset: 0x128
	private EffectObjectBase GradeEffect; //Field offset: 0x12C
	private EffectObjectBase GradeEffect2; //Field offset: 0x130
	public Animator m_GradeAnim; //Field offset: 0x134
	private Animator m_NewAnim; //Field offset: 0x138
	private Animator RootAnimator; //Field offset: 0x13C
	private int m_GaugeScore; //Field offset: 0x140
	private float m_ScoreRate; //Field offset: 0x144
	private AtlasImage m_GradeImg; //Field offset: 0x148
	private List<AtlasImage> m_ScoreAtlasImgs; //Field offset: 0x14C
	private List<ScoreGaugeWork> m_ScoreGaugeWorks; //Field offset: 0x150

	private float GAUGE_RATE
	{
		private get { } //Length: 7
	}

	private static ResultScoreDisp() { }

	public ResultScoreDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public void Finish(long num) { }

	public void GenerateHighScore(long num) { }

	public void GenerateScore(long num) { }

	private float get_GAUGE_RATE() { }

	public void Init(SetupParam _param) { }

	protected virtual void InitUguiOther() { }

	public virtual bool IsPlaying() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	public void StartCloseAnimation() { }

	public void StartGradeEffect(ScoreRankID a_scoreRank) { }

	public void StartNewEffect() { }

	public void StartOpenAnimation(float time = 0) { }

	public void StopGradeEffect() { }

	public void StopNewEffect() { }

	protected virtual void UpdateDispMain() { }

	public void UpdateSkipGrade() { }

}


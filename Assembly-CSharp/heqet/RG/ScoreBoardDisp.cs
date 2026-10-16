namespace Heqet.RG;

public class ScoreBoardDisp : DispBase
{
	[CompilerGenerated]
	private struct <InitEffect>d__32 : IAsyncStateMachine
	{
		public int <>1__state; //Field offset: 0x0
		public AsyncUniTaskVoidMethodBuilder <>t__builder; //Field offset: 0x4
		public ScoreBoardDisp <>4__this; //Field offset: 0x8
		private Vector3 <pos>5__2; //Field offset: 0xC
		private Awaiter <>u__1; //Field offset: 0x18

		private override void MoveNext() { }

		[DebuggerHidden]
		private override void SetStateMachine(IAsyncStateMachine stateMachine) { }

	}

	private const string SCORE_TEXT = "score_text"; //Field offset: 0x0
	private const string NEW_RECORD = "new_record"; //Field offset: 0x0
	private const string MARKS = "marks"; //Field offset: 0x0
	private const string EFFECT_POS = "rank_effect"; //Field offset: 0x0
	private const string BG_KAGURA = "bg_kagura"; //Field offset: 0x0
	private const string BG_DANMAKU = "bg_danmaku"; //Field offset: 0x0
	private const string CAMERA = "GameCamera"; //Field offset: 0x0
	private const float ANIMATION_RATE = 0.3; //Field offset: 0x0
	private const int FRAME = 60; //Field offset: 0x0
	private const float TIME_RATE = 0.016666668; //Field offset: 0x0
	private readonly String[] RANKS; //Field offset: 0x114
	private TextMeshProUGUI m_ScoreText; //Field offset: 0x118
	private GameObject m_NewRecordTag; //Field offset: 0x11C
	private InGameInfo inGameData; //Field offset: 0x120
	private float m_AnimaEndTime; //Field offset: 0x124
	private float m_AnimaUpdateValue; //Field offset: 0x128
	private float m_CurrScore; //Field offset: 0x12C
	private float m_Timer; //Field offset: 0x130
	private int m_TargetScore; //Field offset: 0x134
	private int m_CurrRank; //Field offset: 0x138
	private bool m_IsKaguraLayer; //Field offset: 0x13C
	private bool m_Updating; //Field offset: 0x13D
	private EffectObjectBase m_RankUpEffect; //Field offset: 0x140
	private EffectObjectBase m_SSEffect; //Field offset: 0x144
	private EffectObjectBase m_RankDownEffect; //Field offset: 0x148
	private List<GameObject> m_Marks; //Field offset: 0x14C
	private List<GameObject> m_Ranks; //Field offset: 0x150

	public ScoreBoardDisp() { }

	[CompilerGenerated]
	private bool <InitEffect>b__32_0() { }

	public virtual void Create(LayerBase parent_layer) { }

	[AsyncStateMachine(typeof(<InitEffect>d__32))]
	public UniTaskVoid InitEffect() { }

	private void InitLayout() { }

	private void InitRank() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	private void ScoreAnimation() { }

	public void SetScoreData(int score) { }

	public void SetScoreRank(float score) { }

	public void SetScoreRank(ScoreRankID rank) { }

	public void ShowNewRecord() { }

	protected virtual void UpdateDispMain() { }

}


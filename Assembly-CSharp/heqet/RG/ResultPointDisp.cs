namespace Heqet.RG;

public class ResultPointDisp : DispBase
{
	private enum eLayerId
	{
		FRAME_INGAME_JUDGE_PERFECT = 0,
		FRAME_INGAME_JUDGE_BRILLIANT = 1,
		FRAME_INGAME_JUDGE_GREAT = 2,
		FRAME_INGAME_JUDGE_BAD = 3,
		FRAME_INGAME_JUDGE_MISS = 4,
		FRAME_FAST_SLOW = 5,
	}

	private enum eTextId
	{
		TEXT_RESULT_PERFECT = 0,
		TEXT_RESULT_BRILLIANT = 1,
		TEXT_RESULT_GREAT = 2,
		TEXT_RESULT_BAD = 3,
		TEXT_RESULT_MISS = 4,
		TEXT_FAST = 5,
		TEXT_SLOW = 6,
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
	private Animator RootAnimator; //Field offset: 0x114
	private UiState WindowState; //Field offset: 0x118
	private List<Animation> m_animList; //Field offset: 0x11C

	public List<Animation> PointAnimList
	{
		 get { } //Length: 14
	}

	private static ResultPointDisp() { }

	public ResultPointDisp() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public List<Animation> get_PointAnimList() { }

	protected virtual void InitUguiOther() { }

	public virtual bool IsPlaying() { }

	public bool IsPlayingAnime() { }

	protected virtual void LateUpdate() { }

	public void SetFastCount(int _cnt) { }

	public void SetResultBad(string a_text) { }

	public void SetResultBrilliant(string a_text) { }

	public void SetResultGreat(string a_text) { }

	public void SetResultMiss(string a_text) { }

	public void SetResultPerfect(string a_text) { }

	public void SetShowInGameJudgeBad(bool a_show) { }

	public void SetShowInGameJudgeBrilliant(bool a_show) { }

	public void SetShowInGameJudgeGreat(bool a_show) { }

	public void SetShowInGameJudgeMiss(bool a_show) { }

	public void SetShowInGameJudgePerfect(bool a_show) { }

	public void SetSlowCount(int _cnt) { }

	public void ShowFastSlowCount(bool _enable) { }

	public void StartCloseAnimation() { }

	public void StartOpenAnimation(float time = 0) { }

	protected virtual void UpdateDispMain() { }

}


namespace Heqet.Kagura;

public class DebugResultScene : MainSceneBase
{
	internal enum eContStep
	{
		FADE_IN = 0,
		RESULT_SETTING = 1,
		RESULT_INIT = 2,
		RESULT_START = 3,
		RESULT = 4,
		FADE_OUT = 5,
		NONE = 6,
	}

	internal enum eStepMain
	{
		WAIT_PREV_UNLOAD = 0,
		INIT_START = 1,
		CONT_MAIN = 2,
		CONT_END = 3,
		NUM = 4,
	}

	private class TapResult
	{
		public TapResult key; //Field offset: 0x8
		public InputField input; //Field offset: 0xC

		public TapResult() { }

	}

	[SerializeField]
	private GameObject m_DebugCanvas; //Field offset: 0x14
	[SerializeField]
	private Button m_StartButton; //Field offset: 0x18
	[SerializeField]
	private InputField m_ScoreInput; //Field offset: 0x1C
	[SerializeField]
	private List<TapResult> m_TapResuls; //Field offset: 0x20
	private eStepMain m_StepMain; //Field offset: 0x24
	private eContStep m_ContStep; //Field offset: 0x28
	[SerializeField]
	private RhythmGameResult2 rhythmGameResult; //Field offset: 0x2C
	[SerializeField]
	private Camera gameCamera; //Field offset: 0x30

	public DebugResultScene() { }

	private void ContMain() { }

	protected virtual void DoDestroy() { }

	protected virtual void DoStart() { }

	protected virtual void DoUpdateMain() { }

	private void InitCanvas() { }

	private void InitGame() { }

	private void OnClickStart() { }

	private void OnEndEditScoreInput(string _str) { }

	private void OnEndEditTapResultInput(string _str) { }

}


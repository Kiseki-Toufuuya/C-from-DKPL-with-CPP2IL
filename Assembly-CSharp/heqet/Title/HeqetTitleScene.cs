namespace Heqet.Title;

public class HeqetTitleScene : MainSceneBase
{
	internal enum eContStep
	{
		FADE_IN = 0,
		START = 1,
		MENU = 2,
		FADE_OUT = 3,
		NONE = 4,
	}

	internal enum eStepMain
	{
		WAIT_PREV_UNLOAD = 0,
		TAKASHO_QUIC_WAIT = 1,
		PRE_LOAD_WAIT = 2,
		INIT_START = 3,
		CONT_MAIN = 4,
		CONT_END = 5,
		NUM = 6,
	}

	private const string s_CreditFontPath = "font/credit.xab"; //Field offset: 0x0
	private eStepMain m_StepMain; //Field offset: 0x14
	private eContStep m_ContStep; //Field offset: 0x18
	private UnionAssetBundleLoadOperation m_creditFont; //Field offset: 0x1C
	private TitleLayer m_TitleLayer; //Field offset: 0x20

	public HeqetTitleScene() { }

	[CompilerGenerated]
	private void <DoUpdateMain>b__8_0() { }

	private void ContMain() { }

	protected virtual void DoAwake() { }

	protected virtual void DoDestroy() { }

	protected virtual void DoStart() { }

	protected virtual void DoUpdateMain() { }

	private void InitCanvas() { }

}


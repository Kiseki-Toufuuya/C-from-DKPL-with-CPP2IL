namespace Heqet.TitleLogo;

public class TitleLogoScene : MainSceneBase
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

	private eStepMain m_StepMain; //Field offset: 0x14
	private eContStep m_ContStep; //Field offset: 0x18

	public TitleLogoScene() { }

	[CompilerGenerated]
	private void <DoUpdateMain>b__5_0() { }

	private void ContMain() { }

	protected virtual void DoDestroy() { }

	protected virtual void DoStart() { }

	protected virtual void DoUpdateMain() { }

}


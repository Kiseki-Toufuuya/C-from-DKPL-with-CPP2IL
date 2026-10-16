namespace Heqet;

public class FreePlayScene : MainSceneBase
{
	internal enum eContStep
	{
		INIT = 0,
		FADE_IN = 1,
		START = 2,
		MENU = 3,
		FADE_OUT = 4,
		NONE = 5,
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
	[SerializeField]
	public Vector3 keyPunch; //Field offset: 0x1C
	[SerializeField]
	public int keyPanchCount; //Field offset: 0x28
	[SerializeField]
	public float keyPanchTime; //Field offset: 0x2C

	public FreePlayScene() { }

	[CompilerGenerated]
	private void <DoUpdateMain>b__7_0() { }

	private void ContMain() { }

	protected virtual void DoDestroy() { }

	protected virtual void DoUpdateMain() { }

	private void InitCanvas() { }

}


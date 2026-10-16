namespace Heqet.Prologue;

public class PrologueScene : MainSceneBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<LayerBase> <>9__7_1; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <ContMain>b__7_1(LayerBase _layer) { }

	}

	internal enum eContStep
	{
		START = 0,
		START_EPISODE = 1,
		GO_TO_RHYTHMGAME = 2,
		GO_TO_STORYMODE = 3,
		HELP_WAIT = 4,
		NONE = 5,
	}

	internal enum eStepMain
	{
		INIT_ALL = 0,
		TAKASHO_QUIC_WAIT = 1,
		PRE_LOAD_WAIT = 2,
		WAIT_PREV_UNLOAD = 3,
		INIT_START = 4,
		CONT_MAIN = 5,
		CONT_END = 6,
		NUM = 7,
	}

	private eStepMain m_StepMain; //Field offset: 0x14
	private eContStep m_ContStep; //Field offset: 0x18
	private int m_entry_episode_id; //Field offset: 0x1C

	public PrologueScene() { }

	[CompilerGenerated]
	private void <ContMain>b__7_0() { }

	[CompilerGenerated]
	private void <DoUpdateMain>b__6_0() { }

	private void ContMain() { }

	protected virtual void DoDestroy() { }

	protected virtual void DoStart() { }

	protected virtual void DoUpdateMain() { }

}


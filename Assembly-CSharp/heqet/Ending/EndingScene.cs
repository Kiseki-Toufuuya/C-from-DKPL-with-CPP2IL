namespace Heqet.Ending;

public class EndingScene : MainSceneBase
{
	internal enum eContStep
	{
		START = 0,
		START_EPISODE = 1,
		INIT_CREDIT = 2,
		START_CREDIT = 3,
		WAIT_CREDIT = 4,
		FADE_OUT = 5,
		NONE = 6,
	}

	internal enum eStepMain
	{
		INIT_ALL = 0,
		TAKASHO_QUIC_WAIT = 1,
		PRE_LOAD_WAIT = 2,
		WAIT_PREV_UNLOAD = 3,
		INIT_START = 4,
		CONT_MAIN = 5,
		DO_SAVE = 6,
		WAIT_SYSTEM_DIALOG = 7,
		GO_TO_TITLE = 8,
		CONT_END = 9,
		NUM = 10,
	}

	private eStepMain m_StepMain; //Field offset: 0x14
	private eContStep m_ContStep; //Field offset: 0x18
	private CreditLayer m_creditLayer; //Field offset: 0x1C
	[SerializeField]
	private int m_entry_episode_id; //Field offset: 0x20
	private string m_bgStillTextureName; //Field offset: 0x24
	private Sprite m_preLoadStillSprite; //Field offset: 0x28
	private AssetBundleLoadAssetOperation m_op; //Field offset: 0x2C
	private UnionAssetBundleLoadOperation m_creditFont; //Field offset: 0x30

	public EndingScene() { }

	[CompilerGenerated]
	private void <ContMain>b__13_0() { }

	[CompilerGenerated]
	private void <DoUpdateMain>b__12_0() { }

	[CompilerGenerated]
	private void <PreLoadSprite>b__10_0(AssetBundleLoadAssetOperation textureAb) { }

	private void ContMain() { }

	protected virtual void DoDestroy() { }

	protected virtual void DoStart() { }

	protected virtual void DoUpdateMain() { }

	private void PreLoadSprite() { }

}


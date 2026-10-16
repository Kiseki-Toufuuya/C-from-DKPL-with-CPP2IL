namespace XeApp.Game;

public class DialogRaidBossAutoSelectDisp : DialogChildObject
{
	internal enum eButtonId
	{
		BtnWindowCheck = 0,
		NUM = 1,
	}

	private enum eCheckStep
	{
		None = 0,
		AnimationWait = 1,
	}

	private enum eLayerId
	{
		BASE_NUM = 0,
		TEXT_BASE = 0,
		TEXT_CONTEXT = 0,
		TEXT_CHECK = 1,
		TEXT_NUM = 2,
	}

	private enum eSpriteId
	{
		NONE = 0,
		CHECK_BOX_ON = 1,
		CHECK_BOX_OFF = 2,
		MAX = 3,
	}

	internal class InOutParam
	{
		public bool IsSkipWindow; //Field offset: 0x8
		public Action DialogOpenCallback; //Field offset: 0xC

		public InOutParam() { }

	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private static readonly String[] m_ButtonDataList; //Field offset: 0x4
	private static readonly String[] m_SpriteNameList; //Field offset: 0x8
	private sDialogChildArg ChildArg; //Field offset: 0x12C
	private DialogLayer m_Layer; //Field offset: 0x130
	private InOutParam m_InOutParam; //Field offset: 0x134
	private AtlasImage AtlasCheckButton; //Field offset: 0x138
	private eCheckStep m_CheckStep; //Field offset: 0x13C

	private static DialogRaidBossAutoSelectDisp() { }

	public DialogRaidBossAutoSelectDisp() { }

	public void CallbackButton(int id) { }

	public bool CallbackInputEnable(int id) { }

	public virtual void Create(LayerBase parent_layer) { }

	private Sprite GetSprite(eSpriteId id) { }

	public virtual void InitLoadAfter() { }

	public void InitRaidBossAutoSelect() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	private void SetDispWindowState(bool a_state) { }

	protected virtual void UpdateDispMain() { }

}


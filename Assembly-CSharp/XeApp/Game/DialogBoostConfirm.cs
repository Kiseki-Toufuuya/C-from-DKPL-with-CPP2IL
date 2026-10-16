namespace XeApp.Game;

public class DialogBoostConfirm : DialogChildObject
{
	private enum eBtnLayerId
	{
		BTN_CHECK = 0,
		NUM = 1,
	}

	private enum eCommonLayerId
	{
		BOOST_HD = 0,
		CONSUME_BOOST_HD = 1,
		SLASH_HD = 2,
		ICON_STM = 3,
		NUM = 4,
	}

	private enum eTxtLayerId
	{
		CONFIRM_MESSAGE = 0,
		CONSUME_BOOST = 1,
		HAVE_BOOST = 2,
		CHECK_MESSAGE_LABEL = 3,
		BOOST_CONSUME_LABEL = 4,
		BOOST_LABEL = 5,
		NUM = 6,
	}

	public const string CHILD_ARG_LIVE = "live"; //Field offset: 0x0
	public const string CHILD_ARG_TRAVEL = "travel"; //Field offset: 0x0
	public const string CHILD_ARG_BATTRY = "battry"; //Field offset: 0x0
	private const string AdjustMsg19 = "<color=#ee290c>{0}</color>"; //Field offset: 0x0
	private readonly string CHECK_ON; //Field offset: 0x12C
	private readonly string CHECK_OFF; //Field offset: 0x130
	private DialogLayer m_Layer; //Field offset: 0x134
	private sDialogChildArg ChildArg; //Field offset: 0x138
	private AtlasImage m_CheckBtnAtlas; //Field offset: 0x13C
	private string ChildArgScene; //Field offset: 0x140
	private String[] m_CommonLayerList; //Field offset: 0x144
	private String[] m_TxtLayerList; //Field offset: 0x148
	private String[] m_BtnLayerList; //Field offset: 0x14C

	public DialogBoostConfirm() { }

	private void CallbackInitLayout() { }

	public bool CallbackInputEnable(int id) { }

	public virtual void Create(LayerBase parent_layer) { }

	private int GetPlayerStamina() { }

	protected virtual void InitUguiOther() { }

	public bool IsCheckOn() { }

	protected virtual void LateUpdate() { }

	private void OnClickCheckButton(int btnId) { }

	public virtual void ReleaseAll() { }

	private void SetLocalSaveFlg(bool checkFlg) { }

	protected virtual void UpdateDispMain() { }

}


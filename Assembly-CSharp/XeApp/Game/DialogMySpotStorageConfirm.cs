namespace XeApp.Game;

public class DialogMySpotStorageConfirm : DialogChildObject
{
	internal enum eBtnLayerId
	{
		BTN_CHECK_1 = 0,
		BTN_CHECK_2 = 1,
		NUM = 2,
	}

	private enum eTextId
	{
		DETAIL_01_TEXT = 0,
		DETAIL_02_TEXT = 1,
		TOGGLE_01_TEXT = 2,
		TOGGLE_02_TEXT = 3,
		NUM_TEXT_ID = 4,
	}

	private static readonly String[] m_textDataList; //Field offset: 0x0
	private readonly string CHECK_ON; //Field offset: 0x12C
	private readonly string CHECK_OFF; //Field offset: 0x130
	private sDialogChildArg ChildArg; //Field offset: 0x134
	private DialogLayer m_Layer; //Field offset: 0x138
	private AtlasImage[] m_CheckAtlasImg; //Field offset: 0x13C
	protected String[] m_BtnLayerList; //Field offset: 0x140

	private static DialogMySpotStorageConfirm() { }

	public DialogMySpotStorageConfirm() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	public bool IsButtonOn(eBtnLayerId btn) { }

	protected virtual void LateUpdate() { }

	private void OnClickCheckBtn(int id) { }

	public virtual void ReleaseAll() { }

	protected virtual void UpdateDispMain() { }

}


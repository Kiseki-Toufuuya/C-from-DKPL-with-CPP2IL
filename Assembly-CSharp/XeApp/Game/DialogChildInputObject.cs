namespace XeApp.Game;

public class DialogChildInputObject : DialogChildObject
{
	private enum eLayerId
	{
		BASE_NUM = 0,
		TEXT_TITLE = 0,
		TEXT_INFO = 1,
		TEXT_INPUT_TXT = 2,
		TEXT_NUM = 3,
		BTN_INPUT = 3,
		BTN_NUM = 4,
	}

	private sDialogInutChildArg ChildArg; //Field offset: 0x12C
	private DialogLayer m_Layer; //Field offset: 0x130
	private TMP_InputField m_InputField; //Field offset: 0x134
	private bool isInputComp; //Field offset: 0x138
	private int m_LimitLength; //Field offset: 0x13C
	private readonly String[] m_LayerIdList; //Field offset: 0x140

	public DialogChildInputObject() { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public string GetInputFieldTxt() { }

	public string GetInputTxt() { }

	protected virtual void InitUguiOther() { }

	private void OnClickButtonRelation(int btnId) { }

	private void OnSelectCallback(string tx) { }

	private void ResultKeyboard(string inputTxt) { }

	private void ResultKeyboardTextCheck(string text) { }

}


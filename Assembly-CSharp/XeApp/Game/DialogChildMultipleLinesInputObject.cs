namespace XeApp.Game;

public class DialogChildMultipleLinesInputObject : DialogChildObject
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

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private sDialogInutChildArg ChildArg; //Field offset: 0x12C
	private DialogLayer m_Layer; //Field offset: 0x130
	private TMP_InputField m_InputField; //Field offset: 0x134
	private bool isInputComp; //Field offset: 0x138

	private static DialogChildMultipleLinesInputObject() { }

	public DialogChildMultipleLinesInputObject() { }

	[CompilerGenerated]
	private void <InitUguiOther>b__7_0(int x) { }

	private void CallbackInitLayout() { }

	public virtual void Create(LayerBase parent_layer) { }

	public string GetInputTxt() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	private void OnClickInput() { }

	private void ResultKeyboard(string inputTxt) { }

	protected virtual void UpdateDispMain() { }

}


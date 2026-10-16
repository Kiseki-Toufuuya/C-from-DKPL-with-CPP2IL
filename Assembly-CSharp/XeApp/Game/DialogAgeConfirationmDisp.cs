namespace XeApp.Game;

public class DialogAgeConfirationmDisp : DialogChildObject
{
	private enum eButtonId
	{
		BtnYear = 0,
		BtnMonth = 1,
		NUM = 2,
	}

	private enum eInputType
	{
		Year = 0,
		Month = 1,
	}

	internal class InOutParam
	{
		public int Year; //Field offset: 0x8
		public int Month; //Field offset: 0xC

		public InOutParam() { }

	}

	private static readonly String[] m_ButtonDataList; //Field offset: 0x0
	private sDialogChildArg ChildArg; //Field offset: 0x12C
	private DialogLayer m_Layer; //Field offset: 0x130
	private TextMeshProUGUI m_Text1; //Field offset: 0x134
	private TextMeshProUGUI m_Text2; //Field offset: 0x138
	private TextMeshProUGUI m_Text3; //Field offset: 0x13C
	private TextMeshProUGUI m_Text4; //Field offset: 0x140
	private TMP_InputField m_InputYearText; //Field offset: 0x144
	private TMP_InputField m_InputMonthText; //Field offset: 0x148
	private InOutParam m_InOutParam; //Field offset: 0x14C
	private TextMeshProUGUI m_CurrentInputTarget; //Field offset: 0x150
	private eInputType m_CurrentInputType; //Field offset: 0x154
	private bool m_RetryInput; //Field offset: 0x158
	private CustomScreenKeyboard CurrentKeyboard; //Field offset: 0x15C

	private static DialogAgeConfirationmDisp() { }

	public DialogAgeConfirationmDisp() { }

	private void CheckUpdateButton() { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	private void ResultInputMonth(string a_strRet) { }

	private void ResultInputYear(string a_strRet) { }

	protected virtual void UpdateDispMain() { }

}


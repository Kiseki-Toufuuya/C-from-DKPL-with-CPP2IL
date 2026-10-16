namespace XeApp.Game;

public class DialogRadioBtnDisp : DialogChildObject
{
	internal enum eBtnType
	{
		TYPE_2_BTN = 0,
		TYPE_3_BTN = 1,
	}

	private enum eButtonId
	{
		BTN_2BTN_1 = 0,
		BTN_2BTN_2 = 1,
		BTN_3BTN_1 = 2,
		BTN_3BTN_2 = 3,
		BTN_3BTN_3 = 4,
		BTN_NUM = 5,
	}

	private enum eLayerId
	{
		BASE_NUM = 0,
		TEXT_2BTN_1 = 0,
		TEXT_2BTN_2 = 1,
		TEXT_3BTN_1 = 2,
		TEXT_3BTN_2 = 3,
		TEXT_3BTN_3 = 4,
		TEXT_NUM = 5,
	}

	private enum eSprite
	{
		ON = 0,
		OFF = 1,
		NUM = 2,
	}

	internal class InOutParam
	{
		private eBtnType btn_type; //Field offset: 0x8
		private string btn_text_1; //Field offset: 0xC
		private string btn_text_2; //Field offset: 0x10
		private string btn_text_3; //Field offset: 0x14
		private int select_id; //Field offset: 0x18

		public string BtnText1
		{
			 get { } //Length: 11
		}

		public string BtnText2
		{
			 get { } //Length: 11
		}

		public string BtnText3
		{
			 get { } //Length: 11
		}

		public eBtnType BtnType
		{
			 get { } //Length: 11
		}

		public int SelectId
		{
			 get { } //Length: 11
			 set { } //Length: 14
		}

		public InOutParam(eBtnType type = 0, string btn_1 = "", string btn_2 = "", string btn_3 = "", int id = 0) { }

		public string get_BtnText1() { }

		public string get_BtnText2() { }

		public string get_BtnText3() { }

		public eBtnType get_BtnType() { }

		public int get_SelectId() { }

		public void set_SelectId(int value) { }

	}

	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private static readonly String[] m_ButtonDataList; //Field offset: 0x4
	private sDialogChildArg ChildArg; //Field offset: 0x12C
	private DialogLayer m_Layer; //Field offset: 0x130
	private InOutParam m_InOutParam; //Field offset: 0x134
	private AtlasImage[] m_BtnImage; //Field offset: 0x138
	private Sprite[] m_BtnSprite; //Field offset: 0x13C
	private Int32[] BTN_2_table; //Field offset: 0x140
	private Int32[] BTN_3_table; //Field offset: 0x144

	private static DialogRadioBtnDisp() { }

	public DialogRadioBtnDisp() { }

	private void CallbackInputButton(int id) { }

	public bool CallbackInputEnable(int id) { }

	public virtual void Create(LayerBase parent_layer) { }

	private void Hide2Button() { }

	private void Hide3Button() { }

	protected virtual void InitUguiOther() { }

	protected virtual void LateUpdate() { }

	public virtual void ReleaseAll() { }

	private void SetActiveButton(int select_id) { }

	protected virtual void UpdateDispMain() { }

}


namespace Heqet.FilterDialog;

public class FilterDialogPlateDisp : UIDispBase
{
	private enum eButtonId
	{
		SCREEN_BTN = 0,
		CANCEL_2BTN = 1,
		OK_2BTN = 2,
		CANCEL_3BTN = 3,
		OK_3BTN = 4,
		RESET_3BTN = 5,
	}

	internal enum eChangeBtnType
	{
		CHANGE_NONE = 0,
		CHANGE_2BTN = 1,
		CHANGE_3BTN = 2,
		CHANGE_BTN_NUM = 3,
	}

	internal enum eChangeType
	{
		LEFT = 0,
		CENTER = 1,
		RIGHT = 2,
	}

	internal enum eDispType
	{
		TYPE_2BTN = 0,
		TYPE_3BTN = 1,
	}

	private enum eLayerId
	{
		BASE_SCROLL = 0,
		BASE_2BTN = 1,
		BASE_3BTN = 2,
	}

	internal enum eResultType
	{
		RES_NONE = 0,
		RES_CANCEL = 1,
		RES_DECIDE = 2,
		RES_RESET = 3,
	}

	private enum eTextId
	{
		TEXT_TITLE = 0,
		TEXT_2BTN_CANCEL = 1,
		TEXT_2BTN_OK = 2,
		TEXT_3BTN_CANCEL = 3,
		TEXT_3BTN_OK = 4,
		TEXT_3BTN_RESET = 5,
	}

	private const int InputMax = 15; //Field offset: 0x0
	private static readonly String[] m_LayerIdList; //Field offset: 0x0
	private static readonly String[] m_TextIdList; //Field offset: 0x4
	private static readonly String[] m_ButtonDataList; //Field offset: 0x8
	private readonly string StartAnimName; //Field offset: 0x134
	private readonly string CloseAnimName; //Field offset: 0x138
	private int m_nCanvasId; //Field offset: 0x13C
	private Animator m_RootAnimator; //Field offset: 0x140
	private bool m_bClose; //Field offset: 0x144
	private eResultType m_resSelect; //Field offset: 0x148
	private bool m_bTouchClose; //Field offset: 0x14C

	protected virtual string AnimatorObjectName
	{
		 get { } //Length: 35
	}

	public int InitCanvasId
	{
		 set { } //Length: 17
	}

	protected virtual string StateNameClose
	{
		 get { } //Length: 35
	}

	protected virtual string StateNameOpen
	{
		 get { } //Length: 35
	}

	private static FilterDialogPlateDisp() { }

	public FilterDialogPlateDisp() { }

	private void CallbackButton(int id) { }

	private void CallbackInitLayout() { }

	private bool CallbackInputEnable(int id) { }

	public virtual void Create(LayerBase parent_layer) { }

	protected virtual string get_AnimatorObjectName() { }

	protected virtual string get_StateNameClose() { }

	protected virtual string get_StateNameOpen() { }

	public bool GetReset3ButtonActive() { }

	public GameObject GetScrollRoot() { }

	public eResultType GetSelectResult() { }

	protected virtual void InitUguiOther() { }

	public bool IsClose() { }

	public bool IsSelectReset() { }

	protected virtual void LateUpdate() { }

	public void set_InitCanvasId(int value) { }

	private void SetButtonText(eButtonId buttonId, eTextId textId, string str) { }

	public void SetPlateButtonText(String[] btn) { }

	public void SetPlateTitle(string title) { }

	public void SetPlateType(eDispType type) { }

	public void SetResetButtonEnable(bool enable) { }

	public void SetScreenTouchClose(bool isClose) { }

	public void StartCloseAnim() { }

	public void StartOpenAnim() { }

	protected virtual void UpdateDispMain() { }

}


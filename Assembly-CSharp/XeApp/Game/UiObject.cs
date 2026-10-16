namespace XeApp.Game;

public class UiObject
{
	internal enum AnchorPosition
	{
		CENTER_CENTER = 0,
		RIGHT_CENTER = 1,
		LEFT_CENTER = 2,
		CENTER_TOP = 3,
		CENTER_BOTTOM = 4,
		RIGHT_TOP = 5,
		RIGHT_BOTTOM = 6,
		LEFT_BOTTOM = 7,
		LEFT_TOP = 8,
		FIT = 9,
		AUTO = 10,
	}

	private UiLayoutBase m_UiBase; //Field offset: 0x8
	private GameObject m_ObjPrefab; //Field offset: 0xC
	private RawImageEx[] m_RawImageExList; //Field offset: 0x10
	private LayoutUGUIHitOnly[] m_HitOnlyList; //Field offset: 0x14
	private Boolean[] m_RaycastTargetTemp1; //Field offset: 0x18
	private Boolean[] m_RaycastTargetTemp2; //Field offset: 0x1C

	public GameObject ObjPrefab
	{
		 get { } //Length: 11
	}

	public UiLayoutBase UiBase
	{
		 get { } //Length: 11
	}

	public UiObject() { }

	public bool ChkInitLayout() { }

	private void CommonConstructor(Transform parent, bool raycast, AnchorPosition anchor, bool scr_ajust_h, bool scr_ajust_w) { }

	private void CommonRelease() { }

	public static UiObject Create(string path, Transform parent, bool raycast = false, AnchorPosition anchor = 0, bool scr_ajust_h = false, bool scr_ajust_w = false) { }

	public void ForceRelease() { }

	public GameObject get_ObjPrefab() { }

	public UiLayoutBase get_UiBase() { }

	public AbsoluteLayout GetAbsoluteLayer(string exid, string parent_exid = null) { }

	public bool GetActive() { }

	public UiButtonBase GetButton(string btn_name) { }

	private void GetRawImageList() { }

	public Text GetText(int text_no) { }

	public RawImageEx GetTextureFromRawImageList(string name) { }

	public void SetActive(bool active) { }

	public void SetAddView(UiObject child, string exid, string parent_exid = null) { }

	public void SetAllButtonCallbackOnClick(Action<UiButtonBase> cb_click) { }

	public void SetAnimStart(string name) { }

	public void SetButtonCallback(UiButtonBase button, string tag, Action<String> cb_down, Action<String> cb_up = null, Func<String, Boolean> cb_enable = null, Func<String, Boolean> cb_next = null, float next_rag = -1) { }

	public void SetButtonCallbackLongTap(UiButtonBase button, string tag, float sec, Action<String, Single, Boolean> cb_update = null, Action<String, Single, Boolean> cb_up = null, Action<String, Single> cb_comp = null) { }

	public void SetButtonCallbackOnClick(UiButtonBase button, Action cb_click, Func<Boolean> cb_enable = null, Func<Boolean> cb_next = null) { }

	public void SetCallbackUpdate(Action<UiLayoutBase> cb_update) { }

	public void SetCanvas(Canvas canvas) { }

	public void SetCanvas(int canvas_id = -1) { }

	public void SetParent(Transform parent) { }

	public void SetRelease() { }

	public void SetRemoveView(UiObject child, string exid, string parent_exid = null) { }

	public void SetText(int text_no, string text_data) { }

	public void SetTextBestFit(int text_no, bool fit, int size_max = 0, int size_min = 0) { }

	public void SetTouchEnable(bool enable) { }

}


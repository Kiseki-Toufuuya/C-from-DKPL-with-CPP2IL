namespace Heqet.FilterDialog;

public class FilterDialogLayer : UiScrollListLayerBase
{
	public FilterDialogPlateDisp m_DispPlate; //Field offset: 0x7C
	private FilterDialogType m_DispPanelType; //Field offset: 0x80
	private eDispType m_PlateType; //Field offset: 0x84
	private eChangeBtnType m_ChangeBtnType; //Field offset: 0x88
	private Action<Object> m_ResultCallBack; //Field offset: 0x8C
	private string m_strPlateTitle; //Field offset: 0x90
	private String[] m_strPlateBtn; //Field offset: 0x94
	private bool m_isMaskTouchClose; //Field offset: 0x98
	private FilterDialogType[] m_ChangeDialogType; //Field offset: 0x9C
	private String[] m_strChangeBtn; //Field offset: 0xA0
	private string m_strSearch; //Field offset: 0xA4
	private string strSearch; //Field offset: 0xA8
	private string m_strInputBoxInfo; //Field offset: 0xAC
	private string m_strInputBoxMessage; //Field offset: 0xB0
	private int m_SortId; //Field offset: 0xB4
	private int m_OrderId; //Field offset: 0xB8
	private ulong m_FilterFlag; //Field offset: 0xC0
	public bool m_bLayerWait; //Field offset: 0xC8
	private bool m_isInitCenter; //Field offset: 0xC9
	private String[] m_backupInputBoxMessage; //Field offset: 0xCC
	private int m_backupTypeId; //Field offset: 0xD0
	private bool m_isPrevInputFlag; //Field offset: 0xD4
	[CompilerGenerated]
	private Action<GameObject> <OnSelectedCallback>k__BackingField; //Field offset: 0xD8

	public virtual bool IS_DISP_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_TOUCH_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual bool IS_UPDATE_BACKGROUND
	{
		 get { } //Length: 3
	}

	public virtual eLayerType LAYER_TYPE
	{
		 get { } //Length: 6
	}

	public Action<GameObject> OnSelectedCallback
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public FilterDialogLayer() { }

	protected virtual bool AccessAfter() { }

	private void ChangeDispType(int type_id, string search = null) { }

	protected virtual UiScrollListPanelBase CreatePanel() { }

	protected void CreateScrollView() { }

	protected virtual bool EndUpdateAfter() { }

	public void ForceHideScrollBar() { }

	public virtual bool get_IS_DISP_BACKGROUND() { }

	public virtual bool get_IS_TOUCH_BACKGROUND() { }

	public virtual bool get_IS_UPDATE_BACKGROUND() { }

	public virtual eLayerType get_LAYER_TYPE() { }

	[CompilerGenerated]
	public Action<GameObject> get_OnSelectedCallback() { }

	private object GetInputResult(eResultType btn_res) { }

	protected virtual void InitAll() { }

	public void InitBaseDisp(FilterDialogType type) { }

	public void InitFilterDialog(FilterDialogType type, Action<Object> result_callback) { }

	private void InitPanelDisp() { }

	protected virtual bool InitResourceWait() { }

	public void InitSubDisp(FilterDialogType type) { }

	protected virtual bool InitUpdateBefore() { }

	protected virtual void LateUpdate(bool is_active) { }

	public void OnSelected(BaseEventData _data) { }

	public void OnSelected(GameObject _obj) { }

	public virtual void OverDeleteLayer() { }

	protected virtual bool ReleaseLayer() { }

	[CompilerGenerated]
	public void set_OnSelectedCallback(Action<GameObject> value) { }

	public void SetFilterFlag(ulong filter) { }

	public void SetInitCenter(bool is_center) { }

	public void SetSearchString(string search_str) { }

	public void SetSortId(int sort, int order) { }

	protected virtual void Update(bool is_active) { }

}


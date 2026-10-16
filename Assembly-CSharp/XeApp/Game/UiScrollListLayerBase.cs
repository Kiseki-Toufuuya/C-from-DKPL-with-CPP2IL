namespace XeApp.Game;

public abstract class UiScrollListLayerBase : LayerBase
{
	protected UiScrollListManager m_view_manager; //Field offset: 0x58
	private Dictionary<Int32, UiScrollListManager> m_view_backup; //Field offset: 0x5C
	protected object m_TapData; //Field offset: 0x60
	protected object m_LongTapData; //Field offset: 0x64
	protected int m_nTapIndex; //Field offset: 0x68
	protected int m_nLongTapIndex; //Field offset: 0x6C
	private int m_nNextViewId; //Field offset: 0x70
	private SET_DATA m_NextViewData; //Field offset: 0x74
	private bool m_bInitSE; //Field offset: 0x78
	private bool m_AddCreatePanelFlag; //Field offset: 0x79
	private bool m_InitAddCreatePanel; //Field offset: 0x7A
	private bool m_IsAutoScrollFlg; //Field offset: 0x7B

	public bool InitAddCreatePanelFlag
	{
		 get { } //Length: 11
	}

	public UiScrollListLayerBase() { }

	public override void ChangeAllPanelSE() { }

	protected override bool ChangeScrollView(int back_id, SET_DATA data) { }

	private void CheckTouchPanel() { }

	protected abstract UiScrollListPanelBase CreatePanel() { }

	protected override bool CreateScrollList(GameObject root) { }

	protected override bool CreateScrollPanel(int back_id, SET_DATA data, GameObject root = null) { }

	protected override bool CreateScrollView(SET_DATA data) { }

	protected override UiScrollListPanelBase CreateSubLayerPanel(Transform parent) { }

	protected void EndAutoScroll() { }

	protected void ForceEnableScroll(bool enable) { }

	public bool get_InitAddCreatePanelFlag() { }

	public override object GetDispData(int index) { }

	public int GetNowScrollLeftTopIndex() { }

	protected UiScrollListPanelBase GetPanel(int local_index) { }

	protected UiScrollListPanelBase GetPanelByDispIndex(int index) { }

	protected int GetPanelListCount() { }

	protected object GetPanelLongTapData() { }

	protected int GetPanelLongTapIndex() { }

	protected object GetPanelTapData() { }

	protected int GetPanelTapIndex() { }

	public float GetScrollBarPosition() { }

	public void HideAllPanel() { }

	protected bool IsAutoScrollFlg() { }

	protected bool IsInitialize() { }

	public override bool IsLoadEnableFlag(int index) { }

	protected override bool IsPanelDataLoaded() { }

	protected bool IsPanelLongTap() { }

	protected bool IsPanelTap() { }

	public bool IsPanelTouchEnable() { }

	public bool IsTouchEnable() { }

	protected virtual void LateUpdate(bool is_active) { }

	public override void LongTapPanelAction(int index, int btn_id) { }

	protected virtual void OnSetTouch(bool enable) { }

	protected void RefreshPanelDisp() { }

	protected override void ReleaseAllPanel() { }

	protected virtual bool ReleaseLayer() { }

	private void ReleaseUiScrollList() { }

	private void ReleaseViewManagerPanel(UiScrollListManager view_manager) { }

	public override void ResetChangePanelSeFlag() { }

	protected void ResetContetsNum(int content_num) { }

	protected override void ResetScrollListBaseContentsNum() { }

	protected void SetAutoScrollEndEventListner(Action<Int32> a_event) { }

	public override void SetLoadRequest(int index) { }

	public void SetPanelNoneButtonAnimation() { }

	protected void SetScrollTouch(bool enable) { }

	public void SetSnapSpeed(float speed, float sp_rate = -1, float sp_max = -1) { }

	public void ShowAllPanel() { }

	protected void StartAutoScrollByIndex(int index, float speed = 1) { }

	protected void StartAutoScrollByIndexOutofBounds(int index, float speed = 1, int column_num = -1) { }

	public override void TapPanelAction(int index, int btn_id) { }

	public override bool TapPanelEnableAction(int index, int btn_id) { }

	protected virtual void Update(bool is_active) { }

}


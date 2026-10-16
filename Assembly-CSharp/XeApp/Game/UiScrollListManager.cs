namespace XeApp.Game;

public class UiScrollListManager
{
	private RectTransform m_areaTransform; //Field offset: 0x8
	private ScrollRect m_areaScrollRect; //Field offset: 0xC
	private CanvasGroup m_canvasGroup; //Field offset: 0x10
	private bool m_bScrollAreaAdjust; //Field offset: 0x14
	private SET_DATA m_data; //Field offset: 0x18
	private UiScrollList m_view; //Field offset: 0x1C
	private UiScrollListParameter m_ScrollParameter; //Field offset: 0x20
	private bool m_isTouch; //Field offset: 0x24
	private EventSystem m_areaEvent; //Field offset: 0x28
	private int m_nDefaultDragThreshold; //Field offset: 0x2C
	private bool m_bSettingDragThreshold; //Field offset: 0x30

	public UiScrollListManager(SET_DATA data) { }

	public void AddPanel(UiScrollListPanelBase panel) { }

	public int CulcScrollStartIndex() { }

	public void EnablePanelAll(bool enable) { }

	protected void EnableScrollEvent(bool enable) { }

	public void EndAutoScroll() { }

	public void ForceEnableScroll(bool enable) { }

	public void ForceHideScrollBar() { }

	public int GetDispCount() { }

	public int GetDisplayPanelNum() { }

	public int GetNowScrollLeftTopIndex() { }

	public int GetOneLineNum() { }

	public UiScrollListPanelBase GetPanel(int index) { }

	public UiScrollListPanelBase GetPanelByDispIndex(int disp_index) { }

	public int GetPanelListCount() { }

	public float GetScrollBarPosition() { }

	public float GetScrollBarPositionRate(int index) { }

	public float GetScrollPanelSize() { }

	public ScrollRect GetScrollRect() { }

	public Transform GetScrollViewContent() { }

	public RectTransform GetScrollViewContentRectTransform() { }

	public float GetViewPortHeight() { }

	public float GetViewPortWidth() { }

	public void InitScrollList() { }

	public bool is_created() { }

	public bool IsControll() { }

	public bool IsLoadWait() { }

	public bool isPanelFullyVisible(int index) { }

	public bool IsPanelTouchEnable() { }

	public bool IsScrollBar() { }

	public bool IsSubPanelInitalized() { }

	public bool IsTouchEnable() { }

	public bool IsVerticalScrollBar() { }

	public void RefreshPanelDisp() { }

	public void Release() { }

	private void ReleaseList() { }

	public void ReleaseStopUpdate() { }

	public void ResetContetsNum(int content_num) { }

	public void ResetContetsNumJustNow(int content_num) { }

	public void ResetDragThreshold() { }

	public void RootObjectSettting(GameObject root) { }

	public void SetAutoScrollEndEventListner(Action<Int32> a_event) { }

	public void SetAutoScrollIndex(int index = -1, float speed = 1) { }

	public void SetDragThreshold(int hold_rate) { }

	public void SetLoadEnd() { }

	public void SetPanelNoneButtonAnimation() { }

	public void SetScrollBarPosition(float rate) { }

	public void SetScrollBarPositionIndex(int index) { }

	public void SetScrollTouch(bool enable) { }

	public void SetSnapSpeed(float speed, float sp_rate = -1, float sp_max = -1) { }

	public void StopUpdate() { }

	public void UpDate() { }

}


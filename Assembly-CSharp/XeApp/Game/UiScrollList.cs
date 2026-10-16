namespace XeApp.Game;

public class UiScrollList
{
	internal enum InitType
	{
		Index = 0,
		ScrollBar = 1,
	}

	internal enum ScrollAddType
	{
		Add_None = 0,
		Add_Prev = 1,
		Add_Next = 2,
	}

	internal enum ScrollType
	{
		Scroll_V = 0,
		Scroll_H = 1,
	}

	internal class SET_DATA
	{
		public int index_top; //Field offset: 0x8
		public int content_num; //Field offset: 0xC
		private int top_min; //Field offset: 0x10
		private int bottom_max; //Field offset: 0x14
		public ScrollType type; //Field offset: 0x18
		public InitType init_type; //Field offset: 0x1C
		public int start_index; //Field offset: 0x20
		public float start_scroll_bar_pos; //Field offset: 0x24
		public int one_line_num; //Field offset: 0x28
		public int column_max_num; //Field offset: 0x2C
		public bool screen_adjust; //Field offset: 0x30
		public bool one_panel_scroll; //Field offset: 0x31
		public bool use_sublayer_panel; //Field offset: 0x32
		public bool use_snap_scroll; //Field offset: 0x33
		public bool is_bottom_front; //Field offset: 0x34
		public bool is_bar_non_resize; //Field offset: 0x35
		public bool is_sub_create_panel; //Field offset: 0x36
		public bool is_no_margin; //Field offset: 0x37
		private Func<ScrollAddType, Boolean> callback_add_panel; //Field offset: 0x38

		public Func<ScrollAddType, Boolean> CallbackAddPanel
		{
			 get { } //Length: 11
		}

		public int ListMaxID
		{
			 get { } //Length: 11
		}

		public int ListMinID
		{
			 get { } //Length: 11
		}

		public SET_DATA() { }

		public Func<ScrollAddType, Boolean> get_CallbackAddPanel() { }

		public int get_ListMaxID() { }

		public int get_ListMinID() { }

		public void SetAddPanelParam(int min, int max, Func<ScrollAddType, Boolean> update_check = null) { }

	}

	private enum State
	{
		Init = 0,
		InitWait = 1,
		Main = 2,
		AddPanel = 3,
		RefreshAll = 4,
		ResetContetNum = 5,
		StopUpdate = 6,
		End = 7,
	}

	private State m_State; //Field offset: 0x8
	private readonly float m_fScrollDefaultRate; //Field offset: 0xC
	private readonly int m_nPanelMarginNum; //Field offset: 0x10
	private readonly float m_fPanelNoActivePos; //Field offset: 0x14
	private readonly float m_fScrollDefaultMaxSpeed; //Field offset: 0x18
	private List<UiScrollListPanelBase> m_panelList; //Field offset: 0x1C
	private ScrollRect m_scrollRect; //Field offset: 0x20
	private UiScrollListParameter m_scrollParameter; //Field offset: 0x24
	private int m_nListTop; //Field offset: 0x28
	private int m_nListBottom; //Field offset: 0x2C
	private int m_nListMin; //Field offset: 0x30
	private int m_nListMax; //Field offset: 0x34
	private int m_nContentsInitNum; //Field offset: 0x38
	private int m_nContentsMax; //Field offset: 0x3C
	private Vector2 m_sizePanel; //Field offset: 0x40
	private Vector2 m_scalePanel; //Field offset: 0x48
	private float m_fFullAreaSize; //Field offset: 0x50
	private float m_fDispAreaSize; //Field offset: 0x54
	private int m_nDispPanelCount; //Field offset: 0x58
	private ScrollType m_eScrollType; //Field offset: 0x5C
	private InitType m_eInitType; //Field offset: 0x60
	private int m_initIndex; //Field offset: 0x64
	private float m_initScrollPos; //Field offset: 0x68
	private float m_safeScale; //Field offset: 0x6C
	private Vector2 m_marginTop; //Field offset: 0x70
	private Vector2 m_marginInterval; //Field offset: 0x78
	private Vector2 m_marginBottom; //Field offset: 0x80
	private int m_nOneListNum; //Field offset: 0x88
	private bool m_NoIntervalMargine; //Field offset: 0x8C
	private bool m_bAutoScroll; //Field offset: 0x8D
	private float m_fAutoScrollTime; //Field offset: 0x90
	private float m_fAutoScrollSpeed; //Field offset: 0x94
	private bool m_bAutoScrollTarget; //Field offset: 0x98
	private float m_fAutoScrollTargetPos; //Field offset: 0x9C
	private float m_fAutoScrollSpeedRate; //Field offset: 0xA0
	private float m_fAutoScrollMaxSpeed; //Field offset: 0xA4
	private ScrollAddType m_eScrollAddType; //Field offset: 0xA8
	private int m_prevStartIndex; //Field offset: 0xAC
	private bool m_bLoaded; //Field offset: 0xB0
	private List<UInt32> m_posPanelList; //Field offset: 0xB4
	private List<UInt32> m_sizePanelList; //Field offset: 0xB8
	private uint m_posPanelEnd; //Field offset: 0xBC
	private uint m_sizeSmallPanel; //Field offset: 0xC0
	private bool m_bScrollChangeBan; //Field offset: 0xC4
	private bool m_bOnePanel; //Field offset: 0xC5
	private bool m_bCreateSubLayerPanel; //Field offset: 0xC6
	private bool m_bSnapScroll; //Field offset: 0xC7
	private bool m_bSubAddCreatePanel; //Field offset: 0xC8
	private bool m_bScrollTouchEnable; //Field offset: 0xC9
	private bool m_bSnap; //Field offset: 0xCA
	private float m_fSnapRate; //Field offset: 0xCC
	private float m_fSnapSpeed; //Field offset: 0xD0
	private float m_fSnapMaxSpeed; //Field offset: 0xD4
	private Action<Int32> m_AutoScrollFinishEventListner; //Field offset: 0xD8
	private bool m_bBottomFrontFlag; //Field offset: 0xDC
	private bool m_bScrollBarNonResizeFlag; //Field offset: 0xDD
	private Func<ScrollAddType, Boolean> m_CallbackAddPanelCheck; //Field offset: 0xE0
	private List<Tuple`2<Int32, Int32>> m_SetDataActiveList; //Field offset: 0xE4

	public UiScrollList(SET_DATA data) { }

	private void add_panel() { }

	public void AddPanel(UiScrollListPanelBase panel) { }

	private void AddScrollRect(ScrollAddType add_type) { }

	private void AdjustScrollArea(RectTransform target_rect) { }

	private void CheckAddPanel() { }

	private void CheckDrag() { }

	private void CreateSizeList() { }

	public int CulcScrollStartIndex() { }

	public void EnablePanelAll(bool enable) { }

	public void EnableScrollBan(bool enable) { }

	public void EnableScrollBar(bool enable) { }

	public void EnableScrollRect(bool enable) { }

	public void EndAutoScroll() { }

	public void ForceStopScroll(bool is_adjust = false, ScrollAddType type = 0) { }

	private RectTransform GetContentRectTransform() { }

	public int GetDisplayPanelNum() { }

	public float GetFullPanelAreaEndPosition() { }

	public float GetFullPanelAreaPanelOnlyPosition() { }

	public float GetFullSizeOffset() { }

	private float GetListFullSize(int num) { }

	public int GetListIndexMax() { }

	public int GetNowScrollLeftTopIndex() { }

	public int GetOneLineNum() { }

	public UiScrollListPanelBase GetPanel(int index) { }

	public UiScrollListPanelBase GetPanelByDispIndex(int disp_index) { }

	public int GetPanelCount() { }

	private int GetPanelDispIndex(int index) { }

	public int GetPanelListCount() { }

	public float GetScrollBarMaxPosition() { }

	public float GetScrollBarMinPosition() { }

	public float GetScrollBarPosition() { }

	public int GetScrollBarPositionIndex(float pos_rate) { }

	public float GetScrollBarPositionRate(int index) { }

	public float GetScrollPanelSize() { }

	public float GetScrollPanelSmallSize() { }

	private void init() { }

	public void InitList() { }

	private void InitMargin() { }

	private void InitPanelSize() { }

	private void InitRectTransfromSetting() { }

	private void InitScrollAutoResizeOption(bool active) { }

	private void initScrollFitFilterSetting() { }

	private void InitScrollLayoutGroupSetting() { }

	private void InitScrollPossibleCheck() { }

	private void InitScrollUsedPanel() { }

	private bool initWait() { }

	public bool IsActive() { }

	public bool IsAddPanelLoadWait() { }

	public bool IsAutoScroll() { }

	public bool IsControll() { }

	public bool IsCreated() { }

	public bool isPanelFullyVisible(int index) { }

	public bool IsPanelTouchEnable() { }

	public bool IsScrollBar() { }

	public bool IsVerticalScrollBar() { }

	private bool main() { }

	private void refresh_all() { }

	private void RefreshPanelAll() { }

	public void RefreshPanelDisp() { }

	private void RefreshPanelDispByIndex(int index, int disp_index) { }

	private void RefreshScrollRect() { }

	public void Release() { }

	private void ReleaseList() { }

	public void ReleaseStopUpdate() { }

	public void ResetContetsNum(int content_num) { }

	public void ResetContetsNumJustNow(int content_num) { }

	private void ResetScrollBarResizeOption() { }

	public void SetAcutoScrollEndEventListner(Action<Int32> a_event) { }

	public void SetAdjustScreen(RectTransform parent, bool adjust) { }

	private void SetContentsNum(int content_num) { }

	public void SetLoadEnd() { }

	private void SetPanelContents(RectTransform contents) { }

	public void SetPanelNoneButtonAnimation() { }

	public void SetScrollBarPosition(float rate) { }

	public void SetScrollParameter(UiScrollListParameter parameter) { }

	public void SetScrollRect(ScrollRect rect) { }

	public void SetSnapSpeed(float speed, float rate = -1, float speed_max = -1) { }

	public void StartAutoScroll(int index, float speed = 1) { }

	public void StopUpdate() { }

	public bool UpDate() { }

	private void UpdateAutoScroll() { }

	private void UpdateScrollList() { }

	private void UpdateSnapScroll() { }

}


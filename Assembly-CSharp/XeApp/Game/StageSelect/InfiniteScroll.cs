namespace XeApp.Game.StageSelect;

[DefaultExecutionOrder(99999)]
public class InfiniteScroll : UIBehaviour
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<PanelCache, Single> <>9__96_0; //Field offset: 0x4
		public static Comparison<PanelCache> <>9__105_0; //Field offset: 0x8
		public static Comparison<PanelCache> <>9__105_1; //Field offset: 0xC
		public static Func<PanelCache, Single> <>9__110_0; //Field offset: 0x10

		private static <>c() { }

		public <>c() { }

		internal float <AllUpdateItem>b__96_0(PanelCache panel) { }

		internal int <HidePanelRelocation>b__105_0(PanelCache a, PanelCache b) { }

		internal int <HidePanelRelocation>b__105_1(PanelCache a, PanelCache b) { }

		internal float <SlidePanel>b__110_0(PanelCache panelCache) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass94_0
	{
		public string name; //Field offset: 0x8

		public <>c__DisplayClass94_0() { }

		internal bool <Update>b__0(PanelCache panel) { }

	}

	private enum eReserveState
	{
		None = 0,
		DragEndReserve = 1,
		SwipeReserve = 2,
		AppointAutoScrollReserve = 3,
	}

	private enum eScrollState
	{
		None = 0,
		DragEndStart = 1,
		AppointAutoScrollStart = 2,
		AutoScrollStart = 3,
		SwipeStart = 4,
		AppointAutoScroll = 5,
		AutoScroll = 6,
		Swipe = 7,
		OpenAnimStart = 8,
		OpenAnimCompWait = 9,
		OpenAnimComp = 10,
		Open = 11,
		CloseAnimStart = 12,
		CloseAnimCompWait = 13,
		CloseAnimComp = 14,
	}

	internal enum eTouchState
	{
		None = 0,
		PointDown = 1,
		PointUp = 2,
		Drag = 3,
		DragEnd = 4,
	}

	private readonly float SWIPE_SMALL_FIRST_VELOCITY; //Field offset: 0x10
	private readonly float SWIPE_SMALL_ATTENUATION; //Field offset: 0x14
	private readonly float SWIPE_BIG_FIRST_VELOCITY; //Field offset: 0x18
	private readonly float SWIPE_BIG_ATTENUATION; //Field offset: 0x1C
	private readonly float SWAIP_BIG_POSITION_RATE; //Field offset: 0x20
	private readonly float SWAIP_SMALL_POSITION_RATE; //Field offset: 0x24
	private readonly int SHIFT_TOP_Y_PANEL_NUM; //Field offset: 0x28
	private readonly float LIMIT_AUTO_SCROLL_MOVE_DISTANCE; //Field offset: 0x2C
	private readonly float APPOINT_AUTO_SCROLL_TIME; //Field offset: 0x30
	[SerializeField]
	private float SNAP_OFFSET; //Field offset: 0x34
	private readonly float AUTO_SCROLL_MOVE_DISTANCE_RATE; //Field offset: 0x38
	private readonly float ADJUST_POSITION; //Field offset: 0x3C
	private readonly float ANDER_ALPHA; //Field offset: 0x40
	[SerializeField]
	private float PANEL_ANGLE; //Field offset: 0x44
	public eTouchState m_TouchState; //Field offset: 0x48
	private eScrollState m_ScrollState; //Field offset: 0x4C
	private eReserveState m_ReserveState; //Field offset: 0x50
	private eScrollState m_EndNextScrollSate; //Field offset: 0x54
	[SerializeField]
	private ScrollRectEx m_ScrollRectEx; //Field offset: 0x58
	[SerializeField]
	private RectTransform m_TopAlpha; //Field offset: 0x5C
	private float m_TopAlphaY; //Field offset: 0x60
	private float m_TopAlphaSizeY; //Field offset: 0x64
	[SerializeField]
	private RectTransform m_EndAlpha; //Field offset: 0x68
	private float m_EndAlphaY; //Field offset: 0x6C
	private float m_EndAlphaSizeY; //Field offset: 0x70
	[SerializeField]
	private RectTransform snapTarget; //Field offset: 0x74
	[SerializeField]
	private RectTransform centerTarget; //Field offset: 0x78
	private int m_PanelCount; //Field offset: 0x7C
	private float m_PanelSize; //Field offset: 0x80
	private PanelCache m_CenterPanel; //Field offset: 0x84
	private PanelCache m_BeforeCenterPanel; //Field offset: 0x88
	private bool m_Init; //Field offset: 0x8C
	private List<PanelCache> m_PanelList; //Field offset: 0x90
	private List<PanelCache> m_HidePanelList; //Field offset: 0x94
	private float m_AutoScrollDistance; //Field offset: 0x98
	private float m_AutoScrollAddMoveDistance; //Field offset: 0x9C
	private bool m_IsAutoScrollMoveUp; //Field offset: 0xA0
	private float m_SwipeVelocity; //Field offset: 0xA4
	private float m_SwipeDownRate; //Field offset: 0xA8
	private bool m_IsCenterOpenFlg; //Field offset: 0xAC
	private int m_GoToIndex; //Field offset: 0xB0
	private PositionType m_UsePositionType; //Field offset: 0xB4
	private bool m_IsPanelOpenDrag; //Field offset: 0xB8
	private bool IsSwipeMoveUp; //Field offset: 0xB9
	private bool IsDragMoveUp; //Field offset: 0xBA
	private bool IsSwipeTypeSmall; //Field offset: 0xBB
	private int m_ReserveAutoScrollMoveNum; //Field offset: 0xBC
	private bool IsReserveAutoScrollMoveUp; //Field offset: 0xC0
	private float m_AddScrollPosY; //Field offset: 0xC4
	private int m_ScrollListNum; //Field offset: 0xC8
	private bool m_ScrollEnable; //Field offset: 0xCC
	private Action<Int32> m_OnCenterChangeCallBack; //Field offset: 0xD0
	private Action<Int32> m_OnPanelChangeCallBack; //Field offset: 0xD4
	private Action m_OnPanelScrollSeCallBack; //Field offset: 0xD8
	private Action m_OnOpenCenterAnimationCallBack; //Field offset: 0xDC
	private Action m_OnCenterMusicAnimationCompleteCallBack; //Field offset: 0xE0
	private Action m_OnCloseCenterAnimationCallBack; //Field offset: 0xE4
	private Func<Boolean> m_OnIsPlayCenterOpenAnimationCallBack; //Field offset: 0xE8
	private Func<Boolean> m_OnIsPlayCenterCloseAnimationCallBack; //Field offset: 0xEC

	public RectTransform CenterTargetRect
	{
		 get { } //Length: 11
	}

	public Action<Int32> OnCenterChangeCallBack
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public Action OnCenterMusicAnimationCompleteCallBack
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public Action OnCloseCenterAnimationCallBack
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public Func<Boolean> OnIsPlayCenterCloseAnimationCallBack
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public Func<Boolean> OnIsPlayCenterOpenAnimationCallBack
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public Action OnOpenCenterAnimationCallBack
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public Action<Int32> OnPanelChangeCallBack
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public Action OnPanelScrollSeCallBack
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public bool ScrollEnable
	{
		 get { } //Length: 14
		 set { } //Length: 17
	}

	public RectTransform SnapTargetRect
	{
		 get { } //Length: 11
	}

	public InfiniteScroll() { }

	[CompilerGenerated]
	private bool <SlidePanel>b__110_1(PanelCache panel) { }

	public void AllUpdateItem(int selectMusicIndex, int scrollListNum, bool IsInit = false) { }

	private void AnglePanel(bool isMoveUp) { }

	private void AnglePanelToCopy() { }

	private bool AppointAutoScroll() { }

	private bool AutoScroll() { }

	public void AutoScrollByMoveNum(int moveNum, bool isMoveUp) { }

	protected virtual void Awake() { }

	private void CancelReserveState() { }

	private void CopyPositionReflectToPanel(PositionType type) { }

	private PanelCache CreatePanelCache(float scrollTopY, int index, ShortMusicPanelDisp disp) { }

	private void DeepCopyPanelPosition() { }

	private void ForceOpen() { }

	public RectTransform get_CenterTargetRect() { }

	public Action<Int32> get_OnCenterChangeCallBack() { }

	public Action get_OnCenterMusicAnimationCompleteCallBack() { }

	public Action get_OnCloseCenterAnimationCallBack() { }

	public Func<Boolean> get_OnIsPlayCenterCloseAnimationCallBack() { }

	public Func<Boolean> get_OnIsPlayCenterOpenAnimationCallBack() { }

	public Action get_OnOpenCenterAnimationCallBack() { }

	public Action<Int32> get_OnPanelChangeCallBack() { }

	public Action get_OnPanelScrollSeCallBack() { }

	public bool get_ScrollEnable() { }

	public RectTransform get_SnapTargetRect() { }

	private float GetAppointAutoScrollMoveDistance() { }

	private float GetAutoScrollMoveDistance() { }

	public ShortMusicPanelDisp GetBeforeCenterPanelDisp() { }

	public ShortMusicPanelDisp GetCenterPanelDisp() { }

	private float GetDiffValue(float originValue, float targetValue) { }

	private eScrollState GetEndNextScrollState() { }

	private int GetPaneIndex(int selectIndex) { }

	private float GetPanelCenterYPosition() { }

	private int GetPanelIndex(int index) { }

	private float GetSnapTargetDistance(PanelCache panel) { }

	private void HidePanelRelocation(bool isMoveUp) { }

	public void Initialize(List<ShortMusicPanelDisp> panelList) { }

	private void InitOpen() { }

	private bool IsAppointAutoScroll() { }

	private bool IsAutoScroll() { }

	private bool IsCenterOpen() { }

	private bool IsForceOpen() { }

	private bool IsMoveUp(float posY) { }

	private bool IsOpenAnim() { }

	private bool IsOpenCloseAnim() { }

	private bool IsReserveDragEnd() { }

	private bool IsReserveStateNone() { }

	private bool IsReserveSwipe() { }

	public bool IsScroll() { }

	private bool IsScrollNone() { }

	private bool IsSwipe() { }

	private bool IsSwipe(float avgPosY) { }

	private bool IsSwipeSmall(float avgPosY) { }

	private bool IsTouchEnable() { }

	private float ScrollEndY() { }

	private float ScrollSize() { }

	private float ScrollTopY() { }

	public void set_OnCenterChangeCallBack(Action<Int32> value) { }

	public void set_OnCenterMusicAnimationCompleteCallBack(Action value) { }

	public void set_OnCloseCenterAnimationCallBack(Action value) { }

	public void set_OnIsPlayCenterCloseAnimationCallBack(Func<Boolean> value) { }

	public void set_OnIsPlayCenterOpenAnimationCallBack(Func<Boolean> value) { }

	public void set_OnOpenCenterAnimationCallBack(Action value) { }

	public void set_OnPanelChangeCallBack(Action<Int32> value) { }

	public void set_OnPanelScrollSeCallBack(Action value) { }

	public void set_ScrollEnable(bool value) { }

	private void SetEndNextScrollState(eScrollState next) { }

	private void SetPanelAhpa(PanelCache panel, bool isCopy = false) { }

	private void SlidePanel() { }

	private void SnapPanel() { }

	private bool Swipe() { }

	public void Update() { }

	private void UpdatePosition(float posY, PositionType type = 0) { }

	private void WhenOpenResetState() { }

}


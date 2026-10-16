namespace UnityEngine.UI;

[AddComponentMenu("UI/Scroll Rect", 37)]
[DisallowMultipleComponent]
[ExecuteAlways]
[RequireComponent(typeof(RectTransform))]
[SelectionBase]
public class ScrollRect : UIBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IScrollHandler, ICanvasElement, ILayoutElement, ILayoutGroup, ILayoutController
{
	internal enum MovementType
	{
		Unrestricted = 0,
		Elastic = 1,
		Clamped = 2,
	}

	internal enum ScrollbarVisibility
	{
		Permanent = 0,
		AutoHide = 1,
		AutoHideAndExpandViewport = 2,
	}

	internal class ScrollRectEvent : UnityEvent<Vector2>
	{

		public ScrollRectEvent() { }

	}

	[SerializeField]
	private RectTransform m_Content; //Field offset: 0x10
	[SerializeField]
	private bool m_Horizontal; //Field offset: 0x14
	[SerializeField]
	private bool m_Vertical; //Field offset: 0x15
	[SerializeField]
	private MovementType m_MovementType; //Field offset: 0x18
	[SerializeField]
	private float m_Elasticity; //Field offset: 0x1C
	[SerializeField]
	private bool m_Inertia; //Field offset: 0x20
	[SerializeField]
	private float m_DecelerationRate; //Field offset: 0x24
	[SerializeField]
	private float m_ScrollSensitivity; //Field offset: 0x28
	[SerializeField]
	private RectTransform m_Viewport; //Field offset: 0x2C
	[SerializeField]
	private Scrollbar m_HorizontalScrollbar; //Field offset: 0x30
	[SerializeField]
	private Scrollbar m_VerticalScrollbar; //Field offset: 0x34
	[SerializeField]
	private ScrollbarVisibility m_HorizontalScrollbarVisibility; //Field offset: 0x38
	[SerializeField]
	private ScrollbarVisibility m_VerticalScrollbarVisibility; //Field offset: 0x3C
	[SerializeField]
	private float m_HorizontalScrollbarSpacing; //Field offset: 0x40
	[SerializeField]
	private float m_VerticalScrollbarSpacing; //Field offset: 0x44
	[SerializeField]
	private ScrollRectEvent m_OnValueChanged; //Field offset: 0x48
	private Vector2 m_PointerStartLocalCursor; //Field offset: 0x4C
	protected Vector2 m_ContentStartPosition; //Field offset: 0x54
	private RectTransform m_ViewRect; //Field offset: 0x5C
	protected Bounds m_ContentBounds; //Field offset: 0x60
	private Bounds m_ViewBounds; //Field offset: 0x78
	private Vector2 m_Velocity; //Field offset: 0x90
	private bool m_Dragging; //Field offset: 0x98
	private bool m_Scrolling; //Field offset: 0x99
	private Vector2 m_PrevPosition; //Field offset: 0x9C
	private Bounds m_PrevContentBounds; //Field offset: 0xA4
	private Bounds m_PrevViewBounds; //Field offset: 0xBC
	private bool m_HasRebuiltLayout; //Field offset: 0xD4
	private bool m_HSliderExpand; //Field offset: 0xD5
	private bool m_VSliderExpand; //Field offset: 0xD6
	private float m_HSliderHeight; //Field offset: 0xD8
	private float m_VSliderWidth; //Field offset: 0xDC
	private RectTransform m_Rect; //Field offset: 0xE0
	private RectTransform m_HorizontalScrollbarRect; //Field offset: 0xE4
	private RectTransform m_VerticalScrollbarRect; //Field offset: 0xE8
	private DrivenRectTransformTracker m_Tracker; //Field offset: 0xEC
	private readonly Vector3[] m_Corners; //Field offset: 0xF0

	public RectTransform content
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public float decelerationRate
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public float elasticity
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public override float flexibleHeight
	{
		 get { } //Length: 7
	}

	public override float flexibleWidth
	{
		 get { } //Length: 7
	}

	public bool horizontal
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public float horizontalNormalizedPosition
	{
		 get { } //Length: 465
		 set { } //Length: 40
	}

	public Scrollbar horizontalScrollbar
	{
		 get { } //Length: 11
		 set { } //Length: 336
	}

	public float horizontalScrollbarSpacing
	{
		 get { } //Length: 11
		 set { } //Length: 29
	}

	public ScrollbarVisibility horizontalScrollbarVisibility
	{
		 get { } //Length: 11
		 set { } //Length: 25
	}

	private bool hScrollingNeeded
	{
		private get { } //Length: 145
	}

	public bool inertia
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public override int layoutPriority
	{
		 get { } //Length: 4
	}

	public override float minHeight
	{
		 get { } //Length: 7
	}

	public override float minWidth
	{
		 get { } //Length: 7
	}

	public MovementType movementType
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Vector2 normalizedPosition
	{
		 get { } //Length: 45
		 set { } //Length: 76
	}

	public ScrollRectEvent onValueChanged
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public override float preferredHeight
	{
		 get { } //Length: 7
	}

	public override float preferredWidth
	{
		 get { } //Length: 7
	}

	private RectTransform rectTransform
	{
		private get { } //Length: 134
	}

	public float scrollSensitivity
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public Vector2 velocity
	{
		 get { } //Length: 45
		 set { } //Length: 26
	}

	public bool vertical
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public float verticalNormalizedPosition
	{
		 get { } //Length: 465
		 set { } //Length: 40
	}

	public Scrollbar verticalScrollbar
	{
		 get { } //Length: 11
		 set { } //Length: 336
	}

	public float verticalScrollbarSpacing
	{
		 get { } //Length: 11
		 set { } //Length: 29
	}

	public ScrollbarVisibility verticalScrollbarVisibility
	{
		 get { } //Length: 11
		 set { } //Length: 25
	}

	public RectTransform viewport
	{
		 get { } //Length: 11
		 set { } //Length: 37
	}

	protected RectTransform viewRect
	{
		 get { } //Length: 247
	}

	private bool vScrollingNeeded
	{
		private get { } //Length: 145
	}

	protected ScrollRect() { }

	internal static void AdjustBounds(ref Bounds viewBounds, ref Vector2 contentPivot, ref Vector3 contentSize, ref Vector3 contentPos) { }

	public override void CalculateLayoutInputHorizontal() { }

	public override void CalculateLayoutInputVertical() { }

	private Vector2 CalculateOffset(Vector2 delta) { }

	private void EnsureLayoutHasRebuilt() { }

	public RectTransform get_content() { }

	public float get_decelerationRate() { }

	public float get_elasticity() { }

	public override float get_flexibleHeight() { }

	public override float get_flexibleWidth() { }

	public bool get_horizontal() { }

	public float get_horizontalNormalizedPosition() { }

	public Scrollbar get_horizontalScrollbar() { }

	public float get_horizontalScrollbarSpacing() { }

	public ScrollbarVisibility get_horizontalScrollbarVisibility() { }

	private bool get_hScrollingNeeded() { }

	public bool get_inertia() { }

	public override int get_layoutPriority() { }

	public override float get_minHeight() { }

	public override float get_minWidth() { }

	public MovementType get_movementType() { }

	public Vector2 get_normalizedPosition() { }

	public ScrollRectEvent get_onValueChanged() { }

	public override float get_preferredHeight() { }

	public override float get_preferredWidth() { }

	private RectTransform get_rectTransform() { }

	public float get_scrollSensitivity() { }

	public Vector2 get_velocity() { }

	public bool get_vertical() { }

	public float get_verticalNormalizedPosition() { }

	public Scrollbar get_verticalScrollbar() { }

	public float get_verticalScrollbarSpacing() { }

	public ScrollbarVisibility get_verticalScrollbarVisibility() { }

	public RectTransform get_viewport() { }

	protected RectTransform get_viewRect() { }

	private bool get_vScrollingNeeded() { }

	private Bounds GetBounds() { }

	public override void GraphicUpdateComplete() { }

	internal static Vector2 InternalCalculateOffset(ref Bounds viewBounds, ref Bounds contentBounds, bool horizontal, bool vertical, MovementType movementType, ref Vector2 delta) { }

	internal static Bounds InternalGetBounds(Vector3[] corners, ref Matrix4x4 viewWorldToLocalMatrix) { }

	public virtual bool IsActive() { }

	protected override void LateUpdate() { }

	public override void LayoutComplete() { }

	public override void OnBeginDrag(PointerEventData eventData) { }

	protected virtual void OnDisable() { }

	public override void OnDrag(PointerEventData eventData) { }

	protected virtual void OnEnable() { }

	public override void OnEndDrag(PointerEventData eventData) { }

	public override void OnInitializePotentialDrag(PointerEventData eventData) { }

	protected virtual void OnRectTransformDimensionsChange() { }

	public override void OnScroll(PointerEventData data) { }

	public override void Rebuild(CanvasUpdate executing) { }

	private static float RubberDelta(float overStretching, float viewSize) { }

	public void set_content(RectTransform value) { }

	public void set_decelerationRate(float value) { }

	public void set_elasticity(float value) { }

	public void set_horizontal(bool value) { }

	public void set_horizontalNormalizedPosition(float value) { }

	public void set_horizontalScrollbar(Scrollbar value) { }

	public void set_horizontalScrollbarSpacing(float value) { }

	public void set_horizontalScrollbarVisibility(ScrollbarVisibility value) { }

	public void set_inertia(bool value) { }

	public void set_movementType(MovementType value) { }

	public void set_normalizedPosition(Vector2 value) { }

	public void set_onValueChanged(ScrollRectEvent value) { }

	public void set_scrollSensitivity(float value) { }

	public void set_velocity(Vector2 value) { }

	public void set_vertical(bool value) { }

	public void set_verticalNormalizedPosition(float value) { }

	public void set_verticalScrollbar(Scrollbar value) { }

	public void set_verticalScrollbarSpacing(float value) { }

	public void set_verticalScrollbarVisibility(ScrollbarVisibility value) { }

	public void set_viewport(RectTransform value) { }

	protected override void SetContentAnchoredPosition(Vector2 position) { }

	protected void SetDirty() { }

	protected void SetDirtyCaching() { }

	private void SetHorizontalNormalizedPosition(float value) { }

	public override void SetLayoutHorizontal() { }

	public override void SetLayoutVertical() { }

	protected override void SetNormalizedPosition(float value, int axis) { }

	private void SetVerticalNormalizedPosition(float value) { }

	public override void StopMovement() { }

	private override Transform UnityEngine.UI.ICanvasElement.get_transform() { }

	protected void UpdateBounds() { }

	private void UpdateCachedData() { }

	private static void UpdateOneScrollbarVisibility(bool xScrollingNeeded, bool xAxisEnabled, ScrollbarVisibility scrollbarVisibility, Scrollbar scrollbar) { }

	protected void UpdatePrevData() { }

	private void UpdateScrollbarLayout() { }

	private void UpdateScrollbars(Vector2 offset) { }

	private void UpdateScrollbarVisibility() { }

}


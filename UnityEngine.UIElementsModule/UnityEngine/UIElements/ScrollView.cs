namespace UnityEngine.UIElements;

public class ScrollView : VisualElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<VisualElement> <>9__196_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <ReadSingleLineHeight>b__196_0(VisualElement x) { }

	}

	internal enum NestedInteractionKind
	{
		Default = 0,
		StopScrolling = 1,
		ForwardScrolling = 2,
	}

	internal enum TouchScrollBehavior
	{
		Unrestricted = 0,
		Elastic = 1,
		Clamped = 2,
	}

	public enum TouchScrollingResult
	{
		Apply = 0,
		Forward = 1,
		Block = 2,
	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<ScrollView, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlEnumAttributeDescription<ScrollViewMode> m_ScrollViewMode; //Field offset: 0x44
		private UxmlEnumAttributeDescription<NestedInteractionKind> m_NestedInteractionKind; //Field offset: 0x48
		private UxmlBoolAttributeDescription m_ShowHorizontal; //Field offset: 0x4C
		private UxmlBoolAttributeDescription m_ShowVertical; //Field offset: 0x50
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_HorizontalScrollerVisibility; //Field offset: 0x54
		private UxmlEnumAttributeDescription<ScrollerVisibility> m_VerticalScrollerVisibility; //Field offset: 0x58
		private UxmlFloatAttributeDescription m_HorizontalPageSize; //Field offset: 0x5C
		private UxmlFloatAttributeDescription m_VerticalPageSize; //Field offset: 0x60
		private UxmlFloatAttributeDescription m_MouseWheelScrollSize; //Field offset: 0x64
		private UxmlEnumAttributeDescription<TouchScrollBehavior> m_TouchScrollBehavior; //Field offset: 0x68
		private UxmlFloatAttributeDescription m_ScrollDecelerationRate; //Field offset: 0x6C
		private UxmlFloatAttributeDescription m_Elasticity; //Field offset: 0x70

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId horizontalScrollerVisibilityProperty; //Field offset: 0x0
	internal static readonly BindingId verticalScrollerVisibilityProperty; //Field offset: 0x4C
	internal static readonly BindingId scrollOffsetProperty; //Field offset: 0x98
	internal static readonly BindingId horizontalPageSizeProperty; //Field offset: 0xE4
	internal static readonly BindingId verticalPageSizeProperty; //Field offset: 0x130
	internal static readonly BindingId mouseWheelScrollSizeProperty; //Field offset: 0x17C
	internal static readonly BindingId scrollDecelerationRateProperty; //Field offset: 0x1C8
	internal static readonly BindingId elasticityProperty; //Field offset: 0x214
	internal static readonly BindingId touchScrollBehaviorProperty; //Field offset: 0x260
	internal static readonly BindingId nestedInteractionKindProperty; //Field offset: 0x2AC
	internal static readonly BindingId modeProperty; //Field offset: 0x2F8
	internal static readonly BindingId elasticAnimationIntervalMsProperty; //Field offset: 0x344
	private static readonly float k_DefaultScrollDecelerationRate; //Field offset: 0x390
	private static readonly float k_DefaultElasticity; //Field offset: 0x394
	public static readonly string ussClassName; //Field offset: 0x398
	public static readonly string viewportUssClassName; //Field offset: 0x39C
	public static readonly string horizontalVariantViewportUssClassName; //Field offset: 0x3A0
	public static readonly string verticalVariantViewportUssClassName; //Field offset: 0x3A4
	public static readonly string verticalHorizontalVariantViewportUssClassName; //Field offset: 0x3A8
	public static readonly string contentAndVerticalScrollUssClassName; //Field offset: 0x3AC
	public static readonly string contentUssClassName; //Field offset: 0x3B0
	public static readonly string horizontalVariantContentUssClassName; //Field offset: 0x3B4
	public static readonly string verticalVariantContentUssClassName; //Field offset: 0x3B8
	public static readonly string verticalHorizontalVariantContentUssClassName; //Field offset: 0x3BC
	public static readonly string hScrollerUssClassName; //Field offset: 0x3C0
	public static readonly string vScrollerUssClassName; //Field offset: 0x3C4
	public static readonly string horizontalVariantUssClassName; //Field offset: 0x3C8
	public static readonly string verticalVariantUssClassName; //Field offset: 0x3CC
	public static readonly string verticalHorizontalVariantUssClassName; //Field offset: 0x3D0
	public static readonly string scrollVariantUssClassName; //Field offset: 0x3D4
	private int m_FirstLayoutPass; //Field offset: 0x368
	private ScrollerVisibility m_HorizontalScrollerVisibility; //Field offset: 0x36C
	private ScrollerVisibility m_VerticalScrollerVisibility; //Field offset: 0x370
	private long m_ElasticAnimationIntervalMs; //Field offset: 0x378
	private VisualElement m_AttachedRootVisualContainer; //Field offset: 0x380
	private float m_SingleLineHeight; //Field offset: 0x384
	private bool m_SingleLineHeightDirtyFlag; //Field offset: 0x388
	internal bool m_MouseWheelScrollSizeIsInline; //Field offset: 0x389
	[DontCreateProperty]
	[SerializeField]
	private Vector2 m_ScrollOffset; //Field offset: 0x38C
	private float m_HorizontalPageSize; //Field offset: 0x394
	private float m_VerticalPageSize; //Field offset: 0x398
	private float m_MouseWheelScrollSize; //Field offset: 0x39C
	private float m_ScrollDecelerationRate; //Field offset: 0x3A0
	private float k_ScaledPixelsPerPointMultiplier; //Field offset: 0x3A4
	private float k_TouchScrollInertiaBaseTimeInterval; //Field offset: 0x3A8
	private float m_Elasticity; //Field offset: 0x3AC
	private TouchScrollBehavior m_TouchScrollBehavior; //Field offset: 0x3B0
	private NestedInteractionKind m_NestedInteractionKind; //Field offset: 0x3B4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly VisualElement <contentViewport>k__BackingField; //Field offset: 0x3B8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Scroller <horizontalScroller>k__BackingField; //Field offset: 0x3BC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Scroller <verticalScroller>k__BackingField; //Field offset: 0x3C0
	private VisualElement m_ContentContainer; //Field offset: 0x3C4
	private VisualElement m_ContentAndVerticalScrollContainer; //Field offset: 0x3C8
	private float previousVerticalTouchScrollTimeStamp; //Field offset: 0x3CC
	private float previousHorizontalTouchScrollTimeStamp; //Field offset: 0x3D0
	private float elapsedTimeSinceLastVerticalTouchScroll; //Field offset: 0x3D4
	private float elapsedTimeSinceLastHorizontalTouchScroll; //Field offset: 0x3D8
	private ScrollViewMode m_Mode; //Field offset: 0x3DC
	private IVisualElementScheduledItem m_ScheduledLayoutPassResetItem; //Field offset: 0x3E0
	private Vector2 m_StartPosition; //Field offset: 0x3E4
	private Vector2 m_PointerStartPosition; //Field offset: 0x3EC
	private Vector2 m_Velocity; //Field offset: 0x3F4
	private Vector2 m_SpringBackVelocity; //Field offset: 0x3FC
	private Vector2 m_LowBounds; //Field offset: 0x404
	private Vector2 m_HighBounds; //Field offset: 0x40C
	private float m_LastVelocityLerpTime; //Field offset: 0x414
	private bool m_StartedMoving; //Field offset: 0x418
	private bool m_TouchPointerMoveAllowed; //Field offset: 0x419
	private bool m_TouchStoppedVelocity; //Field offset: 0x41A
	private VisualElement m_CapturedTarget; //Field offset: 0x41C
	private EventCallback<PointerMoveEvent> m_CapturedTargetPointerMoveCallback; //Field offset: 0x420
	private EventCallback<PointerUpEvent> m_CapturedTargetPointerUpCallback; //Field offset: 0x424
	internal IVisualElementScheduledItem m_PostPointerUpAnimation; //Field offset: 0x428

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 14
	}

	public VisualElement contentViewport
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	[CreateProperty]
	public long elasticAnimationIntervalMs
	{
		 get { } //Length: 20
		 set { } //Length: 287
	}

	[CreateProperty]
	public float elasticity
	{
		 get { } //Length: 14
		 set { } //Length: 222
	}

	private bool hasInertia
	{
		private get { } //Length: 26
	}

	[CreateProperty]
	public float horizontalPageSize
	{
		 get { } //Length: 14
		 set { } //Length: 241
	}

	public Scroller horizontalScroller
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	[CreateProperty]
	public ScrollerVisibility horizontalScrollerVisibility
	{
		 get { } //Length: 14
		 set { } //Length: 245
	}

	internal bool isHorizontalScrollDisplayed
	{
		internal get { } //Length: 89
	}

	internal bool isVerticalScrollDisplayed
	{
		internal get { } //Length: 89
	}

	[CreateProperty]
	public ScrollViewMode mode
	{
		 get { } //Length: 14
		 set { } //Length: 114
	}

	[CreateProperty]
	public float mouseWheelScrollSize
	{
		 get { } //Length: 14
		 set { } //Length: 172
	}

	internal bool needsHorizontal
	{
		internal get { } //Length: 74
	}

	internal bool needsVertical
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 74
	}

	[CreateProperty]
	public NestedInteractionKind nestedInteractionKind
	{
		 get { } //Length: 14
		 set { } //Length: 103
	}

	internal float scrollableHeight
	{
		internal get { } //Length: 107
	}

	internal float scrollableWidth
	{
		internal get { } //Length: 107
	}

	[CreateProperty]
	public float scrollDecelerationRate
	{
		 get { } //Length: 14
		 set { } //Length: 222
	}

	[CreateProperty]
	public Vector2 scrollOffset
	{
		 get { } //Length: 45
		 set { } //Length: 538
	}

	[Obsolete("showHorizontal is obsolete. Use horizontalScrollerVisibility instead")]
	public bool showHorizontal
	{
		 set { } //Length: 27
	}

	[Obsolete("showVertical is obsolete. Use verticalScrollerVisibility instead")]
	public bool showVertical
	{
		 set { } //Length: 27
	}

	[CreateProperty]
	public TouchScrollBehavior touchScrollBehavior
	{
		 get { } //Length: 14
		 set { } //Length: 239
	}

	[CreateProperty]
	public float verticalPageSize
	{
		 get { } //Length: 14
		 set { } //Length: 241
	}

	public Scroller verticalScroller
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	[CreateProperty]
	public ScrollerVisibility verticalScrollerVisibility
	{
		 get { } //Length: 14
		 set { } //Length: 263
	}

	private static ScrollView() { }

	public ScrollView(ScrollViewMode scrollViewMode) { }

	public ScrollView() { }

	[CompilerGenerated]
	private void <.ctor>b__140_0(float value) { }

	[CompilerGenerated]
	private void <.ctor>b__140_1(float value) { }

	private void AdjustScrollers() { }

	internal void ApplyScrollInertia() { }

	private bool ApplyTouchScrolling(Vector2 newScrollOffset) { }

	private static float ComputeElasticOffset(float deltaPointer, float initialScrollOffset, float lowLimit, float hardLowLimit, float highLimit, float hardHighLimit) { }

	private void ComputeInitialSpringBackVelocity() { }

	internal TouchScrollingResult ComputeTouchScrolling(Vector2 position) { }

	private void ExecuteElasticSpringAnimation() { }

	public virtual VisualElement get_contentContainer() { }

	[CompilerGenerated]
	public VisualElement get_contentViewport() { }

	public long get_elasticAnimationIntervalMs() { }

	public float get_elasticity() { }

	private bool get_hasInertia() { }

	public float get_horizontalPageSize() { }

	[CompilerGenerated]
	public Scroller get_horizontalScroller() { }

	public ScrollerVisibility get_horizontalScrollerVisibility() { }

	internal bool get_isHorizontalScrollDisplayed() { }

	internal bool get_isVerticalScrollDisplayed() { }

	public ScrollViewMode get_mode() { }

	public float get_mouseWheelScrollSize() { }

	internal bool get_needsHorizontal() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool get_needsVertical() { }

	public NestedInteractionKind get_nestedInteractionKind() { }

	internal float get_scrollableHeight() { }

	internal float get_scrollableWidth() { }

	public float get_scrollDecelerationRate() { }

	public Vector2 get_scrollOffset() { }

	public TouchScrollBehavior get_touchScrollBehavior() { }

	public float get_verticalPageSize() { }

	[CompilerGenerated]
	public Scroller get_verticalScroller() { }

	public ScrollerVisibility get_verticalScrollerVisibility() { }

	private float GetDeltaDistance(float viewMin, float viewMax, float childBoundaryMin, float childBoundaryMax) { }

	private float GetXDeltaOffset(VisualElement child) { }

	private float GetYDeltaOffset(VisualElement child) { }

	internal void InitTouchScrolling(Vector2 position) { }

	private void MarkSingleLineHeightDirty() { }

	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	private void OnGeometryChanged(GeometryChangedEvent evt) { }

	private void OnHorizontalScrollDragElementChanged(GeometryChangedEvent evt) { }

	private void OnHorizontalScrollerSetValueWithoutNotify(float value) { }

	private void OnHorizontalSliderViewDataRestored() { }

	private void OnPointerCancel(PointerCancelEvent evt) { }

	private void OnPointerCapture(PointerCaptureEvent evt) { }

	private void OnPointerCaptureOut(PointerCaptureOutEvent evt) { }

	private void OnPointerDown(PointerDownEvent evt) { }

	private void OnPointerMove(PointerMoveEvent evt) { }

	private void OnPointerUp(PointerUpEvent evt) { }

	private void OnRootCustomStyleResolved(CustomStyleResolvedEvent evt) { }

	private void OnRootPointerUp(PointerUpEvent evt) { }

	private void OnScrollersGeometryChanged(GeometryChangedEvent evt) { }

	private void OnScrollWheel(WheelEvent evt) { }

	private void OnVerticalScrollDragElementChanged(GeometryChangedEvent evt) { }

	private void OnVerticalScrollerSetValueWithoutNotify(float value) { }

	private void OnVerticalSliderViewDataRestored() { }

	internal virtual void OnViewDataReady() { }

	private void PostPointerUpAnimation() { }

	private void ReadSingleLineHeight() { }

	private bool ReleaseScrolling(int pointerId, IEventHandler target) { }

	private void ResetLayoutPass() { }

	private void ScheduleResetLayoutPass() { }

	public void ScrollTo(VisualElement child) { }

	public void set_elasticAnimationIntervalMs(long value) { }

	public void set_elasticity(float value) { }

	public void set_horizontalPageSize(float value) { }

	public void set_horizontalScrollerVisibility(ScrollerVisibility value) { }

	public void set_mode(ScrollViewMode value) { }

	public void set_mouseWheelScrollSize(float value) { }

	public void set_nestedInteractionKind(NestedInteractionKind value) { }

	public void set_scrollDecelerationRate(float value) { }

	public void set_scrollOffset(Vector2 value) { }

	public void set_showHorizontal(bool value) { }

	public void set_showVertical(bool value) { }

	public void set_touchScrollBehavior(TouchScrollBehavior value) { }

	public void set_verticalPageSize(float value) { }

	public void set_verticalScrollerVisibility(ScrollerVisibility value) { }

	internal void SetScrollOffsetWithoutNotify(Vector2 value) { }

	private void SetScrollViewMode(ScrollViewMode mode) { }

	private void SpringBack() { }

	internal void UpdateContentViewTransform() { }

	private void UpdateElasticBehaviour() { }

	private void UpdateHorizontalSliderPageSize() { }

	internal void UpdateScrollers(bool displayHorizontal, bool displayVertical) { }

	private void UpdateVerticalSliderPageSize() { }

}


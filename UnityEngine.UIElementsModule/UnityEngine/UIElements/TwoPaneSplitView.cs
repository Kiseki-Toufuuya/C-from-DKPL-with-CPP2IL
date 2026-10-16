namespace UnityEngine.UIElements;

public class TwoPaneSplitView : VisualElement
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<TwoPaneSplitView, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlIntAttributeDescription m_FixedPaneIndex; //Field offset: 0x44
		private UxmlIntAttributeDescription m_FixedPaneInitialDimension; //Field offset: 0x48
		private UxmlEnumAttributeDescription<TwoPaneSplitViewOrientation> m_Orientation; //Field offset: 0x4C

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId fixedPaneIndexProperty; //Field offset: 0x0
	internal static readonly BindingId fixedPaneInitialDimensionProperty; //Field offset: 0x4C
	internal static readonly BindingId orientationProperty; //Field offset: 0x98
	private static readonly string s_UssClassName; //Field offset: 0xE4
	private static readonly string s_ContentContainerClassName; //Field offset: 0xE8
	private static readonly string s_HandleDragLineClassName; //Field offset: 0xEC
	private static readonly string s_HandleDragLineVerticalClassName; //Field offset: 0xF0
	private static readonly string s_HandleDragLineHorizontalClassName; //Field offset: 0xF4
	private static readonly string s_HandleDragLineAnchorClassName; //Field offset: 0xF8
	private static readonly string s_HandleDragLineAnchorVerticalClassName; //Field offset: 0xFC
	private static readonly string s_HandleDragLineAnchorHorizontalClassName; //Field offset: 0x100
	private static readonly string s_VerticalClassName; //Field offset: 0x104
	private static readonly string s_HorizontalClassName; //Field offset: 0x108
	private VisualElement m_LeftPane; //Field offset: 0x368
	private VisualElement m_RightPane; //Field offset: 0x36C
	private VisualElement m_FixedPane; //Field offset: 0x370
	private VisualElement m_FlexedPane; //Field offset: 0x374
	[DontCreateProperty]
	[SerializeField]
	private float m_FixedPaneDimension; //Field offset: 0x378
	private VisualElement m_DragLine; //Field offset: 0x37C
	private VisualElement m_DragLineAnchor; //Field offset: 0x380
	private bool m_CollapseMode; //Field offset: 0x384
	private bool m_PendingCollapseToExecute; //Field offset: 0x385
	private int m_CollapsedChildIndex; //Field offset: 0x388
	private VisualElement m_Content; //Field offset: 0x38C
	private TwoPaneSplitViewOrientation m_Orientation; //Field offset: 0x390
	private int m_FixedPaneIndex; //Field offset: 0x394
	private float m_FixedPaneInitialDimension; //Field offset: 0x398
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal TwoPaneSplitViewResizer m_Resizer; //Field offset: 0x39C

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 14
	}

	internal VisualElement dragLine
	{
		internal get { } //Length: 14
	}

	public VisualElement fixedPane
	{
		 get { } //Length: 14
	}

	internal float fixedPaneDimension
	{
		internal get { } //Length: 62
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 45
	}

	[CreateProperty]
	public int fixedPaneIndex
	{
		 get { } //Length: 14
		 set { } //Length: 130
	}

	[CreateProperty]
	public float fixedPaneInitialDimension
	{
		 get { } //Length: 14
		 set { } //Length: 138
	}

	public VisualElement flexedPane
	{
		 get { } //Length: 14
	}

	[CreateProperty]
	public TwoPaneSplitViewOrientation orientation
	{
		 get { } //Length: 14
		 set { } //Length: 136
	}

	private static TwoPaneSplitView() { }

	public TwoPaneSplitView() { }

	private void AdjustPanesBasedOnAnchor() { }

	public void CollapseChild(int index) { }

	public virtual VisualElement get_contentContainer() { }

	internal VisualElement get_dragLine() { }

	public VisualElement get_fixedPane() { }

	internal float get_fixedPaneDimension() { }

	public int get_fixedPaneIndex() { }

	public float get_fixedPaneInitialDimension() { }

	public VisualElement get_flexedPane() { }

	public TwoPaneSplitViewOrientation get_orientation() { }

	private void IdentifyLeftAndRightPane() { }

	internal override void Init(int fixedPaneIndex, float fixedPaneInitialDimension, TwoPaneSplitViewOrientation orientation) { }

	private void OnPostDisplaySetup(GeometryChangedEvent evt) { }

	private void OnSizeChange(GeometryChangedEvent evt) { }

	internal virtual void OnViewDataReady() { }

	private void PostDisplaySetup() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void set_fixedPaneDimension(float value) { }

	public void set_fixedPaneIndex(int value) { }

	public void set_fixedPaneInitialDimension(float value) { }

	public void set_orientation(TwoPaneSplitViewOrientation value) { }

	private void SetDragLineOffset(float offset) { }

	private void SetFixedPaneDimension(float dimension) { }

	private void SetupSplitView() { }

	private void UpdateLayout(bool updateFixedPane, bool updateDragLine) { }

}


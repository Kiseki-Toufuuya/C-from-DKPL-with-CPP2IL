namespace UnityEngine.UIElements.Internal;

internal class MultiColumnHeaderColumn : VisualElement
{
	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string sortableUssClassName; //Field offset: 0x4
	public static readonly string sortedAscendingUssClassName; //Field offset: 0x8
	public static readonly string sortedDescendingUssClassName; //Field offset: 0xC
	public static readonly string movingUssClassName; //Field offset: 0x10
	public static readonly string contentContainerUssClassName; //Field offset: 0x14
	public static readonly string contentUssClassName; //Field offset: 0x18
	public static readonly string defaultContentUssClassName; //Field offset: 0x1C
	public static readonly string hasIconUssClassName; //Field offset: 0x20
	public static readonly string hasTitleUssClassName; //Field offset: 0x24
	public static readonly string titleUssClassName; //Field offset: 0x28
	public static readonly string iconElementName; //Field offset: 0x2C
	public static readonly string titleElementName; //Field offset: 0x30
	private static readonly string s_BoundVEPropertyName; //Field offset: 0x34
	private static readonly string s_BindingCallbackVEPropertyName; //Field offset: 0x38
	private static readonly string s_UnbindingCallbackVEPropertyName; //Field offset: 0x3C
	private static readonly string s_DestroyCallbackVEPropertyName; //Field offset: 0x40
	private VisualElement m_ContentContainer; //Field offset: 0x368
	private VisualElement m_Content; //Field offset: 0x36C
	private MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer; //Field offset: 0x370
	private IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate; //Field offset: 0x374
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Clickable <clickable>k__BackingField; //Field offset: 0x378
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ColumnMover <mover>k__BackingField; //Field offset: 0x37C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Column <column>k__BackingField; //Field offset: 0x380

	public private Clickable clickable
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private Column column
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public VisualElement content
	{
		 get { } //Length: 14
		 set { } //Length: 578
	}

	private bool isContentBound
	{
		private get { } //Length: 163
		private set { } //Length: 125
	}

	public private ColumnMover mover
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public string sortOrderLabel
	{
		 set { } //Length: 56
	}

	private static MultiColumnHeaderColumn() { }

	public MultiColumnHeaderColumn(Column column) { }

	private void BindHeaderContent() { }

	private VisualElement CreateDefaultHeaderContent() { }

	private void DefaultBindHeaderContent(VisualElement ve) { }

	private void DestroyHeaderContent() { }

	public void Dispose() { }

	[CompilerGenerated]
	public Clickable get_clickable() { }

	[CompilerGenerated]
	public Column get_column() { }

	public VisualElement get_content() { }

	private bool get_isContentBound() { }

	[CompilerGenerated]
	public ColumnMover get_mover() { }

	private void InitManipulators() { }

	private void OnColumnChanged(Column c, ColumnDataType role) { }

	private void OnColumnResized(Column c) { }

	private void OnMoverChanged(ColumnMover mv) { }

	[CompilerGenerated]
	private void set_clickable(Clickable value) { }

	[CompilerGenerated]
	private void set_column(Column value) { }

	public void set_content(VisualElement value) { }

	private void set_isContentBound(bool value) { }

	[CompilerGenerated]
	private void set_mover(ColumnMover value) { }

	public void set_sortOrderLabel(string value) { }

	private void UnbindHeaderContent() { }

	private void UpdateDataFromColumn() { }

	private void UpdateGeometryFromColumn() { }

	private void UpdateHeaderTemplate() { }

}


namespace UnityEngine.UIElements;

public class MultiColumnController : IDisposable
{
	private static readonly PropertyName k_BoundColumnVePropertyName; //Field offset: 0x0
	internal static readonly PropertyName bindableElementPropertyName; //Field offset: 0x4
	internal static readonly string baseUssClassName; //Field offset: 0x8
	private static readonly string k_HeaderContainerViewDataKey; //Field offset: 0xC
	public static readonly string headerContainerUssClassName; //Field offset: 0x10
	public static readonly string rowContainerUssClassName; //Field offset: 0x14
	public static readonly string cellUssClassName; //Field offset: 0x18
	public static readonly string cellLabelUssClassName; //Field offset: 0x1C
	private static readonly string k_HeaderViewDataKey; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action columnSortingChanged; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent; //Field offset: 0xC
	private List<Int32> m_SortedToSourceIndex; //Field offset: 0x10
	private List<Int32> m_SourceToSortedIndex; //Field offset: 0x14
	private ColumnSortingMode m_SortingMode; //Field offset: 0x18
	private BaseVerticalCollectionView m_View; //Field offset: 0x1C
	private VisualElement m_HeaderContainer; //Field offset: 0x20
	private MultiColumnCollectionHeader m_MultiColumnHeader; //Field offset: 0x24

	public event Action columnSortingChanged
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public event Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent
	{
		[CompilerGenerated]
		 add { } //Length: 125
		[CompilerGenerated]
		 remove { } //Length: 125
	}

	internal MultiColumnCollectionHeader header
	{
		internal get { } //Length: 11
	}

	internal ColumnSortingMode sortingMode
	{
		internal get { } //Length: 11
		internal set { } //Length: 51
	}

	private static MultiColumnController() { }

	public MultiColumnController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	[CompilerGenerated]
	public void add_columnSortingChanged(Action value) { }

	[CompilerGenerated]
	public void add_headerContextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	private static void BindCellItem(VisualElement ve, int rowIndex, Column column, T item) { }

	public void BindItem(VisualElement element, int index, T item) { }

	private int CombinedComparison(int a, int b) { }

	private static void DefaultBindCellItem(VisualElement ve, T item) { }

	private static VisualElement DefaultMakeCellItem() { }

	public void DestroyItem(VisualElement element) { }

	public override void Dispose() { }

	internal MultiColumnCollectionHeader get_header() { }

	internal ColumnSortingMode get_sortingMode() { }

	private static int GetIndexFromList(int index, List<Int32> indices) { }

	internal int GetSortedIndex(int sourceIndex) { }

	internal int GetSourceIndex(int sortedIndex) { }

	public VisualElement MakeItem() { }

	private void OnColumnAdded(Column column, int index) { }

	private void OnColumnChanged(ColumnsDataType type) { }

	private void OnColumnContainerGeometryChanged(GeometryChangedEvent evt) { }

	private void OnColumnRemoved(Column column) { }

	private void OnColumnReordered(Column column, int from, int to) { }

	private void OnColumnResized(int index, float width) { }

	private void OnColumnsChanged(Column column, ColumnDataType type) { }

	private void OnColumnSortingChanged() { }

	private void OnContextMenuPopulateEvent(ContextualMenuPopulateEvent evt, Column column) { }

	private void OnHorizontalScrollerValueChanged(float v) { }

	private void OnViewDataRestored() { }

	private void OnViewportGeometryChanged(GeometryChangedEvent evt) { }

	public void PrepareView(BaseVerticalCollectionView collectionView) { }

	[CompilerGenerated]
	public void remove_columnSortingChanged(Action value) { }

	[CompilerGenerated]
	public void remove_headerContextMenuPopulateEvent(Action<ContextualMenuPopulateEvent, Column> value) { }

	internal void set_sortingMode(ColumnSortingMode value) { }

	internal void SortIfNeeded() { }

	private static void UnbindCellItem(VisualElement ve, int rowIndex, Column column) { }

	public void UnbindItem(VisualElement element, int index) { }

	private void UpdateContentContainer(BaseVerticalCollectionView collectionView) { }

	internal void UpdateDragger() { }

}


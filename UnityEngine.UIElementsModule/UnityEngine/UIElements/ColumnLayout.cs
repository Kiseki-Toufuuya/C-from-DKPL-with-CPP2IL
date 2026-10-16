namespace UnityEngine.UIElements;

internal class ColumnLayout
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass54_0
	{
		public float totalColumnWidth; //Field offset: 0x8
		public ColumnLayout <>4__this; //Field offset: 0xC

		public <>c__DisplayClass54_0() { }

		internal void <RecomputeToMaxWidthProportionally>b__1(Column c) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass55_0
	{
		public float totalColumnsWidth; //Field offset: 0x8
		public ColumnLayout <>4__this; //Field offset: 0xC

		public <>c__DisplayClass55_0() { }

		internal void <RecomputeToMinWidthProportionally>b__1(Column c) { }

	}

	private List<Column> m_StretchableColumns; //Field offset: 0x8
	private List<Column> m_FixedColumns; //Field offset: 0xC
	private List<Column> m_RelativeWidthColumns; //Field offset: 0x10
	private List<Column> m_MixedWidthColumns; //Field offset: 0x14
	private Columns m_Columns; //Field offset: 0x18
	private float m_ColumnsWidth; //Field offset: 0x1C
	private bool m_ColumnsWidthDirty; //Field offset: 0x20
	private float m_MaxColumnsWidth; //Field offset: 0x24
	private float m_MinColumnsWidth; //Field offset: 0x28
	private bool m_IsDirty; //Field offset: 0x2C
	private float m_PreviousWidth; //Field offset: 0x30
	private float m_LayoutWidth; //Field offset: 0x34
	private bool m_DragResizeInPreviewMode; //Field offset: 0x38
	private bool m_DragResizing; //Field offset: 0x39
	private float m_DragStartPos; //Field offset: 0x3C
	private float m_DragLastPos; //Field offset: 0x40
	private float m_DragInitialColumnWidth; //Field offset: 0x44
	private List<Column> m_DragStretchableColumns; //Field offset: 0x48
	private List<Column> m_DragRelativeColumns; //Field offset: 0x4C
	private List<Column> m_DragFixedColumns; //Field offset: 0x50
	private Dictionary<Column, Single> m_PreviewDesiredWidths; //Field offset: 0x54
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action layoutRequested; //Field offset: 0x58

	public event Action layoutRequested
	{
		[CompilerGenerated]
		 add { } //Length: 116
		[CompilerGenerated]
		 remove { } //Length: 116
	}

	public Columns columns
	{
		 get { } //Length: 11
	}

	public float columnsWidth
	{
		 get { } //Length: 509
	}

	public bool hasRelativeWidthColumns
	{
		 get { } //Length: 77
	}

	public bool hasStretchableColumns
	{
		 get { } //Length: 56
	}

	public float layoutWidth
	{
		 get { } //Length: 11
	}

	public float maxColumnsWidth
	{
		 get { } //Length: 11
	}

	public float minColumnsWidth
	{
		 get { } //Length: 11
	}

	public ColumnLayout(Columns columns) { }

	[CompilerGenerated]
	private int <DoLayout>b__50_0(Column c1, Column c2) { }

	[CompilerGenerated]
	private int <DoLayout>b__50_1(Column c1, Column c2) { }

	[CompilerGenerated]
	private int <RecomputeToMaxWidthProportionally>b__54_0(Column c1, Column c2) { }

	[CompilerGenerated]
	private int <RecomputeToMinWidthProportionally>b__55_0(Column c1, Column c2) { }

	[CompilerGenerated]
	public void add_layoutRequested(Action value) { }

	internal void BeginDragResize(Column column, float pos, bool previewMode) { }

	private void ClearCache() { }

	public void Dirty() { }

	private void DistributeExcess(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	private void DistributeOverflow(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	public void DoLayout(float width) { }

	public void DragResize(Column column, float pos) { }

	internal void EndDragResize(Column column, bool cancelled) { }

	public Columns get_columns() { }

	public float get_columnsWidth() { }

	public bool get_hasRelativeWidthColumns() { }

	public bool get_hasStretchableColumns() { }

	public float get_layoutWidth() { }

	public float get_maxColumnsWidth() { }

	public float get_minColumnsWidth() { }

	public float GetDesiredPosition(Column column) { }

	public float GetDesiredWidth(Column c) { }

	private static bool IsClamped(float value, float min, float max) { }

	private void MakeRoomForColumn(Column column) { }

	private void OnColumnAdded(Column column, int index) { }

	private void OnColumnChanged(Column column, ColumnDataType type) { }

	private void OnColumnRemoved(Column column) { }

	private void OnColumnReordered(Column column, int from, int to) { }

	private void OnColumnResized(Column column) { }

	private float RecomputeToDesiredWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) { }

	private float RecomputeToDesiredWidth(Column column, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow) { }

	private float RecomputeToMaxWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false) { }

	private float RecomputeToMaxWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false) { }

	private float RecomputeToMinWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false) { }

	private float RecomputeToMinWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false) { }

	[CompilerGenerated]
	public void remove_layoutRequested(Action value) { }

	private bool RequiresLayoutUpdate(ColumnDataType type) { }

	private void ResizeColumn(Column column, float width, bool setDesiredWidthOnly = false) { }

	public void ResizeToFit(float width) { }

	public void StretchResizeColumns(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize) { }

	private void UpdateCache() { }

	private void UpdateMinAndMaxColumnsWidth() { }

}


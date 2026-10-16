namespace UnityEngine.UIElements;

internal class ListViewDraggerAnimated : ListViewDragger
{
	private int m_DragStartIndex; //Field offset: 0x54
	private int m_CurrentIndex; //Field offset: 0x58
	private float m_SelectionHeight; //Field offset: 0x5C
	private float m_LocalOffsetOnStart; //Field offset: 0x60
	private Vector3 m_CurrentPointerPosition; //Field offset: 0x64
	private ReusableCollectionItem m_Item; //Field offset: 0x70
	private ReusableCollectionItem m_OffsetItem; //Field offset: 0x74
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isDragging>k__BackingField; //Field offset: 0x78

	public ReusableCollectionItem draggedItem
	{
		 get { } //Length: 11
	}

	public private bool isDragging
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	protected virtual bool supportsDragEvents
	{
		 get { } //Length: 3
	}

	public ListViewDraggerAnimated(BaseVerticalCollectionView listView) { }

	private void Animate(ReusableCollectionItem element, float paddingTop) { }

	protected virtual void ClearDragAndDropUI(bool dragCancelled) { }

	public ReusableCollectionItem get_draggedItem() { }

	[CompilerGenerated]
	public bool get_isDragging() { }

	protected virtual bool get_supportsDragEvents() { }

	protected private virtual void OnDrop(Vector3 pointerPosition) { }

	[CompilerGenerated]
	private void set_isDragging(bool value) { }

	protected private virtual StartDragArgs StartDrag(Vector3 pointerPosition) { }

	protected virtual bool TryGetDragPosition(Vector2 pointerPosition, ref DragPosition dragPosition) { }

	protected private virtual void UpdateDrag(Vector3 pointerPosition) { }

}


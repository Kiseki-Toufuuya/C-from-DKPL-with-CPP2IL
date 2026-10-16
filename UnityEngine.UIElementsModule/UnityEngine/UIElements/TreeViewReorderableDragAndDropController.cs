namespace UnityEngine.UIElements;

internal class TreeViewReorderableDragAndDropController : BaseReorderableDragAndDropController
{
	internal class DropData
	{
		public Int32[] expandedIdsBeforeDrag; //Field offset: 0x8
		public Int32[] draggedIds; //Field offset: 0xC
		public int lastItemId; //Field offset: 0x10
		public float expandItemBeginTimerMs; //Field offset: 0x14
		public Vector2 expandItemBeginPosition; //Field offset: 0x18

		public DropData() { }

	}

	protected DropData m_DropData; //Field offset: 0x14
	protected readonly BaseTreeView m_TreeView; //Field offset: 0x18
	private IVisualElementScheduledItem m_ExpandDropItemScheduledItem; //Field offset: 0x1C
	private Action m_ExpandDropItemCallback; //Field offset: 0x20

	public TreeViewReorderableDragAndDropController(BaseTreeView view) { }

	public virtual bool CanDrop() { }

	protected virtual int CompareId(int id1, int id2) { }

	private void DelayExpandDropItem() { }

	public virtual void DragCleanup() { }

	private void ExpandDropItem() { }

	public virtual void HandleAutoExpand(ReusableCollectionItem item, Vector2 pointerPosition) { }

	public virtual DragVisualMode HandleDragAndDrop(IListDragAndDropArgs args) { }

	public virtual void OnDrop(IListDragAndDropArgs args) { }

	private void RestoreExpanded(List<Int32> ids) { }

	public virtual StartDragArgs SetupDragAndDrop(IEnumerable<Int32> itemIds, bool skipText = false) { }

}


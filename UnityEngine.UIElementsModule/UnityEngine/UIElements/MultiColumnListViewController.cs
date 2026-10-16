namespace UnityEngine.UIElements;

public class MultiColumnListViewController : BaseListViewController
{
	private MultiColumnController m_ColumnController; //Field offset: 0x24

	public MultiColumnController columnController
	{
		 get { } //Length: 11
	}

	public MultiColumnListViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	protected virtual void BindItem(VisualElement element, int index) { }

	protected virtual void DestroyItem(VisualElement element) { }

	public virtual void Dispose() { }

	public MultiColumnController get_columnController() { }

	public virtual int GetIdForIndex(int index) { }

	public virtual int GetIndexForId(int id) { }

	public virtual object GetItemForIndex(int index) { }

	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	protected virtual VisualElement MakeItem() { }

	protected virtual void PrepareView() { }

	internal virtual void PreRefresh() { }

	private void SortIfNeeded() { }

	protected virtual void UnbindItem(VisualElement element, int index) { }

	private void UpdateReorderClassList() { }

}


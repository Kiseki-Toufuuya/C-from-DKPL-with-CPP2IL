namespace UnityEngine.UIElements;

public abstract class MultiColumnTreeViewController : BaseTreeViewController
{
	private MultiColumnController m_ColumnController; //Field offset: 0x34

	public MultiColumnController columnController
	{
		 get { } //Length: 11
	}

	protected MultiColumnTreeViewController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns) { }

	protected virtual void BindItem(VisualElement element, int index) { }

	protected virtual void DestroyItem(VisualElement element) { }

	public virtual void Dispose() { }

	public MultiColumnController get_columnController() { }

	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	protected virtual VisualElement MakeItem() { }

	protected virtual void PrepareView() { }

	internal virtual void PreRefresh() { }

	protected virtual void UnbindItem(VisualElement element, int index) { }

}


namespace UnityEngine.UIElements;

public class DefaultTreeViewController : TreeViewController
{
	private TreeDataController<T> m_TreeDataController; //Field offset: 0x0

	public virtual IList itemsSource
	{
		 get { } //Length: 31
		 set { } //Length: 231
	}

	private TreeDataController<T> treeDataController
	{
		private get { } //Length: 92
	}

	public DefaultTreeViewController`1() { }

	[CompilerGenerated]
	private HierarchyNode <SetRootItems>b__6_0(HierarchyNode node) { }

	[CompilerGenerated]
	private void <SetRootItems>b__6_1(int id, HierarchyNode node) { }

	public virtual IList get_itemsSource() { }

	private TreeDataController<T> get_treeDataController() { }

	public virtual object GetItemForIndex(int index) { }

	public virtual void set_itemsSource(IList value) { }

	public override void SetRootItems(IList<TreeViewItemData`1<T>> items) { }

}


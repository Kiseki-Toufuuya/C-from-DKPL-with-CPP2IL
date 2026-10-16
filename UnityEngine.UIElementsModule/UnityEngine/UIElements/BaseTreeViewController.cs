namespace UnityEngine.UIElements;

public abstract class BaseTreeViewController : CollectionViewController
{
	[CompilerGenerated]
	private sealed class <GetAllItemIds>d__23 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private int <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private IEnumerable<Int32> rootIds; //Field offset: 0x14
		public IEnumerable<Int32> <>3__rootIds; //Field offset: 0x18
		public BaseTreeViewController <>4__this; //Field offset: 0x1C
		private Enumerator <>s__1; //Field offset: 0x20
		private HierarchyFlattenedNode <flattenedNode>5__2; //Field offset: 0x34
		private HierarchyNode <node>5__3; //Field offset: 0x50
		private IEnumerator<Int32> <>s__4; //Field offset: 0x58
		private int <id>5__5; //Field offset: 0x5C
		private HierarchyNode <parentNode>5__6; //Field offset: 0x60
		private HierarchyFlattenedNodeChildren <flattenedNodeChildren>5__7; //Field offset: 0x68
		private Enumerator <>s__8; //Field offset: 0x7C
		private HierarchyNode <node>5__9; //Field offset: 0xA8

		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 828
		}

		[DebuggerHidden]
		public <GetAllItemIds>d__23(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[DebuggerHidden]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetChildrenIds>d__25 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private int <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private int id; //Field offset: 0x14
		public int <>3__id; //Field offset: 0x18
		public BaseTreeViewController <>4__this; //Field offset: 0x1C
		private HierarchyNode <nodeById>5__1; //Field offset: 0x20
		private HierarchyNodeChildren <nodes>5__2; //Field offset: 0x28
		private Enumerator <>s__3; //Field offset: 0x38
		private HierarchyNode <node>5__4; //Field offset: 0x4C

		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 828
		}

		[DebuggerHidden]
		public <GetChildrenIds>d__25(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[DebuggerHidden]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	[CompilerGenerated]
	private sealed class <GetChildrenIdsByIndex>d__41 : IEnumerable<Int32>, IEnumerable, IEnumerator<Int32>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private int <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private int index; //Field offset: 0x14
		public int <>3__index; //Field offset: 0x18
		public BaseTreeViewController <>4__this; //Field offset: 0x1C
		private HierarchyNodeChildren <nodes>5__1; //Field offset: 0x20
		private Enumerator <>s__2; //Field offset: 0x30
		private HierarchyNode <node>5__3; //Field offset: 0x44

		private override int System.Collections.Generic.IEnumerator<System.Int32>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 828
		}

		[DebuggerHidden]
		public <GetChildrenIdsByIndex>d__41(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Int32> System.Collections.Generic.IEnumerable<System.Int32>.GetEnumerator() { }

		[DebuggerHidden]
		private override int System.Collections.Generic.IEnumerator<System.Int32>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly ProfilerMarker K_ExpandItemByIndex; //Field offset: 0x0
	 Hierarchy m_Hierarchy; //Field offset: 0x18
	 HierarchyFlattened m_HierarchyFlattened; //Field offset: 0x1C
	 HierarchyViewModel m_HierarchyViewModel; //Field offset: 0x20
	 Dictionary<Int32, HierarchyNode> m_IdToNodeDictionary; //Field offset: 0x24
	private IHierarchyProperty<Int32> m_TreeViewDataProperty; //Field offset: 0x28
	private bool m_HierarchyHasPendingChanged; //Field offset: 0x2C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<TreeViewExpansionChangedArgs> itemExpandedChanged; //Field offset: 0x30

	internal event Action<TreeViewExpansionChangedArgs> itemExpandedChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 125
		[CompilerGenerated]
		internal remove { } //Length: 125
	}

	protected BaseTreeView baseTreeView
	{
		 get { } //Length: 112
	}

	 Hierarchy hierarchy
	{
		 get { } //Length: 11
		 set { } //Length: 282
	}

	public virtual IList itemsSource
	{
		 get { } //Length: 11
		 set { } //Length: 64
	}

	private static BaseTreeViewController() { }

	protected BaseTreeViewController() { }

	[CompilerGenerated]
	internal void add_itemExpandedChanged(Action<TreeViewExpansionChangedArgs> value) { }

	public override bool CanChangeExpandedState(int id) { }

	internal void ClearIdToNodeDictionary() { }

	public void CollapseItem(int id, bool collapseAllChildren, bool refresh = true) { }

	public void CollapseItemByIndex(int index, bool collapseAllChildren, bool refresh = true) { }

	private void CollapseItemByNode(in HierarchyNode node, bool collapseAllChildren, bool refresh) { }

	internal HierarchyNode CreateNode(in HierarchyNode parent) { }

	internal void DisposeHierarchy() { }

	public bool Exists(int id) { }

	public void ExpandItem(int id, bool expandAllChildren, bool refresh = true) { }

	public void ExpandItemByIndex(int index, bool expandAllChildren, bool refresh = true) { }

	private void ExpandItemByNode(in HierarchyNode node, bool expandAllChildren, bool refresh) { }

	protected virtual void Finalize() { }

	protected BaseTreeView get_baseTreeView() { }

	 Hierarchy get_hierarchy() { }

	public virtual IList get_itemsSource() { }

	[IteratorStateMachine(typeof(<GetAllItemIds>d__23))]
	public override IEnumerable<Int32> GetAllItemIds(IEnumerable<Int32> rootIds = null) { }

	public int GetChildIndexForId(int id) { }

	[IteratorStateMachine(typeof(<GetChildrenIds>d__25))]
	public override IEnumerable<Int32> GetChildrenIds(int id) { }

	[IteratorStateMachine(typeof(<GetChildrenIdsByIndex>d__41))]
	public IEnumerable<Int32> GetChildrenIdsByIndex(int index) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal void GetExpandedItemIds(List<Int32> list) { }

	internal HierarchyNode GetHierarchyNodeById(int id) { }

	internal HierarchyNode GetHierarchyNodeByIndex(int index) { }

	public virtual int GetIdForIndex(int index) { }

	public int GetIndentationDepth(int id) { }

	public int GetIndentationDepthByIndex(int index) { }

	public virtual int GetIndexForId(int id) { }

	public override int GetParentId(int id) { }

	public override bool HasChildren(int id) { }

	public bool HasChildrenByIndex(int index) { }

	internal virtual void InvokeBindItem(ReusableCollectionItem reusableItem, int index) { }

	internal virtual void InvokeDestroyItem(ReusableCollectionItem reusableItem) { }

	internal virtual void InvokeMakeItem(ReusableCollectionItem reusableItem) { }

	private bool IsChildOf(int childId, int id) { }

	public bool IsExpanded(int id) { }

	public bool IsExpandedByIndex(int index) { }

	private bool IsIndexValid(int index) { }

	internal bool IsViewDataKeyEnabled() { }

	public override void Move(int id, int newParentId, int childIndex = -1, bool rebuildTree = true) { }

	private void OnItemPointerUp(PointerUpEvent evt) { }

	private void OnToggleValueChanged(ChangeEvent<Boolean> evt) { }

	internal void OnViewDataReadyUpdateNodes() { }

	internal void PostInitRegistration(ReusableTreeViewItem treeItem) { }

	internal virtual void PreRefresh() { }

	private void RaiseItemExpandedChanged(int id, bool isExpanded, bool isAppliedToAllChildren) { }

	internal void RaiseItemParentChanged(int id, int newParentId) { }

	[CompilerGenerated]
	internal void remove_itemExpandedChanged(Action<TreeViewExpansionChangedArgs> value) { }

	 void set_hierarchy(Hierarchy value) { }

	public virtual void set_itemsSource(IList value) { }

	internal void UpdateHierarchy() { }

	internal void UpdateIdToNodeDictionary(int id, in HierarchyNode node, bool isAdd = true) { }

	internal void UpdateSortOrder(in HierarchyNode newParent, in HierarchyNode insertedNode, int insertedIndex) { }

}


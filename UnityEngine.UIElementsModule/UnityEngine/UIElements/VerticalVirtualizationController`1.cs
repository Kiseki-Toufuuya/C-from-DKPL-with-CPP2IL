namespace UnityEngine.UIElements;

internal abstract class VerticalVirtualizationController : CollectionVirtualizationController
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c<T> <>9; //Field offset: 0x0
		public static Func<T> <>9__35_0; //Field offset: 0x0
		public static Action<T> <>9__35_1; //Field offset: 0x0
		public static Action<T> <>9__35_2; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal T <.ctor>b__35_0() { }

		internal void <.ctor>b__35_1(T i) { }

		internal void <.ctor>b__35_2(T i) { }

	}

	private readonly ObjectPool<T> m_Pool; //Field offset: 0x0
	protected BaseVerticalCollectionView m_CollectionView; //Field offset: 0x0
	protected List<T> m_ActiveItems; //Field offset: 0x0
	protected T m_DraggedItem; //Field offset: 0x0
	private Nullable<Int32> m_DeferredScrollToItemIndex; //Field offset: 0x0
	private readonly Action m_PerformDeferredScrollToItem; //Field offset: 0x0
	private IVisualElementScheduledItem m_ScheduleDeferredScrollToItem; //Field offset: 0x0
	private IVisualElementScheduledItem m_ScrollScheduledItem; //Field offset: 0x0
	private Action m_ScrollCallback; //Field offset: 0x0
	private int m_LastFocusedElementIndex; //Field offset: 0x0
	private List<Int32> m_LastFocusedElementTreeChildIndexes; //Field offset: 0x0
	protected readonly Func<T, Boolean> m_VisibleItemPredicateDelegate; //Field offset: 0x0
	protected List<T> m_ScrollInsertionList; //Field offset: 0x0
	private VisualElement m_EmptyRows; //Field offset: 0x0

	public virtual IEnumerable<ReusableCollectionItem> activeItems
	{
		 get { } //Length: 11
	}

	protected override bool alwaysRebindOnRefresh
	{
		 get { } //Length: 3
	}

	public virtual int firstVisibleIndex
	{
		 get { } //Length: 103
		 set { } //Length: 36
	}

	internal T firstVisibleItem
	{
		internal get { } //Length: 312
	}

	internal int itemsCount
	{
		internal get { } //Length: 119
	}

	protected float lastHeight
	{
		 get { } //Length: 26
	}

	internal T lastVisibleItem
	{
		internal get { } //Length: 99
	}

	protected SerializedVirtualizationData serializedData
	{
		 get { } //Length: 26
	}

	public virtual int visibleItemCount
	{
		 get { } //Length: 300
	}

	protected VerticalVirtualizationController`1(BaseVerticalCollectionView collectionView) { }

	internal virtual void EndDrag(int dropIndex) { }

	public virtual IEnumerable<ReusableCollectionItem> get_activeItems() { }

	protected override bool get_alwaysRebindOnRefresh() { }

	public virtual int get_firstVisibleIndex() { }

	internal T get_firstVisibleItem() { }

	internal int get_itemsCount() { }

	protected float get_lastHeight() { }

	internal T get_lastVisibleItem() { }

	protected SerializedVirtualizationData get_serializedData() { }

	public virtual int get_visibleItemCount() { }

	protected int GetDraggedIndex() { }

	internal override T GetOrMakeItemAtIndex(int activeItemIndex = -1, int scrollViewIndex = -1) { }

	private void HandleFocus(ReusableCollectionItem recycledItem, int previousIndex) { }

	private void OnDestroyItem(ReusableCollectionItem item) { }

	private void OnDetachFromPanelEvent(DetachFromPanelEvent evt) { }

	public virtual void OnFocusIn(VisualElement leafTarget) { }

	public virtual void OnFocusOut(VisualElement willFocus) { }

	protected override void OnScrollUpdate() { }

	private void PerformDeferredScrollToItem() { }

	public virtual void Refresh(bool rebuild) { }

	internal override void ReleaseItem(int activeItemsIndex) { }

	protected void ScheduleDeferredScrollToItem() { }

	protected void ScheduleScroll() { }

	protected virtual void set_firstVisibleIndex(int value) { }

	protected void Setup(T recycledItem, int newIndex) { }

	protected bool ShouldDeferScrollToItem(int index) { }

	internal virtual void StartDragItem(ReusableCollectionItem item) { }

	public virtual void UnbindAll() { }

	public virtual void UpdateBackground() { }

	protected override bool VisibleItemPredicate(T i) { }

}


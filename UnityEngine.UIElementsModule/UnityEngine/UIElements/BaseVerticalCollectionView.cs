namespace UnityEngine.UIElements;

public abstract class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action <>9__179_1; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__179_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass182_0
	{
		public int id; //Field offset: 0x8

		public <>c__DisplayClass182_0() { }

		internal bool <GetRootElementForId>b__0(ReusableCollectionItem t) { }

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass193_0
	{
		public bool selectedIndicesChanged; //Field offset: 0x0
		public BaseVerticalCollectionView <>4__this; //Field offset: 0x4
		public int previousSelectionCount; //Field offset: 0x8

	}

	[CompilerGenerated]
	private struct <>c__DisplayClass204_0
	{
		public BaseVerticalCollectionView <>4__this; //Field offset: 0x0
		public bool shiftKey; //Field offset: 0x4

	}

	[CompilerGenerated]
	private sealed class <get_selectedItems>d__88 : IEnumerable<Object>, IEnumerable, IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		public BaseVerticalCollectionView <>4__this; //Field offset: 0x14
		private Enumerator<Int32> <>s__1; //Field offset: 0x18
		private int <index>5__2; //Field offset: 0x28
		private object <item>5__3; //Field offset: 0x2C

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <get_selectedItems>d__88(int <>1__state) { }

		private void <>m__Finally1() { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<Object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class Selection
	{
		private readonly HashSet<Int32> m_IndexLookup; //Field offset: 0x8
		private readonly HashSet<Int32> m_IdLookup; //Field offset: 0xC
		private int m_MinIndex; //Field offset: 0x10
		private int m_MaxIndex; //Field offset: 0x14
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private List<Int32> <selectedIds>k__BackingField; //Field offset: 0x18
		public readonly List<Int32> indices; //Field offset: 0x1C
		public readonly Dictionary<Int32, Object> items; //Field offset: 0x20

		public int capacity
		{
			 get { } //Length: 64
			 set { } //Length: 131
		}

		public int idCount
		{
			 get { } //Length: 52
		}

		public int indexCount
		{
			 get { } //Length: 52
		}

		public int maxIndex
		{
			 get { } //Length: 38
		}

		public int minIndex
		{
			 get { } //Length: 38
		}

		public List<Int32> selectedIds
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 27
		}

		public Selection() { }

		public void AddId(int id) { }

		public void AddIndex(int index, object obj) { }

		public void Clear() { }

		public void ClearIds() { }

		public void ClearIndices() { }

		public void ClearItems() { }

		public bool ContainsId(int id) { }

		public bool ContainsIndex(int index) { }

		public int FirstIndex() { }

		public object FirstObject() { }

		public int get_capacity() { }

		public int get_idCount() { }

		public int get_indexCount() { }

		public int get_maxIndex() { }

		public int get_minIndex() { }

		[CompilerGenerated]
		public List<Int32> get_selectedIds() { }

		public void RemoveId(int id) { }

		public void set_capacity(int value) { }

		[CompilerGenerated]
		public void set_selectedIds(List<Int32> value) { }

		public bool TryRemove(int index) { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private readonly UxmlEnumAttributeDescription<CollectionVirtualizationMethod> m_VirtualizationMethod; //Field offset: 0x48
		private readonly UxmlIntAttributeDescription m_FixedItemHeight; //Field offset: 0x4C
		private readonly UxmlBoolAttributeDescription m_ShowBorder; //Field offset: 0x50
		private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType; //Field offset: 0x54
		private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds; //Field offset: 0x58
		private readonly UxmlBoolAttributeDescription m_Reorderable; //Field offset: 0x5C
		private readonly UxmlBoolAttributeDescription m_HorizontalScrollingEnabled; //Field offset: 0x60

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId itemsSourceProperty; //Field offset: 0x0
	internal static readonly BindingId selectionTypeProperty; //Field offset: 0x4C
	internal static readonly BindingId selectedItemProperty; //Field offset: 0x98
	internal static readonly BindingId selectedItemsProperty; //Field offset: 0xE4
	internal static readonly BindingId selectedIndexProperty; //Field offset: 0x130
	internal static readonly BindingId selectedIndicesProperty; //Field offset: 0x17C
	internal static readonly BindingId showBorderProperty; //Field offset: 0x1C8
	internal static readonly BindingId reorderableProperty; //Field offset: 0x214
	internal static readonly BindingId horizontalScrollingEnabledProperty; //Field offset: 0x260
	internal static readonly BindingId showAlternatingRowBackgroundsProperty; //Field offset: 0x2AC
	internal static readonly BindingId virtualizationMethodProperty; //Field offset: 0x2F8
	internal static readonly BindingId fixedItemHeightProperty; //Field offset: 0x344
	private static readonly ProfilerMarker k_RefreshMarker; //Field offset: 0x390
	private static readonly ProfilerMarker k_RebuildMarker; //Field offset: 0x394
	private static readonly List<ReusableCollectionItem> k_EmptyItems; //Field offset: 0x398
	internal static readonly string k_InvalidTemplateError; //Field offset: 0x39C
	internal static CustomStyleProperty<Int32> s_ItemHeightProperty; //Field offset: 0x3A0
	public static readonly string ussClassName; //Field offset: 0x3A4
	public static readonly string borderUssClassName; //Field offset: 0x3A8
	public static readonly string itemUssClassName; //Field offset: 0x3AC
	public static readonly string dragHoverBarUssClassName; //Field offset: 0x3B0
	public static readonly string dragHoverMarkerUssClassName; //Field offset: 0x3B4
	public static readonly string itemDragHoverUssClassName; //Field offset: 0x3B8
	public static readonly string itemSelectedVariantUssClassName; //Field offset: 0x3BC
	public static readonly string itemAlternativeBackgroundUssClassName; //Field offset: 0x3C0
	public static readonly string listScrollViewUssClassName; //Field offset: 0x3C4
	internal static readonly string backgroundFillUssClassName; //Field offset: 0x3C8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IEnumerable`1<Object>> itemsChosen; //Field offset: 0x370
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IEnumerable`1<Object>> selectionChanged; //Field offset: 0x374
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IEnumerable`1<Int32>> selectedIndicesChanged; //Field offset: 0x378
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Int32, Int32> itemIndexChanged; //Field offset: 0x37C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action itemsSourceChanged; //Field offset: 0x380
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action m_SelectionNotChanged; //Field offset: 0x384
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<CanStartDragArgs, Boolean> canStartDrag; //Field offset: 0x388
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<SetupDragAndDropArgs, StartDragArgs> setupDragAndDrop; //Field offset: 0x38C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<HandleDragAndDropArgs, DragVisualMode> dragAndDropUpdate; //Field offset: 0x390
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<HandleDragAndDropArgs, DragVisualMode> handleDrop; //Field offset: 0x394
	private SelectionType m_SelectionType; //Field offset: 0x398
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal bool allowSingleClickChoice; //Field offset: 0x39C
	private bool m_HorizontalScrollingEnabled; //Field offset: 0x39D
	[DontCreateProperty]
	[SerializeField]
	private AlternatingRowBackground m_ShowAlternatingRowBackgrounds; //Field offset: 0x3A0
	internal float m_FixedItemHeight; //Field offset: 0x3A4
	internal bool m_ItemHeightIsInline; //Field offset: 0x3A8
	private CollectionVirtualizationMethod m_VirtualizationMethod; //Field offset: 0x3AC
	private readonly ScrollView m_ScrollView; //Field offset: 0x3B0
	private CollectionViewController m_ViewController; //Field offset: 0x3B4
	private CollectionVirtualizationController m_VirtualizationController; //Field offset: 0x3B8
	private KeyboardNavigationManipulator m_NavigationManipulator; //Field offset: 0x3BC
	[DontCreateProperty]
	[SerializeField]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal SerializedVirtualizationData serializedVirtualizationData; //Field offset: 0x3C0
	[DontCreateProperty]
	[SerializeField]
	private List<Int32> m_SelectedIds; //Field offset: 0x3C4
	private readonly Selection m_Selection; //Field offset: 0x3C8
	private float m_LastHeight; //Field offset: 0x3CC
	private bool m_IsRangeSelectionDirectionUp; //Field offset: 0x3D0
	private ListViewDragger m_Dragger; //Field offset: 0x3D4
	private readonly Action<Int32, Int32> m_ItemIndexChangedCallback; //Field offset: 0x3D8
	private readonly Action m_ItemsSourceChangedCallback; //Field offset: 0x3DC
	private IVisualElementScheduledItem m_RebuildScheduled; //Field offset: 0x3E0
	internal int m_PreviousRefreshedCount; //Field offset: 0x3E4
	private Vector3 m_TouchDownPosition; //Field offset: 0x3E8
	private long m_LastPointerDownTimeStamp; //Field offset: 0x3F8
	private int m_PointerDownCount; //Field offset: 0x400

	internal IEnumerable<ReusableCollectionItem> activeItems
	{
		internal get { } //Length: 105
	}

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 3
	}

	internal ListViewDragger dragger
	{
		internal get { } //Length: 14
	}

	[CreateProperty]
	public float fixedItemHeight
	{
		 get { } //Length: 14
		 set { } //Length: 275
	}

	[CreateProperty]
	public bool horizontalScrollingEnabled
	{
		 get { } //Length: 14
		 set { } //Length: 165
	}

	internal bool isRebuildScheduled
	{
		internal get { } //Length: 68
	}

	[CreateProperty]
	public IList itemsSource
	{
		 get { } //Length: 42
		 set { } //Length: 95
	}

	internal float lastHeight
	{
		internal get { } //Length: 14
	}

	[CreateProperty]
	public bool reorderable
	{
		 get { } //Length: 151
		 set { } //Length: 296
	}

	internal ScrollView scrollView
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 14
	}

	public IEnumerable<Int32> selectedIds
	{
		 get { } //Length: 26
	}

	[CreateProperty]
	public int selectedIndex
	{
		 get { } //Length: 100
		 set { } //Length: 16
	}

	[CreateProperty(ReadOnly = True)]
	public IEnumerable<Int32> selectedIndices
	{
		 get { } //Length: 26
	}

	[CreateProperty(ReadOnly = True)]
	public object selectedItem
	{
		 get { } //Length: 178
	}

	[CreateProperty(ReadOnly = True)]
	public IEnumerable<Object> selectedItems
	{
		[IteratorStateMachine(typeof(<get_selectedItems>d__88))]
		 get { } //Length: 95
	}

	[CreateProperty]
	public SelectionType selectionType
	{
		 get { } //Length: 14
		 set { } //Length: 222
	}

	[CreateProperty]
	public AlternatingRowBackground showAlternatingRowBackgrounds
	{
		 get { } //Length: 14
		 set { } //Length: 112
	}

	[CreateProperty]
	public bool showBorder
	{
		 get { } //Length: 99
		 set { } //Length: 176
	}

	public CollectionViewController viewController
	{
		 get { } //Length: 14
	}

	internal CollectionVirtualizationController virtualizationController
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal get { } //Length: 45
	}

	[CreateProperty]
	public CollectionVirtualizationMethod virtualizationMethod
	{
		 get { } //Length: 14
		 set { } //Length: 129
	}

	private static BaseVerticalCollectionView() { }

	public BaseVerticalCollectionView(IList itemsSource, float itemHeight = -1) { }

	public BaseVerticalCollectionView() { }

	[CompilerGenerated]
	private void <.ctor>b__179_0(float v) { }

	[CompilerGenerated]
	private void <Apply>g__HandleSelectionAndScroll|204_0(int index, ref <>c__DisplayClass204_0 unnamed_param_1) { }

	[CompilerGenerated]
	private void <RefreshSelection>g__NotifyIfChanged|193_0(ref <>c__DisplayClass193_0 unnamed_param_0) { }

	public void AddToSelection(int index) { }

	internal void AddToSelection(IList<Int32> indexes) { }

	private void AddToSelectionWithoutValidation(int index) { }

	private bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey) { }

	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent) { }

	public void ClearSelection() { }

	private void ClearSelectionWithoutValidation() { }

	internal abstract ICollectionDragAndDropController CreateDragAndDropController() { }

	internal override ListViewDragger CreateDragger() { }

	protected abstract CollectionViewController CreateViewController() { }

	internal void CreateVirtualizationController() { }

	override void CreateVirtualizationController() { }

	internal void DoRangeSelection(int rangeSelectionFinalIndex) { }

	private void DoSelect(Vector2 localPosition, int mouseButton, int clickCount, bool actionKey, bool shiftKey) { }

	[EventInterest(EventInterestOptions::Inherit (0))]
	[Obsolete("ExecuteDefaultAction override has been removed because default event handling was migrated to HandleEventBubbleUp. Please use HandleEventBubbleUp.", False)]
	protected virtual void ExecuteDefaultAction(EventBase evt) { }

	internal IEnumerable<ReusableCollectionItem> get_activeItems() { }

	public virtual VisualElement get_contentContainer() { }

	internal ListViewDragger get_dragger() { }

	public float get_fixedItemHeight() { }

	public bool get_horizontalScrollingEnabled() { }

	internal bool get_isRebuildScheduled() { }

	public IList get_itemsSource() { }

	internal float get_lastHeight() { }

	public bool get_reorderable() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal ScrollView get_scrollView() { }

	public IEnumerable<Int32> get_selectedIds() { }

	public int get_selectedIndex() { }

	public IEnumerable<Int32> get_selectedIndices() { }

	public object get_selectedItem() { }

	[IteratorStateMachine(typeof(<get_selectedItems>d__88))]
	public IEnumerable<Object> get_selectedItems() { }

	public SelectionType get_selectionType() { }

	public AlternatingRowBackground get_showAlternatingRowBackgrounds() { }

	public bool get_showBorder() { }

	public CollectionViewController get_viewController() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal CollectionVirtualizationController get_virtualizationController() { }

	public CollectionVirtualizationMethod get_virtualizationMethod() { }

	internal CollectionViewController GetOrCreateViewController() { }

	internal CollectionVirtualizationController GetOrCreateVirtualizationController() { }

	public VisualElement GetRootElementForId(int id) { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(PointerUpEvent), typeof(FocusInEvent), typeof(FocusOutEvent), typeof(NavigationSubmitEvent)})]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	override bool HandleItemNavigation(bool moveIn, bool altKey) { }

	internal bool HasCanStartDrag() { }

	internal override bool HasValidDataAndBindings() { }

	internal void InitializeDragAndDropController(bool enableReordering) { }

	private bool MatchesExistingSelection(IEnumerable<Int32> indices) { }

	private void NotifyOfSelectionChange() { }

	private void OnAttachToPanel(AttachToPanelEvent evt) { }

	private void OnCustomStyleResolved(CustomStyleResolvedEvent e) { }

	private void OnDetachFromPanel(DetachFromPanelEvent evt) { }

	private void OnItemIndexChanged(int srcIndex, int dstIndex) { }

	private void OnItemsSourceChanged() { }

	private void OnPointerCancel(PointerCancelEvent evt) { }

	private void OnPointerDown(PointerDownEvent evt) { }

	private void OnPointerMove(PointerMoveEvent evt) { }

	private void OnPointerUp(PointerUpEvent evt) { }

	private void OnScroll(Vector2 offset) { }

	private void OnSizeChanged(GeometryChangedEvent evt) { }

	internal virtual void OnViewDataReady() { }

	override void PostRefresh() { }

	private void ProcessPointerDown(IPointerEvent evt) { }

	private void ProcessPointerUp(IPointerEvent evt) { }

	private void ProcessSingleClick(int clickedIndex) { }

	internal bool RaiseCanStartDrag(ReusableCollectionItem item, IEnumerable<Int32> ids) { }

	internal DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	internal DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs) { }

	internal StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, IEnumerable<Int32> ids, StartDragArgs args) { }

	public void Rebuild() { }

	public void RefreshItems() { }

	private void RefreshSelection() { }

	public void RemoveFromSelection(int index) { }

	private void RemoveFromSelectionWithoutValidation(int index) { }

	private void Resize(Vector2 size) { }

	internal float ResolveItemHeight(float height = -1) { }

	internal void ScheduleRebuild() { }

	public void ScrollToItem(int index) { }

	public void ScrollToItemById(int id) { }

	internal void SelectAll() { }

	public void set_fixedItemHeight(float value) { }

	public void set_horizontalScrollingEnabled(bool value) { }

	public void set_itemsSource(IList value) { }

	public void set_reorderable(bool value) { }

	public void set_selectedIndex(int value) { }

	public void set_selectionType(SelectionType value) { }

	public void set_showAlternatingRowBackgrounds(AlternatingRowBackground value) { }

	public void set_showBorder(bool value) { }

	public void set_virtualizationMethod(CollectionVirtualizationMethod value) { }

	public void SetSelection(int index) { }

	public void SetSelection(IEnumerable<Int32> indices) { }

	internal void SetSelectionInternal(IEnumerable<Int32> indices, bool sendNotification) { }

	public void SetSelectionWithoutNotify(IEnumerable<Int32> indices) { }

	public override void SetViewController(CollectionViewController controller) { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

}


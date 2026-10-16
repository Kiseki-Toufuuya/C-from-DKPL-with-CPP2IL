namespace UnityEngine.UIElements;

public abstract class BaseListView : BaseVerticalCollectionView
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass82_0
	{
		public BaseListView <>4__this; //Field offset: 0x8
		public int itemsCountPreCallback; //Field offset: 0xC

		public <>c__DisplayClass82_0() { }

		internal void <OnAddClicked>b__0() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader; //Field offset: 0x64
		private readonly UxmlStringAttributeDescription m_HeaderTitle; //Field offset: 0x68
		private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter; //Field offset: 0x6C
		private readonly UxmlBoolAttributeDescription m_AllowAdd; //Field offset: 0x70
		private readonly UxmlBoolAttributeDescription m_AllowRemove; //Field offset: 0x74
		private readonly UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode; //Field offset: 0x78
		private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize; //Field offset: 0x7C
		private readonly UxmlEnumAttributeDescription<BindingSourceSelectionMode> m_BindingSourceSelectionMode; //Field offset: 0x80

		protected UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private static readonly string k_SizeFieldLabel; //Field offset: 0x0
	internal static readonly BindingId showBoundCollectionSizeProperty; //Field offset: 0x4
	internal static readonly BindingId showFoldoutHeaderProperty; //Field offset: 0x50
	internal static readonly BindingId headerTitleProperty; //Field offset: 0x9C
	internal static readonly BindingId makeHeaderProperty; //Field offset: 0xE8
	internal static readonly BindingId makeFooterProperty; //Field offset: 0x134
	internal static readonly BindingId showAddRemoveFooterProperty; //Field offset: 0x180
	internal static readonly BindingId bindingSourceSelectionModeProperty; //Field offset: 0x1CC
	internal static readonly BindingId reorderModeProperty; //Field offset: 0x218
	internal static readonly BindingId makeNoneElementProperty; //Field offset: 0x264
	internal static readonly BindingId allowAddProperty; //Field offset: 0x2B0
	internal static readonly BindingId overridingAddButtonBehaviorProperty; //Field offset: 0x2FC
	internal static readonly BindingId onAddProperty; //Field offset: 0x348
	internal static readonly BindingId allowRemoveProperty; //Field offset: 0x394
	internal static readonly BindingId onRemoveProperty; //Field offset: 0x3E0
	public static readonly string ussClassName; //Field offset: 0x42C
	public static readonly string itemUssClassName; //Field offset: 0x430
	public static readonly string emptyLabelUssClassName; //Field offset: 0x434
	public static readonly string overMaxMultiEditLimitClassName; //Field offset: 0x438
	public static readonly string reorderableUssClassName; //Field offset: 0x43C
	public static readonly string reorderableItemUssClassName; //Field offset: 0x440
	public static readonly string reorderableItemContainerUssClassName; //Field offset: 0x444
	public static readonly string reorderableItemHandleUssClassName; //Field offset: 0x448
	public static readonly string reorderableItemHandleBarUssClassName; //Field offset: 0x44C
	public static readonly string footerUssClassName; //Field offset: 0x450
	public static readonly string foldoutHeaderUssClassName; //Field offset: 0x454
	public static readonly string arraySizeFieldUssClassName; //Field offset: 0x458
	public static readonly string arraySizeFieldWithHeaderUssClassName; //Field offset: 0x45C
	public static readonly string arraySizeFieldWithFooterUssClassName; //Field offset: 0x460
	public static readonly string listViewWithHeaderUssClassName; //Field offset: 0x464
	public static readonly string listViewWithFooterUssClassName; //Field offset: 0x468
	public static readonly string scrollViewWithFooterUssClassName; //Field offset: 0x46C
	public static readonly string footerAddButtonName; //Field offset: 0x470
	public static readonly string footerRemoveButtonName; //Field offset: 0x474
	private static readonly string k_EmptyListStr; //Field offset: 0x478
	private bool m_ShowBoundCollectionSize; //Field offset: 0x408
	private bool m_ShowFoldoutHeader; //Field offset: 0x409
	private string m_HeaderTitle; //Field offset: 0x40C
	private VisualElement drawnHeader; //Field offset: 0x410
	private Func<VisualElement> m_MakeHeader; //Field offset: 0x414
	private VisualElement drawnFooter; //Field offset: 0x418
	private Func<VisualElement> m_MakeFooter; //Field offset: 0x41C
	private bool m_ShowAddRemoveFooter; //Field offset: 0x420
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IEnumerable`1<Int32>> itemsAdded; //Field offset: 0x424
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IEnumerable`1<Int32>> itemsRemoved; //Field offset: 0x428
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action itemsSourceSizeChanged; //Field offset: 0x42C
	private IVisualElementScheduledItem m_TrackedItem; //Field offset: 0x430
	private Action m_TrackCount; //Field offset: 0x434
	private Func<Boolean> m_WhileAutoAssign; //Field offset: 0x438
	private BindingSourceSelectionMode m_BindingSourceSelectionMode; //Field offset: 0x43C
	private Label m_ListViewLabel; //Field offset: 0x440
	private Foldout m_Foldout; //Field offset: 0x444
	private TextField m_ArraySizeField; //Field offset: 0x448
	private bool m_IsOverMultiEditLimit; //Field offset: 0x44C
	private VisualElement m_Footer; //Field offset: 0x450
	private Button m_AddButton; //Field offset: 0x454
	private Button m_RemoveButton; //Field offset: 0x458
	private Action<IEnumerable`1<Int32>> m_ItemAddedCallback; //Field offset: 0x45C
	private Action<IEnumerable`1<Int32>> m_ItemRemovedCallback; //Field offset: 0x460
	private Action m_ItemsSourceSizeChangedCallback; //Field offset: 0x464
	private ListViewReorderMode m_ReorderMode; //Field offset: 0x468
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action reorderModeChanged; //Field offset: 0x46C
	private VisualElement m_NoneElement; //Field offset: 0x470
	private Func<VisualElement> m_MakeNoneElement; //Field offset: 0x474
	private bool m_AllowAdd; //Field offset: 0x478
	private Action<BaseListView, Button> m_OverridingAddButtonBehavior; //Field offset: 0x47C
	private Action<BaseListView> m_OnAdd; //Field offset: 0x480
	private bool m_AllowRemove; //Field offset: 0x484
	private Action<BaseListView> m_OnRemove; //Field offset: 0x488
	private string m_MaxMultiEditStr; //Field offset: 0x48C

	internal event Action reorderModeChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 118
		[CompilerGenerated]
		internal remove { } //Length: 118
	}

	[CreateProperty]
	public bool allowAdd
	{
		 get { } //Length: 14
		 set { } //Length: 123
	}

	[CreateProperty]
	public bool allowRemove
	{
		 get { } //Length: 14
		 set { } //Length: 112
	}

	internal bool autoAssignSource
	{
		internal get { } //Length: 18
	}

	[CreateProperty]
	public BindingSourceSelectionMode bindingSourceSelectionMode
	{
		 get { } //Length: 14
		 set { } //Length: 168
	}

	internal VisualElement footer
	{
		internal get { } //Length: 14
	}

	[CreateProperty]
	public string headerTitle
	{
		 get { } //Length: 14
		 set { } //Length: 169
	}

	[CreateProperty]
	public Func<VisualElement> makeFooter
	{
		 get { } //Length: 14
		 set { } //Length: 533
	}

	[CreateProperty]
	public Func<VisualElement> makeHeader
	{
		 get { } //Length: 14
		 set { } //Length: 574
	}

	[CreateProperty]
	public Func<VisualElement> makeNoneElement
	{
		 get { } //Length: 14
		 set { } //Length: 188
	}

	[CreateProperty]
	public Action<BaseListView> onAdd
	{
		 get { } //Length: 14
		 set { } //Length: 140
	}

	[CreateProperty]
	public Action<BaseListView> onRemove
	{
		 get { } //Length: 14
		 set { } //Length: 140
	}

	[CreateProperty]
	public Action<BaseListView, Button> overridingAddButtonBehavior
	{
		 get { } //Length: 14
		 set { } //Length: 140
	}

	[CreateProperty]
	public ListViewReorderMode reorderMode
	{
		 get { } //Length: 14
		 set { } //Length: 161
	}

	[CreateProperty]
	public bool showAddRemoveFooter
	{
		 get { } //Length: 18
		 set { } //Length: 204
	}

	[CreateProperty]
	public bool showBoundCollectionSize
	{
		 get { } //Length: 14
		 set { } //Length: 110
	}

	[CreateProperty]
	public bool showFoldoutHeader
	{
		 get { } //Length: 14
		 set { } //Length: 561
	}

	private Action trackCount
	{
		private get { } //Length: 113
	}

	private IVisualElementScheduledItem trackItemCount
	{
		private get { } //Length: 465
	}

	private Func<Boolean> untilManualBindingSourceSelectionMode
	{
		private get { } //Length: 113
	}

	public BaseListViewController viewController
	{
		 get { } //Length: 115
	}

	private static BaseListView() { }

	public BaseListView(IList itemsSource, float itemHeight = -1) { }

	public BaseListView() { }

	[CompilerGenerated]
	private void <get_trackCount>b__65_0() { }

	[CompilerGenerated]
	private bool <get_untilManualBindingSourceSelectionMode>b__68_0() { }

	[CompilerGenerated]
	internal void add_reorderModeChanged(Action value) { }

	private void AddFoldout() { }

	private void AddItems(int itemCount) { }

	internal virtual ICollectionDragAndDropController CreateDragAndDropController() { }

	internal virtual ListViewDragger CreateDragger() { }

	virtual void CreateVirtualizationController() { }

	private void EnableFooter(bool enabled) { }

	public bool get_allowAdd() { }

	public bool get_allowRemove() { }

	internal bool get_autoAssignSource() { }

	public BindingSourceSelectionMode get_bindingSourceSelectionMode() { }

	internal VisualElement get_footer() { }

	public string get_headerTitle() { }

	public Func<VisualElement> get_makeFooter() { }

	public Func<VisualElement> get_makeHeader() { }

	public Func<VisualElement> get_makeNoneElement() { }

	public Action<BaseListView> get_onAdd() { }

	public Action<BaseListView> get_onRemove() { }

	public Action<BaseListView, Button> get_overridingAddButtonBehavior() { }

	public ListViewReorderMode get_reorderMode() { }

	public bool get_showAddRemoveFooter() { }

	public bool get_showBoundCollectionSize() { }

	public bool get_showFoldoutHeader() { }

	private Action get_trackCount() { }

	private IVisualElementScheduledItem get_trackItemCount() { }

	private Func<Boolean> get_untilManualBindingSourceSelectionMode() { }

	public BaseListViewController get_viewController() { }

	virtual bool HandleItemNavigation(bool moveIn, bool altPressed) { }

	private void OnAddClicked() { }

	private void OnAfterAddClicked(int itemsCountPreCallback) { }

	private void OnArraySizeFieldChanged(ChangeEvent<String> evt) { }

	private void OnItemAdded(IEnumerable<Int32> indices) { }

	private void OnItemsRemoved(IEnumerable<Int32> indices) { }

	private void OnItemsSourceSizeChanged() { }

	private void OnRemoveClicked() { }

	virtual void PostRefresh() { }

	[CompilerGenerated]
	internal void remove_reorderModeChanged(Action value) { }

	private void RemoveFoldout() { }

	public void set_allowAdd(bool value) { }

	public void set_allowRemove(bool value) { }

	public void set_bindingSourceSelectionMode(BindingSourceSelectionMode value) { }

	public void set_headerTitle(string value) { }

	public void set_makeFooter(Func<VisualElement> value) { }

	public void set_makeHeader(Func<VisualElement> value) { }

	public void set_makeNoneElement(Func<VisualElement> value) { }

	public void set_onAdd(Action<BaseListView> value) { }

	public void set_onRemove(Action<BaseListView> value) { }

	public void set_overridingAddButtonBehavior(Action<BaseListView, Button> value) { }

	public void set_reorderMode(ListViewReorderMode value) { }

	public void set_showAddRemoveFooter(bool value) { }

	public void set_showBoundCollectionSize(bool value) { }

	public void set_showFoldoutHeader(bool value) { }

	internal void SetupArraySizeField() { }

	public virtual void SetViewController(CollectionViewController controller) { }

	internal void UpdateArraySizeField() { }

	internal void UpdateListViewLabel() { }

	private void UpdateRemoveButton() { }

}


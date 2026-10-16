namespace UnityEngine.UIElements;

public class Tab : VisualElement
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static EventCallback<TooltipEvent> <>9__67_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__67_0(TooltipEvent evt) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<Tab, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private readonly UxmlStringAttributeDescription m_Label; //Field offset: 0x44
		private readonly UxmlImageAttributeDescription m_IconImage; //Field offset: 0x48
		private readonly UxmlBoolAttributeDescription m_Closeable; //Field offset: 0x4C

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId labelProperty; //Field offset: 0x0
	internal static readonly BindingId iconImageProperty; //Field offset: 0x4C
	internal static readonly BindingId closeableProperty; //Field offset: 0x98
	public static readonly string ussClassName; //Field offset: 0xE4
	public static readonly string tabHeaderUssClassName; //Field offset: 0xE8
	public static readonly string tabHeaderImageUssClassName; //Field offset: 0xEC
	public static readonly string tabHeaderEmptyImageUssClassName; //Field offset: 0xF0
	public static readonly string tabHeaderStandaloneImageUssClassName; //Field offset: 0xF4
	public static readonly string tabHeaderLabelUssClassName; //Field offset: 0xF8
	public static readonly string tabHeaderEmptyLabeUssClassName; //Field offset: 0xFC
	public static readonly string tabHeaderUnderlineUssClassName; //Field offset: 0x100
	public static readonly string contentUssClassName; //Field offset: 0x104
	public static readonly string draggingUssClassName; //Field offset: 0x108
	public static readonly string reorderableUssClassName; //Field offset: 0x10C
	public static readonly string reorderableItemHandleUssClassName; //Field offset: 0x110
	public static readonly string reorderableItemHandleBarUssClassName; //Field offset: 0x114
	public static readonly string closeableUssClassName; //Field offset: 0x118
	public static readonly string closeButtonUssClassName; //Field offset: 0x11C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Tab> selected; //Field offset: 0x368
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<Boolean> closing; //Field offset: 0x36C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Tab> closed; //Field offset: 0x370
	private string m_Label; //Field offset: 0x374
	private Background m_IconImage; //Field offset: 0x378
	private bool m_Closeable; //Field offset: 0x388
	private VisualElement m_ContentContainer; //Field offset: 0x38C
	private VisualElement m_DragHandle; //Field offset: 0x390
	private VisualElement m_CloseButton; //Field offset: 0x394
	private VisualElement m_TabHeader; //Field offset: 0x398
	private Image m_TabHeaderImage; //Field offset: 0x39C
	private Label m_TabHeaderLabel; //Field offset: 0x3A0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly TabDragger <dragger>k__BackingField; //Field offset: 0x3A4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <index>k__BackingField; //Field offset: 0x3A8

	public event Action<Tab> closed
	{
		[CompilerGenerated]
		 add { } //Length: 130
		[CompilerGenerated]
		 remove { } //Length: 130
	}

	public event Action<Tab> selected
	{
		[CompilerGenerated]
		 add { } //Length: 130
		[CompilerGenerated]
		 remove { } //Length: 130
	}

	[CreateProperty]
	public bool closeable
	{
		 get { } //Length: 14
		 set { } //Length: 236
	}

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 14
	}

	[CreateProperty]
	public Background iconImage
	{
		 get { } //Length: 21
		 set { } //Length: 782
	}

	internal int index
	{
		[CompilerGenerated]
		internal get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 17
	}

	[CreateProperty]
	public string label
	{
		 get { } //Length: 14
		 set { } //Length: 279
	}

	public VisualElement tabHeader
	{
		 get { } //Length: 14
	}

	private static Tab() { }

	public Tab(string label, Background iconImage) { }

	public Tab() { }

	[CompilerGenerated]
	public void add_closed(Action<Tab> value) { }

	[CompilerGenerated]
	public void add_selected(Action<Tab> value) { }

	private void AddCloseButton() { }

	private void AddDragHandles() { }

	internal void EnableTabCloseButton(bool enable) { }

	internal void EnableTabDragHandles(bool enable) { }

	public bool get_closeable() { }

	public virtual VisualElement get_contentContainer() { }

	public Background get_iconImage() { }

	[CompilerGenerated]
	internal int get_index() { }

	public string get_label() { }

	public VisualElement get_tabHeader() { }

	private void OnCloseButtonClicked(PointerDownEvent evt) { }

	private void OnTabClicked(PointerDownEvent _) { }

	[CompilerGenerated]
	public void remove_closed(Action<Tab> value) { }

	[CompilerGenerated]
	public void remove_selected(Action<Tab> value) { }

	private void RemoveCloseButton() { }

	private void RemoveDragHandles() { }

	public void set_closeable(bool value) { }

	public void set_iconImage(Background value) { }

	[CompilerGenerated]
	internal void set_index(int value) { }

	public void set_label(string value) { }

	internal void SetActive() { }

	internal void SetInactive() { }

	private void UpdateTooltip(TooltipEvent evt) { }

}


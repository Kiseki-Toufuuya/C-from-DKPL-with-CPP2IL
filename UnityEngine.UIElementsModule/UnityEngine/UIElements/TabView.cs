namespace UnityEngine.UIElements;

[UxmlElement(null, new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(Tab)})]
public class TabView : VisualElement
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public string key; //Field offset: 0x8

		public <>c__DisplayClass56_0() { }

		internal bool <FindTabByKey>b__0(Tab tab) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<TabView, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private readonly UxmlBoolAttributeDescription m_Reorderable; //Field offset: 0x44

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	private class ViewState : ISerializationCallbackReceiver
	{
		private bool m_HasPersistedData; //Field offset: 0x8
		[SerializeField]
		private List<String> m_TabOrder; //Field offset: 0xC
		[SerializeField]
		private string m_ActiveTabKey; //Field offset: 0x10

		public ViewState() { }

		internal void Apply(TabView tabView) { }

		public override void OnAfterDeserialize() { }

		public override void OnBeforeSerialize() { }

		internal void Save(TabView tabView) { }

	}

	internal static readonly BindingId reorderableProperty; //Field offset: 0x0
	public static readonly string ussClassName; //Field offset: 0x4C
	public static readonly string headerContainerClassName; //Field offset: 0x50
	public static readonly string contentContainerUssClassName; //Field offset: 0x54
	public static readonly string reorderableUssClassName; //Field offset: 0x58
	public static readonly string verticalUssClassName; //Field offset: 0x5C
	private VisualElement m_HeaderContainer; //Field offset: 0x368
	private VisualElement m_ContentContainer; //Field offset: 0x36C
	private List<Tab> m_Tabs; //Field offset: 0x370
	private List<VisualElement> m_TabHeaders; //Field offset: 0x374
	private Tab m_ActiveTab; //Field offset: 0x378
	private ViewState m_ViewState; //Field offset: 0x37C
	private bool m_ApplyingViewState; //Field offset: 0x380
	private bool m_Reordering; //Field offset: 0x381
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Tab, Tab> activeTabChanged; //Field offset: 0x384
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Int32, Int32> tabReordered; //Field offset: 0x388
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Tab, Int32> tabClosed; //Field offset: 0x38C
	private bool m_Reorderable; //Field offset: 0x390

	public Tab activeTab
	{
		 get { } //Length: 14
		 set { } //Length: 374
	}

	public virtual VisualElement contentContainer
	{
		 get { } //Length: 14
	}

	internal VisualElement header
	{
		internal get { } //Length: 14
	}

	[CreateProperty]
	public bool reorderable
	{
		 get { } //Length: 14
		 set { } //Length: 433
	}

	internal List<VisualElement> tabHeaders
	{
		internal get { } //Length: 14
	}

	internal List<Tab> tabs
	{
		internal get { } //Length: 14
	}

	private static TabView() { }

	public TabView() { }

	internal Tab FindTabByKey(string key) { }

	public Tab get_activeTab() { }

	public virtual VisualElement get_contentContainer() { }

	internal VisualElement get_header() { }

	public bool get_reorderable() { }

	internal List<VisualElement> get_tabHeaders() { }

	internal List<Tab> get_tabs() { }

	private void OnElementAdded(VisualElement ve, int index) { }

	private void OnElementRemoved(VisualElement ve) { }

	private void OnTabClosed(Tab tab) { }

	private void OnTabSelected(Tab tab) { }

	internal virtual void OnViewDataReady() { }

	public void ReorderTab(int from, int to) { }

	private void SaveViewState() { }

	public void set_activeTab(Tab value) { }

	public void set_reorderable(bool value) { }

	private void UpdateIndexes() { }

}


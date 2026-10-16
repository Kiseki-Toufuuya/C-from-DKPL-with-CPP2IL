namespace UnityEngine.Accessibility;

public class AccessibilityNode
{
	[DefaultMember("Item")]
	private class ObservableList
	{
		private readonly List<T> m_Items; //Field offset: 0x0
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
		private Action listChanged; //Field offset: 0x0

		public event Action listChanged
		{
			[CompilerGenerated]
			 add { } //Length: 116
			[CompilerGenerated]
			 remove { } //Length: 116
		}

		public override int Count
		{
			 get { } //Length: 23
		}

		public override T Item
		{
			 get { } //Length: 44
		}

		[CompilerGenerated]
		public void add_listChanged(Action value) { }

		public override int get_Count() { }

		public override T get_Item(int index) { }

		public override IEnumerator<T> GetEnumerator() { }

		[CompilerGenerated]
		public void remove_listChanged(Action value) { }

	}

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <id>k__BackingField; //Field offset: 0x8
	private Func<Rect> m_FrameGetter; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<AccessibilityNode, Boolean> focusChanged; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<Boolean> selected; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action incremented; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action decremented; //Field offset: 0x1C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Func<Boolean> dismissed; //Field offset: 0x20
	private string m_Label; //Field offset: 0x24
	private string m_Value; //Field offset: 0x28
	private string m_Hint; //Field offset: 0x2C
	private bool m_IsActive; //Field offset: 0x30
	private AccessibilityRole m_Role; //Field offset: 0x32
	private bool m_AllowsDirectInteraction; //Field offset: 0x34
	private AccessibilityState m_State; //Field offset: 0x36
	private AccessibilityNode m_Parent; //Field offset: 0x38
	private ObservableList<AccessibilityNode> m_Children; //Field offset: 0x3C
	private ObservableList<AccessibilityAction> m_Actions; //Field offset: 0x40
	private Rect m_Frame; //Field offset: 0x44
	private SystemLanguage m_Language; //Field offset: 0x54
	private AccessibilityHierarchy m_Hierarchy; //Field offset: 0x58

	public bool allowsDirectInteraction
	{
		 get { } //Length: 11
	}

	internal IList<AccessibilityNode> childList
	{
		internal get { } //Length: 11
	}

	public Rect frame
	{
		 get { } //Length: 317
	}

	public Func<Rect> frameGetter
	{
		 get { } //Length: 11
	}

	public string hint
	{
		 get { } //Length: 11
	}

	public int id
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public bool isActive
	{
		 get { } //Length: 11
	}

	public string label
	{
		 get { } //Length: 11
	}

	internal SystemLanguage language
	{
		internal get { } //Length: 11
	}

	public AccessibilityNode parent
	{
		 get { } //Length: 11
	}

	public AccessibilityRole role
	{
		 get { } //Length: 12
	}

	public AccessibilityState state
	{
		 get { } //Length: 12
	}

	public string value
	{
		 get { } //Length: 11
	}

	private void ActionsChanged() { }

	internal void CalculateFrame() { }

	private void ChildrenChanged() { }

	internal bool Dismissed() { }

	internal void FreeNative(bool freeChildren) { }

	public bool get_allowsDirectInteraction() { }

	internal IList<AccessibilityNode> get_childList() { }

	public Rect get_frame() { }

	public Func<Rect> get_frameGetter() { }

	public string get_hint() { }

	[CompilerGenerated]
	public int get_id() { }

	public bool get_isActive() { }

	public string get_label() { }

	internal SystemLanguage get_language() { }

	public AccessibilityNode get_parent() { }

	public AccessibilityRole get_role() { }

	public AccessibilityState get_state() { }

	public string get_value() { }

	internal void GetNodeData(ref AccessibilityNodeData nodeData) { }

	internal void InvokeDecremented() { }

	internal void InvokeFocusChanged(bool isNodeFocused) { }

	internal void InvokeIncremented() { }

	internal bool InvokeSelected() { }

	private bool IsInActiveHierarchy() { }

	internal void NotifyFocusChanged(bool isNodeFocused) { }

	private void SetFrame(Rect frame) { }

}


namespace UnityEngine.UIElements;

internal class ReusableCollectionItem
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private VisualElement <bindableElement>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ValueAnimation<StyleValues> <animator>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <index>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <id>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isDragGhost>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<ReusableCollectionItem> onGeometryChanged; //Field offset: 0x1C
	protected EventCallback<GeometryChangedEvent> m_GeometryChangedEventCallback; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<ReusableCollectionItem> onDestroy; //Field offset: 0x24

	internal event Action<ReusableCollectionItem> onDestroy
	{
		[CompilerGenerated]
		internal add { } //Length: 125
		[CompilerGenerated]
		internal remove { } //Length: 125
	}

	public event Action<ReusableCollectionItem> onGeometryChanged
	{
		[CompilerGenerated]
		 add { } //Length: 125
		[CompilerGenerated]
		 remove { } //Length: 125
	}

	public ValueAnimation<StyleValues> animator
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public VisualElement bindableElement
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int id
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int index
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	internal bool isDragGhost
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public override VisualElement rootElement
	{
		 get { } //Length: 11
	}

	public ReusableCollectionItem() { }

	[CompilerGenerated]
	internal void add_onDestroy(Action<ReusableCollectionItem> value) { }

	[CompilerGenerated]
	public void add_onGeometryChanged(Action<ReusableCollectionItem> value) { }

	public override void DestroyElement() { }

	public override void DetachElement() { }

	[CompilerGenerated]
	public ValueAnimation<StyleValues> get_animator() { }

	[CompilerGenerated]
	public VisualElement get_bindableElement() { }

	[CompilerGenerated]
	public int get_id() { }

	[CompilerGenerated]
	public int get_index() { }

	[CompilerGenerated]
	internal bool get_isDragGhost() { }

	public override VisualElement get_rootElement() { }

	public override void Init(VisualElement item) { }

	protected override void OnGeometryChanged(GeometryChangedEvent evt) { }

	public override void PreAttachElement() { }

	[CompilerGenerated]
	internal void remove_onDestroy(Action<ReusableCollectionItem> value) { }

	[CompilerGenerated]
	public void remove_onGeometryChanged(Action<ReusableCollectionItem> value) { }

	[CompilerGenerated]
	public void set_animator(ValueAnimation<StyleValues> value) { }

	[CompilerGenerated]
	protected void set_bindableElement(VisualElement value) { }

	[CompilerGenerated]
	public void set_id(int value) { }

	[CompilerGenerated]
	public void set_index(int value) { }

	[CompilerGenerated]
	private void set_isDragGhost(bool value) { }

	public override void SetDragGhost(bool dragGhost) { }

	public override void SetSelected(bool selected) { }

}


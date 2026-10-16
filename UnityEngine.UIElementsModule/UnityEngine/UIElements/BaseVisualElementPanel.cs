namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal abstract class BaseVisualElementPanel : IPanel, IDisposable, IGroupBox
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<BaseVisualElementPanel> panelDisposed; //Field offset: 0x8
	private UIElementsBridge m_UIElementsBridge; //Field offset: 0xC
	private float m_Scale; //Field offset: 0x10
	internal LayoutConfig layoutConfig; //Field offset: 0x14
	private float m_PixelsPerPoint; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private float <referenceSpritePixelsPerUnit>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private PanelClearSettings <clearSettings>k__BackingField; //Field offset: 0x38
	internal IPanelRenderer panelRenderer; //Field offset: 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <duringLayoutPhase>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RepaintData <repaintData>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ICursorManager <cursorManager>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ContextualMenuManager <contextualMenuManager>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private DataBindingManager <dataBindingManager>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x64
	internal ElementUnderPointer m_TopElementUnderPointers; //Field offset: 0x68
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action isFlatChanged; //Field offset: 0x6C
	private bool m_IsFlat; //Field offset: 0x70
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action atlasChanged; //Field offset: 0x74
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private HierarchyEvent hierarchyChanged; //Field offset: 0x78
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<IPanel> beforeUpdate; //Field offset: 0x7C

	internal event Action atlasChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 116
		[CompilerGenerated]
		internal remove { } //Length: 116
	}

	internal event HierarchyEvent hierarchyChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 116
		[CompilerGenerated]
		internal remove { } //Length: 116
	}

	internal event Action isFlatChanged
	{
		[CompilerGenerated]
		internal add { } //Length: 116
		[CompilerGenerated]
		internal remove { } //Length: 116
	}

	internal event Action<BaseVisualElementPanel> panelDisposed
	{
		[CompilerGenerated]
		internal add { } //Length: 125
		[CompilerGenerated]
		internal remove { } //Length: 125
	}

	public abstract AtlasBase atlas
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	internal PanelClearSettings clearSettings
	{
		[CompilerGenerated]
		internal get { } //Length: 24
		[CompilerGenerated]
		internal set { } //Length: 22
	}

	public abstract ContextType contextType
	{
		 get { } //Length: 0
	}

	public internal override ContextualMenuManager contextualMenuManager
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	internal override ICursorManager cursorManager
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	internal override DataBindingManager dataBindingManager
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	public abstract EventDispatcher dispatcher
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	internal bool disposed
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	internal bool duringLayoutPhase
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public abstract FocusController focusController
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract GetViewDataDictionary getViewDataDictionary
	{
		 get { } //Length: 0
	}

	internal abstract uint hierarchyVersion
	{
		internal get { } //Length: 0
	}

	public abstract int IMGUIContainersCount
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public abstract EventInterests IMGUIEventInterests
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public bool isFlat
	{
		 get { } //Length: 11
		 set { } //Length: 53
	}

	public abstract ScriptableObject ownerObject
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public float referenceSpritePixelsPerUnit
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 18
	}

	internal override RepaintData repaintData
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	public abstract IMGUIContainer rootIMGUIContainer
	{
		 get { } //Length: 0
	}

	public abstract SavePersistentViewData saveViewData
	{
		 get { } //Length: 0
	}

	internal float scale
	{
		internal get { } //Length: 11
		internal set { } //Length: 244
	}

	public override float scaledPixelsPerPoint
	{
		 get { } //Length: 14
	}

	internal abstract IScheduler scheduler
	{
		internal get { } //Length: 0
	}

	internal abstract IStylePropertyAnimationSystem styleAnimationSystem
	{
		internal get { } //Length: 0
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
		internal set { } //Length: 0
	}

	internal UIElementsBridge uiElementsBridge
	{
		internal get { } //Length: 82
	}

	internal abstract uint version
	{
		internal get { } //Length: 0
	}

	public abstract VisualElement visualTree
	{
		 get { } //Length: 0
	}

	protected BaseVisualElementPanel() { }

	[CompilerGenerated]
	internal void add_atlasChanged(Action value) { }

	[CompilerGenerated]
	internal void add_hierarchyChanged(HierarchyEvent value) { }

	[CompilerGenerated]
	internal void add_isFlatChanged(Action value) { }

	[CompilerGenerated]
	internal void add_panelDisposed(Action<BaseVisualElementPanel> value) { }

	public abstract void ApplyStyles() { }

	internal void ClearCachedElementUnderPointer(int pointerId, EventBase triggerEvent) { }

	internal void CommitElementUnderPointers() { }

	internal override IGenericMenu CreateMenu() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public abstract AtlasBase get_atlas() { }

	[CompilerGenerated]
	internal PanelClearSettings get_clearSettings() { }

	public abstract ContextType get_contextType() { }

	[CompilerGenerated]
	public override ContextualMenuManager get_contextualMenuManager() { }

	[CompilerGenerated]
	internal override ICursorManager get_cursorManager() { }

	[CompilerGenerated]
	internal override DataBindingManager get_dataBindingManager() { }

	public abstract EventDispatcher get_dispatcher() { }

	[CompilerGenerated]
	internal bool get_disposed() { }

	[CompilerGenerated]
	internal bool get_duringLayoutPhase() { }

	public abstract FocusController get_focusController() { }

	public abstract GetViewDataDictionary get_getViewDataDictionary() { }

	internal abstract uint get_hierarchyVersion() { }

	public abstract int get_IMGUIContainersCount() { }

	public abstract EventInterests get_IMGUIEventInterests() { }

	public bool get_isFlat() { }

	public abstract ScriptableObject get_ownerObject() { }

	[CompilerGenerated]
	public float get_referenceSpritePixelsPerUnit() { }

	[CompilerGenerated]
	internal override RepaintData get_repaintData() { }

	public abstract IMGUIContainer get_rootIMGUIContainer() { }

	public abstract SavePersistentViewData get_saveViewData() { }

	internal float get_scale() { }

	public override float get_scaledPixelsPerPoint() { }

	internal abstract IScheduler get_scheduler() { }

	internal abstract IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	internal UIElementsBridge get_uiElementsBridge() { }

	internal abstract uint get_version() { }

	public abstract VisualElement get_visualTree() { }

	internal VisualElement GetTopElementUnderPointer(int pointerId) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal abstract IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	protected void InvokeAtlasChanged() { }

	internal void InvokeBeforeUpdate() { }

	internal void InvokeHierarchyChanged(VisualElement ve, HierarchyChangeType changeType, IReadOnlyList<VisualElement> additionalContext = null) { }

	internal abstract void OnVersionChanged(VisualElement ele, VersionChangeType changeTypeFlag) { }

	public abstract VisualElement Pick(Vector2 point) { }

	public abstract VisualElement PickAll(Vector2 point, List<VisualElement> picked) { }

	internal VisualElement RecomputeTopElementUnderPointer(int pointerId, Vector2 pointerPos, EventBase triggerEvent) { }

	[CompilerGenerated]
	internal void remove_atlasChanged(Action value) { }

	[CompilerGenerated]
	internal void remove_hierarchyChanged(HierarchyEvent value) { }

	[CompilerGenerated]
	internal void remove_isFlatChanged(Action value) { }

	[CompilerGenerated]
	internal void remove_panelDisposed(Action<BaseVisualElementPanel> value) { }

	public override void Render() { }

	public abstract void Repaint(Event e) { }

	internal void SendEvent(EventBase e, DispatchMode dispatchMode = 1) { }

	public abstract void set_atlas(AtlasBase value) { }

	[CompilerGenerated]
	internal void set_clearSettings(PanelClearSettings value) { }

	[CompilerGenerated]
	internal void set_contextualMenuManager(ContextualMenuManager value) { }

	[CompilerGenerated]
	internal override void set_cursorManager(ICursorManager value) { }

	[CompilerGenerated]
	internal override void set_dataBindingManager(DataBindingManager value) { }

	public abstract void set_dispatcher(EventDispatcher value) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	[CompilerGenerated]
	internal void set_duringLayoutPhase(bool value) { }

	public abstract void set_focusController(FocusController value) { }

	public abstract void set_IMGUIContainersCount(int value) { }

	public abstract void set_IMGUIEventInterests(EventInterests value) { }

	public void set_isFlat(bool value) { }

	protected abstract void set_ownerObject(ScriptableObject value) { }

	[CompilerGenerated]
	public void set_referenceSpritePixelsPerUnit(float value) { }

	[CompilerGenerated]
	internal override void set_repaintData(RepaintData value) { }

	internal void set_scale(float value) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal abstract void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	internal void SetSpecializedHierarchyFlagsUpdater() { }

	internal abstract void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase) { }

	private override void UnityEngine.UIElements.IGroupBox.OnOptionAdded(IGroupBoxOption option) { }

	private override void UnityEngine.UIElements.IGroupBox.OnOptionRemoved(IGroupBoxOption option) { }

	public abstract void UpdateAnimations() { }

	public abstract void UpdateBindings() { }

	internal void UpdateElementUnderPointers() { }

	public abstract void ValidateFocus() { }

	public abstract void ValidateLayout() { }

}


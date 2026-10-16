namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class Panel : BaseVisualElementPanel
{
	internal const int k_DefaultPixelsPerUnit = 100; //Field offset: 0x0
	private static ProfilerMarker s_MarkerPickAll; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static LoadResourceFunction <loadResourceFunc>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static TimeMsFunction <TimeSinceStartup>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private static Action<Panel> beforeAnyRepaint; //Field offset: 0xC
	private VisualElement m_RootContainer; //Field offset: 0x80
	private VisualTreeUpdater m_VisualTreeUpdater; //Field offset: 0x84
	private IStylePropertyAnimationSystem m_StylePropertyAnimationSystem; //Field offset: 0x88
	private string m_PanelName; //Field offset: 0x8C
	private uint m_Version; //Field offset: 0x90
	private uint m_RepaintVersion; //Field offset: 0x94
	private uint m_HierarchyVersion; //Field offset: 0x98
	private ProfilerMarker m_MarkerBeforeUpdate; //Field offset: 0x9C
	private ProfilerMarker m_MarkerUpdate; //Field offset: 0xA0
	private ProfilerMarker m_MarkerRender; //Field offset: 0xA4
	private ProfilerMarker m_MarkerLayout; //Field offset: 0xA8
	private ProfilerMarker m_MarkerBindings; //Field offset: 0xAC
	private ProfilerMarker m_MarkerDataBinding; //Field offset: 0xB0
	private ProfilerMarker m_MarkerAnimations; //Field offset: 0xB4
	private ProfilerMarker m_MarkerPanelChangeReceiver; //Field offset: 0xB8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventDispatcher <dispatcher>k__BackingField; //Field offset: 0xBC
	private TimerEventScheduler m_Scheduler; //Field offset: 0xC0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private ScriptableObject <ownerObject>k__BackingField; //Field offset: 0xC4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly ContextType <contextType>k__BackingField; //Field offset: 0xC8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private SavePersistentViewData <saveViewData>k__BackingField; //Field offset: 0xCC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private GetViewDataDictionary <getViewDataDictionary>k__BackingField; //Field offset: 0xD0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private FocusController <focusController>k__BackingField; //Field offset: 0xD4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private EventInterests <IMGUIEventInterests>k__BackingField; //Field offset: 0xD8
	private bool m_JustReceivedFocus; //Field offset: 0xDB
	private IDebugPanelChangeReceiver m_PanelChangeReceiver; //Field offset: 0xDC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private int <IMGUIContainersCount>k__BackingField; //Field offset: 0xE0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private IMGUIContainer <rootIMGUIContainer>k__BackingField; //Field offset: 0xE4
	private AtlasBase m_Atlas; //Field offset: 0xE8
	private bool m_ValidatingLayout; //Field offset: 0xEC

	public virtual AtlasBase atlas
	{
		 get { } //Length: 14
		 set { } //Length: 110
	}

	public virtual ContextType contextType
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public virtual EventDispatcher dispatcher
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public virtual FocusController focusController
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public virtual GetViewDataDictionary getViewDataDictionary
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	internal virtual uint hierarchyVersion
	{
		internal get { } //Length: 14
	}

	public virtual int IMGUIContainersCount
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 17
	}

	public virtual EventInterests IMGUIEventInterests
	{
		[CompilerGenerated]
		 get { } //Length: 30
		[CompilerGenerated]
		 set { } //Length: 28
	}

	private static LoadResourceFunction loadResourceFunc
	{
		[CompilerGenerated]
		private get { } //Length: 61
	}

	internal string name
	{
		internal get { } //Length: 14
		internal set { } //Length: 43
	}

	public virtual ScriptableObject ownerObject
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public IDebugPanelChangeReceiver panelChangeReceiver
	{
		 get { } //Length: 14
		 set { } //Length: 152
	}

	public virtual IMGUIContainer rootIMGUIContainer
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	public virtual SavePersistentViewData saveViewData
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	internal virtual IScheduler scheduler
	{
		internal get { } //Length: 96
	}

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal virtual IStylePropertyAnimationSystem styleAnimationSystem
	{
		internal get { } //Length: 14
		internal set { } //Length: 101
	}

	public TimerEventScheduler timerEventScheduler
	{
		 get { } //Length: 96
	}

	private static TimeMsFunction TimeSinceStartup
	{
		[CompilerGenerated]
		private get { } //Length: 61
	}

	internal virtual uint version
	{
		internal get { } //Length: 14
	}

	public virtual VisualElement visualTree
	{
		 get { } //Length: 14
	}

	private static Panel() { }

	public Panel(ScriptableObject ownerObject, ContextType contextType, EventDispatcher dispatcher) { }

	[CompilerGenerated]
	internal static Vector2Int <Pick>g__PixelOf|105_0(Vector2 p) { }

	public virtual void ApplyStyles() { }

	internal void Blur() { }

	private void CreateMarkers() { }

	internal static long DefaultTimeSinceStartupMs() { }

	protected virtual void Dispose(bool disposing) { }

	internal void Focus() { }

	public virtual AtlasBase get_atlas() { }

	[CompilerGenerated]
	public virtual ContextType get_contextType() { }

	[CompilerGenerated]
	public virtual EventDispatcher get_dispatcher() { }

	[CompilerGenerated]
	public virtual FocusController get_focusController() { }

	[CompilerGenerated]
	public virtual GetViewDataDictionary get_getViewDataDictionary() { }

	internal virtual uint get_hierarchyVersion() { }

	[CompilerGenerated]
	public virtual int get_IMGUIContainersCount() { }

	[CompilerGenerated]
	public virtual EventInterests get_IMGUIEventInterests() { }

	[CompilerGenerated]
	private static LoadResourceFunction get_loadResourceFunc() { }

	internal string get_name() { }

	[CompilerGenerated]
	public virtual ScriptableObject get_ownerObject() { }

	public IDebugPanelChangeReceiver get_panelChangeReceiver() { }

	[CompilerGenerated]
	public virtual IMGUIContainer get_rootIMGUIContainer() { }

	[CompilerGenerated]
	public virtual SavePersistentViewData get_saveViewData() { }

	internal virtual IScheduler get_scheduler() { }

	internal virtual IStylePropertyAnimationSystem get_styleAnimationSystem() { }

	public TimerEventScheduler get_timerEventScheduler() { }

	[CompilerGenerated]
	private static TimeMsFunction get_TimeSinceStartup() { }

	internal virtual uint get_version() { }

	public virtual VisualElement get_visualTree() { }

	internal virtual IVisualTreeUpdater GetUpdater(VisualTreeUpdatePhase phase) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
	internal static object LoadResource(string pathName, Type type, float dpiScaling) { }

	internal virtual void OnVersionChanged(VisualElement ve, VersionChangeType versionChangeType) { }

	private static VisualElement PerformPick(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false) { }

	public virtual VisualElement Pick(Vector2 point) { }

	private static VisualElement PickAll(VisualElement root, Vector2 point, List<VisualElement> picked = null, bool includeIgnoredElement = false) { }

	public virtual VisualElement PickAll(Vector2 point, List<VisualElement> picked) { }

	public virtual void Render() { }

	public virtual void Repaint(Event e) { }

	public virtual void set_atlas(AtlasBase value) { }

	[CompilerGenerated]
	public virtual void set_dispatcher(EventDispatcher value) { }

	[CompilerGenerated]
	public virtual void set_focusController(FocusController value) { }

	[CompilerGenerated]
	public virtual void set_IMGUIContainersCount(int value) { }

	[CompilerGenerated]
	public virtual void set_IMGUIEventInterests(EventInterests value) { }

	internal void set_name(string value) { }

	[CompilerGenerated]
	protected virtual void set_ownerObject(ScriptableObject value) { }

	public void set_panelChangeReceiver(IDebugPanelChangeReceiver value) { }

	internal virtual void set_styleAnimationSystem(IStylePropertyAnimationSystem value) { }

	internal virtual void SetUpdater(IVisualTreeUpdater updater, VisualTreeUpdatePhase phase) { }

	public static long TimeSinceStartupMs() { }

	public virtual void UpdateAnimations() { }

	public virtual void UpdateBindings() { }

	private void UpdateForRepaint() { }

	public virtual void ValidateFocus() { }

	public virtual void ValidateLayout() { }

}


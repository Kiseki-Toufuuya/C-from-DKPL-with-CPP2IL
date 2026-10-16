namespace UnityEngine.UIElements;

[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEditor.UIBuilderModule"})]
internal class UIElementsUtility : IUIElementsUtility
{
	private static Stack<IMGUIContainer> s_ContainerStack; //Field offset: 0x0
	private static Dictionary<Int32, Panel> s_UIElementsCache; //Field offset: 0x4
	private static Event s_EventInstance; //Field offset: 0x8
	internal static Color editorPlayModeTintColor; //Field offset: 0xC
	internal static float singleLineHeight; //Field offset: 0x1C
	internal static bool s_EnableOSXContextualMenuEventsOnNonOSXPlatforms; //Field offset: 0x20
	private static UIElementsUtility s_Instance; //Field offset: 0x24
	internal static List<Panel> s_PanelsIterationList; //Field offset: 0x28
	internal static readonly string s_RepaintProfilerMarkerName; //Field offset: 0x2C
	internal static readonly string s_EventProfilerMarkerName; //Field offset: 0x30
	private static readonly ProfilerMarker s_RepaintProfilerMarker; //Field offset: 0x34
	private static readonly ProfilerMarker s_EventProfilerMarker; //Field offset: 0x38
	internal static Char[] s_Modifiers; //Field offset: 0x3C

	public static bool isOSXContextualMenuPlatform
	{
		 get { } //Length: 127
	}

	private static UIElementsUtility() { }

	private UIElementsUtility() { }

	internal static void BeginContainerGUI(LayoutCache cache, Event evt, IMGUIContainer container) { }

	internal static EventBase CreateEvent(Event systemEvent, EventType eventType) { }

	internal static EventBase CreateEvent(Event systemEvent) { }

	private static bool DoDispatch(BaseVisualElementPanel panel) { }

	internal static void EndContainerGUI(Event evt, Rect layoutSize) { }

	public static bool get_isOSXContextualMenuPlatform() { }

	internal static void GetAllPanels(List<Panel> panels, ContextType contextType) { }

	internal static Enumerator<Int32, Panel> GetPanelsIterator() { }

	internal static string ParseMenuName(string menuName) { }

	internal static float PixelsPerUnitScaleForElement(VisualElement ve, Sprite sprite) { }

	public static void RegisterCachedPanel(int instanceID, Panel panel) { }

	public static void RemoveCachedPanel(int instanceID) { }

	public static bool TryGetPanel(int instanceID, out Panel panel) { }

	private override bool UnityEngine.UIElements.IUIElementsUtility.CleanupRoots() { }

	private override bool UnityEngine.UIElements.IUIElementsUtility.EndContainerGUIFromException(Exception exception) { }

	private override bool UnityEngine.UIElements.IUIElementsUtility.MakeCurrentIMGUIContainerDirty() { }

	private override bool UnityEngine.UIElements.IUIElementsUtility.ProcessEvent(int instanceID, IntPtr nativeEventPtr, ref bool eventHandled) { }

	private override bool UnityEngine.UIElements.IUIElementsUtility.ReleaseCapture() { }

	private override bool UnityEngine.UIElements.IUIElementsUtility.TakeCapture() { }

}


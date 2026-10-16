namespace UnityEngine.EventSystems;

[AddComponentMenu("Event/Event System")]
[DisallowMultipleComponent]
public class EventSystem : UIBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass56_0
	{
		public GameObject go; //Field offset: 0x8

		public <>c__DisplayClass56_0() { }

		internal void <CreateUIToolkitPanelGameObject>b__0() { }

	}

	private struct UIToolkitOverrideConfig
	{
		public EventSystem activeEventSystem; //Field offset: 0x0
		public bool sendEvents; //Field offset: 0x4
		public bool createPanelGameObjectsOnStart; //Field offset: 0x5

	}

	private static List<EventSystem> m_EventSystems; //Field offset: 0x0
	private static readonly Comparison<RaycastResult> s_RaycastComparer; //Field offset: 0x4
	private static UIToolkitOverrideConfig s_UIToolkitOverride; //Field offset: 0x8
	private List<BaseInputModule> m_SystemInputModules; //Field offset: 0x10
	private BaseInputModule m_CurrentInputModule; //Field offset: 0x14
	[FormerlySerializedAs("m_Selected")]
	[SerializeField]
	private GameObject m_FirstSelected; //Field offset: 0x18
	[SerializeField]
	private bool m_sendNavigationEvents; //Field offset: 0x1C
	[SerializeField]
	private int m_DragThreshold; //Field offset: 0x20
	private GameObject m_CurrentSelected; //Field offset: 0x24
	private bool m_HasFocus; //Field offset: 0x28
	private bool m_SelectionGuard; //Field offset: 0x29
	private BaseEventData m_DummyData; //Field offset: 0x2C
	private bool m_Started; //Field offset: 0x30
	private bool m_IsTrackingUIToolkitPanels; //Field offset: 0x31

	public bool alreadySelecting
	{
		 get { } //Length: 11
	}

	private BaseEventData baseEventDataCache
	{
		private get { } //Length: 100
	}

	private bool createUIToolkitPanelGameObjectsOnStart
	{
		private get { } //Length: 83
	}

	public static EventSystem current
	{
		 get { } //Length: 147
		 set { } //Length: 324
	}

	public BaseInputModule currentInputModule
	{
		 get { } //Length: 11
	}

	public GameObject currentSelectedGameObject
	{
		 get { } //Length: 11
	}

	public GameObject firstSelectedGameObject
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public bool isFocused
	{
		 get { } //Length: 11
	}

	private bool isUIToolkitActiveEventSystem
	{
		private get { } //Length: 184
	}

	[Obsolete("lastSelectedGameObject is no longer supported")]
	public GameObject lastSelectedGameObject
	{
		 get { } //Length: 3
	}

	public int pixelDragThreshold
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool sendNavigationEvents
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private bool sendUIToolkitEvents
	{
		private get { } //Length: 83
	}

	private static EventSystem() { }

	protected EventSystem() { }

	private void ChangeEventModule(BaseInputModule module) { }

	private void CreateUIToolkitPanelGameObject(BaseRuntimePanel panel) { }

	public bool get_alreadySelecting() { }

	private BaseEventData get_baseEventDataCache() { }

	private bool get_createUIToolkitPanelGameObjectsOnStart() { }

	public static EventSystem get_current() { }

	public BaseInputModule get_currentInputModule() { }

	public GameObject get_currentSelectedGameObject() { }

	public GameObject get_firstSelectedGameObject() { }

	public bool get_isFocused() { }

	private bool get_isUIToolkitActiveEventSystem() { }

	public GameObject get_lastSelectedGameObject() { }

	public int get_pixelDragThreshold() { }

	public bool get_sendNavigationEvents() { }

	private bool get_sendUIToolkitEvents() { }

	public bool IsPointerOverGameObject() { }

	public bool IsPointerOverGameObject(int pointerId) { }

	protected override void OnApplicationFocus(bool hasFocus) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	public void RaycastAll(PointerEventData eventData, List<RaycastResult> raycastResults) { }

	private static int RaycastComparer(RaycastResult lhs, RaycastResult rhs) { }

	public static void set_current(EventSystem value) { }

	public void set_firstSelectedGameObject(GameObject value) { }

	public void set_pixelDragThreshold(int value) { }

	public void set_sendNavigationEvents(bool value) { }

	public void SetSelectedGameObject(GameObject selected) { }

	public void SetSelectedGameObject(GameObject selected, BaseEventData pointer) { }

	public static void SetUITookitEventSystemOverride(EventSystem activeEventSystem, bool sendEvents = true, bool createPanelGameObjectsOnStart = true) { }

	protected virtual void Start() { }

	private void StartTrackingUIToolkitPanels() { }

	private void StopTrackingUIToolkitPanels() { }

	private void TickModules() { }

	public virtual string ToString() { }

	protected override void Update() { }

	public void UpdateModules() { }

}


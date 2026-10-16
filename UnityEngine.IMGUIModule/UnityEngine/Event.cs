namespace UnityEngine;

[NativeHeader("Modules/IMGUI/Event.bindings.h")]
[StaticAccessor("GUIEvent", StaticAccessorType::DoubleColon (2))]
public sealed class Event
{
	public static class BindingsMarshaller
	{

		public static IntPtr ConvertToNative(Event e) { }

	}

	internal const float scrollWheelDeltaPerTick = 3; //Field offset: 0x0
	internal static bool ignoreGuiDepth; //Field offset: 0x0
	private static Event s_Current; //Field offset: 0x4
	private static Event s_MasterEvent; //Field offset: 0x8
	internal IntPtr m_Ptr; //Field offset: 0x8

	public bool alt
	{
		 get { } //Length: 74
	}

	[NativeProperty("button", False, TargetType::Field (1))]
	public int button
	{
		 get { } //Length: 69
	}

	public bool capsLock
	{
		 get { } //Length: 74
	}

	[NativeProperty("character", False, TargetType::Field (1))]
	public char character
	{
		 get { } //Length: 69
		 set { } //Length: 72
	}

	[NativeProperty("clickCount", False, TargetType::Field (1))]
	public int clickCount
	{
		 get { } //Length: 69
	}

	public bool command
	{
		 get { } //Length: 74
	}

	public string commandName
	{
		[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = True)]
		 get { } //Length: 250
		[FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = True)]
		 set { } //Length: 410
	}

	public bool control
	{
		 get { } //Length: 74
	}

	public static Event current
	{
		 get { } //Length: 41
		 set { } //Length: 138
	}

	[NativeProperty("delta", False, TargetType::Field (1))]
	public Vector2 delta
	{
		 get { } //Length: 92
		 set { } //Length: 73
	}

	[NativeProperty("displayIndex", False, TargetType::Field (1))]
	public int displayIndex
	{
		 get { } //Length: 69
		 set { } //Length: 72
	}

	public bool functionKey
	{
		 get { } //Length: 74
	}

	[NativeProperty("keycode", False, TargetType::Field (1))]
	private KeyCode Internal_keyCode
	{
		private get { } //Length: 69
		private set { } //Length: 72
	}

	internal bool isDirectManipulationDevice
	{
		[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
		internal get { } //Length: 141
	}

	public bool isKey
	{
		 get { } //Length: 91
	}

	public bool isMouse
	{
		 get { } //Length: 117
	}

	public bool isScrollWheel
	{
		 get { } //Length: 75
	}

	public KeyCode keyCode
	{
		 get { } //Length: 360
		 set { } //Length: 72
	}

	[NativeProperty("modifiers", False, TargetType::Field (1))]
	public EventModifiers modifiers
	{
		 get { } //Length: 69
		 set { } //Length: 72
	}

	[NativeProperty("mousePosition", False, TargetType::Field (1))]
	public Vector2 mousePosition
	{
		 get { } //Length: 92
		 set { } //Length: 73
	}

	public bool numeric
	{
		 get { } //Length: 74
	}

	[NativeProperty("penStatus", False, TargetType::Field (1))]
	public PenStatus penStatus
	{
		 get { } //Length: 69
	}

	[NativeProperty("pointerType", False, TargetType::Field (1))]
	public PointerType pointerType
	{
		 get { } //Length: 69
	}

	[NativeProperty("pressure", False, TargetType::Field (1))]
	public float pressure
	{
		 get { } //Length: 73
	}

	[NativeProperty("type", False, TargetType::Field (1))]
	public EventType rawType
	{
		 get { } //Length: 69
	}

	public bool shift
	{
		 get { } //Length: 74
	}

	[NativeProperty("tilt", False, TargetType::Field (1))]
	public Vector2 tilt
	{
		 get { } //Length: 92
	}

	[NativeProperty("twist", False, TargetType::Field (1))]
	public float twist
	{
		 get { } //Length: 73
	}

	public EventType type
	{
		[FreeFunction("GUIEvent::GetType", HasExplicitThis = True)]
		 get { } //Length: 69
		[FreeFunction("GUIEvent::SetType", HasExplicitThis = True)]
		 set { } //Length: 72
	}

	public Event(int displayIndex) { }

	public Event() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void CopyFrom(Event e) { }

	[FreeFunction("GUIEvent::CopyFromPtr", IsThreadSafe = True, HasExplicitThis = True)]
	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal void CopyFromPtr(IntPtr ptr) { }

	private static void CopyFromPtr_Injected(IntPtr _unity_self, IntPtr ptr) { }

	public virtual bool Equals(object obj) { }

	protected virtual void Finalize() { }

	public bool get_alt() { }

	public int get_button() { }

	private static int get_button_Injected(IntPtr _unity_self) { }

	public bool get_capsLock() { }

	public char get_character() { }

	private static char get_character_Injected(IntPtr _unity_self) { }

	public int get_clickCount() { }

	private static int get_clickCount_Injected(IntPtr _unity_self) { }

	public bool get_command() { }

	[FreeFunction("GUIEvent::GetCommandName", HasExplicitThis = True)]
	public string get_commandName() { }

	private static void get_commandName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	public bool get_control() { }

	public static Event get_current() { }

	public Vector2 get_delta() { }

	private static void get_delta_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public int get_displayIndex() { }

	private static int get_displayIndex_Injected(IntPtr _unity_self) { }

	public bool get_functionKey() { }

	private KeyCode get_Internal_keyCode() { }

	private static KeyCode get_Internal_keyCode_Injected(IntPtr _unity_self) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule"})]
	internal bool get_isDirectManipulationDevice() { }

	public bool get_isKey() { }

	public bool get_isMouse() { }

	public bool get_isScrollWheel() { }

	public KeyCode get_keyCode() { }

	public EventModifiers get_modifiers() { }

	private static EventModifiers get_modifiers_Injected(IntPtr _unity_self) { }

	public Vector2 get_mousePosition() { }

	private static void get_mousePosition_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public bool get_numeric() { }

	public PenStatus get_penStatus() { }

	private static PenStatus get_penStatus_Injected(IntPtr _unity_self) { }

	public PointerType get_pointerType() { }

	private static PointerType get_pointerType_Injected(IntPtr _unity_self) { }

	public float get_pressure() { }

	private static float get_pressure_Injected(IntPtr _unity_self) { }

	public EventType get_rawType() { }

	private static EventType get_rawType_Injected(IntPtr _unity_self) { }

	public bool get_shift() { }

	public Vector2 get_tilt() { }

	private static void get_tilt_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public float get_twist() { }

	private static float get_twist_Injected(IntPtr _unity_self) { }

	[FreeFunction("GUIEvent::GetType", HasExplicitThis = True)]
	public EventType get_type() { }

	private static EventType get_type_Injected(IntPtr _unity_self) { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.UIElementsModule", "UnityEngine.InputForUIModule"})]
	internal static int GetDoubleClickTime() { }

	[VisibleToOtherModules(new IL2CPP_TYPE_STRING[] {"UnityEngine.InputForUIModule"})]
	internal static void GetEventAtIndex(int index, Event outEvent) { }

	private static void GetEventAtIndex_Injected(int index, IntPtr outEvent) { }

	public static int GetEventCount() { }

	public virtual int GetHashCode() { }

	[FreeFunction("GUIEvent::GetTypeForControl", HasExplicitThis = True)]
	public EventType GetTypeForControl(int controlID) { }

	private static EventType GetTypeForControl_Injected(IntPtr _unity_self, int controlID) { }

	[FreeFunction("GUIEvent::Internal_Create", IsThreadSafe = True)]
	private static IntPtr Internal_Create(int displayIndex) { }

	[FreeFunction("GUIEvent::Internal_Destroy", IsThreadSafe = True)]
	private static void Internal_Destroy(IntPtr ptr) { }

	[RequiredByNativeCode]
	internal static void Internal_MakeMasterEventCurrent(int displayIndex) { }

	private static void Internal_SetNativeEvent(IntPtr ptr) { }

	[NativeMethod("Use")]
	private void Internal_Use() { }

	private static void Internal_Use_Injected(IntPtr _unity_self) { }

	public static Event KeyboardEvent(string key) { }

	public static bool PopEvent(Event outEvent) { }

	private static bool PopEvent_Injected(IntPtr outEvent) { }

	public void set_character(char value) { }

	private static void set_character_Injected(IntPtr _unity_self, char value) { }

	[FreeFunction("GUIEvent::SetCommandName", HasExplicitThis = True)]
	public void set_commandName(string value) { }

	private static void set_commandName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	public static void set_current(Event value) { }

	public void set_delta(Vector2 value) { }

	private static void set_delta_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_displayIndex(int value) { }

	private static void set_displayIndex_Injected(IntPtr _unity_self, int value) { }

	private void set_Internal_keyCode(KeyCode value) { }

	private static void set_Internal_keyCode_Injected(IntPtr _unity_self, KeyCode value) { }

	public void set_keyCode(KeyCode value) { }

	public void set_modifiers(EventModifiers value) { }

	private static void set_modifiers_Injected(IntPtr _unity_self, EventModifiers value) { }

	public void set_mousePosition(Vector2 value) { }

	private static void set_mousePosition_Injected(IntPtr _unity_self, in Vector2 value) { }

	[FreeFunction("GUIEvent::SetType", HasExplicitThis = True)]
	public void set_type(EventType value) { }

	private static void set_type_Injected(IntPtr _unity_self, EventType value) { }

	public virtual string ToString() { }

	public void Use() { }

}


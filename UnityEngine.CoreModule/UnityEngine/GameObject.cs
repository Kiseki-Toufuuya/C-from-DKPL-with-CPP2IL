namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
[UsedByNativeCode]
public sealed class GameObject : object
{

	[Obsolete("GameObject.active is obsolete. Use GameObject.SetActive(), GameObject.activeSelf or GameObject.activeInHierarchy.")]
	public bool active
	{
		[NativeMethod(Name = "IsActive")]
		 get { } //Length: 98
		[NativeMethod(Name = "SetSelfActive")]
		 set { } //Length: 101
	}

	public bool activeInHierarchy
	{
		[NativeMethod(Name = "IsActive")]
		 get { } //Length: 98
	}

	public bool activeSelf
	{
		[NativeMethod(Name = "IsSelfActive")]
		 get { } //Length: 98
	}

	public GameObject gameObject
	{
		 get { } //Length: 8
	}

	public bool isStatic
	{
		[NativeMethod(Name = "GetIsStaticDeprecated")]
		 get { } //Length: 98
		[NativeMethod(Name = "SetIsStaticDeprecated")]
		 set { } //Length: 101
	}

	internal bool isStaticBatchable
	{
		[NativeMethod(Name = "IsStaticBatchable")]
		internal get { } //Length: 98
	}

	public int layer
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Scene scene
	{
		[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = True)]
		 get { } //Length: 115
	}

	public ulong sceneCullingMask
	{
		[FreeFunction(Name = "GameObjectBindings::GetSceneCullingMask", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public string tag
	{
		[FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = True)]
		 get { } //Length: 279
		[FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = True)]
		 set { } //Length: 420
	}

	public Transform transform
	{
		[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
		 get { } //Length: 120
	}

	public GameObject(string name, Type[] components) { }

	public GameObject() { }

	public GameObject(string name) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component AddComponent(Type componentType) { }

	public T AddComponent() { }

	[FreeFunction(Name = "MonoAddComponent", HasExplicitThis = True)]
	internal Component AddComponentInternal(string className) { }

	private static IntPtr AddComponentInternal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper className) { }

	[ExcludeFromDocs]
	public void BroadcastMessage(string methodName) { }

	[FreeFunction(Name = "Scripting::BroadcastScriptingMessage", HasExplicitThis = True)]
	public void BroadcastMessage(string methodName, object parameter, SendMessageOptions options) { }

	public void BroadcastMessage(string methodName, SendMessageOptions options) { }

	[ExcludeFromDocs]
	public void BroadcastMessage(string methodName, object parameter) { }

	private static void BroadcastMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object parameter, SendMessageOptions options) { }

	public bool CompareTag(TagHandle tag) { }

	public bool CompareTag(string tag) { }

	[FreeFunction(Name = "GameObjectBindings::CompareTag", HasExplicitThis = True)]
	private bool CompareTag_Internal(string tag) { }

	private static bool CompareTag_Internal_Injected(IntPtr _unity_self, ref ManagedSpanWrapper tag) { }

	[FreeFunction(Name = "GameObjectBindings::CompareTagHandle", HasExplicitThis = True)]
	private bool CompareTagHandle_Internal(TagHandle tag) { }

	private static bool CompareTagHandle_Internal_Injected(IntPtr _unity_self, in TagHandle tag) { }

	[FreeFunction("GameObjectBindings::CreatePrimitive")]
	public static GameObject CreatePrimitive(PrimitiveType type) { }

	private static IntPtr CreatePrimitive_Injected(PrimitiveType type) { }

	[FreeFunction(Name = "GameObjectBindings::Find")]
	public static GameObject Find(string name) { }

	private static IntPtr Find_Injected(ref ManagedSpanWrapper name) { }

	public static void FindGameObjectsWithTag(string tag, List<GameObject> results) { }

	[FreeFunction(Name = "GameObjectBindings::FindGameObjectsWithTag", ThrowsException = True)]
	public static GameObject[] FindGameObjectsWithTag(string tag) { }

	private static GameObject[] FindGameObjectsWithTag_Injected(ref ManagedSpanWrapper tag) { }

	[FreeFunction(Name = "GameObjectBindings::FindGameObjectsWithTagForListInternal", ThrowsException = True)]
	private static void FindGameObjectsWithTagForListInternal(string tag, object results) { }

	private static void FindGameObjectsWithTagForListInternal_Injected(ref ManagedSpanWrapper tag, object results) { }

	[FreeFunction(Name = "GameObjectBindings::FindGameObjectWithTag", ThrowsException = True)]
	public static GameObject FindGameObjectWithTag(string tag) { }

	private static IntPtr FindGameObjectWithTag_Injected(ref ManagedSpanWrapper tag) { }

	public static GameObject FindWithTag(string tag) { }

	[NativeMethod(Name = "IsActive")]
	public bool get_active() { }

	private static bool get_active_Injected(IntPtr _unity_self) { }

	[NativeMethod(Name = "IsActive")]
	public bool get_activeInHierarchy() { }

	private static bool get_activeInHierarchy_Injected(IntPtr _unity_self) { }

	[NativeMethod(Name = "IsSelfActive")]
	public bool get_activeSelf() { }

	private static bool get_activeSelf_Injected(IntPtr _unity_self) { }

	public GameObject get_gameObject() { }

	[NativeMethod(Name = "GetIsStaticDeprecated")]
	public bool get_isStatic() { }

	private static bool get_isStatic_Injected(IntPtr _unity_self) { }

	[NativeMethod(Name = "IsStaticBatchable")]
	internal bool get_isStaticBatchable() { }

	private static bool get_isStaticBatchable_Injected(IntPtr _unity_self) { }

	public int get_layer() { }

	private static int get_layer_Injected(IntPtr _unity_self) { }

	[FreeFunction("GameObjectBindings::GetScene", HasExplicitThis = True)]
	public Scene get_scene() { }

	private static void get_scene_Injected(IntPtr _unity_self, out Scene ret) { }

	[FreeFunction(Name = "GameObjectBindings::GetSceneCullingMask", HasExplicitThis = True)]
	public ulong get_sceneCullingMask() { }

	private static ulong get_sceneCullingMask_Injected(IntPtr _unity_self) { }

	[FreeFunction("GameObjectBindings::GetTag", HasExplicitThis = True)]
	public string get_tag() { }

	private static void get_tag_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = True)]
	public Transform get_transform() { }

	private static IntPtr get_transform_Injected(IntPtr _unity_self) { }

	public T GetComponent() { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponent(Type type) { }

	public Component GetComponent(string type) { }

	private static IntPtr GetComponent_Injected(IntPtr _unity_self, Type type) { }

	public T GetComponentAtIndex(int index) { }

	public Component GetComponentAtIndex(int index) { }

	[FreeFunction(Name = "Scripting::GetScriptingWrapperOfComponentOfGameObject", HasExplicitThis = True)]
	internal Component GetComponentByName(string type) { }

	private static IntPtr GetComponentByName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper type) { }

	[FreeFunction(Name = "Scripting::GetScriptingWrapperOfComponentOfGameObjectWithCase", HasExplicitThis = True)]
	internal Component GetComponentByNameWithCase(string type, bool caseSensitive) { }

	private static IntPtr GetComponentByNameWithCase_Injected(IntPtr _unity_self, ref ManagedSpanWrapper type, bool caseSensitive) { }

	public int GetComponentCount() { }

	private static int GetComponentCount_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	internal void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	private static void GetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type type, bool includeInactive) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInChildren(Type type) { }

	public T GetComponentInChildren(bool includeInactive) { }

	[ExcludeFromDocs]
	public T GetComponentInChildren() { }

	private static IntPtr GetComponentInChildren_Injected(IntPtr _unity_self, Type type, bool includeInactive) { }

	public int GetComponentIndex(Component component) { }

	private static int GetComponentIndex_Injected(IntPtr _unity_self, IntPtr component) { }

	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type type) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public Component GetComponentInParent(Type type, bool includeInactive) { }

	[ExcludeFromDocs]
	public T GetComponentInParent() { }

	public T GetComponentInParent(bool includeInactive) { }

	private static IntPtr GetComponentInParent_Injected(IntPtr _unity_self, Type type, bool includeInactive) { }

	public T[] GetComponents() { }

	public Component[] GetComponents(Type type) { }

	public void GetComponents(List<T> results) { }

	public void GetComponents(Type type, List<Component> results) { }

	public T[] GetComponentsInChildren() { }

	public Component[] GetComponentsInChildren(Type type, bool includeInactive) { }

	public T[] GetComponentsInChildren(bool includeInactive) { }

	public void GetComponentsInChildren(List<T> results) { }

	[ExcludeFromDocs]
	public Component[] GetComponentsInChildren(Type type) { }

	public void GetComponentsInChildren(bool includeInactive, List<T> results) { }

	public void GetComponentsInParent(bool includeInactive, List<T> results) { }

	public Component[] GetComponentsInParent(Type type, bool includeInactive) { }

	public T[] GetComponentsInParent(bool includeInactive) { }

	public T[] GetComponentsInParent() { }

	[ExcludeFromDocs]
	public Component[] GetComponentsInParent(Type type) { }

	[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = True, ThrowsException = True)]
	private Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	private static Array GetComponentsInternal_Injected(IntPtr _unity_self, Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList) { }

	[FreeFunction(Name = "GameObjectBindings::GetSceneByInstanceID")]
	public static Scene GetScene(int instanceID) { }

	private static void GetScene_Injected(int instanceID, out Scene ret) { }

	[FreeFunction("GameObjectBindings::InstantiateGameObjectsByInstanceID")]
	private static void InstantiateGameObjects(int sourceInstanceID, IntPtr newInstanceIDs, IntPtr newTransformInstanceIDs, int count, Scene destinationScene) { }

	public static void InstantiateGameObjects(int sourceInstanceID, int count, NativeArray<Int32> newInstanceIDs, NativeArray<Int32> newTransformInstanceIDs, Scene destinationScene = null) { }

	private static void InstantiateGameObjects_Injected(int sourceInstanceID, IntPtr newInstanceIDs, IntPtr newTransformInstanceIDs, int count, in Scene destinationScene) { }

	[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = True)]
	private Component Internal_AddComponentWithType(Type componentType) { }

	private static IntPtr Internal_AddComponentWithType_Injected(IntPtr _unity_self, Type componentType) { }

	[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
	private static void Internal_CreateGameObject(GameObject self, string name) { }

	private static void Internal_CreateGameObject_Injected(GameObject self, ref ManagedSpanWrapper name) { }

	[NativeName("QueryComponentAtIndex<Unity::Component>")]
	internal Component QueryComponentAtIndex(int index) { }

	private static IntPtr QueryComponentAtIndex_Injected(IntPtr _unity_self, int index) { }

	public void SendMessage(string methodName, SendMessageOptions options) { }

	[ExcludeFromDocs]
	public void SendMessage(string methodName) { }

	[ExcludeFromDocs]
	public void SendMessage(string methodName, object value) { }

	[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = True)]
	public void SendMessage(string methodName, object value, SendMessageOptions options) { }

	private static void SendMessage_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value, SendMessageOptions options) { }

	public void SendMessageUpwards(string methodName, SendMessageOptions options) { }

	[ExcludeFromDocs]
	public void SendMessageUpwards(string methodName, object value) { }

	[FreeFunction(Name = "Scripting::SendScriptingMessageUpwards", HasExplicitThis = True)]
	public void SendMessageUpwards(string methodName, object value, SendMessageOptions options) { }

	[ExcludeFromDocs]
	public void SendMessageUpwards(string methodName) { }

	private static void SendMessageUpwards_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value, SendMessageOptions options) { }

	[NativeMethod(Name = "SetSelfActive")]
	public void set_active(bool value) { }

	private static void set_active_Injected(IntPtr _unity_self, bool value) { }

	[NativeMethod(Name = "SetIsStaticDeprecated")]
	public void set_isStatic(bool value) { }

	private static void set_isStatic_Injected(IntPtr _unity_self, bool value) { }

	public void set_layer(int value) { }

	private static void set_layer_Injected(IntPtr _unity_self, int value) { }

	[FreeFunction("GameObjectBindings::SetTag", HasExplicitThis = True)]
	public void set_tag(string value) { }

	private static void set_tag_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	[NativeMethod(Name = "SetSelfActive")]
	public void SetActive(bool value) { }

	private static void SetActive_Injected(IntPtr _unity_self, bool value) { }

	[NativeMethod(Name = "SetActiveRecursivelyDeprecated")]
	[Obsolete("gameObject.SetActiveRecursively() is obsolete. Use GameObject.SetActive(), which is now inherited by children.")]
	public void SetActiveRecursively(bool state) { }

	private static void SetActiveRecursively_Injected(IntPtr _unity_self, bool state) { }

	public static void SetGameObjectsActive(ReadOnlySpan<Int32> instanceIDs, bool active) { }

	public static void SetGameObjectsActive(NativeArray<Int32> instanceIDs, bool active) { }

	[FreeFunction(Name = "GameObjectBindings::SetGameObjectsActiveByInstanceID")]
	private static void SetGameObjectsActive(IntPtr instanceIds, int instanceCount, bool active) { }

	public bool TryGetComponent(out T component) { }

	public bool TryGetComponent(Type type, out Component component) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = True, ThrowsException = True)]
	internal void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue) { }

	private static void TryGetComponentFastPath_Injected(IntPtr _unity_self, Type type, IntPtr oneFurtherThanResultValue) { }

	[FreeFunction(Name = "GameObjectBindings::TryGetComponentFromType", HasExplicitThis = True, ThrowsException = True)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	internal Component TryGetComponentInternal(Type type) { }

	private static IntPtr TryGetComponentInternal_Injected(IntPtr _unity_self, Type type) { }

}


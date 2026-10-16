namespace UnityEngine;

[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[NativeHeader("Runtime/GameCode/CloneObject.h")]
[RequiredByNativeCode(GenerateProxy = True)]
public class object
{
	[VisibleToOtherModules]
	public static class MarshalledUnityObject
	{

		public static IntPtr Marshal(T obj) { }

		public static IntPtr MarshalNotNull(T obj) { }

		public static void TryThrowEditorNullExceptionObject(object unityObj, string paramterName) { }

	}

	private const int kInstanceID_None = 0; //Field offset: 0x0
	internal static readonly int OffsetOfInstanceIDInCPlusPlusObject; //Field offset: 0x0
	private const string objectIsNullMessage = "The Object you want to instantiate is null."; //Field offset: 0x0
	private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake."; //Field offset: 0x0
	private IntPtr m_CachedPtr; //Field offset: 0x8

	public HideFlags hideFlags
	{
		 get { } //Length: 128
		 set { } //Length: 131
	}

	public string name
	{
		 get { } //Length: 16
		 set { } //Length: 16
	}

	private static Object() { }

	public Object() { }

	private static void CheckNullArgument(object arg, string message) { }

	private static bool CompareBaseObjects(object lhs, object rhs) { }

	[NativeMethod(Name = "CurrentThreadIsMainThread", IsFreeFunction = True, IsThreadSafe = True)]
	private static bool CurrentThreadIsMainThread() { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = True, ThrowsException = True)]
	public static void Destroy(object obj, float t) { }

	[ExcludeFromDocs]
	public static void Destroy(object obj) { }

	private static void Destroy_Injected(IntPtr obj, float t) { }

	[ExcludeFromDocs]
	public static void DestroyImmediate(object obj) { }

	[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = True, ThrowsException = True)]
	public static void DestroyImmediate(object obj, bool allowDestroyingAssets) { }

	private static void DestroyImmediate_Injected(IntPtr obj, bool allowDestroyingAssets) { }

	[Obsolete("use Object.Destroy instead.")]
	public static void DestroyObject(object obj, float t) { }

	[ExcludeFromDocs]
	[Obsolete("use Object.Destroy instead.")]
	public static void DestroyObject(object obj) { }

	[NativeMethod(Name = "UnityEngineObjectBindings::DoesObjectWithInstanceIDExist", IsFreeFunction = True, IsThreadSafe = True)]
	internal static bool DoesObjectWithInstanceIDExist(int instanceID) { }

	[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = True)]
	public static void DontDestroyOnLoad(object target) { }

	private static void DontDestroyOnLoad_Injected(IntPtr target) { }

	private void EnsureRunningOnMainThread() { }

	public virtual bool Equals(object other) { }

	public static T FindAnyObjectByType(FindObjectsInactive findObjectsInactive) { }

	public static T FindAnyObjectByType() { }

	public static object FindAnyObjectByType(Type type) { }

	public static object FindAnyObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	public static object FindFirstObjectByType(Type type, FindObjectsInactive findObjectsInactive) { }

	public static object FindFirstObjectByType(Type type) { }

	public static T FindFirstObjectByType(FindObjectsInactive findObjectsInactive) { }

	public static T FindFirstObjectByType() { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
	[VisibleToOtherModules]
	internal static object FindObjectFromInstanceID(int instanceID) { }

	private static IntPtr FindObjectFromInstanceID_Injected(int instanceID) { }

	[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", False)]
	public static T FindObjectOfType(bool includeInactive) { }

	[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", False)]
	public static T FindObjectOfType() { }

	[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", False)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public static object FindObjectOfType(Type type) { }

	[Obsolete("Object.FindObjectOfType has been deprecated. Use Object.FindFirstObjectByType instead or if finding any instance is acceptable the faster Object.FindAnyObjectByType", False)]
	[TypeInferenceRule(TypeInferenceRules::TypeReferencedByFirstArgument (0))]
	public static object FindObjectOfType(Type type, bool includeInactive) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectsByType")]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsByType(Type type, FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	public static Object[] FindObjectsByType(Type type, FindObjectsSortMode sortMode) { }

	public static T[] FindObjectsByType(FindObjectsInactive findObjectsInactive, FindObjectsSortMode sortMode) { }

	public static T[] FindObjectsByType(FindObjectsSortMode sortMode) { }

	[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	public static T[] FindObjectsOfType() { }

	[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	public static T[] FindObjectsOfType(bool includeInactive) { }

	[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID, but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	public static Object[] FindObjectsOfType(Type type) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
	[Obsolete("Object.FindObjectsOfType has been deprecated. Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	[TypeInferenceRule(TypeInferenceRules::ArrayOfTypeReferencedByFirstArgument (2))]
	public static Object[] FindObjectsOfType(Type type, bool includeInactive) { }

	[Obsolete("Please use Resources.FindObjectsOfTypeAll instead")]
	public static Object[] FindObjectsOfTypeAll(Type type) { }

	[FreeFunction("UnityEngineObjectBindings::FindObjectsOfTypeIncludingAssets")]
	[Obsolete("use Resources.FindObjectsOfTypeAll instead.")]
	public static Object[] FindObjectsOfTypeIncludingAssets(Type type) { }

	[Obsolete("Object.FindSceneObjectsOfType has been deprecated, Use Object.FindObjectsByType instead which lets you decide whether you need the results sorted or not.  FindSceneObjectsOfType sorts the results by InstanceID but if you do not need this using FindObjectSortMode.None is considerably faster.", False)]
	public static Object[] FindSceneObjectsOfType(Type type) { }

	[FreeFunction("UnityEngineObjectBindings::ForceLoadFromInstanceID")]
	[VisibleToOtherModules]
	internal static object ForceLoadFromInstanceID(int instanceID) { }

	private static IntPtr ForceLoadFromInstanceID_Injected(int instanceID) { }

	public HideFlags get_hideFlags() { }

	private static HideFlags get_hideFlags_Injected(IntPtr _unity_self) { }

	public string get_name() { }

	private IntPtr GetCachedPtr() { }

	public virtual int GetHashCode() { }

	public int GetInstanceID() { }

	[FreeFunction("UnityEngineObjectBindings::GetName", HasExplicitThis = True)]
	private string GetName() { }

	private static void GetName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret) { }

	[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = True, IsThreadSafe = True)]
	private static int GetOffsetOfInstanceIDInCPlusPlusObject() { }

	[FreeFunction("UnityEngineObjectBindings::GetPtrFromInstanceID")]
	private static IntPtr GetPtrFromInstanceID(int instanceID, Type objectType, out bool isMonoBehaviour) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Vector3 position, Quaternion rotation) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Scene scene) { }

	public static T Instantiate(T original, Transform parent, bool worldPositionStays) { }

	public static T Instantiate(T original, Vector3 position, Quaternion rotation, InstantiateParameters parameters) { }

	public static T Instantiate(T original, Transform parent) { }

	public static T Instantiate(T original, InstantiateParameters parameters) { }

	public static T Instantiate(T original, Vector3 position, Quaternion rotation) { }

	public static T Instantiate(T original, Vector3 position, Quaternion rotation, Transform parent) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Transform parent) { }

	public static T Instantiate(T original) { }

	[TypeInferenceRule(TypeInferenceRules::TypeOfFirstArgument (3))]
	public static object Instantiate(object original, Transform parent, bool instantiateInWorldSpace) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Vector3 position, Quaternion rotation, InstantiateParameters parameters, CancellationToken cancellationToken = null) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Vector3 position, Quaternion rotation) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, Transform parent, Vector3 position, Quaternion rotation) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, Vector3 position, Quaternion rotation) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, Transform parent) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations, InstantiateParameters parameters, CancellationToken cancellationToken = null) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Transform parent, Vector3 position, Quaternion rotation, CancellationToken cancellationToken) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Transform parent, Vector3 position, Quaternion rotation) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Transform parent) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Transform parent, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, Transform parent, ReadOnlySpan<Vector3> positions, ReadOnlySpan<Quaternion> rotations, CancellationToken cancellationToken) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, InstantiateParameters parameters, CancellationToken cancellationToken = null) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, int count, InstantiateParameters parameters, CancellationToken cancellationToken = null) { }

	public static AsyncInstantiateOperation<T> InstantiateAsync(T original, Vector3 position, Quaternion rotation, InstantiateParameters parameters, CancellationToken cancellationToken = null) { }

	[NativeMethod(Name = "CloneObject", IsFreeFunction = True, ThrowsException = True)]
	private static object Internal_CloneSingle(object data) { }

	private static IntPtr Internal_CloneSingle_Injected(IntPtr data) { }

	[FreeFunction("CloneObjectWithParams")]
	private static object Internal_CloneSingleWithParams(object data, InstantiateParameters parameters) { }

	private static IntPtr Internal_CloneSingleWithParams_Injected(IntPtr data, in InstantiateParameters parameters) { }

	[FreeFunction("CloneObject")]
	private static object Internal_CloneSingleWithParent(object data, Transform parent, bool worldPositionStays) { }

	private static IntPtr Internal_CloneSingleWithParent_Injected(IntPtr data, IntPtr parent, bool worldPositionStays) { }

	[FreeFunction("CloneObjectToScene")]
	private static object Internal_CloneSingleWithScene(object data, Scene scene) { }

	private static IntPtr Internal_CloneSingleWithScene_Injected(IntPtr data, in Scene scene) { }

	[FreeFunction("InstantiateAsyncObjects")]
	private static IntPtr Internal_InstantiateAsyncWithParams(object original, int count, InstantiateParameters parameters, IntPtr positions, int positionsCount, IntPtr rotations, int rotationsCount) { }

	private static IntPtr Internal_InstantiateAsyncWithParams_Injected(IntPtr original, int count, in InstantiateParameters parameters, IntPtr positions, int positionsCount, IntPtr rotations, int rotationsCount) { }

	[FreeFunction("InstantiateObject")]
	private static object Internal_InstantiateSingle(object data, Vector3 pos, Quaternion rot) { }

	private static IntPtr Internal_InstantiateSingle_Injected(IntPtr data, in Vector3 pos, in Quaternion rot) { }

	[FreeFunction("InstantiateObjectWithParams")]
	private static object Internal_InstantiateSingleWithParams(object data, Vector3 position, Quaternion rotation, InstantiateParameters parameters) { }

	private static IntPtr Internal_InstantiateSingleWithParams_Injected(IntPtr data, in Vector3 position, in Quaternion rotation, in InstantiateParameters parameters) { }

	[FreeFunction("InstantiateObject")]
	private static object Internal_InstantiateSingleWithParent(object data, Transform parent, Vector3 pos, Quaternion rot) { }

	private static IntPtr Internal_InstantiateSingleWithParent_Injected(IntPtr data, IntPtr parent, in Vector3 pos, in Quaternion rot) { }

	private static bool IsNativeObjectAlive(object o) { }

	[FreeFunction("UnityEngineObjectBindings::IsPersistent")]
	internal static bool IsPersistent(object obj) { }

	private static bool IsPersistent_Injected(IntPtr obj) { }

	[FreeFunction("UnityEngineObjectBindings::MarkObjectDirty", HasExplicitThis = True)]
	internal void MarkDirty() { }

	private static void MarkDirty_Injected(IntPtr _unity_self) { }

	public static bool op_Equality(object x, object y) { }

	public static bool op_Implicit(object exists) { }

	public static bool op_Inequality(object x, object y) { }

	public void set_hideFlags(HideFlags value) { }

	private static void set_hideFlags_Injected(IntPtr _unity_self, HideFlags value) { }

	public void set_name(string value) { }

	[FreeFunction("UnityEngineObjectBindings::SetName", HasExplicitThis = True)]
	private void SetName(string name) { }

	private static void SetName_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name) { }

	public virtual string ToString() { }

	[FreeFunction("UnityEngineObjectBindings::ToString")]
	private static string ToString(object obj) { }

	private static void ToString_Injected(IntPtr obj, out ManagedSpanWrapper ret) { }

}


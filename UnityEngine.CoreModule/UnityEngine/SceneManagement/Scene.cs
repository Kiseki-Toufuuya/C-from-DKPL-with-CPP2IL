namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/Export/SceneManager/Scene.bindings.h")]
public struct Scene
{
	[HideInInspector]
	[SerializeField]
	private int m_Handle; //Field offset: 0x0

	public int handle
	{
		 get { } //Length: 10
	}

	public bool isLoaded
	{
		 get { } //Length: 45
	}

	public string name
	{
		 get { } //Length: 20
	}

	public int rootCount
	{
		 get { } //Length: 45
	}

	public virtual bool Equals(object other) { }

	public int get_handle() { }

	public bool get_isLoaded() { }

	public string get_name() { }

	public int get_rootCount() { }

	public virtual int GetHashCode() { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static bool GetIsLoadedInternal(int sceneHandle) { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static string GetNameInternal(int sceneHandle) { }

	private static void GetNameInternal_Injected(int sceneHandle, out ManagedSpanWrapper ret) { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static int GetRootCountInternal(int sceneHandle) { }

	public GameObject[] GetRootGameObjects() { }

	public void GetRootGameObjects(List<GameObject> rootGameObjects) { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static void GetRootGameObjectsInternal(int sceneHandle, object resultRootList) { }

	public bool IsValid() { }

	[StaticAccessor("SceneBindings", StaticAccessorType::DoubleColon (2))]
	private static bool IsValidInternal(int sceneHandle) { }

	public static bool op_Equality(Scene lhs, Scene rhs) { }

}


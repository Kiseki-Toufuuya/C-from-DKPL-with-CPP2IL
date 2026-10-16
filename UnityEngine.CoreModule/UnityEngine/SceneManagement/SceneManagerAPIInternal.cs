namespace UnityEngine.SceneManagement;

[NativeHeader("Runtime/SceneManager/SceneManager.h")]
[NativeHeader("Runtime/Export/SceneManager/SceneManager.bindings.h")]
[StaticAccessor("SceneManagerBindings", StaticAccessorType::DoubleColon (2))]
internal static class SceneManagerAPIInternal
{

	[NativeThrows]
	public static AsyncOperation LoadSceneAsyncNameIndexInternal(string sceneName, int sceneBuildIndex, LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

	private static IntPtr LoadSceneAsyncNameIndexInternal_Injected(ref ManagedSpanWrapper sceneName, int sceneBuildIndex, in LoadSceneParameters parameters, bool mustCompleteNextFrame) { }

}


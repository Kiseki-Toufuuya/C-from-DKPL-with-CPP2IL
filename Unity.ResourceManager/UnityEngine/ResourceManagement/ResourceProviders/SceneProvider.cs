namespace UnityEngine.ResourceManagement.ResourceProviders;

public class SceneProvider : ISceneProvider2, ISceneProvider
{
	private class SceneOp : AsyncOperationBase<SceneInstance>, IUpdateReceiver
	{
		private bool m_ActivateOnLoad; //Field offset: 0x58
		private SceneInstance m_Inst; //Field offset: 0x5C
		private IResourceLocation m_Location; //Field offset: 0x68
		private LoadSceneParameters m_LoadSceneParameters; //Field offset: 0x6C
		private SceneReleaseMode m_ReleaseMode; //Field offset: 0x74
		private int m_Priority; //Field offset: 0x78
		private AsyncOperationHandle<IList`1<AsyncOperationHandle>> m_DepOp; //Field offset: 0x7C
		private ResourceManager m_ResourceManager; //Field offset: 0x88
		private ISceneProvider2 m_provider; //Field offset: 0x8C

		protected virtual string DebugName
		{
			 get { } //Length: 215
		}

		protected virtual float Progress
		{
			 get { } //Length: 166
		}

		public SceneOp(ResourceManager rm, ISceneProvider2 provider) { }

		protected virtual void Destroy() { }

		protected virtual void Execute() { }

		protected virtual string get_DebugName() { }

		protected virtual float get_Progress() { }

		public virtual void GetDependencies(List<AsyncOperationHandle> deps) { }

		internal virtual DownloadStatus GetDownloadStatus(HashSet<Object> visited) { }

		public void Init(IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority, AsyncOperationHandle<IList`1<AsyncOperationHandle>> depOp) { }

		public void Init(IResourceLocation location, LoadSceneParameters loadSceneParameters, SceneReleaseMode releaseMode, bool activateOnLoad, int priority, AsyncOperationHandle<IList`1<AsyncOperationHandle>> depOp) { }

		private AsyncOperation InternalLoad(string path, bool loadingFromBundle, LoadSceneParameters loadSceneParameters) { }

		internal SceneInstance InternalLoadScene(IResourceLocation location, bool loadingFromBundle, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority) { }

		protected virtual bool InvokeWaitForCompletion() { }

		private override void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime) { }

	}

	private class UnloadSceneOp : AsyncOperationBase<SceneInstance>
	{
		private SceneInstance m_Instance; //Field offset: 0x58
		private AsyncOperationHandle<SceneInstance> m_sceneLoadHandle; //Field offset: 0x64
		private UnloadSceneOptions m_UnloadOptions; //Field offset: 0x70

		protected virtual float Progress
		{
			 get { } //Length: 55
		}

		public UnloadSceneOp() { }

		protected virtual void Execute() { }

		protected virtual float get_Progress() { }

		public void Init(AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions options) { }

		protected virtual bool InvokeWaitForCompletion() { }

		private void UnloadSceneCompleted(AsyncOperation obj) { }

	}


	public SceneProvider() { }

	public override AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneMode loadSceneMode, bool activateOnLoad, int priority) { }

	public override AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, bool activateOnLoad, int priority) { }

	public override AsyncOperationHandle<SceneInstance> ProvideScene(ResourceManager resourceManager, IResourceLocation location, LoadSceneParameters loadSceneParameters, SceneReleaseMode releaseMode, bool activateOnLoad, int priority) { }

	public override AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle) { }

	private override AsyncOperationHandle<SceneInstance> UnityEngine.ResourceManagement.ResourceProviders.ISceneProvider2.ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions) { }

}


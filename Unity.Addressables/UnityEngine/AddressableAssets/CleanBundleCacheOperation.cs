namespace UnityEngine.AddressableAssets;

internal class CleanBundleCacheOperation : AsyncOperationBase<Boolean>, IUpdateReceiver
{
	private AddressablesImpl m_Addressables; //Field offset: 0x50
	private AsyncOperationHandle<IList`1<AsyncOperationHandle>> m_DepOp; //Field offset: 0x54
	private List<String> m_CacheDirsForRemoval; //Field offset: 0x60
	private Thread m_EnumerationThread; //Field offset: 0x64
	private string m_BaseCachePath; //Field offset: 0x68
	private bool m_UseMultiThreading; //Field offset: 0x6C

	public CleanBundleCacheOperation(AddressablesImpl aa, bool forceSingleThreading) { }

	public void CompleteInternal(bool result, bool success, string errorMsg) { }

	protected virtual void Destroy() { }

	private void DetermineCacheDirsNotInUse(object data) { }

	private void DetermineCacheDirsNotInUse(HashSet<String> cacheDirsInUse) { }

	protected virtual void Execute() { }

	private HashSet<String> GetCacheDirsInUse(IList<AsyncOperationHandle> catalogOps) { }

	public virtual void GetDependencies(List<AsyncOperationHandle> dependencies) { }

	protected virtual bool InvokeWaitForCompletion() { }

	private void RemoveCacheEntries() { }

	public AsyncOperationHandle<Boolean> Start(AsyncOperationHandle<IList`1<AsyncOperationHandle>> depOp) { }

	private override void UnityEngine.ResourceManagement.IUpdateReceiver.Update(float unscaledDeltaTime) { }

}


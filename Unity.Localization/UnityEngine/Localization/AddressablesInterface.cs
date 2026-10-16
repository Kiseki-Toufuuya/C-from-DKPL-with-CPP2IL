namespace UnityEngine.Localization;

internal class AddressablesInterface
{
	private static AddressablesInterface s_Instance; //Field offset: 0x0

	public static AddressablesInterface Instance
	{
		 get { } //Length: 100
		 set { } //Length: 64
	}

	public static ResourceManager ResourceManager
	{
		 get { } //Length: 60
	}

	public AddressablesInterface() { }

	public static void Acquire(AsyncOperationHandle handle) { }

	internal override void AcquireInternal(AsyncOperationHandle handle) { }

	public static AsyncOperationHandle<IList`1<AsyncOperationHandle>> CreateGroupOperation(List<AsyncOperationHandle> asyncOperations) { }

	public static AddressablesInterface get_Instance() { }

	public static ResourceManager get_ResourceManager() { }

	internal override AsyncOperationHandle<IResourceLocator> InitializeAddressablesAsync() { }

	public static AsyncOperationHandle<TObject> LoadAssetFromGUID(string guid) { }

	internal override AsyncOperationHandle<TObject> LoadAssetFromGUIDInternal(string guid) { }

	public static AsyncOperationHandle<TObject> LoadAssetFromName(string name) { }

	internal override AsyncOperationHandle<TObject> LoadAssetFromNameInternal(string name) { }

	public static AsyncOperationHandle<IList`1<TObject>> LoadAssetsFromLocations(IList<IResourceLocation> locations, Action<TObject> callback) { }

	internal override AsyncOperationHandle<IList`1<TObject>> LoadAssetsFromLocationsInternal(IList<IResourceLocation> locations, Action<TObject> callback) { }

	public static AsyncOperationHandle<IList`1<TObject>> LoadAssetsWithLabel(string label, Action<TObject> callback) { }

	internal override AsyncOperationHandle<IList`1<TObject>> LoadAssetsWithLabelInternal(string label, Action<TObject> callback) { }

	public static AsyncOperationHandle<IList`1<IResourceLocation>> LoadResourceLocationsWithLabelsAsync(IEnumerable labels, MergeMode mode, Type type = null) { }

	internal override AsyncOperationHandle<IList`1<IResourceLocation>> LoadResourceLocationsWithLabelsAsyncInternal(IEnumerable labels, MergeMode mode, Type type = null) { }

	public static AsyncOperationHandle<TObject> LoadTableFromLocation(IResourceLocation location) { }

	internal override AsyncOperationHandle<TObject> LoadTableFromLocationInternal(IResourceLocation location) { }

	public static AsyncOperationHandle<IList`1<IResourceLocation>> LoadTableLocationsAsync(string tableName, LocaleIdentifier id, Type type) { }

	internal override AsyncOperationHandle<IList`1<IResourceLocation>> LoadTableLocationsAsyncInternal(string tableName, LocaleIdentifier id, Type type) { }

	public static void Release(AsyncOperationHandle handle) { }

	public static void ReleaseAndReset(ref AsyncOperationHandle<TObject>& handle) { }

	internal override void ReleaseInternal(AsyncOperationHandle handle) { }

	public static void SafeRelease(AsyncOperationHandle handle) { }

	public static void set_Instance(AddressablesInterface value) { }

}


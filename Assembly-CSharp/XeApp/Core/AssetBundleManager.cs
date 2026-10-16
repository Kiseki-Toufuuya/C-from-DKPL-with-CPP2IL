namespace XeApp.Core;

public class AssetBundleManager : SingletonBehaviour<AssetBundleManager>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass24_0
	{
		public string assetBundleName; //Field offset: 0x8
		public int loadingCount; //Field offset: 0xC

		public <>c__DisplayClass24_0() { }

		internal bool <LoadAssetBundleInternal>b__0(AssetBundle ab) { }

		internal bool <LoadAssetBundleInternal>b__1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public Action<SpriteAtlas> atlasAction; //Field offset: 0x8
		public AssetBundleRequest request; //Field offset: 0xC

		public <>c__DisplayClass44_0() { }

		internal void <AtlasRequested>b__0(AsyncOperation op) { }

	}

	[CompilerGenerated]
	private sealed class <UnloadAllAssetBundle>d__36 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <UnloadAllAssetBundle>d__36(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private class SpriteAtlasNameToBundleName
	{
		public string StartPrefix; //Field offset: 0x8
		public string PostReplcae; //Field offset: 0xC
		public string BaseDir; //Field offset: 0x10
		public string Suffix; //Field offset: 0x14

		public SpriteAtlasNameToBundleName() { }

	}

	private static AssetBundleManifest m_AssetBundleManifest; //Field offset: 0x0
	private static Dictionary<String, LoadedAssetBundle> m_LoadedAssetBundles; //Field offset: 0x4
	private static Dictionary<String, Object> m_LoadedAssetBundlesSimulate; //Field offset: 0x8
	private static Dictionary<String, Int32> m_lodingAssetBundle; //Field offset: 0xC
	private static Dictionary<String, String> m_lodingErrors; //Field offset: 0x10
	private static List<AssetBundleLoadOperation> m_InProgressOperations; //Field offset: 0x14
	private static Dictionary<String, String[]> m_Dependencies; //Field offset: 0x18
	public static bool isTutorialNow; //Field offset: 0x1C
	public static Dictionary<String, Int32> m_tutorialAssetMap; //Field offset: 0x20
	private static Dictionary<String, Object> AssetCacheMap; //Field offset: 0x24
	private static int cacheCounter; //Field offset: 0x28
	[CompilerGenerated]
	private static IAssetBundleFileLoader <AssetBundleFileLoader>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private static string <BaseAssetBundleInstallPath>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private static string <StreamingAssetBundlePath>k__BackingField; //Field offset: 0x34
	private static SpriteAtlasNameToBundleName[] settings; //Field offset: 0x38

	public static IAssetBundleFileLoader AssetBundleFileLoader
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		 set { } //Length: 89
	}

	public static string BaseAssetBundleInstallPath
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		 set { } //Length: 89
	}

	public static string StreamingAssetBundlePath
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		 set { } //Length: 89
	}

	private static AssetBundleManager() { }

	public AssetBundleManager() { }

	private void AtlasRequested(string spriteAtlasNameWithoutExtention, Action<SpriteAtlas> atlasAction) { }

	public static bool ChkLoadRequest(int loadRequestID) { }

	public static bool ChkLoadRequest(string assetBundleName) { }

	public static bool ChkLoadRequest() { }

	public static void CleanupAssetCache() { }

	[CompilerGenerated]
	public static IAssetBundleFileLoader get_AssetBundleFileLoader() { }

	[CompilerGenerated]
	public static string get_BaseAssetBundleInstallPath() { }

	[CompilerGenerated]
	public static string get_StreamingAssetBundlePath() { }

	public static object GetCachedAsset(string key) { }

	public static LoadedAssetBundle GetLoadedAssetBundle(string assetBundleName, out string error) { }

	public static bool IsLoadAssetBundle(string assetBundleName) { }

	public static AssetBundleLoadAllAssetOperationBase LoadAllAssetAsync(string assetBundleName) { }

	public static AssetBundleLoadAssetOperation LoadAssetAsync(string assetBundleName, string assetName, Type type, Action<AssetBundleLoadAssetOperation> end_load, bool enableErrorLog = true) { }

	protected static void LoadAssetBundle(string assetBundleName, bool isLoadingAssetBundleManifest = false) { }

	protected static bool LoadAssetBundleInternal(string assetBundleName) { }

	public static AssetBundleLoadAllAssetOperationBase LoadDecorationItemAssetAsync(string assetBundleName) { }

	[Conditional("USE_MANIFEST")]
	protected static void LoadDependencies(string assetBundleName) { }

	public static AssetBundleLoadLayoutOperationBase LoadLayoutAsync(string assetBundleName, string prefabName) { }

	public static ShaderAssetBundleLoadOperation LoadShaderAssetBundle(string assetBundleName) { }

	public static void LoadTutorialAssetsList() { }

	public static UnionAssetBundleLoadOperation LoadUnionAssetBundle(string assetBundleName) { }

	public static void LogError(string error) { }

	public static void LogInfo(string info) { }

	public static string MakeAssetBundlePath(string assetBundleName) { }

	public static string MakeAssetKey(string a, string b, Type type) { }

	private void OnDisable() { }

	private void OnEnable() { }

	[CompilerGenerated]
	public static void set_AssetBundleFileLoader(IAssetBundleFileLoader value) { }

	[CompilerGenerated]
	public static void set_BaseAssetBundleInstallPath(string value) { }

	[CompilerGenerated]
	public static void set_StreamingAssetBundlePath(string value) { }

	public static void SetCachedAsset(string key, object obj) { }

	[IteratorStateMachine(typeof(<UnloadAllAssetBundle>d__36))]
	public static IEnumerator UnloadAllAssetBundle() { }

	public static void UnloadAssetBundle(string assetBundleName, bool unloadAllLoadedObject = true) { }

	protected static void UnloadAssetBundleInternal(string assetBundleName, bool unloadAllLoadedObject = false) { }

	[Conditional("USE_MANIFEST")]
	protected static void UnloadDependencies(string assetBundleName) { }

	private void Update() { }

	public static void VisitLoadedAssetBundle(Action<String, Int32> onVisit) { }

}


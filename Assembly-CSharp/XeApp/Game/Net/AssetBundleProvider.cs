namespace XeApp.Game.Net;

public class AssetBundleProvider : IAssetBundleFileLoader
{
	[CompilerGenerated]
	private sealed class <Co_AsyncLoding>d__8 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string assetBundleName; //Field offset: 0x10
		public Func<Boolean> onFailed; //Field offset: 0x14
		public AssetBundleProvider <>4__this; //Field offset: 0x18
		public Func<AssetBundle, Boolean> onSuccess; //Field offset: 0x1C
		private AssetPathEntry <entry>5__2; //Field offset: 0x20
		private string <localPath>5__3; //Field offset: 0x24
		private SemaphoJob <sema>5__4; //Field offset: 0x28
		private AssetBundleCreateRequest <request>5__5; //Field offset: 0x2C

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
		public <Co_AsyncLoding>d__8(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <Co_AsyncLodingFromRawDir>d__10 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string assetBundleName; //Field offset: 0x10
		public Func<Boolean> onFailed; //Field offset: 0x14
		public Func<AssetBundle, Boolean> onSuccess; //Field offset: 0x18
		private string <rawAssetPath>5__2; //Field offset: 0x1C
		private SemaphoJob <sema>5__3; //Field offset: 0x20
		private AssetBundleCreateRequest <bundleLoadRequest>5__4; //Field offset: 0x24

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
		public <Co_AsyncLodingFromRawDir>d__10(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <Co_AsyncLodingFromStreamingAsset>d__9 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string assetBundleName; //Field offset: 0x10
		public Func<AssetBundle, Boolean> onSuccess; //Field offset: 0x14
		public Func<Boolean> onFailed; //Field offset: 0x18
		private string <streamingAssetPath>5__2; //Field offset: 0x1C
		private SemaphoJob <sema>5__3; //Field offset: 0x20
		private AssetBundleCreateRequest <request>5__4; //Field offset: 0x24

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
		public <Co_AsyncLodingFromStreamingAsset>d__9(int <>1__state) { }

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

	[CompilerGenerated]
	private sealed class <Validate>d__11 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public string assetBundleName; //Field offset: 0x10

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
		public <Validate>d__11(int <>1__state) { }

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

	public static bool LogEnable; //Field offset: 0x0
	private const int DOWNLOAD_OPTION_XAB_SALT_MASK = 4095; //Field offset: 0x0
	private static readonly Byte[] UnityHeader; //Field offset: 0x4
	private Dictionary<String, Stream> StreamMap; //Field offset: 0x8

	public static bool IsLoadFromRawData
	{
		 get { } //Length: 3
	}

	private static AssetBundleProvider() { }

	public AssetBundleProvider() { }

	[IteratorStateMachine(typeof(<Co_AsyncLoding>d__8))]
	private IEnumerator Co_AsyncLoding(string assetBundleName, Func<AssetBundle, Boolean> onSuccess, Func<Boolean> onFailed) { }

	[IteratorStateMachine(typeof(<Co_AsyncLodingFromRawDir>d__10))]
	private IEnumerator Co_AsyncLodingFromRawDir(string assetBundleName, Func<AssetBundle, Boolean> onSuccess, Func<Boolean> onFailed) { }

	[IteratorStateMachine(typeof(<Co_AsyncLodingFromStreamingAsset>d__9))]
	private IEnumerator Co_AsyncLodingFromStreamingAsset(string assetBundleName, Func<AssetBundle, Boolean> onSuccess, Func<Boolean> onFailed) { }

	public static bool get_IsLoadFromRawData() { }

	public bool IsEmbeddedBundle(string assetBundleName) { }

	public override void LoadRequest(string loadPath, string assetBundleName, Func<AssetBundle, Boolean> onSuccess, Func<Boolean> onFailed) { }

	public override void OnUnload(string assetBundleName) { }

	[IteratorStateMachine(typeof(<Validate>d__11))]
	public static IEnumerator Validate(string assetBundleName) { }

}


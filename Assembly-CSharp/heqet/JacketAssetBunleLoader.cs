namespace Heqet;

public class JacketAssetBunleLoader : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Action`1<AssetBundleLoadAssetOperation>, AssetBundleLoadAssetOperation> <>9__3_0; //Field offset: 0x4
		public static Action<Int32, Boolean> <>9__3_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal AssetBundleLoadAssetOperation <.ctor>b__3_0(int jacketId, Action<AssetBundleLoadAssetOperation> loadFunc) { }

		internal void <.ctor>b__3_1(int jacketId, bool unloadAllLoadedObject) { }

	}

	private ImageAssetBundleLoader<Int32> m_loader; //Field offset: 0x8

	public bool IsLoading
	{
		 get { } //Length: 64
	}

	public JacketAssetBunleLoader() { }

	public override void Dispose() { }

	public bool get_IsLoading() { }

	public void GetHeqetJacketImage(int jacketId, Action<AssetBundleLoadAssetOperation> onLoaded) { }

}


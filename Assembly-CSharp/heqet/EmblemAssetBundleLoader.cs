namespace Heqet;

public class EmblemAssetBundleLoader : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<Int32, Action`1<AssetBundleLoadAssetOperation>, AssetBundleLoadAssetOperation> <>9__1_0; //Field offset: 0x4
		public static Action<Int32, Boolean> <>9__1_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal AssetBundleLoadAssetOperation <.ctor>b__1_0(int id, Action<AssetBundleLoadAssetOperation> loadFunc) { }

		internal void <.ctor>b__1_1(int id, bool unloadAllLoadedObject) { }

	}

	private ImageAssetBundleLoader<Int32> m_loader; //Field offset: 0x8

	public EmblemAssetBundleLoader() { }

	public override void Dispose() { }

	public void GetEmblemIcon(int id, Action<AssetBundleLoadAssetOperation> onLoaded) { }

}


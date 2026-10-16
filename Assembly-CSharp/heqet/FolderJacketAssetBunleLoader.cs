namespace Heqet;

public class FolderJacketAssetBunleLoader : IDisposable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Action<Int32, Boolean> <>9__4_1; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <.ctor>b__4_1(int jacketId, bool unloadAllLoadedObject) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public FolderJacketAssetBunleLoader <>4__this; //Field offset: 0x8
		public int jacketId; //Field offset: 0xC
		public Action<AssetBundleLoadAssetOperation> onLoaded; //Field offset: 0x10

		public <>c__DisplayClass6_0() { }

		internal void <GetHeqetFolderJacketImage>b__0(AssetBundleLoadAssetOperation loadFunc) { }

	}

	private ImageAssetBundleLoader<Int32> m_loader; //Field offset: 0x8
	private string m_langCode; //Field offset: 0xC

	public bool IsLoading
	{
		 get { } //Length: 64
	}

	public FolderJacketAssetBunleLoader() { }

	[CompilerGenerated]
	private AssetBundleLoadAssetOperation <.ctor>b__4_0(int jacketId, Action<AssetBundleLoadAssetOperation> loadFunc) { }

	public override void Dispose() { }

	public bool get_IsLoading() { }

	public void GetHeqetFolderJacketImage(int jacketId, Action<AssetBundleLoadAssetOperation> onLoaded) { }

}


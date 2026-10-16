namespace D4L.TakashoFes.DataContext;

public sealed class AssetPathContext
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public AssetPathContext <>4__this; //Field offset: 0x8
		public IDataStorage rawAssetLoader; //Field offset: 0xC

		public <>c__DisplayClass14_0() { }

		internal void <LoadAsync>b__0() { }

	}

	private string variant; //Field offset: 0x8
	private readonly IAssetPathAccessor _AssetPath; //Field offset: 0xC
	private bool isDataStorageLoaded; //Field offset: 0x10
	private bool isRemoteStorageLoaded; //Field offset: 0x11

	public override IAssetPathAccessor AssetPath
	{
		 get { } //Length: 11
	}

	public AssetPathContext(string variant = null) { }

	public override IAssetPathAccessor get_AssetPath() { }

	public override void Load(IDataStorage rawAssetLoader) { }

	public override Task LoadAsync(IDataStorage rawAssetLoader) { }

}


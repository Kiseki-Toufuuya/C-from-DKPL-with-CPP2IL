namespace D4L.TakashoFes.DataContext;

public sealed class ErrorDataContext
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public ErrorDataContext <>4__this; //Field offset: 0x8
		public IDataStorage rawAssetLoader; //Field offset: 0xC

		public <>c__DisplayClass14_0() { }

		internal void <LoadAsync>b__0() { }

	}

	private string variant; //Field offset: 0x8
	private readonly IErrorMessageAccessor _ErrorMessage; //Field offset: 0xC
	private bool isDataStorageLoaded; //Field offset: 0x10
	private bool isRemoteStorageLoaded; //Field offset: 0x11

	public override IErrorMessageAccessor ErrorMessage
	{
		 get { } //Length: 11
	}

	public ErrorDataContext(string variant = null) { }

	public override IErrorMessageAccessor get_ErrorMessage() { }

	public override void Load(IDataStorage rawAssetLoader) { }

	public override Task LoadAsync(IDataStorage rawAssetLoader) { }

}


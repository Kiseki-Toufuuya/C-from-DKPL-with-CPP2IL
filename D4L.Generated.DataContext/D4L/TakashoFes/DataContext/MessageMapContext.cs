namespace D4L.TakashoFes.DataContext;

public sealed class MessageMapContext : IMessageMapContext
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public MessageMapContext <>4__this; //Field offset: 0x8
		public IDataStorage rawAssetLoader; //Field offset: 0xC

		public <>c__DisplayClass14_0() { }

		internal void <LoadAsync>b__0() { }

	}

	private string variant; //Field offset: 0x8
	private readonly IMessageMapAccessor _MessageMap; //Field offset: 0xC
	private bool isDataStorageLoaded; //Field offset: 0x10
	private bool isRemoteStorageLoaded; //Field offset: 0x11

	public override IMessageMapAccessor MessageMap
	{
		 get { } //Length: 11
	}

	public MessageMapContext(string variant = null) { }

	public override IMessageMapAccessor get_MessageMap() { }

	public override void Load(IDataStorage rawAssetLoader) { }

	public override Task LoadAsync(IDataStorage rawAssetLoader) { }

}


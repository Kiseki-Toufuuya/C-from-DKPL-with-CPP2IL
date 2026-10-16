namespace D4L.Dao;

public abstract class FlatBuffersAccessorBase : IFlatBuffersAccessor<TDao, TEntry, TIdentity>, IDaoAccessor<TDao, TEntry, TIdentity>
{
	[CompilerGenerated]
	private LocalStorageKey <Key>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private TDao <Dao>k__BackingField; //Field offset: 0x0

	public override TDao Dao
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public override TEntry[] Entries
	{
		 get { } //Length: 64
	}

	public override LocalStorageKey Key
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 34
	}

	protected FlatBuffersAccessorBase`3() { }

	public override TEntry Get(TIdentity id) { }

	public override IEnumerable<TEntry> Get(IEnumerable<TIdentity> ids) { }

	[CompilerGenerated]
	public override TDao get_Dao() { }

	public override TEntry[] get_Entries() { }

	[CompilerGenerated]
	public override LocalStorageKey get_Key() { }

	public override IEnumerable<TEntry> GetAll() { }

	public override TDao Load(IDataStorage loader, string variant) { }

	protected override TDao Parse(Byte[] bytes) { }

	[CompilerGenerated]
	public void set_Dao(TDao value) { }

	[CompilerGenerated]
	public void set_Key(LocalStorageKey value) { }

}


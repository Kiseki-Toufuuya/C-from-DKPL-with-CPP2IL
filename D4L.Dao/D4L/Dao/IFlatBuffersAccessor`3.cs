namespace D4L.Dao;

public interface IFlatBuffersAccessor : IDaoAccessor<TDao, TEntry, TIdentity>
{

	public TEntry[] Entries
	{
		 get { } //Length: 0
	}

	public TEntry[] get_Entries() { }

	public TDao Load(IDataStorage loader, string variant = null) { }

}


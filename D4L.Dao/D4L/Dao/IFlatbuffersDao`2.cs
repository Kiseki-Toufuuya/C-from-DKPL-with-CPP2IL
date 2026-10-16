namespace D4L.Dao;

public interface IFlatbuffersDao
{

	public TEntry[] Entries
	{
		 get { } //Length: 0
	}

	public TEntry Get(TIdentity id) { }

	public IEnumerable<TEntry> Get(IEnumerable<TIdentity> ids) { }

	public TEntry[] get_Entries() { }

	public IEnumerable<TEntry> GetAll() { }

}


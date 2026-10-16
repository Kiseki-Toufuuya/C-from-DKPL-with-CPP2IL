namespace D4L.Dao;

public interface IDaoAccessor
{

	public TEntry Get(TIdentity id) { }

	public IEnumerable<TEntry> GetAll() { }

}


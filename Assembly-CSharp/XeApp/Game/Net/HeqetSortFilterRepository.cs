namespace XeApp.Game.Net;

public class HeqetSortFilterRepository : IRepository<HeqetSortFilterModel, Int32>
{
	private HeqetSortFilterScriptableObject m_scriptableObject; //Field offset: 0x8

	public HeqetSortFilterRepository(HeqetSortFilterScriptableObject scriptableObject) { }

	public override HeqetSortFilterModel Get(int id) { }

	public IList<HeqetSortFilterModel> GetAll(bool test = false) { }

	public int GetCount() { }

	public override IList<HeqetSortFilterModel> GetList(IEnumerable<Int32> ids) { }

	private HeqetSortFilterModel GetModelById(int id) { }

}


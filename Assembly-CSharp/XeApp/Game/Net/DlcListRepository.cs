namespace XeApp.Game.Net;

public class DlcListRepository : IRepository<DlcListModel, Int32>
{
	private DlcListScriptableObject m_scriptableObject; //Field offset: 0x8

	public DlcListRepository(DlcListScriptableObject scriptableObject) { }

	public override DlcListModel Get(int id) { }

	public IList<DlcListModel> GetAll() { }

	public int GetCount() { }

	public override IList<DlcListModel> GetList(IEnumerable<Int32> ids) { }

	private DlcListModel GetModelById(int id) { }

	public int TotalCount() { }

}


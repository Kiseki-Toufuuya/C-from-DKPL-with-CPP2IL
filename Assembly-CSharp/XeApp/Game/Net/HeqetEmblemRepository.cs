namespace XeApp.Game.Net;

public class HeqetEmblemRepository : IRepository<HeqetEmblemModel, Int32>
{
	private HeqetEmblemScriptableObject m_scriptableObject; //Field offset: 0x8

	public HeqetEmblemRepository(HeqetEmblemScriptableObject scriptableObject) { }

	public override HeqetEmblemModel Get(int id) { }

	public IList<HeqetEmblemModel> GetAll(bool test = false) { }

	public override IList<HeqetEmblemModel> GetList(IEnumerable<Int32> ids) { }

	private HeqetEmblemModel GetModelById(int id) { }

	public int TotalCount() { }

}


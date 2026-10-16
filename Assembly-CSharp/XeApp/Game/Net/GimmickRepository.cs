namespace XeApp.Game.Net;

public class GimmickRepository : IRepository<GimmickModel, Int32>
{
	private GimmickScriptableObject m_scriptableObject; //Field offset: 0x8

	public GimmickRepository(GimmickScriptableObject scriptableObject) { }

	public override GimmickModel Get(int id) { }

	public override IList<GimmickModel> GetList(IEnumerable<Int32> ids) { }

	private GimmickModel GetModelById(int id) { }

}


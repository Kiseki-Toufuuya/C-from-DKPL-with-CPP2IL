namespace XeApp.Game.Net;

public class IngameBGRepository : IRepository<IngameBGModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private IngameBGScriptableObject m_scriptableObject; //Field offset: 0xC

	public IngameBGRepository(IngameBGScriptableObject scriptableObject) { }

	public override IngameBGModel Get(int id) { }

	public override IList<IngameBGModel> GetList(IEnumerable<Int32> ids) { }

	private IngameBGModel GetModelById(int id) { }

}


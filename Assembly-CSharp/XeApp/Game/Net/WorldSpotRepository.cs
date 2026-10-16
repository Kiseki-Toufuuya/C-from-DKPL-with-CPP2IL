namespace XeApp.Game.Net;

public class WorldSpotRepository : IRepository<WorldSpotModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private WorldSpotScriptableObject m_scriptableObject; //Field offset: 0xC

	public WorldSpotRepository(WorldSpotScriptableObject scriptableObject) { }

	public override WorldSpotModel Get(int id) { }

	public IList<WorldSpotModel> GetAll() { }

	public IList<WorldSpotModel> GetByAreaId(int areaId) { }

	public override IList<WorldSpotModel> GetList(IEnumerable<Int32> ids) { }

	private WorldSpotModel GetModelById(int id) { }

}


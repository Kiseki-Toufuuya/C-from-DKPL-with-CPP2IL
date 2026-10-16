namespace XeApp.Game.Net;

public class WorldAreaRepository : IRepository<WorldAreaModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private WorldAreaScriptableObject m_scriptableObject; //Field offset: 0xC

	public WorldAreaRepository(WorldAreaScriptableObject scriptableObject) { }

	public override WorldAreaModel Get(int id) { }

	public IList<WorldAreaModel> GetAll() { }

	public override IList<WorldAreaModel> GetList(IEnumerable<Int32> ids) { }

	private WorldAreaModel GetModelById(int id) { }

}


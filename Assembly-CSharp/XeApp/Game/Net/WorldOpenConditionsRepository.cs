namespace XeApp.Game.Net;

public class WorldOpenConditionsRepository : IRepository<WorldOpenConditionsModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private WorldOpenConditionsScriptableObject m_scriptableObject; //Field offset: 0xC

	public WorldOpenConditionsRepository(WorldOpenConditionsScriptableObject scriptableObject) { }

	public override WorldOpenConditionsModel Get(int id) { }

	public override IList<WorldOpenConditionsModel> GetList(IEnumerable<Int32> ids) { }

	private WorldOpenConditionsModel GetModelById(int id) { }

}


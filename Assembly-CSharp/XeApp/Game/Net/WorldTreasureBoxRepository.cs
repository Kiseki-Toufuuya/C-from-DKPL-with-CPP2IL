namespace XeApp.Game.Net;

public class WorldTreasureBoxRepository : IRepository<WorldTreasureBoxModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private WorldTreasureBoxScriptableObject m_scriptableObject; //Field offset: 0xC

	public WorldTreasureBoxRepository(WorldTreasureBoxScriptableObject scriptableObject) { }

	public override WorldTreasureBoxModel Get(int id) { }

	public override IList<WorldTreasureBoxModel> GetList(IEnumerable<Int32> ids) { }

	private WorldTreasureBoxModel GetModelById(int id) { }

	public WorldTreasureBoxModel GetStageItem(int stageId) { }

}


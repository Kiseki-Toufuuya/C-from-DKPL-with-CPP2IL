namespace XeApp.Game.Net;

public class WorldStageRepository : IRepository<WorldStageModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private WorldStageScriptableObject m_scriptableObject; //Field offset: 0xC

	public WorldStageRepository(WorldStageScriptableObject scriptableObject) { }

	public override WorldStageModel Get(int id) { }

	public IList<WorldStageModel> GetAll() { }

	public IList<WorldStageModel> GetBySpotId(int spotId) { }

	public override IList<WorldStageModel> GetList(IEnumerable<Int32> ids) { }

	private WorldStageModel GetModelById(int id) { }

}


namespace XeApp.Game.Net;

public class WorldBoosterRepository : IRepository<WorldBoosterModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private WorldBoosterScriptableObject m_scriptableObject; //Field offset: 0xC

	public WorldBoosterRepository(WorldBoosterScriptableObject scriptableObject) { }

	public override WorldBoosterModel Get(int id) { }

	public override IList<WorldBoosterModel> GetList(IEnumerable<Int32> ids) { }

	private WorldBoosterModel GetModelById(int id) { }

	public IList<WorldBoosterModel> GetRythmGameTypeItem(RythmGameType rythmGameType) { }

}


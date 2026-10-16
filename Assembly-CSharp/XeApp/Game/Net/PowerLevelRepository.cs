namespace XeApp.Game.Net;

public class PowerLevelRepository : IRepository<PowerLevelModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private PowerLevelScriptableObject m_scriptableObject; //Field offset: 0xC

	public PowerLevelRepository(PowerLevelScriptableObject scriptableObject) { }

	public override PowerLevelModel Get(int id) { }

	public override IList<PowerLevelModel> GetList(IEnumerable<Int32> ids) { }

	private PowerLevelModel GetModelById(int id) { }

}


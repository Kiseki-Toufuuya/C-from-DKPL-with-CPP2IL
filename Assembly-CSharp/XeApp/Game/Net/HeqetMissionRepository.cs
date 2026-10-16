namespace XeApp.Game.Net;

public class HeqetMissionRepository : IRepository<HeqetMissionModel, Int32>
{
	private HeqetMissionScriptableObject m_scriptableObject; //Field offset: 0x8

	public HeqetMissionRepository(HeqetMissionScriptableObject scriptableObject) { }

	public override HeqetMissionModel Get(int id) { }

	public override IList<HeqetMissionModel> GetList(IEnumerable<Int32> ids) { }

	private HeqetMissionModel GetModelById(int id) { }

}


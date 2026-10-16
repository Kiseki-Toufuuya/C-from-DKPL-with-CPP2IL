namespace XeApp.Game.Net;

public class StatusIconsRepository : IRepository<StatusIconsModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private StatusIconsScriptableObject m_scriptableObject; //Field offset: 0xC

	public StatusIconsRepository(StatusIconsScriptableObject scriptableObject) { }

	public override StatusIconsModel Get(int id) { }

	public override IList<StatusIconsModel> GetList(IEnumerable<Int32> ids) { }

	private StatusIconsModel GetModelById(int id) { }

	public bool GetStatus(int id) { }

	public bool SetStatus(int id, bool value) { }

}


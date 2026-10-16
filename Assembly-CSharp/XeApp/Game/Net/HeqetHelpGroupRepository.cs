namespace XeApp.Game.Net;

public class HeqetHelpGroupRepository : IRepository<HeqetHelpGroupModel, Int32>
{
	private HeqetHelpPageScriptableObject m_pageScriptableObject; //Field offset: 0x8
	private HeqetHelpGroupScriptableObject m_groupScriptableObject; //Field offset: 0xC

	public HeqetHelpGroupRepository(HeqetHelpPageScriptableObject page, HeqetHelpGroupScriptableObject group) { }

	public override HeqetHelpGroupModel Get(int id) { }

	public IList<HeqetHelpGroupModel> GetAll(bool test = false) { }

	public override IList<HeqetHelpGroupModel> GetList(IEnumerable<Int32> ids) { }

	private HeqetHelpGroupModel GetModelById(int id) { }

}


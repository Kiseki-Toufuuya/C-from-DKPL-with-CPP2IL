namespace XeApp.Game.Net;

public class NotesJudgeRepository : IRepository<NotesJudgeModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private NotesJudgeScriptableObject m_scriptableObject; //Field offset: 0xC

	public NotesJudgeRepository(NotesJudgeScriptableObject scriptableObject) { }

	public override NotesJudgeModel Get(int id) { }

	public override IList<NotesJudgeModel> GetList(IEnumerable<Int32> ids) { }

	private NotesJudgeModel GetModelById(int id) { }

}


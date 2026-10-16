namespace XeApp.Game.Net;

public class NotesSkinRepository : IRepository<NotesSkinModel, Int32>
{
	private NotesSkinScriptableObject m_scriptableObject; //Field offset: 0x8

	public NotesSkinRepository(NotesSkinScriptableObject scriptableObject) { }

	public override NotesSkinModel Get(int id) { }

	public int GetCount() { }

	public override IList<NotesSkinModel> GetList(IEnumerable<Int32> ids) { }

	private NotesSkinModel GetModelById(int id) { }

	public List<NotesSkinModel> GetUserSettingNotesSkinList() { }

}


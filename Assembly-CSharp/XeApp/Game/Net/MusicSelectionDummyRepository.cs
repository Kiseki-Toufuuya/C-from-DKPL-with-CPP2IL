namespace XeApp.Game.Net;

public class MusicSelectionDummyRepository : IRepository<MusicSelectionDummyModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private MusicSelectionDummyScriptableObject m_scriptableObject; //Field offset: 0xC

	public MusicSelectionDummyRepository(MusicSelectionDummyScriptableObject scriptableObject) { }

	public override MusicSelectionDummyModel Get(int id) { }

	public IList<MusicSelectionDummyModel> GetAll() { }

	public override IList<MusicSelectionDummyModel> GetList(IEnumerable<Int32> ids) { }

	private MusicSelectionDummyModel GetModelById(int id) { }

}


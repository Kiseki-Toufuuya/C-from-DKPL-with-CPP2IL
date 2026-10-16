namespace XeApp.Game.Net;

public class HeqetMusicSelectionRepository : IRepository<HeqetMusicSelectionModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private HeqetMusicSelectionScriptableObject m_scriptableObject; //Field offset: 0xC

	public HeqetMusicSelectionRepository(HeqetMusicSelectionScriptableObject scriptableObject) { }

	public override HeqetMusicSelectionModel Get(int id) { }

	public IList<HeqetMusicSelectionModel> GetAll() { }

	public override IList<HeqetMusicSelectionModel> GetList(IEnumerable<Int32> ids) { }

	private HeqetMusicSelectionModel GetModelById(int id) { }

}


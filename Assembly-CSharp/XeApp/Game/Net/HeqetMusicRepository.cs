namespace XeApp.Game.Net;

public class HeqetMusicRepository : IRepository<HeqetMusicModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private HeqetMusicScriptableObject m_scriptableObject; //Field offset: 0xC

	public HeqetMusicRepository(HeqetMusicScriptableObject scriptableObject) { }

	public override HeqetMusicModel Get(int id) { }

	public List<HeqetMusicModel> GetAll(bool test = false) { }

	public override IList<HeqetMusicModel> GetList(IEnumerable<Int32> ids) { }

	private HeqetMusicModel GetModelById(int id) { }

}


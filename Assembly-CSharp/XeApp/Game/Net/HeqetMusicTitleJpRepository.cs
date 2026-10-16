namespace XeApp.Game.Net;

public class HeqetMusicTitleJpRepository : IRepository<HeqetMusicTitleJpModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private HeqetMusicScriptableObject m_scriptableObject; //Field offset: 0xC

	public HeqetMusicTitleJpRepository(HeqetMusicScriptableObject scriptableObject) { }

	public override HeqetMusicTitleJpModel Get(int id) { }

	public IList<HeqetMusicTitleJpModel> GetAll() { }

	public override IList<HeqetMusicTitleJpModel> GetList(IEnumerable<Int32> ids) { }

	private HeqetMusicTitleJpModel GetModelById(int id) { }

}


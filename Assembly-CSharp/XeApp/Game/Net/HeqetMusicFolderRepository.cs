namespace XeApp.Game.Net;

public class HeqetMusicFolderRepository : IRepository<HeqetMusicFolderModel, Int32>
{
	private HeqetMusicFolderScriptableObject m_scriptableObject; //Field offset: 0x8

	public HeqetMusicFolderRepository(HeqetMusicFolderScriptableObject scriptableObject) { }

	public override HeqetMusicFolderModel Get(int id) { }

	public IList<HeqetMusicFolderModel> GetAll(bool checkEnable) { }

	public override IList<HeqetMusicFolderModel> GetList(IEnumerable<Int32> ids) { }

	private HeqetMusicFolderModel GetModelById(int id) { }

}


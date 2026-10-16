namespace XeApp.Game.Net;

public class MusicLevelFactorRepository : IRepository<MusicLevelFactorModel, Int32>
{
	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private MusicLevelFactorScriptableObject m_scriptableObject; //Field offset: 0xC

	public MusicLevelFactorRepository(MusicLevelFactorScriptableObject scriptableObject) { }

	public override MusicLevelFactorModel Get(int id) { }

	public override IList<MusicLevelFactorModel> GetList(IEnumerable<Int32> ids) { }

	private MusicLevelFactorModel GetModelById(int id) { }

	public float GetMusicLevelFactor(int musicLevel) { }

}


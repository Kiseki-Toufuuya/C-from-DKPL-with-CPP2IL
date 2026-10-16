namespace XeApp.Game.Net;

public class MusicScoreRepository : IRepository<MusicScoreModel, Int32>
{
	private MusicScoreScriptableObject m_scriptableObject; //Field offset: 0x8

	public MusicScoreRepository(MusicScoreScriptableObject scriptableObject) { }

	[CompilerGenerated]
	private MusicScoreModel <GetAll>b__5_0(Data entry) { }

	public override MusicScoreModel Get(int id) { }

	public List<MusicScoreModel> GetAll() { }

	public MusicScoreModel GetFromMusicID(int musicId, int difficalty) { }

	public override IList<MusicScoreModel> GetList(IEnumerable<Int32> ids) { }

	private MusicScoreModel GetModelById(int id) { }

}


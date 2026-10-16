namespace XeApp.Game.Net;

public class EpisodeRepository : IRepository<EpisodeModel, Int32>
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public EpisodeRepository <>4__this; //Field offset: 0x8
		public int targetDataVersion; //Field offset: 0xC
		public int targetEnable; //Field offset: 0x10

		public <>c__DisplayClass4_0() { }

		internal EpisodeModel <GetAll>b__0(EpisodeEntry entry) { }

		internal bool <GetAll>b__1(EpisodeModel entry) { }

	}

	private DefaultMasterDataContext m_context; //Field offset: 0x8

	public EpisodeRepository(DefaultMasterDataContext context) { }

	public override EpisodeModel Get(int id) { }

	public List<EpisodeModel> GetAll(bool test = false) { }

	public override IList<EpisodeModel> GetList(IEnumerable<Int32> ids) { }

	private EpisodeModel GetModelById(int id) { }

}


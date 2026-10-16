namespace XeApp.Game.Net;

public class ExScoreRepository : IRepository<ExScoreModel, Int32>
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Data> <>9__7_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <GetList>b__7_0(Data a, Data b) { }

	}

	private DefaultMasterDataContext m_context; //Field offset: 0x8
	private ExScoreScriptableObject m_scriptableObject; //Field offset: 0xC
	private List<Data> sortedList; //Field offset: 0x10

	public ExScoreRepository(ExScoreScriptableObject scriptableObject) { }

	public int CalcExScore(List<NotesRecordData> notes, bool isExpert = false) { }

	public int CalcExScore(NotesRecordData notes, bool isExpert = false) { }

	public List<Int32> CalcExScoreList(List<NotesRecordData> notes, bool isExpert = false) { }

	public override ExScoreModel Get(int id) { }

	public override IList<ExScoreModel> GetList(IEnumerable<Int32> ids) { }

	public List<Data> GetList() { }

	private ExScoreModel GetModelById(int id) { }

}


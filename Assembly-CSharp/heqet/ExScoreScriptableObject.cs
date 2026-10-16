namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/ExScoreRepository")]
[MovedFrom(False, null, null, "ExScoreRepository")]
public class ExScoreScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public float JudgeTiming; //Field offset: 0xC
		public Int32[] ExScores; //Field offset: 0x10

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC

	public List<Data> EntityList
	{
		 get { } //Length: 11
	}

	public ExScoreScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_EntityList() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


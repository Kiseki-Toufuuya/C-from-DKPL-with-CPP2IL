namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/NotesJudgeRepository")]
[MovedFrom(False, null, null, "NotesJudgeRepository")]
public class NotesJudgeScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public string Name; //Field offset: 0xC
		public Single[] JudgeTimings; //Field offset: 0x10
		public float ScoreFactor; //Field offset: 0x14

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC

	public NotesJudgeScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


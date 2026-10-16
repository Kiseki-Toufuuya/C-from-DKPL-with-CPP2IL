namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/RecommendCardRepository")]
[MovedFrom(False, null, null, "RecommendCardRepository")]
public class RecommendCardScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public Int32[] Mission1; //Field offset: 0xC
		public Int32[] Mission2; //Field offset: 0x10
		public Int32[] Gimmick1; //Field offset: 0x14
		public Int32[] Gimmick2; //Field offset: 0x18
		public Int32[] Gimmick3; //Field offset: 0x1C
		public Int32[] StageClear; //Field offset: 0x20

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public RecommendCardScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


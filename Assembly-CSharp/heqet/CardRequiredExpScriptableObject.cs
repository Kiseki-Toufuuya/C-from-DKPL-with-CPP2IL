namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/CardRequiredExpRepository")]
[MovedFrom(False, null, null, "CardRequiredExpRepository")]
public class CardRequiredExpScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public int Level; //Field offset: 0xC
		public int RequiredExpFast1; //Field offset: 0x10
		public int RequiredExpFast2; //Field offset: 0x14
		public int RequiredExpLate1; //Field offset: 0x18
		public int RequiredExpLate2; //Field offset: 0x1C

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public CardRequiredExpScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


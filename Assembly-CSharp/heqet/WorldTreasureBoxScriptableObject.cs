namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/WorldTreasureBoxRepository")]
[MovedFrom(False, null, null, "WorldTreasureBoxRepository")]
public class WorldTreasureBoxScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public int StageID; //Field offset: 0xC
		public ItemType ItemTypeID; //Field offset: 0x10
		public int ItemID; //Field offset: 0x14

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public WorldTreasureBoxScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


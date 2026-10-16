namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/WorldBoosterRepository")]
[MovedFrom(False, null, null, "WorldBoosterRepository")]
public class WorldBoosterScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public string Name; //Field offset: 0xC
		public string NameYomi; //Field offset: 0x10
		public int ImageID; //Field offset: 0x14
		public string Description; //Field offset: 0x18
		public int ItemGimmickID; //Field offset: 0x1C
		public int Price; //Field offset: 0x20
		public CategoryType CategoryTypeID; //Field offset: 0x24

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public WorldBoosterScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


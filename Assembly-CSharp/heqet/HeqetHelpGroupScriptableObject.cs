namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/HeqetHelpGroupScriptableObject")]
[MovedFrom(False, null, null, "HeqetHelpGroupScriptableObject")]
public class HeqetHelpGroupScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public int SortNo; //Field offset: 0xC
		public string Name; //Field offset: 0x10
		public Int32[] Pages; //Field offset: 0x14
		public bool Hidden; //Field offset: 0x18
		public long FirstMaskFlag; //Field offset: 0x20

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public HeqetHelpGroupScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


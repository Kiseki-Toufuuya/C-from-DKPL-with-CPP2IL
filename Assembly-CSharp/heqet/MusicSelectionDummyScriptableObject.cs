namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/MusicSelectionDummy")]
[MovedFrom(False, null, null, "MusicSelection")]
public class MusicSelectionDummyScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public string Title; //Field offset: 0xC
		public string TitleYomi; //Field offset: 0x10
		public Int64[] MusicIds; //Field offset: 0x14
		public int SortNo; //Field offset: 0x18
		public int CoverId; //Field offset: 0x1C
		public int BackGroundId; //Field offset: 0x20
		public int Cost; //Field offset: 0x24

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public MusicSelectionDummyScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


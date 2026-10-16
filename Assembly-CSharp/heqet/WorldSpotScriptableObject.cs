namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/WorldSpotRepository")]
public class WorldSpotScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public int DlcID; //Field offset: 0xC
		public int AreaID; //Field offset: 0x10
		public int SortNo; //Field offset: 0x14
		public string Name; //Field offset: 0x18
		public string NameYomi; //Field offset: 0x1C
		public int OpenConditionsID; //Field offset: 0x20
		public int Thumbnail; //Field offset: 0x24
		public string FlavorText; //Field offset: 0x28
		public int RenaissanceEffectID; //Field offset: 0x2C
		public int ArrivalEpisodeID; //Field offset: 0x30
		public int OpenEffectID; //Field offset: 0x34
		public int RenaissanceConditionsID; //Field offset: 0x38
		public int MarisaEpisodeID; //Field offset: 0x3C

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public WorldSpotScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


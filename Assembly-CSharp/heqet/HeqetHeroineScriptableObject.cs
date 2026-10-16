namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/HeqetHeroineRepository")]
[MovedFrom(False, null, null, "HeqetHeroineRepository")]
public class HeqetHeroineScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public int DlcID; //Field offset: 0xC
		public bool ListDisplay; //Field offset: 0x10
		public int Number; //Field offset: 0x14
		public string SecondName; //Field offset: 0x18
		public string Name; //Field offset: 0x1C
		public string NameYomi; //Field offset: 0x20
		public string IllustratorName; //Field offset: 0x24
		public string FlavorText; //Field offset: 0x28
		public int DanmakuID; //Field offset: 0x2C
		public int SkillType; //Field offset: 0x30
		public Int32[] SkinArray; //Field offset: 0x34
		public Int32[] SeriesArray; //Field offset: 0x38

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public HeqetHeroineScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


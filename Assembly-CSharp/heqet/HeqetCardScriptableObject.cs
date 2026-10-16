namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/HeqetCardRepository")]
[MovedFrom(False, null, null, "HeqetCardRepository")]
public class HeqetCardScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public int Number; //Field offset: 0xC
		public int HeroineID; //Field offset: 0x10
		public int ImageID; //Field offset: 0x14
		public int Rarity; //Field offset: 0x18
		public eAttribute Attribute; //Field offset: 0x1C
		public int PlayerStock; //Field offset: 0x20
		public int BombStock; //Field offset: 0x24
		public int CardSkilID; //Field offset: 0x28
		public string SecondName; //Field offset: 0x2C
		public string IllustratorName; //Field offset: 0x30
		public string FlavorText; //Field offset: 0x34
		public int SkillType; //Field offset: 0x38
		public int GrowthType; //Field offset: 0x3C
		public int LifeMin; //Field offset: 0x40
		public int LifeMax; //Field offset: 0x44
		public int PowerMin; //Field offset: 0x48
		public int PowerMax; //Field offset: 0x4C

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public HeqetCardScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


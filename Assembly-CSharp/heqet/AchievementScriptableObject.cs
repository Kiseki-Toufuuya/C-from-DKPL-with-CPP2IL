namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/AchievementRepository")]
[MovedFrom(False, null, null, "AchievementRepository")]
public class AchievementScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public string Name; //Field offset: 0xC
		public string Description; //Field offset: 0x10
		public string Reward; //Field offset: 0x14
		public int ImageID; //Field offset: 0x18
		public int HiddenElement; //Field offset: 0x1C
		public int SkillType; //Field offset: 0x20
		public ItemType ItemTypeID; //Field offset: 0x24
		public int ItemID; //Field offset: 0x28
		public int BuffID; //Field offset: 0x2C
		public string SteamApiName; //Field offset: 0x30
		public int PS4trophy; //Field offset: 0x34

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public AchievementScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/SkillRepository")]
[MovedFrom(False, null, null, "SkillRepository")]
public class SkillScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public string Name; //Field offset: 0xC
		public string Description; //Field offset: 0x10
		public int GimmickID1; //Field offset: 0x14
		public int GimmickID2; //Field offset: 0x18
		public int GimmickID3; //Field offset: 0x1C

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public SkillScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


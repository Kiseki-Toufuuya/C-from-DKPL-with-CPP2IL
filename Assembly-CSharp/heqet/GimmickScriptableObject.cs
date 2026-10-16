namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/GimmickRepository")]
[MovedFrom(False, null, null, "GimmickRepository")]
public class GimmickScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public int ImageID; //Field offset: 0xC
		public string Name; //Field offset: 0x10
		public int EffectID; //Field offset: 0x14
		public float Param1; //Field offset: 0x18
		public float Param2; //Field offset: 0x1C
		public float Param3; //Field offset: 0x20

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public GimmickScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


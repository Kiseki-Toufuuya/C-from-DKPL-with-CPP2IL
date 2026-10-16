namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/WorldOpenConditionsRepository")]
public class WorldOpenConditionsScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public OpenConditionType OpenConditionTypeID; //Field offset: 0xC
		public Int32[] Params; //Field offset: 0x10

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public WorldOpenConditionsScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


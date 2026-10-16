namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/StatusIconsRepository")]
[MovedFrom(False, null, null, "StatusIconsRepository")]
public class StatusIconsScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public string ImageID; //Field offset: 0xC

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public StatusIconsScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


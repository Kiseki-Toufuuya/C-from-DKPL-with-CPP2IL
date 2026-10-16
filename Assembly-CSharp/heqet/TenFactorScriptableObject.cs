namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/TenFactorRepository")]
[MovedFrom(False, null, null, "TenFactorRepository")]
public class TenFactorScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public int Min; //Field offset: 0xC
		public int Max; //Field offset: 0x10
		public float TenFactor; //Field offset: 0x14

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public TenFactorScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


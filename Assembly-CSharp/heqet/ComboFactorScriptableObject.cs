namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/ComboFactorRepository")]
[MovedFrom(False, null, null, "ComboFactorRepository")]
public class ComboFactorScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public int Min; //Field offset: 0xC
		public int Max; //Field offset: 0x10
		public float ComboFactor; //Field offset: 0x14

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public ComboFactorScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


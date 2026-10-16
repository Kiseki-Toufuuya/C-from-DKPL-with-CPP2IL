namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/StageLevelFactorRepository")]
[MovedFrom(False, null, null, "StageLevelFactorRepository")]
public class StageLevelFactorScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public float AcquireMoneyFactor; //Field offset: 0xC

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public StageLevelFactorScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/MusicLevelFactorRepository")]
[MovedFrom(False, null, null, "MusicLevelFactorRepository")]
public class MusicLevelFactorScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public float MusicLevelFactor; //Field offset: 0xC

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public MusicLevelFactorScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


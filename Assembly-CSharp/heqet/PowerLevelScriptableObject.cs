namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/PowerLevelRepository")]
[MovedFrom(False, null, null, "PowerLevelRepository")]
public class PowerLevelScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public float MainShot; //Field offset: 0xC
		public float ExtraShot; //Field offset: 0x10
		public float OptionShot; //Field offset: 0x14

		public int Level
		{
			 get { } //Length: 11
		}

		public Data() { }

		public int get_Level() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC

	public PowerLevelScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


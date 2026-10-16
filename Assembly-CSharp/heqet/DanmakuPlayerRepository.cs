namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/DanmakuPlayerRepository")]
public class DanmakuPlayerRepository : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public string Name; //Field offset: 0xC

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC

	public DanmakuPlayerRepository() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}


namespace Heqet;

[CreateAssetMenu(menuName = "Heqet/MasterData/HeqetMusicSelection")]
[MovedFrom(False, null, null, "HeqetMusicSelectionRepository")]
public class HeqetMusicSelectionScriptableObject : ScriptableObject, IDummyRepository<Data, Int32>, IJsonImportExport
{
	internal class Data
	{
		public int ID; //Field offset: 0x8
		public string Title; //Field offset: 0xC
		public Int64[] MusicIdArray; //Field offset: 0x10
		public int SortNo; //Field offset: 0x14
		public int JacketId; //Field offset: 0x18
		public int BackGroundId; //Field offset: 0x1C
		public int BGMovieId; //Field offset: 0x20
		public Int32[] MusicDifficultyLevelArray; //Field offset: 0x24
		public int AcquirableMoney; //Field offset: 0x28
		public int NewRelease; //Field offset: 0x2C

		public Data() { }

	}

	[SerializeField]
	private List<Data> entityList; //Field offset: 0xC
	private Dictionary<Int32, Data> entityDic; //Field offset: 0x10

	public List<Data> Entries
	{
		 get { } //Length: 11
	}

	public HeqetMusicSelectionScriptableObject() { }

	public override void FromJson(string json) { }

	public override Data Get(int id) { }

	public List<Data> get_Entries() { }

	public override IList<Data> GetList(IEnumerable<Int32> ids) { }

	public override string ToJson() { }

}

